using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FifthMigration_SeedLines : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Lines",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("00a24b3a-51f5-43e9-ac97-5807a7f06a10"), "303" },
                    { new Guid("013ed488-943a-44ae-922b-ac424a298429"), "300" },
                    { new Guid("0381967e-6024-4ae5-937b-e80b92fa7114"), "N82" },
                    { new Guid("04733ce7-e636-4e7e-bbb4-ef69e2d70f16"), "312" },
                    { new Guid("0a0f4637-6413-46e7-9e1d-c087175ddeaf"), "72" },
                    { new Guid("0b73af15-4bd6-448c-bab0-e447deacbad4"), "90" },
                    { new Guid("0e1e33a6-30bf-4832-a810-8d08eff28492"), "13" },
                    { new Guid("0fee202a-53bd-442f-aa0c-8be8173ba1fe"), "TD5" },
                    { new Guid("102c8597-a47a-40f8-b515-2413305f08f4"), "TD3" },
                    { new Guid("11b85c06-f927-46c5-98da-9dec751bfd77"), "45" },
                    { new Guid("1449c29e-1bd3-4fca-8aed-07bf026692ce"), "N11" },
                    { new Guid("14dc03db-8aac-42d8-978e-e292fcd98d35"), "14" },
                    { new Guid("1be09fbe-3182-4550-bbe1-a83c7885f7ef"), "181" },
                    { new Guid("1e75678a-0df9-4b91-adfc-0ca37c800023"), "91" },
                    { new Guid("1fd78c35-5852-4dad-baaa-26a3b9036fa7"), "313" },
                    { new Guid("20eba823-5c69-41d4-8051-8afd5d8e2fb1"), "54" },
                    { new Guid("210776b5-9c0c-4689-94d1-a1de8685ce3b"), "X1A" },
                    { new Guid("225d071c-0157-4652-b304-19ccf8e25c8e"), "N301" },
                    { new Guid("23d0d93a-96d7-4327-bae6-7a85064224d1"), "61" },
                    { new Guid("29712a1e-0e36-4da6-8478-db2141b1ed6f"), "41" },
                    { new Guid("2a062527-a0f6-45bb-9d7d-45133fb8cfdf"), "25" },
                    { new Guid("2bd6aa8b-a792-4384-abcb-ffc3c1b5c06c"), "47" },
                    { new Guid("2dac88e4-0e26-46dd-94a5-66ebd6d4cd18"), "206" },
                    { new Guid("3109c832-ea45-42ae-aa05-a7f5dff969cd"), "X299" },
                    { new Guid("3284fd73-ef3d-4843-8fb9-018a1eee4be7"), "TD13" },
                    { new Guid("338ea7da-45b7-4ac1-912e-3dc7d17e0da6"), "N48" },
                    { new Guid("34245779-4ddb-473e-bd60-7b651bd1ee3b"), "150" },
                    { new Guid("34eecbdb-0e60-4290-816d-0adfea46f7d6"), "24" },
                    { new Guid("356e2493-2dde-40ae-9430-ea7219fe8f34"), "213" },
                    { new Guid("357399c1-f7b0-4c41-86df-1bc4ed64e544"), "210" },
                    { new Guid("386a0cb1-1613-4fb8-9268-a02858a3b42e"), "124" },
                    { new Guid("398cb0b9-e422-4b4d-b800-1ff702c5335c"), "211" },
                    { new Guid("3ac4cf13-4abe-4d74-a97a-a9940d5b9e9f"), "205" },
                    { new Guid("3e1bb8d3-5ba1-489f-9028-a5ab8da76a12"), "238" },
                    { new Guid("3f86f6a8-1d70-4cea-a8f2-78886e5bb16a"), "202" },
                    { new Guid("3f9327c2-144c-405f-9b3b-cf90e87444d7"), "53" },
                    { new Guid("401f21eb-b11b-42e7-befa-17dd52c37d76"), "103" },
                    { new Guid("41721a58-3711-4d29-92fc-9dd7cf7b246a"), "250" },
                    { new Guid("429dc960-8c41-4761-8ace-b892b4517628"), "203" },
                    { new Guid("475da1af-e9a8-460b-a10e-86480034bb20"), "214" },
                    { new Guid("486f0913-55e2-4153-88e7-c5aa90d11194"), "109" },
                    { new Guid("4a0ad825-7474-4285-a50b-63b3e2c2397d"), "71" },
                    { new Guid("4bfa657b-a49d-43ba-9187-054ccf02bd29"), "82A" },
                    { new Guid("4fb76edd-b35e-484f-b0c2-8c2e5a18f663"), "31" },
                    { new Guid("50a7c2e2-b67a-4312-863f-946c3c9bfc66"), "56" },
                    { new Guid("52799f6f-0118-479d-9da1-eb6664ec8f21"), "305" },
                    { new Guid("541e3d0f-feff-4575-a02d-0a61928ab468"), "35" },
                    { new Guid("59586aa6-805c-4621-9c9d-2ffdb746298b"), "N212" },
                    { new Guid("5b9591c1-a976-44d1-bdb9-278b01b1393a"), "48" },
                    { new Guid("5c2c6295-4a67-4bdc-b0af-470e87ead3ba"), "403" },
                    { new Guid("601719e0-048f-4034-b3bb-835df8279873"), "280" },
                    { new Guid("602e9b8a-228a-4201-aa65-43db9ff197fe"), "221" },
                    { new Guid("60a9f0c4-d827-455a-baf9-b1abaf6d5799"), "302" },
                    { new Guid("623cfdd9-26b7-4396-8532-5ec644e121fb"), "64" },
                    { new Guid("651de373-e20b-4aeb-a9b8-f45f0827a14c"), "208" },
                    { new Guid("67cd380a-60bf-4cac-b1aa-fabf490f4151"), "119" },
                    { new Guid("6de70d79-f4bc-4f11-ae7c-14381f853024"), "201" },
                    { new Guid("6e1cd7c3-29b3-485a-be28-6dc84f1b4425"), "58" },
                    { new Guid("7114b0c2-661a-4f30-a636-97bb340bf2e1"), "92" },
                    { new Guid("7114fdf6-9289-4b4e-98b5-a891a03373c1"), "81" },
                    { new Guid("71e5774d-5cd5-4362-bf81-2e4ff5d366ef"), "135" },
                    { new Guid("7228eb45-be81-4dbf-8131-4d82e7dc066d"), "49" },
                    { new Guid("72407aa3-340a-4b19-ad1a-ee7820f564b5"), "15" },
                    { new Guid("729e8dd4-0ae6-4ca1-8697-b0df167ee8fb"), "3" },
                    { new Guid("734e9822-a316-4502-b9d3-1bb19bc18c3e"), "307" },
                    { new Guid("73bc18c5-7afd-4b7d-bbe3-8e4190317efb"), "84" },
                    { new Guid("73d0acf7-bf72-4380-9c62-a674756082fa"), "207" },
                    { new Guid("755aae3e-7062-4716-ac35-9afa59a06f73"), "301" },
                    { new Guid("777f0672-e3a6-4f9a-8c5b-afff690cb12f"), "88" },
                    { new Guid("792c4d35-b19d-4ac9-8af9-ba70c6f23659"), "122" },
                    { new Guid("7c28531d-0042-45e0-812c-0579431a8ed8"), "44" },
                    { new Guid("7d6633c4-892c-489a-8698-4b8052286bde"), "TD1" },
                    { new Guid("7ef06165-fe8c-4f63-b870-a856777c4932"), "233" },
                    { new Guid("7ff7b33b-9e44-47d2-9724-c2e39c695709"), "209" },
                    { new Guid("80070528-3f8c-4ede-9037-2716d58862c6"), "212" },
                    { new Guid("802cc91c-5e88-4227-bb5d-9dc30c378f49"), "182" },
                    { new Guid("8e0c20d2-6df4-47f5-bf52-73e578e59e99"), "308" },
                    { new Guid("90c9677e-b970-4a8c-964b-513e72dfeb9d"), "186" },
                    { new Guid("9301a98e-2b3e-4a0a-9675-c734640ba8e4"), "TD4" },
                    { new Guid("948b2a2f-914a-423f-b067-39916a1b4df4"), "N91" },
                    { new Guid("94af91b2-f6d8-408c-a5ea-4b2194e685fe"), "322" },
                    { new Guid("95249bf4-139b-4f7b-9a2a-3ddc1ec0ddec"), "120" },
                    { new Guid("965fe562-a342-4912-a6dc-3ccacf35f170"), "404" },
                    { new Guid("97ce6239-c5aa-46fc-8570-fc30ad1836d0"), "214" },
                    { new Guid("97f744c7-b42f-4335-aaa5-934ccc313813"), "46" },
                    { new Guid("98f1a9f6-146d-4daf-b468-0221594ef710"), "323" },
                    { new Guid("9a973093-092d-4f56-b8c8-55a2271d8e73"), "223" },
                    { new Guid("9fb2ce5d-090c-4f63-b8e7-5634e54f973a"), "N62" },
                    { new Guid("a03f937a-028d-43db-8d51-e76451f66602"), "32" },
                    { new Guid("a217516c-ab23-45a4-bd8b-8cbb0b399d2d"), "52" },
                    { new Guid("a376d58b-f362-4f71-904d-c789562d4654"), "101" },
                    { new Guid("a4a7cfec-2e48-4dcf-a2ba-1720c183b605"), "133" },
                    { new Guid("a5bca6a8-c6d9-483c-a3fc-2e31aac7358c"), "106" },
                    { new Guid("a6125eed-a528-4822-b6f4-5471f61a18ea"), "4" },
                    { new Guid("a6728f71-1b74-49d4-a838-31b617b36fa6"), "82B" },
                    { new Guid("aa5686d8-3b98-432e-b524-8468a21a2701"), "110" },
                    { new Guid("ac9716c6-accb-4a5f-b78f-e75f9a9fa16b"), "58A" },
                    { new Guid("ade71bc7-3eff-4643-ba36-a9fd11c7d795"), "16" },
                    { new Guid("aeedf7bb-df5f-4c25-a455-df7a94f2f843"), "109A" },
                    { new Guid("afb281f7-6972-4b63-88f1-31dc4cdb8225"), "62" },
                    { new Guid("b00b38f8-313b-486c-b67a-ee741b2af705"), "13A" },
                    { new Guid("b2c40277-e4dd-4ba2-98d6-e7a353336a48"), "94" },
                    { new Guid("b5279270-1997-4f25-8111-d02c38d3cf67"), "405" },
                    { new Guid("b78c7b0f-ef06-46fa-9a84-6caba11ead47"), "117" },
                    { new Guid("b89f57c8-2ad1-4a76-9618-edfda60d3a09"), "311" },
                    { new Guid("b99477e2-786e-451b-b227-3a05c72d9b7c"), "74" },
                    { new Guid("bc0536a4-d39d-44fe-83bc-15a06b0f7938"), "TD10" },
                    { new Guid("bffd8c4e-c584-467d-938f-df5878d5d41b"), "401" },
                    { new Guid("c00e1231-b5a2-4ed3-9e47-0dabe8988116"), "204" },
                    { new Guid("c779a42f-68f7-465e-a675-22505a744ddf"), "63" },
                    { new Guid("c8662835-844b-43a1-9654-faeecb88d77d"), "85" },
                    { new Guid("cb3b0034-ac2a-4f0d-9d08-38704e6bf005"), "N13" },
                    { new Guid("cc311dd0-c80f-4d1f-a373-3a598f8463e2"), "21" },
                    { new Guid("cced26d9-1327-4e12-8990-a1829cf64e69"), "TD2" },
                    { new Guid("d140a230-1641-427b-a0ff-0d61fa32f8a6"), "218" },
                    { new Guid("d5357845-3b14-4a60-9790-933247f846b8"), "222" },
                    { new Guid("d5a5266f-622c-4d4c-83fa-31ce2936a1dd"), "50" },
                    { new Guid("d8176cc9-63cf-4a9b-baaa-d6508837cc7e"), "402" },
                    { new Guid("d8fcedba-6e54-409e-a280-399624c989eb"), "1" },
                    { new Guid("d9220756-07d4-4980-9783-2b3e88843ec2"), "42" },
                    { new Guid("daeef622-2929-4447-be40-54b75fe19573"), "X300" },
                    { new Guid("db930adf-141c-43f0-bb90-82b005392390"), "51" },
                    { new Guid("dd398fb9-8e1f-46b3-917d-8acf1c85d4f9"), "226" },
                    { new Guid("e1b7611f-567e-422b-b080-58750bf091b0"), "260" },
                    { new Guid("e1d25b79-bb2e-4941-9878-7c7bbbd2e386"), "83" },
                    { new Guid("e22e9dc2-1a77-451b-b2a7-28e34a993c2e"), "130" },
                    { new Guid("e2e56358-1429-49d3-93c2-b33ddb90ea91"), "225" },
                    { new Guid("e431da1c-ff29-429e-9c31-e98e05148b87"), "310" },
                    { new Guid("e6c0c979-8cc9-4710-8005-0abf7a441668"), "2" },
                    { new Guid("e7c46745-f65c-4950-b40f-a457021d1021"), "309" },
                    { new Guid("e825c388-e0a6-430f-834c-33d545a75122"), "93" },
                    { new Guid("eaeb7317-9f9e-4b7e-8264-be873b3ebd33"), "82" },
                    { new Guid("f0346b32-0de2-48dd-86d2-10eede3319c7"), "306" },
                    { new Guid("f71020d3-98b4-40b6-a133-60b9c91231b0"), "22" },
                    { new Guid("f743cbc2-a4e9-45b1-9a38-5f9b2e030c83"), "121" },
                    { new Guid("fc50fded-11c5-4a97-b8b8-e3ddafc8cc5b"), "80" },
                    { new Guid("fc9d41d8-8c6c-47ec-b747-9c2f101501f6"), "73" },
                    { new Guid("fd9a9afb-35f1-4793-b60a-cbce8b1abe48"), "330" },
                    { new Guid("ffe88da3-6eef-43d9-b54f-a5129343a3b1"), "43" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("00a24b3a-51f5-43e9-ac97-5807a7f06a10"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("013ed488-943a-44ae-922b-ac424a298429"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("0381967e-6024-4ae5-937b-e80b92fa7114"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("04733ce7-e636-4e7e-bbb4-ef69e2d70f16"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("0a0f4637-6413-46e7-9e1d-c087175ddeaf"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("0b73af15-4bd6-448c-bab0-e447deacbad4"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("0e1e33a6-30bf-4832-a810-8d08eff28492"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("0fee202a-53bd-442f-aa0c-8be8173ba1fe"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("102c8597-a47a-40f8-b515-2413305f08f4"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("11b85c06-f927-46c5-98da-9dec751bfd77"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("1449c29e-1bd3-4fca-8aed-07bf026692ce"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("14dc03db-8aac-42d8-978e-e292fcd98d35"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("1be09fbe-3182-4550-bbe1-a83c7885f7ef"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("1e75678a-0df9-4b91-adfc-0ca37c800023"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("1fd78c35-5852-4dad-baaa-26a3b9036fa7"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("20eba823-5c69-41d4-8051-8afd5d8e2fb1"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("210776b5-9c0c-4689-94d1-a1de8685ce3b"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("225d071c-0157-4652-b304-19ccf8e25c8e"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("23d0d93a-96d7-4327-bae6-7a85064224d1"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("29712a1e-0e36-4da6-8478-db2141b1ed6f"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("2a062527-a0f6-45bb-9d7d-45133fb8cfdf"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("2bd6aa8b-a792-4384-abcb-ffc3c1b5c06c"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("2dac88e4-0e26-46dd-94a5-66ebd6d4cd18"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("3109c832-ea45-42ae-aa05-a7f5dff969cd"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("3284fd73-ef3d-4843-8fb9-018a1eee4be7"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("338ea7da-45b7-4ac1-912e-3dc7d17e0da6"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("34245779-4ddb-473e-bd60-7b651bd1ee3b"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("34eecbdb-0e60-4290-816d-0adfea46f7d6"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("356e2493-2dde-40ae-9430-ea7219fe8f34"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("357399c1-f7b0-4c41-86df-1bc4ed64e544"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("386a0cb1-1613-4fb8-9268-a02858a3b42e"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("398cb0b9-e422-4b4d-b800-1ff702c5335c"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("3ac4cf13-4abe-4d74-a97a-a9940d5b9e9f"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("3e1bb8d3-5ba1-489f-9028-a5ab8da76a12"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("3f86f6a8-1d70-4cea-a8f2-78886e5bb16a"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("3f9327c2-144c-405f-9b3b-cf90e87444d7"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("401f21eb-b11b-42e7-befa-17dd52c37d76"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("41721a58-3711-4d29-92fc-9dd7cf7b246a"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("429dc960-8c41-4761-8ace-b892b4517628"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("475da1af-e9a8-460b-a10e-86480034bb20"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("486f0913-55e2-4153-88e7-c5aa90d11194"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("4a0ad825-7474-4285-a50b-63b3e2c2397d"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("4bfa657b-a49d-43ba-9187-054ccf02bd29"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("4fb76edd-b35e-484f-b0c2-8c2e5a18f663"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("50a7c2e2-b67a-4312-863f-946c3c9bfc66"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("52799f6f-0118-479d-9da1-eb6664ec8f21"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("541e3d0f-feff-4575-a02d-0a61928ab468"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("59586aa6-805c-4621-9c9d-2ffdb746298b"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("5b9591c1-a976-44d1-bdb9-278b01b1393a"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("5c2c6295-4a67-4bdc-b0af-470e87ead3ba"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("601719e0-048f-4034-b3bb-835df8279873"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("602e9b8a-228a-4201-aa65-43db9ff197fe"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("60a9f0c4-d827-455a-baf9-b1abaf6d5799"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("623cfdd9-26b7-4396-8532-5ec644e121fb"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("651de373-e20b-4aeb-a9b8-f45f0827a14c"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("67cd380a-60bf-4cac-b1aa-fabf490f4151"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("6de70d79-f4bc-4f11-ae7c-14381f853024"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("6e1cd7c3-29b3-485a-be28-6dc84f1b4425"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("7114b0c2-661a-4f30-a636-97bb340bf2e1"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("7114fdf6-9289-4b4e-98b5-a891a03373c1"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("71e5774d-5cd5-4362-bf81-2e4ff5d366ef"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("7228eb45-be81-4dbf-8131-4d82e7dc066d"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("72407aa3-340a-4b19-ad1a-ee7820f564b5"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("729e8dd4-0ae6-4ca1-8697-b0df167ee8fb"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("734e9822-a316-4502-b9d3-1bb19bc18c3e"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("73bc18c5-7afd-4b7d-bbe3-8e4190317efb"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("73d0acf7-bf72-4380-9c62-a674756082fa"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("755aae3e-7062-4716-ac35-9afa59a06f73"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("777f0672-e3a6-4f9a-8c5b-afff690cb12f"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("792c4d35-b19d-4ac9-8af9-ba70c6f23659"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("7c28531d-0042-45e0-812c-0579431a8ed8"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("7d6633c4-892c-489a-8698-4b8052286bde"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("7ef06165-fe8c-4f63-b870-a856777c4932"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("7ff7b33b-9e44-47d2-9724-c2e39c695709"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("80070528-3f8c-4ede-9037-2716d58862c6"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("802cc91c-5e88-4227-bb5d-9dc30c378f49"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("8e0c20d2-6df4-47f5-bf52-73e578e59e99"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("90c9677e-b970-4a8c-964b-513e72dfeb9d"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("9301a98e-2b3e-4a0a-9675-c734640ba8e4"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("948b2a2f-914a-423f-b067-39916a1b4df4"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("94af91b2-f6d8-408c-a5ea-4b2194e685fe"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("95249bf4-139b-4f7b-9a2a-3ddc1ec0ddec"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("965fe562-a342-4912-a6dc-3ccacf35f170"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("97ce6239-c5aa-46fc-8570-fc30ad1836d0"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("97f744c7-b42f-4335-aaa5-934ccc313813"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("98f1a9f6-146d-4daf-b468-0221594ef710"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("9a973093-092d-4f56-b8c8-55a2271d8e73"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("9fb2ce5d-090c-4f63-b8e7-5634e54f973a"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("a03f937a-028d-43db-8d51-e76451f66602"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("a217516c-ab23-45a4-bd8b-8cbb0b399d2d"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("a376d58b-f362-4f71-904d-c789562d4654"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("a4a7cfec-2e48-4dcf-a2ba-1720c183b605"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("a5bca6a8-c6d9-483c-a3fc-2e31aac7358c"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("a6125eed-a528-4822-b6f4-5471f61a18ea"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("a6728f71-1b74-49d4-a838-31b617b36fa6"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("aa5686d8-3b98-432e-b524-8468a21a2701"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("ac9716c6-accb-4a5f-b78f-e75f9a9fa16b"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("ade71bc7-3eff-4643-ba36-a9fd11c7d795"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("aeedf7bb-df5f-4c25-a455-df7a94f2f843"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("afb281f7-6972-4b63-88f1-31dc4cdb8225"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("b00b38f8-313b-486c-b67a-ee741b2af705"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("b2c40277-e4dd-4ba2-98d6-e7a353336a48"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("b5279270-1997-4f25-8111-d02c38d3cf67"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("b78c7b0f-ef06-46fa-9a84-6caba11ead47"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("b89f57c8-2ad1-4a76-9618-edfda60d3a09"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("b99477e2-786e-451b-b227-3a05c72d9b7c"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("bc0536a4-d39d-44fe-83bc-15a06b0f7938"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("bffd8c4e-c584-467d-938f-df5878d5d41b"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("c00e1231-b5a2-4ed3-9e47-0dabe8988116"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("c779a42f-68f7-465e-a675-22505a744ddf"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("c8662835-844b-43a1-9654-faeecb88d77d"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("cb3b0034-ac2a-4f0d-9d08-38704e6bf005"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("cc311dd0-c80f-4d1f-a373-3a598f8463e2"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("cced26d9-1327-4e12-8990-a1829cf64e69"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("d140a230-1641-427b-a0ff-0d61fa32f8a6"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("d5357845-3b14-4a60-9790-933247f846b8"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("d5a5266f-622c-4d4c-83fa-31ce2936a1dd"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("d8176cc9-63cf-4a9b-baaa-d6508837cc7e"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("d8fcedba-6e54-409e-a280-399624c989eb"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("d9220756-07d4-4980-9783-2b3e88843ec2"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("daeef622-2929-4447-be40-54b75fe19573"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("db930adf-141c-43f0-bb90-82b005392390"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("dd398fb9-8e1f-46b3-917d-8acf1c85d4f9"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("e1b7611f-567e-422b-b080-58750bf091b0"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("e1d25b79-bb2e-4941-9878-7c7bbbd2e386"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("e22e9dc2-1a77-451b-b2a7-28e34a993c2e"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("e2e56358-1429-49d3-93c2-b33ddb90ea91"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("e431da1c-ff29-429e-9c31-e98e05148b87"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("e6c0c979-8cc9-4710-8005-0abf7a441668"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("e7c46745-f65c-4950-b40f-a457021d1021"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("e825c388-e0a6-430f-834c-33d545a75122"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("eaeb7317-9f9e-4b7e-8264-be873b3ebd33"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("f0346b32-0de2-48dd-86d2-10eede3319c7"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("f71020d3-98b4-40b6-a133-60b9c91231b0"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("f743cbc2-a4e9-45b1-9a38-5f9b2e030c83"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("fc50fded-11c5-4a97-b8b8-e3ddafc8cc5b"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("fc9d41d8-8c6c-47ec-b747-9c2f101501f6"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("fd9a9afb-35f1-4793-b60a-cbce8b1abe48"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "Id",
                keyValue: new Guid("ffe88da3-6eef-43d9-b54f-a5129343a3b1"));
        }
    }
}
