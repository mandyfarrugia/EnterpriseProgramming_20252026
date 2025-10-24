using DataAccess.Repositories;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Presentation.Models.ViewModels;
using System.Net.Http.Headers;

namespace Presentation.Controllers
{
    public class FleetsController : Controller
    {
        private FleetsRepository _fleetsRepository;

        public FleetsController(FleetsRepository fleetsRepository)
        {
            this._fleetsRepository = fleetsRepository;
        }

        public IActionResult Index()
        {
            List<Fleet> fleets = this._fleetsRepository.Get().ToList();
            return View(fleets);
        }

        [HttpGet("Fleets/Search")]
        public IActionResult Search(string searchTerm)
        {
            List<Fleet>? fleets = null;

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                fleets = this._fleetsRepository.Get().ToList();
                return View(nameof(Index), fleets);
            }

            fleets = this._fleetsRepository.GetFleetsByName(searchTerm).ToList();
            ViewData["search_hits"] = fleets.Count();
            return View(nameof(Index), fleets);
        }

        [HttpGet]
        public IActionResult Create()
        {
            FleetCreateViewModel fleetCreateViewModel = new FleetCreateViewModel();
            return View(fleetCreateViewModel);
        }

        /* [FromServices] denotes the intention to inject the parameter from the application’s dependency injection (DI) container, not the request body.
         * In this case, we are registering the interface IWebHostEnvironment which provides information regarding web hosting environment,
         * we will access the WebRootPath which refers to the wwwroot folder (where static files reside such as CSS and JavaScript files).
         * Anything within wwwroot is accessible and downloadable for all. */
        [HttpPost]
        public IActionResult Create(FleetCreateViewModel fleetCreateViewModel, [FromServices] IWebHostEnvironment host)
        {
            string relativePath = string.Empty;

            try
            {
                //If there are invalid inputs, render a view with the form containing the current data and allow the user to fix errors and resubmit.
                if (!ModelState.IsValid)
                {
                    return View(fleetCreateViewModel);
                }

                if (fleetCreateViewModel.ImageFile != null && !string.IsNullOrEmpty(fleetCreateViewModel.ImageFile.FileName))
                {
                    /* 1. The filename will be given a unique name, for which a unique identifier can be generated using Guid.NewGuid(). 
                     * 2. Fetch the file extension of the file (if included in the submission). 
                     * 3. Concatenate the filename and the file extension without a delimiter since the file extension is prefixed by a period. */
                    string filename = string.Join(string.Empty, new object[] { Guid.NewGuid(), Path.GetExtension(fleetCreateViewModel.ImageFile.FileName) });
                    
                    //Combine the path to the full path to the wwwroot folder and the images folder which will store pictures of different bus fleets.
                    string pathToImagesWithinWWWRoot = Path.Combine(host.WebRootPath, "images");

                    //Check if the images directory exists within wwwroot. If the directory does not exist, then create it programmatically.
                    if (!Directory.Exists(pathToImagesWithinWWWRoot))
                    {
                        Directory.CreateDirectory(pathToImagesWithinWWWRoot);
                    }

                    string absolutePath = Path.Combine(pathToImagesWithinWWWRoot, filename); //This path is to be accessed when copying the image to the FileStream instance - we need to know where we are getting the image from.
                    relativePath = Path.Combine(string.Join(string.Empty, Path.DirectorySeparatorChar, "images"), filename); //This path is to be assigned to the image path corresponding to the Fleet entity being inserted into the database.

                    /* Access the absolute path (the path to the images folder within wwwroot) in which the image selected when filling in the form will be uploaded.
                     * FileMode.CreateNew allows the file to be created (in layman terms, uploaded to the specified path) but throw an exception if the file already exists.
                     * This protects against accidental overwriting. If you intend to overwrite files, use FileMode.Create instead. */
                    using(FileStream fileStream = new FileStream(absolutePath, FileMode.CreateNew))
                    {
                        fleetCreateViewModel.ImageFile.CopyTo(fileStream); //Copy the contents of the file in binary data to the FileStream instance - represents writing the contents to the destination path.
                        fileStream.Flush(); //Ensure everything is saved properly.
                        fileStream.Close(); //Dispose of the FileStream instance safely.
                    }
                }

                if (this._fleetsRepository.Get(fleetCreateViewModel.Name) == null)
                {
                    Fleet fleetToInsert = new Fleet()
                    {
                        Name = fleetCreateViewModel.Name,
                        ImagePath = !string.IsNullOrWhiteSpace(relativePath) ? relativePath : null,
                        YearBuilt = fleetCreateViewModel.YearBuilt
                    };

                    this._fleetsRepository.AddFleet(fleetToInsert);
                    TempData["success"] = "Fleet inserted successfully!";
                }

                return RedirectToAction(nameof(Create)); //TempData only survives a redirection, not when returning a view.
            }
            catch(Exception exception)
            {
                TempData["failure"] = "Unable to insert fleet!";
                return View(fleetCreateViewModel);
            }
        }

        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            FleetEditViewModel fleetEditViewModel = new FleetEditViewModel();
            Fleet? fleetToEdit = this._fleetsRepository.Get(id);

            if(fleetToEdit != null)
            {
                fleetEditViewModel.Id = id;
                fleetEditViewModel.Name = fleetToEdit.Name;
                fleetEditViewModel.YearBuilt = fleetToEdit.YearBuilt;
                fleetEditViewModel.ImagePath = fleetToEdit.ImagePath;
                return View(fleetEditViewModel);
            }

            TempData["failure"] = "Unable to locate fleet. The ID may have been tampered with!";
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Edit(FleetEditViewModel fleetEditViewModel, [FromServices] IWebHostEnvironment host)
        {
            string relativePath = string.Empty;

            try
            {
                if(!ModelState.IsValid)
                {
                    return View(fleetEditViewModel);
                }

                if(this._fleetsRepository.Get(fleetEditViewModel.Id) == null)
                {
                    TempData["failure"] = "This ID does not correspond with any of the fleets! Try again!";
                    return RedirectToAction(nameof(Index));
                }

                if(fleetEditViewModel.ImageFile != null && !string.IsNullOrEmpty(fleetEditViewModel.ImageFile.FileName))
                {
                    string filename = string.Join(string.Empty, new object[] { Guid.NewGuid(), Path.GetExtension(fleetEditViewModel.ImageFile.FileName) });
                    string pathToImagesWithinWWWRootFolder = Path.Combine(host.WebRootPath, "images");

                    if(!Directory.Exists(pathToImagesWithinWWWRootFolder))
                    {
                        Directory.CreateDirectory(pathToImagesWithinWWWRootFolder);
                    }

                    string absolutePath = Path.Combine(pathToImagesWithinWWWRootFolder, filename);
                    relativePath = Path.Combine(string.Join(string.Empty, Path.DirectorySeparatorChar, "images"), filename);

                    using (FileStream fileStream = new FileStream(absolutePath, FileMode.CreateNew))
                    {
                        fleetEditViewModel.ImageFile.CopyTo(fileStream);
                        fileStream.Flush();
                        fileStream.Close();
                    }

                    string? pathToOldImage = this._fleetsRepository.Get(fleetEditViewModel.Id).ImagePath;

                    if(!string.IsNullOrEmpty(pathToOldImage))
                    {
                        string absolutePathToOldImage = Path.Combine(pathToImagesWithinWWWRootFolder, Path.GetFileName(pathToOldImage));
                        System.IO.File.Delete(absolutePathToOldImage);
                    }
                }
                else
                {
                    relativePath = this._fleetsRepository.Get(fleetEditViewModel.Id).ImagePath;
                }

                Fleet fleetToUpdate = new Fleet()
                {
                    Id = fleetEditViewModel.Id,
                    Name = fleetEditViewModel.Name,
                    YearBuilt = fleetEditViewModel.YearBuilt,
                    ImagePath = !string.IsNullOrWhiteSpace(relativePath) ? relativePath : null
                };

                this._fleetsRepository.UpdateFleet(fleetToUpdate);
                TempData["success"] = "Fleet has been updated successfully!";
                return RedirectToAction(nameof(Edit), new { id = fleetEditViewModel.Id });
            }
            catch(Exception exception)
            {
                return View(fleetEditViewModel);
            }
        }

        public IActionResult Delete(Guid id, [FromServices] IWebHostEnvironment host)
        {
            try
            {
                Fleet? fleetToDelete = this._fleetsRepository.Get(id);

                if(fleetToDelete != null)
                {
                    if(!string.IsNullOrEmpty(fleetToDelete.ImagePath))
                    {
                        string pathToWWWRootFolder = host.WebRootPath;
                        string absolutePath = Path.Combine(pathToWWWRootFolder, fleetToDelete.ImagePath.TrimStart(Path.DirectorySeparatorChar));

                        if(System.IO.File.Exists(absolutePath))
                        {
                            System.IO.File.Delete(absolutePath);
                        }
                    }

                    this._fleetsRepository.DeleteFleet(id);
                    TempData["success"] = "Fleet deleted successfully!";
                }
                else
                {
                    TempData["failure"] = "Unable to locate fleet! The ID may have been tampered with.";
                }

                return RedirectToAction(nameof(Index));
            }
            catch(Exception exception)
            {
                TempData["failure"] = "Failed to delete fleet, try again!";
                return RedirectToAction(nameof(Index));
            }
        }
    }
}