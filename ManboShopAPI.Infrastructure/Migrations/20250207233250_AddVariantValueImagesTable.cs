using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManboShopAPI.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddVariantValueImagesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FeedbackLikes_AspNetUsers_UserId",
                table: "FeedbackLikes");

            migrationBuilder.DropForeignKey(
                name: "FK_FeedbackLikes_Feedbacks_FeedbackId",
                table: "FeedbackLikes");

            migrationBuilder.DropForeignKey(
                name: "FK_FeedbackReports_AspNetUsers_UserId",
                table: "FeedbackReports");

            migrationBuilder.DropForeignKey(
                name: "FK_FeedbackReports_Feedbacks_FeedbackId",
                table: "FeedbackReports");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Products_ProductId",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "VariantValues");

            migrationBuilder.AlterColumn<int>(
                name: "FeedbackId",
                table: "FeedbackReports",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FeedbackId",
                table: "FeedbackLikes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "VariantValueImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VariantValueId = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VariantValueImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VariantValueImages_VariantValues_VariantValueId",
                        column: x => x.VariantValueId,
                        principalTable: "VariantValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9674 Savannah Creek, North Mariehaven, Georgia", "8123372d-8af0-47ab-97a0-e7a18952f5b4", new DateTime(2024, 6, 20, 23, 32, 47, 845, DateTimeKind.Utc).AddTicks(9717), "Delfina.McCullough4@hotmail.com", "Delfina", "McCullough", "DELFINA.MCCULLOUGH4@HOTMAIL.COM", "DELFINA.MCCULLOUGH", "AQAAAAIAAYagAAAAEIYZpHq8a/vSMy9nhyQg9Bh1/DXBCsEH2Nhmb5W8xiWPVam6kHHu8bn0j9wKk7wVOw==", "052-298-4170", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1138.jpg", "Delfina.McCullough" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "5092 Johns Extension, Port Mireillestad, Estonia", "a57d057f-7406-4353-be6c-d5d425e66cbf", new DateTime(2024, 11, 1, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(3036), "Ashleigh.White@hotmail.com", "Ashleigh", "White", "ASHLEIGH.WHITE@HOTMAIL.COM", "ASHLEIGH_WHITE", "AQAAAAIAAYagAAAAEO1YhQJOYKWkPVBA/ISKUQKwQgjGw1fLb8wAwLJ9Qr/jjzrc6RwoDulN+psOsYfBZQ==", "811-835-4498", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/125.jpg", "Ashleigh_White" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "2006 Veum Prairie, Isabellashire, Montenegro", "0b01f792-64f9-40d4-a280-b43f8c01b861", new DateTime(2024, 5, 22, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(3387), "Guy.Stehr88@hotmail.com", "Guy", "Stehr", "GUY.STEHR88@HOTMAIL.COM", "GUY.STEHR0", "AQAAAAIAAYagAAAAEFWKp7K2mTlAWa2e6ebNftGlnIavYgMCognSKoY23vchPh6PbXIwmpaLYjoX4dOR8A==", "289-568-1035", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/136.jpg", "Guy.Stehr0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6047 Heidenreich Viaduct, East Breanne, Burundi", "b0387a9b-03b6-488e-a2d1-ee4383b6339b", new DateTime(2024, 10, 9, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(3630), "Foster78@hotmail.com", "Foster", "Marquardt", "FOSTER78@HOTMAIL.COM", "FOSTER44", "AQAAAAIAAYagAAAAEPo+oDV+TM0xPcLI85OXvk3FzxKWapCaPYl/qwZJ6yRLs48+jwaTtIgT4wT/w7PKsA==", "254-242-0600", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/16.jpg", "Foster44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "397 Sawayn Highway, Lake Halle, Saint Pierre and Miquelon", "9f4db71f-2edd-4437-aeef-067b21157b4a", new DateTime(2024, 11, 6, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(3953), "Adelbert17@hotmail.com", "Adelbert", "Lueilwitz", "ADELBERT17@HOTMAIL.COM", "ADELBERT.LUEILWITZ", "AQAAAAIAAYagAAAAELCOL5EsIYoyWtZxNM6BFV4J+nS9avYHPYBvOfYzYpmXQo/R7Ilfysww/i0aEs4OaQ==", "460-968-5330", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1071.jpg", "Adelbert.Lueilwitz" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "631 Kautzer Corner, Botsfordville, Bahamas", "af355c3c-d7a9-4b28-a77d-ed3e21fd9cce", new DateTime(2024, 12, 20, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(4207), "Elyse24@gmail.com", "Elyse", "Nitzsche", "ELYSE24@GMAIL.COM", "ELYSE.NITZSCHE30", "AQAAAAIAAYagAAAAEABTWOKF+OV4n5XffsSS7pHiMtPFrPwFcRkCoLexE7DFHJ7yA9p4cOJV1HPGBwPoaw==", "008-502-0775", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/476.jpg", "Elyse.Nitzsche30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "288 Donnelly Trafficway, North Juliusport, Togo", "1a2ef54c-de22-42d7-8332-74fba604fc54", new DateTime(2025, 1, 27, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(4477), "Eugenia.Wisoky@hotmail.com", "Eugenia", "Wisoky", "EUGENIA.WISOKY@HOTMAIL.COM", "EUGENIA11", "AQAAAAIAAYagAAAAEFKO7XeuvexQdUcj3mMOz+oWjUtj3xMf9ZFycMMzLuYVcXU37VQJUduvM+z3gRwbkw==", "549-215-8754", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1111.jpg", "Eugenia11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "33195 Carroll Mews, East Boborough, French Guiana", "58cecc50-bf25-4c2b-8edd-7d352e6f602f", new DateTime(2024, 11, 12, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(4737), "Chadrick15@yahoo.com", "Chadrick", "Gerlach", "CHADRICK15@YAHOO.COM", "CHADRICK.GERLACH", "AQAAAAIAAYagAAAAEFlEpediQLREhWipRfZvtg/Vhsy09yGV6T423oPiKL1sa5FwWKEa6r7Qp6CNiKmitw==", "455-079-1239", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1036.jpg", "Chadrick.Gerlach" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "136 Nolan Port, Cheyenneberg, Namibia", "519ef944-6006-4ba6-abbb-36bcf2f03e0f", new DateTime(2024, 3, 3, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(4938), "Adrianna11@gmail.com", "Adrianna", "Fahey", "ADRIANNA11@GMAIL.COM", "ADRIANNA.FAHEY84", "AQAAAAIAAYagAAAAEPfSt0LSk0HjkwBL0zHykQb1x90m0DPJjiKTkU5HrlyQD1taxRX5oY8OCrUDIySARA==", "203-843-2418", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/294.jpg", "Adrianna.Fahey84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "54320 Jordy Oval, New Linneaview, El Salvador", "a483ff1c-174c-4048-ae45-c32042a6ddb2", new DateTime(2024, 8, 30, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(5202), "Pierre.Yost@gmail.com", "Pierre", "Yost", "PIERRE.YOST@GMAIL.COM", "PIERRE_YOST59", "AQAAAAIAAYagAAAAEFv833AYJS4m8UY4CMJwHkjIaEduxubdw/h5OyDb6QyfTtueVfwEsw1OX28cKP+P7Q==", "715-174-8039", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/819.jpg", "Pierre_Yost59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "18658 Mariela Station, Lake Caitlyn, Tonga", "44faf38e-fee9-4d0e-b08d-1ed89869e83d", new DateTime(2024, 7, 2, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(5410), "Malinda29@yahoo.com", "Malinda", "Schaden", "MALINDA29@YAHOO.COM", "MALINDA.SCHADEN", "AQAAAAIAAYagAAAAELVO7caoF6GasctwveQxckmgJrspVXNGDGqTHMcn8YMD8khJgTjsNoI4IlnkdxlRPg==", "205-310-3575", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/985.jpg", "Malinda.Schaden" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8870 Jaida Centers, East Estevanhaven, Zimbabwe", "2cc84c0b-e43b-4679-beff-c2337b17b268", new DateTime(2024, 7, 20, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(5647), "Sigmund.Emard25@hotmail.com", "Sigmund", "Emard", "SIGMUND.EMARD25@HOTMAIL.COM", "SIGMUND63", "AQAAAAIAAYagAAAAEF+73Y4Rj5VEZ+0KcYlnI54cXtpWlx3RsfqwwPZsAm+0Q2aTDQDmqG+rXfw6kNFNwQ==", "647-798-0157", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1057.jpg", "Sigmund63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8405 Grover Dale, North Terrenceport, Malaysia", "c1fb6242-e5ac-4561-8111-be5be1f70ab9", new DateTime(2024, 4, 4, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(5867), "Harley86@yahoo.com", "Harley", "Collier", "HARLEY86@YAHOO.COM", "HARLEY_COLLIER", "AQAAAAIAAYagAAAAEO9ehHXR6CPx0sZ5OLnOPO3YOPhAa4OV9VJGIn/X1FIVjiwpJ8whbEln0KI/AAM+oQ==", "878-290-7570", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/634.jpg", "Harley_Collier" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "63604 Karl Branch, Ziemefort, New Zealand", "3a5c6c81-2524-4f9a-91e1-d01a3957af0c", new DateTime(2024, 6, 6, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(6097), "Alisa_Powlowski@gmail.com", "Alisa", "Powlowski", "ALISA_POWLOWSKI@GMAIL.COM", "ALISA.POWLOWSKI72", "AQAAAAIAAYagAAAAEMhLLbceJ37ECpNtCSmsvwf4g7T4J9MRQ3lZSMb5KCY63sEhOVzaoBAzJj2EFNoGwg==", "751-064-2655", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/982.jpg", "Alisa.Powlowski72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "2931 Weber Flat, New Otha, Tokelau", "d770ae5c-db10-475d-96fb-47d4ed20be6b", new DateTime(2024, 7, 11, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(6319), "Emmett_Bartoletti70@yahoo.com", "Emmett", "Bartoletti", "EMMETT_BARTOLETTI70@YAHOO.COM", "EMMETT.BARTOLETTI91", "AQAAAAIAAYagAAAAELyplYQvN1IU5d1KBgFmhMYiaZemk5IuHXCDEcQ8IuzTCJh2U70U9a6e5ug7VcZ3cg==", "861-996-2495", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/362.jpg", "Emmett.Bartoletti91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8946 Charlie Wall, Port Justynton, Iran", "aa372bf2-1d14-4e3e-9cc4-75c8f5e0a984", new DateTime(2025, 2, 2, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(6586), "Braeden60@hotmail.com", "Braeden", "Lynch", "BRAEDEN60@HOTMAIL.COM", "BRAEDEN.LYNCH51", "AQAAAAIAAYagAAAAEKy7HztzqUNR/DVYsgeAGCvw2ZSENVnHr5PK3B1s5Xz2dgu/98hd2/KzOvL5+PL2sA==", "513-271-4971", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/977.jpg", "Braeden.Lynch51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "0133 Altenwerth Rest, North Antonette, Moldova", "808c8d8f-74b4-4571-969a-6cbecfba769c", new DateTime(2024, 8, 16, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(6788), "Marcelle66@hotmail.com", "Marcelle", "Wiza", "MARCELLE66@HOTMAIL.COM", "MARCELLE53", "AQAAAAIAAYagAAAAENNK+JwmJrU8S9JjhREDuM7zGVK6n0cPbWT0NnWxMTX5jn0rlSZEG6AKxTzuk4QYHQ==", "616-278-4206", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/746.jpg", "Marcelle53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "64534 Hodkiewicz Track, North Alexandroborough, Iceland", "f895c597-3e2e-47a4-8943-f6cc10e0569d", new DateTime(2024, 8, 13, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(7016), "Foster85@hotmail.com", "Foster", "West", "FOSTER85@HOTMAIL.COM", "FOSTER_WEST", "AQAAAAIAAYagAAAAEG6e3y3r1KrwHG6Vrmat9G6vbbDF6/Bw9G4MvL3Xnpfg12zg9623MKjRymAremtfVQ==", "665-643-6722", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/501.jpg", "Foster_West" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "832 Melisa Locks, South Joany, Jordan", "5aa42781-f5eb-47a4-9c19-9a96ef72eac9", new DateTime(2024, 9, 17, 23, 32, 47, 847, DateTimeKind.Utc).AddTicks(7226), "Hector41@gmail.com", "Hector", "O'Connell", "HECTOR41@GMAIL.COM", "HECTOR0", "AQAAAAIAAYagAAAAELRCiUNIs/bhSe+oQNovE6LW/ZfWTtKjfrtKU3cdJA6egkS1ivP7feE3gFVO4hgP0A==", "555-561-6391", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/33.jpg", "Hector0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6467 Roberto Plains, South Karlie, Mexico", "b73eeb88-5c0c-416e-a9d4-45d008e54dcd", new DateTime(2024, 7, 20, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(3149), "Presley97@hotmail.com", "Presley", "O'Hara", "PRESLEY97@HOTMAIL.COM", "PRESLEY.OHARA", "AQAAAAIAAYagAAAAEOBgt/RBcnxY/D1pcWDPany3tYmeigbl2BgoRBFUYfEW7rESeVYnbXWYMzLSdGoJBg==", "938-911-4032", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/616.jpg", "Presley.OHara" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "66121 Hayes Loaf, Lilianachester, Ukraine", "531e9d6c-8256-461b-9020-c9a91cf60203", new DateTime(2024, 6, 4, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(3489), "Cassandre.Quitzon@hotmail.com", "Cassandre", "Quitzon", "CASSANDRE.QUITZON@HOTMAIL.COM", "CASSANDRE.QUITZON52", "AQAAAAIAAYagAAAAEEK1dJSeCdPFH4mvFwzgximVDPYSQhNA/7zEfjpZEIp0/BMKreyvBp1RXvycIaozsA==", "791-713-4215", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/877.jpg", "Cassandre.Quitzon52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "15327 Tracy Forges, Pourosberg, Paraguay", "387766c0-d49d-49ec-b863-04d6aba797e7", new DateTime(2024, 12, 13, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(3745), "Reina_Cummings87@yahoo.com", "Reina", "Cummings", "REINA_CUMMINGS87@YAHOO.COM", "REINA7", "AQAAAAIAAYagAAAAEOUxYYHDhiW2qL2afggfC7X1hNmHgYpC5H2rRaGaqwptOT2lHGAtrj5gjxBJaySuhQ==", "239-500-1244", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/567.jpg", "Reina7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "0049 Howell Valleys, Rodriguezborough, Lithuania", "412f7203-8690-48e2-a6d2-81d0ced903d2", new DateTime(2024, 9, 12, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(4002), "Wendy.Erdman@yahoo.com", "Wendy", "Erdman", "WENDY.ERDMAN@YAHOO.COM", "WENDY.ERDMAN8", "AQAAAAIAAYagAAAAEN+c/L2kmi9PL3Pxd+/B7JeBfDlJCNn/igUQTZF9KsAjp885lCDR2/zP5wr1dUrYlA==", "479-209-4754", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/825.jpg", "Wendy.Erdman8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "656 Hartmann Knoll, Brendenview, Slovakia (Slovak Republic)", "9a1dbb4e-99bd-422c-bbcd-24f46888b72a", new DateTime(2024, 11, 14, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(4214), "Parker76@yahoo.com", "Parker", "Dibbert", "PARKER76@YAHOO.COM", "PARKER67", "AQAAAAIAAYagAAAAEKDosb+av6v42l2nv0XS37mk7F/QfPiE6oahKP0jAgsxiI8OPeMiGi3mJrD85rQ6TQ==", "513-204-7742", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/216.jpg", "Parker67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "42533 Madilyn Prairie, Pierceberg, Liechtenstein", "d11db386-ff98-4b05-aaa8-a924c45f4331", new DateTime(2024, 6, 2, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(4443), "Lucius_Koss@gmail.com", "Lucius", "Koss", "LUCIUS_KOSS@GMAIL.COM", "LUCIUS_KOSS13", "AQAAAAIAAYagAAAAEPoKiVOVutrNdjbOhbldzZToZ4uHY4CKoSezBPW7gvutK/nF2D058E1Ng+bbJ17OgQ==", "965-451-5096", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/549.jpg", "Lucius_Koss13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "31309 Blanda Village, West Clarabelle, Angola", "ebc3607d-d2cc-4406-acd0-43bee620884a", new DateTime(2024, 7, 25, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(4696), "Cordelia56@gmail.com", "Cordelia", "Emard", "CORDELIA56@GMAIL.COM", "CORDELIA82", "AQAAAAIAAYagAAAAEMlUkHMY5HVnRQZZY6ExRe+QJvzshzwO/d1D5zjqP6z44MZGUHwVDhgKQivA3iX7Fw==", "524-127-2704", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/770.jpg", "Cordelia82" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "53961 Norma Unions, Kunzemouth, Cambodia", "2db6008c-b984-4b2a-a5bf-c79236294ad1", new DateTime(2025, 1, 13, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(4941), "Wilma_Gaylord51@hotmail.com", "Wilma", "Gaylord", "WILMA_GAYLORD51@HOTMAIL.COM", "WILMA22", "AQAAAAIAAYagAAAAEEIn57cxje6Bfz/mq7mwJbIDozbDs2h+rc8o1kRF7GyylAtY/8uuv1Rk9twG48vSow==", "196-958-7518", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/566.jpg", "Wilma22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "36696 Alessia Lock, Nannieside, Slovakia (Slovak Republic)", "8a905185-a306-4a91-90d7-4e02ddac9c4e", new DateTime(2024, 5, 29, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(5182), "Margarette_Cummerata57@gmail.com", "Margarette", "Cummerata", "MARGARETTE_CUMMERATA57@GMAIL.COM", "MARGARETTE.CUMMERATA", "AQAAAAIAAYagAAAAEBeaC8Ng40Hj31j3M8ROVQvKz/M/CEJpJcumgRp0/Qu0X0h7hlxzc1V6ooBb88R6RA==", "047-753-6261", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/60.jpg", "Margarette.Cummerata" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "873 Francisca Inlet, New Jeanne, Cocos (Keeling) Islands", "456658a2-dbac-466a-b320-bbed253a99c5", new DateTime(2024, 10, 17, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(5420), "Jannie47@gmail.com", "Jannie", "Bogan", "JANNIE47@GMAIL.COM", "JANNIE.BOGAN", "AQAAAAIAAYagAAAAEOuUIaWwKwuMDV5pWPy+L7oRVDx6/XkIeVi2J5MDzS8yGmMm4Wxl4XrN2Q+lSt132Q==", "452-171-3976", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/618.jpg", "Jannie.Bogan" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "69890 Jailyn Skyway, New Quinnside, French Polynesia", "7197dfda-c049-4551-9f30-bae931b874fe", new DateTime(2024, 9, 8, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(5632), "Larry_Torphy@yahoo.com", "Larry", "Torphy", "LARRY_TORPHY@YAHOO.COM", "LARRY11", "AQAAAAIAAYagAAAAEFSBW0tuDrVYBH/n+QEV9Qm9ItjDp7aN6urPVGTVnHFehsI/UMJcSh0eTc3kpSjmBA==", "638-863-0734", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/222.jpg", "Larry11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8337 Troy Forge, West Chaz, Falkland Islands (Malvinas)", "8572ac91-434c-4bb7-90ea-b929adda0651", new DateTime(2024, 3, 1, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(5861), "Toni_Barton@yahoo.com", "Toni", "Barton", "TONI_BARTON@YAHOO.COM", "TONI.BARTON", "AQAAAAIAAYagAAAAEJ6yqT0l7Rn4EMyqKLDwfsKVWJ7LYML0xFsGSraYbil0PZ7FZm884v0jDeC+SYUjhA==", "792-916-9722", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/601.jpg", "Toni.Barton" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6011 Klocko Square, Port Edgar, Guinea-Bissau", "64474711-57a6-4281-a24a-8ab9c91cf04b", new DateTime(2024, 10, 17, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(6078), "Marilyne_Kunde41@yahoo.com", "Marilyne", "Kunde", "MARILYNE_KUNDE41@YAHOO.COM", "MARILYNE.KUNDE", "AQAAAAIAAYagAAAAEO/jVqEsHVztp7JJxgeQ6WByfgZcApiE9HK67empiE2HIccLIUkqabn+6M6L+EOCLg==", "888-402-2157", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1189.jpg", "Marilyne.Kunde" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "01208 Brittany Point, Lynchview, Saint Kitts and Nevis", "69836ab5-cb34-4681-8b39-63a80aefa97d", new DateTime(2024, 3, 24, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(6328), "Marjory_McLaughlin24@yahoo.com", "Marjory", "McLaughlin", "MARJORY_MCLAUGHLIN24@YAHOO.COM", "MARJORY_MCLAUGHLIN58", "AQAAAAIAAYagAAAAEJJ7pfsurZjmEs2aRpCHckygaMgng3pypZi4SFBg+FIZ8arjPZTKJXCb30IzuBO4vg==", "396-502-4549", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/979.jpg", "Marjory_McLaughlin58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "61895 Hahn Coves, South Estamouth, Austria", "8c3c397d-d04a-4e8f-ab54-2802d2258d23", new DateTime(2024, 9, 19, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(6586), "Kristian_Stiedemann90@hotmail.com", "Kristian", "Stiedemann", "KRISTIAN_STIEDEMANN90@HOTMAIL.COM", "KRISTIAN62", "AQAAAAIAAYagAAAAEOcssQRESng9OkndC5NttskP8lXXEoFOo4jWXGyWosq6jBDwzfiolW+TjvoNY9GCzg==", "424-163-1473", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/644.jpg", "Kristian62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "439 Purdy Throughway, Lake Stonemouth, Indonesia", "fcd886c1-043c-432e-9798-e86310b1d8bc", new DateTime(2024, 10, 31, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(6812), "Lauretta_Price42@gmail.com", "Lauretta", "Price", "LAURETTA_PRICE42@GMAIL.COM", "LAURETTA75", "AQAAAAIAAYagAAAAEMMs7zvSqJOkaYcfs4CBVaqxSLKCMgNDscoimvN3M5Ts8YjpYzci/mgju/S/gt5Lnw==", "753-892-5754", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1051.jpg", "Lauretta75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "30982 Joel Oval, Dickiport, Andorra", "23f38c6d-cee3-43bf-9905-3ec5cd58576e", new DateTime(2024, 10, 20, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(7032), "Oma71@hotmail.com", "Oma", "Howe", "OMA71@HOTMAIL.COM", "OMA87", "AQAAAAIAAYagAAAAEEi2m86WRhhtmKRvyiDpBePKbkqTICqUn9DqpIrn5AeyBHlGlQym8B7+ARhwYj+rWA==", "395-062-0232", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1035.jpg", "Oma87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "11003 Altenwerth Hills, Johnsontown, Niger", "5827f641-ac33-4bde-ab62-f136787ee828", new DateTime(2024, 7, 20, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(7248), "Angie_Rau6@gmail.com", "Angie", "Rau", "ANGIE_RAU6@GMAIL.COM", "ANGIE_RAU9", "AQAAAAIAAYagAAAAEI70FeE8j5VdnxAbu2ERnrfore42GbuBuvx4eo6lKPm4V1ngdnuM02LmDosm9IpWPg==", "307-735-7208", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/870.jpg", "Angie_Rau9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7398 Jakob Flat, Schmelerburgh, Aruba", "456c6e46-77f9-4f54-bffc-635c544d1068", new DateTime(2024, 12, 23, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(7524), "Noah54@hotmail.com", "Noah", "Lubowitz", "NOAH54@HOTMAIL.COM", "NOAH.LUBOWITZ0", "AQAAAAIAAYagAAAAEHSjB/r0Rfn1Gv27JRzO2sV3YqGAEVEWhYAayl5hZZA65uDcMtyfA6m+nmTuOQulXQ==", "034-821-1405", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1194.jpg", "Noah.Lubowitz0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "913 Toy Trace, Kutchville, French Polynesia", "25dfd645-2359-4e3e-be94-271a4fd02bc6", new DateTime(2024, 3, 30, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(7736), "Sadye_Mante44@gmail.com", "Sadye", "Mante", "SADYE_MANTE44@GMAIL.COM", "SADYE10", "AQAAAAIAAYagAAAAEB8qWgNwxA7rEpHMurnbqLLSjpioxLON0BYSehgtQiI5y6uFIog5ctlPnXZ+6bI6yg==", "179-675-2921", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/110.jpg", "Sadye10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "64490 Luella Street, Monahanstad, Honduras", "05c7494d-5a30-4dfd-8e5b-cdf470d34b88", new DateTime(2024, 8, 21, 23, 32, 47, 848, DateTimeKind.Utc).AddTicks(7961), "Theresa.Ernser41@gmail.com", "Theresa", "Ernser", "THERESA.ERNSER41@GMAIL.COM", "THERESA_ERNSER44", "AQAAAAIAAYagAAAAELYwmKDBVHtTsWUPHVXwacU3dVvlG8BdjPm90s9Q5Vnus6dEMEA5ZXXTo4R2rTIUpQ==", "671-673-2394", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/248.jpg", "Theresa_Ernser44" });

            migrationBuilder.CreateIndex(
                name: "IX_VariantValueImages_VariantValueId",
                table: "VariantValueImages",
                column: "VariantValueId");

            migrationBuilder.AddForeignKey(
                name: "FK_FeedbackLikes_AspNetUsers_UserId",
                table: "FeedbackLikes",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FeedbackLikes_Feedbacks_FeedbackId",
                table: "FeedbackLikes",
                column: "FeedbackId",
                principalTable: "Feedbacks",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_FeedbackReports_AspNetUsers_UserId",
                table: "FeedbackReports",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FeedbackReports_Feedbacks_FeedbackId",
                table: "FeedbackReports",
                column: "FeedbackId",
                principalTable: "Feedbacks",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Products_ProductId",
                table: "Feedbacks",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FeedbackLikes_AspNetUsers_UserId",
                table: "FeedbackLikes");

            migrationBuilder.DropForeignKey(
                name: "FK_FeedbackLikes_Feedbacks_FeedbackId",
                table: "FeedbackLikes");

            migrationBuilder.DropForeignKey(
                name: "FK_FeedbackReports_AspNetUsers_UserId",
                table: "FeedbackReports");

            migrationBuilder.DropForeignKey(
                name: "FK_FeedbackReports_Feedbacks_FeedbackId",
                table: "FeedbackReports");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Products_ProductId",
                table: "Feedbacks");

            migrationBuilder.DropTable(
                name: "VariantValueImages");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "VariantValues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FeedbackId",
                table: "FeedbackReports",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FeedbackId",
                table: "FeedbackLikes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "077 Oberbrunner Park, West Rorybury, Aruba", "54b10b2d-086d-43b8-b892-37f613b26177", new DateTime(2024, 9, 29, 7, 10, 19, 798, DateTimeKind.Utc).AddTicks(3101), "Oceane_Cummings86@yahoo.com", "Oceane", "Cummings", "OCEANE_CUMMINGS86@YAHOO.COM", "OCEANE44", "AQAAAAIAAYagAAAAECb/cUoAOD7V+TjfXgTg8pLXRPPMLBX9EAnJVvY0Dsj0aQ/1KPqmBtfNSLtIopUtrA==", "425-667-0698", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/666.jpg", "Oceane44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "38458 Rashawn Crescent, South Jazmyneberg, Albania", "2127be1f-1c95-4500-a7ef-ccb3b4c61c9c", new DateTime(2024, 4, 3, 7, 10, 19, 799, DateTimeKind.Utc).AddTicks(7377), "Keith.Gleichner@gmail.com", "Keith", "Gleichner", "KEITH.GLEICHNER@GMAIL.COM", "KEITH.GLEICHNER", "AQAAAAIAAYagAAAAEOrY5jD/+AoZBhTqTx4GyWmj0w3dxkMlqYipByPSe62ZirhteWfuSzhDYTaMcQPonA==", "633-861-9113", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/257.jpg", "Keith.Gleichner" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "01853 Adams Ridges, Gradytown, Uzbekistan", "2acd26d4-3298-4831-b70d-b23d11c4d831", new DateTime(2025, 1, 8, 7, 10, 19, 799, DateTimeKind.Utc).AddTicks(7752), "Bertram30@yahoo.com", "Bertram", "Tillman", "BERTRAM30@YAHOO.COM", "BERTRAM46", "AQAAAAIAAYagAAAAEDexS9ZsCPJFweNzbY7h2qZQtw/VLqRm7I2XXgpLrmGv/gPOEaiNw/KGt6/GtDD6LQ==", "136-933-1261", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/859.jpg", "Bertram46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "686 Brody Radial, VonRuedenborough, Swaziland", "d0081d86-b9cc-4399-aa00-b72bdd811fb7", new DateTime(2024, 7, 17, 7, 10, 19, 799, DateTimeKind.Utc).AddTicks(8026), "Garett47@yahoo.com", "Garett", "Powlowski", "GARETT47@YAHOO.COM", "GARETT_POWLOWSKI77", "AQAAAAIAAYagAAAAEJEe3aP45QcJZ0DidS2ufgpqonUxsppaav/2t8uRQyztZ9YXMb+JTMp8QhOxVShPMg==", "494-933-6243", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/944.jpg", "Garett_Powlowski77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "575 Rubie Land, Pagachaven, French Guiana", "e79e878c-589e-4dfc-9bbb-a4db07e79960", new DateTime(2024, 11, 28, 7, 10, 19, 799, DateTimeKind.Utc).AddTicks(8235), "Brennon39@gmail.com", "Brennon", "Kerluke", "BRENNON39@GMAIL.COM", "BRENNON45", "AQAAAAIAAYagAAAAEGfoj0oMZdqX9ofAx9sci9TStEKAAzXYu7GwwrRYJl2WBQEDocTSE7aTkxn4ZtrEMw==", "507-438-4071", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/608.jpg", "Brennon45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "18378 Leannon Ridge, Chrisshire, Luxembourg", "0ce6ef9a-0842-4958-aaf6-079ce6be8544", new DateTime(2024, 4, 18, 7, 10, 19, 799, DateTimeKind.Utc).AddTicks(8468), "Roosevelt71@hotmail.com", "Roosevelt", "Kassulke", "ROOSEVELT71@HOTMAIL.COM", "ROOSEVELT35", "AQAAAAIAAYagAAAAEGC+E5Dnkn25VChTXwpUmebV2ydjHpQ2pEM8722i9TulNd4mC34w8+lDvOxEr1dHrA==", "195-265-5105", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/534.jpg", "Roosevelt35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "003 Mustafa Forges, Sadieberg, United Arab Emirates", "b7c4c342-aed7-4b05-b70f-1857404c8ca0", new DateTime(2024, 4, 24, 7, 10, 19, 799, DateTimeKind.Utc).AddTicks(8678), "Lionel.Predovic@yahoo.com", "Lionel", "Predovic", "LIONEL.PREDOVIC@YAHOO.COM", "LIONEL_PREDOVIC", "AQAAAAIAAYagAAAAELVoFdqfj297V48C2QE+wJfpcC4Y9DHMXEGkHUd+jFzZdwXu/65/XkAN8bRFDXx2xA==", "222-074-5688", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1220.jpg", "Lionel_Predovic" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8054 Zachery Expressway, New Darrin, Lebanon", "3b506795-06c7-418b-b297-4309caf0b9c7", new DateTime(2024, 12, 10, 7, 10, 19, 799, DateTimeKind.Utc).AddTicks(8934), "Oda.Considine@gmail.com", "Oda", "Considine", "ODA.CONSIDINE@GMAIL.COM", "ODA.CONSIDINE98", "AQAAAAIAAYagAAAAEIXjznZHwGSNYFIIqTzxPxArsH7cQefZmT7YYqaCSnXuNq24Z6QGl/jChT1T1SfQoQ==", "747-762-0939", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/132.jpg", "Oda.Considine98" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7236 Jovani Forge, Carleeberg, Sudan", "50186085-74fa-4cc2-8174-22cf2621f13d", new DateTime(2024, 3, 17, 7, 10, 19, 799, DateTimeKind.Utc).AddTicks(9125), "Mose.Macejkovic@yahoo.com", "Mose", "Macejkovic", "MOSE.MACEJKOVIC@YAHOO.COM", "MOSE_MACEJKOVIC", "AQAAAAIAAYagAAAAECT+eascTZYy8F8AyldITGdsFXerOyA/VOnavTX047br6kkbA+6zmgUXCdsGolPA2w==", "753-645-4433", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/144.jpg", "Mose_Macejkovic" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "01463 Anderson Highway, Rutherfordville, Chad", "1899e0f4-799d-4546-8d68-e2a8cfb5ec05", new DateTime(2024, 6, 22, 7, 10, 19, 799, DateTimeKind.Utc).AddTicks(9393), "Winfield21@hotmail.com", "Winfield", "Jacobi", "WINFIELD21@HOTMAIL.COM", "WINFIELD.JACOBI37", "AQAAAAIAAYagAAAAEGy919EVHTu4Pv3E+UuWQjwoLvM/BCPBk8lQ85t3tss51goCzy2TRWCnsL4pJp8u8w==", "688-290-3233", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/26.jpg", "Winfield.Jacobi37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "0930 Elmira Drive, Garfieldborough, Turks and Caicos Islands", "f6e4cc6e-5a27-4e80-989c-36918ef4454e", new DateTime(2024, 10, 28, 7, 10, 19, 799, DateTimeKind.Utc).AddTicks(9633), "Trent.Lesch@yahoo.com", "Trent", "Lesch", "TRENT.LESCH@YAHOO.COM", "TRENT48", "AQAAAAIAAYagAAAAEH33a8JdQ6TP9NcKVzVq9g/IhyQz9yPGdBs2hPiMcAkFBemQN5t9TY5B09tQkDN14Q==", "104-659-2531", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1209.jpg", "Trent48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "990 Gutmann Crescent, Generalbury, Uganda", "a1a6c79b-ac10-43a3-9037-20ac5f1f0ef6", new DateTime(2024, 10, 19, 7, 10, 19, 799, DateTimeKind.Utc).AddTicks(9841), "Liliane72@hotmail.com", "Liliane", "Nikolaus", "LILIANE72@HOTMAIL.COM", "LILIANE.NIKOLAUS75", "AQAAAAIAAYagAAAAEEsVaBHr6yMkYLFYq1wSRlH5BHzQc34f88bYdI0HcH7qhjh5wDoAnv6st6Li/qju0w==", "821-842-4956", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/983.jpg", "Liliane.Nikolaus75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1280 Harber Overpass, Randallberg, Iraq", "5b96515e-6aa0-4e2c-bd36-647f038590dd", new DateTime(2024, 11, 30, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(33), "Nichole.Runte6@gmail.com", "Nichole", "Runte", "NICHOLE.RUNTE6@GMAIL.COM", "NICHOLE_RUNTE", "AQAAAAIAAYagAAAAEA4P1IxwwzMBHvPne2MVPWT5YxgCH/6gk4wV5lcoBprYeifS48bWKh9sjaSYHuk5aQ==", "370-073-3342", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/414.jpg", "Nichole_Runte" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "51011 Dalton Square, North Kenneth, Svalbard & Jan Mayen Islands", "738914cc-97fd-477b-8c7d-cd9fc5afdda1", new DateTime(2024, 6, 13, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(249), "Boris55@gmail.com", "Boris", "Emmerich", "BORIS55@GMAIL.COM", "BORIS.EMMERICH85", "AQAAAAIAAYagAAAAEDGKdenD9D8GPOOJMiRMSf4ISGpo9aLdk8mZuOUX8Rn6RebYeom91475w67MMfMrsw==", "403-177-6450", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/570.jpg", "Boris.Emmerich85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "599 Garett Place, West Meredithberg, Antigua and Barbuda", "2de6e217-cce9-48ee-8e63-23b4bb2851ed", new DateTime(2024, 6, 9, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(431), "Ellie_Wisozk@yahoo.com", "Ellie", "Wisozk", "ELLIE_WISOZK@YAHOO.COM", "ELLIE76", "AQAAAAIAAYagAAAAEJ/1u+t9+jCS4BPEcPYXbqT3iT8oW/G3haMD3hGZmeZiD3oPiS9i4hWvqrMnJBvykg==", "579-686-9218", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/738.jpg", "Ellie76" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "72906 Hilll Manors, Maryseville, Papua New Guinea", "e7fbd63f-4d88-4f19-9b74-4854fe21110d", new DateTime(2024, 6, 18, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(680), "Kailey_Stiedemann@gmail.com", "Kailey", "Stiedemann", "KAILEY_STIEDEMANN@GMAIL.COM", "KAILEY_STIEDEMANN", "AQAAAAIAAYagAAAAEBIawalxI9Uz6N0SBaNi8hHfVOEAsmnsehDjRvWUgW+6l/msoNw3L2GDcWRgau+MBg==", "900-174-6926", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/33.jpg", "Kailey_Stiedemann" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "51628 Abernathy Place, South Mya, Cambodia", "801fd928-1a59-44b8-8db1-b1ba34506a74", new DateTime(2025, 1, 22, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(897), "Abigale71@gmail.com", "Abigale", "Littel", "ABIGALE71@GMAIL.COM", "ABIGALE.LITTEL85", "AQAAAAIAAYagAAAAEOZVq++oaFxmPm0Ea/Ur32EMNUt+3Uel5irQSfoFAAVWZFJreQs8Rya/f2yA0exfIA==", "083-851-1081", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/835.jpg", "Abigale.Littel85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1927 Halvorson Tunnel, Titusport, Lithuania", "c35cdef9-7d9a-4912-939d-7ea49098b845", new DateTime(2024, 8, 30, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(1093), "Armando.Kertzmann96@gmail.com", "Armando", "Kertzmann", "ARMANDO.KERTZMANN96@GMAIL.COM", "ARMANDO_KERTZMANN", "AQAAAAIAAYagAAAAEK30+yVh//iz+DWFsr/tkOFxJi+SZV6rbCL8QEvVscy4TfWhCDPIBS76wzzrF2NaQQ==", "927-223-6627", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/896.jpg", "Armando_Kertzmann" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "155 Will Extension, East Rolandoville, Guinea-Bissau", "1be9000b-acc8-48ac-bf59-bd9b52bffd56", new DateTime(2024, 7, 31, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(1317), "Corrine.Cummings@yahoo.com", "Corrine", "Cummings", "CORRINE.CUMMINGS@YAHOO.COM", "CORRINE39", "AQAAAAIAAYagAAAAEBM1bHr9vaEb1hzgQAqSXs7mzjbIOYNu9A3VbmvP0WOD+H1quAcDJdybwIqLnJoFrg==", "291-277-0830", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/297.jpg", "Corrine39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "952 Lemke Square, Gastonville, Netherlands", "f22ade51-b92f-4e11-8d42-b89aeff38474", new DateTime(2024, 3, 7, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(1493), "Elmore_Flatley61@yahoo.com", "Elmore", "Flatley", "ELMORE_FLATLEY61@YAHOO.COM", "ELMORE.FLATLEY67", "AQAAAAIAAYagAAAAEI7Bf7BJedbqcByLAtWICOM4+XfH8UPMqzP/7xy6GBrLatD3mUwHB8OgAGtt0ziNvw==", "815-832-2911", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/492.jpg", "Elmore.Flatley67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "48744 Baumbach Vista, Cruzport, Christmas Island", "158c1b91-455f-4570-995d-e9dadf016767", new DateTime(2024, 3, 3, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(1724), "Thaddeus_Blick53@gmail.com", "Thaddeus", "Blick", "THADDEUS_BLICK53@GMAIL.COM", "THADDEUS21", "AQAAAAIAAYagAAAAELpRZZYbnh9RV7dwL7QW7w4CcitBYOwa3qbTDSAp0Kpi/P6sHQRXlDp+C/T2TSEfzw==", "007-660-0114", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/596.jpg", "Thaddeus21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "649 Fiona Green, Darronfort, Guadeloupe", "bc667860-e08e-492a-bed8-ba56b1d269cb", new DateTime(2024, 12, 8, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(1913), "Clair77@yahoo.com", "Clair", "Schamberger", "CLAIR77@YAHOO.COM", "CLAIR.SCHAMBERGER29", "AQAAAAIAAYagAAAAEIpb/Jbb/rsSpJ3lIOzsBk8JrTFiPg/+nuezZVlIaJ0DFKOq4P0VhGfr060FkjARew==", "670-659-6848", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1173.jpg", "Clair.Schamberger29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1999 Hagenes Causeway, Harveyfort, Guinea-Bissau", "aed1b8a7-4ad0-478b-a309-554e23256b3f", new DateTime(2024, 7, 30, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(2117), "Rosetta18@gmail.com", "Rosetta", "Mosciski", "ROSETTA18@GMAIL.COM", "ROSETTA.MOSCISKI", "AQAAAAIAAYagAAAAEC6L4TnRKijBtlxn8gM3Mp9OCkPiCSEtY8L/IXGoPOp/kkFOLVK9jmVO/aPUGlRhHQ==", "765-208-8248", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/641.jpg", "Rosetta.Mosciski" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "94715 O'Reilly Center, South Morris, Estonia", "23b57ad7-f26f-44aa-9de7-4df82361dff9", new DateTime(2024, 9, 8, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(2286), "Samir49@gmail.com", "Samir", "Ledner", "SAMIR49@GMAIL.COM", "SAMIR.LEDNER", "AQAAAAIAAYagAAAAEBINDCSPT2zgNYnLXsu0PdUBLGv9v81k3r+PgxOhjHn9+u+2UW+nsPlTcWuynOtINQ==", "175-922-1747", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/744.jpg", "Samir.Ledner" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "242 Koepp Stream, Port Talonfort, Gabon", "1d45c6e2-d953-4834-9510-2b40779eec8e", new DateTime(2024, 4, 1, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(2489), "Gabriella.Berge47@gmail.com", "Gabriella", "Berge", "GABRIELLA.BERGE47@GMAIL.COM", "GABRIELLA.BERGE", "AQAAAAIAAYagAAAAEJFX9gQqBYA0EejcvHaWg2yHB44y/cD3Blv1fJdKm/UnZ67QAibZD2NT1P+rhYeU8g==", "696-309-9043", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1133.jpg", "Gabriella.Berge" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "82534 Enid Knolls, Schuppeland, Brunei Darussalam", "6a536e39-e49e-4a2b-a70e-0127740418e2", new DateTime(2024, 2, 17, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(2794), "Jackson_Tromp4@gmail.com", "Jackson", "Tromp", "JACKSON_TROMP4@GMAIL.COM", "JACKSON.TROMP53", "AQAAAAIAAYagAAAAELrmDI5LpZ87PPx9hGlLx55yHbNWe9/mNz81Ox4R8YKAHknH62UuFfguMCtQogldRQ==", "778-217-4354", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/158.jpg", "Jackson.Tromp53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9071 Una Flat, New Vaughn, Bermuda", "2a53231f-ce2c-45b4-99cc-2c2e77630f28", new DateTime(2024, 8, 29, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(2992), "Hilbert74@gmail.com", "Hilbert", "Reynolds", "HILBERT74@GMAIL.COM", "HILBERT.REYNOLDS41", "AQAAAAIAAYagAAAAEHhknLkY+s+Xw7Zi/d/trTXK5Rft71YtGF+fTCR8N44V+xu2Aqt3OfC0zSq6ZpzmXw==", "633-832-5256", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/448.jpg", "Hilbert.Reynolds41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "02015 Will Ford, Terrellbury, Taiwan", "aa76a422-a472-471a-a0b7-b2b0a961c4d8", new DateTime(2024, 8, 2, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(3163), "Arden_Ferry@gmail.com", "Arden", "Ferry", "ARDEN_FERRY@GMAIL.COM", "ARDEN_FERRY4", "AQAAAAIAAYagAAAAEBGazUtwKNlRy6Zwp40kj9TQk27zQiln7c8LFInzRN7VWRuj6Ar+h5I7Dh8KQwdY5w==", "856-640-2069", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/227.jpg", "Arden_Ferry4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "94301 Humberto Locks, North Jessikastad, Philippines", "1f16c4e0-a979-42fa-8964-5859a5618030", new DateTime(2024, 2, 26, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(3381), "Eloise_Carter@gmail.com", "Eloise", "Carter", "ELOISE_CARTER@GMAIL.COM", "ELOISE15", "AQAAAAIAAYagAAAAEB2FzWqVZ0O1Uljzx+nP6GGNoT46idifudqyG15OoJMCbNwtrPZOYYCykc5zxu1nsw==", "266-162-9135", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/402.jpg", "Eloise15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "246 Haley Summit, Wymanhaven, Saudi Arabia", "e9a63d89-a867-4d77-8f77-f2873703e284", new DateTime(2024, 12, 11, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(3585), "Mario.Aufderhar@hotmail.com", "Mario", "Aufderhar", "MARIO.AUFDERHAR@HOTMAIL.COM", "MARIO_AUFDERHAR16", "AQAAAAIAAYagAAAAECcJINqsZhxEA8q1Ut8mpnxjWNTz53KoaUsY6yq3/Rh/djeBKtRUDKBdrL9bqX7GtA==", "294-471-2972", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/441.jpg", "Mario_Aufderhar16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "500 Hertha Center, Eldredmouth, United Arab Emirates", "76422c61-4147-4d7a-b46c-f7c9cb56c9a7", new DateTime(2024, 4, 29, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(3793), "Mabelle96@hotmail.com", "Mabelle", "Heidenreich", "MABELLE96@HOTMAIL.COM", "MABELLE_HEIDENREICH82", "AQAAAAIAAYagAAAAEE91v6h2NmJi3sF2nJDliIGaKX9sxZ+jk8LTr/f/4wWMfcFuusW0Apui7JtFkngmVw==", "466-057-3669", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/934.jpg", "Mabelle_Heidenreich82" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "453 Craig Run, East Timothyfort, Qatar", "ea8830ec-8e57-4d72-be07-0bba6aeec83d", new DateTime(2024, 8, 23, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(4016), "Tamia_Stracke87@gmail.com", "Tamia", "Stracke", "TAMIA_STRACKE87@GMAIL.COM", "TAMIA_STRACKE", "AQAAAAIAAYagAAAAEB7DXv86Nkt9wEj54F3+Ne3HMJVtwL9+qQKYkVTNxU4oNc8KnzuEGE2VjNuyBF+JXA==", "632-522-9615", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/940.jpg", "Tamia_Stracke" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "11673 Hyatt Freeway, Port Evalynborough, Portugal", "c04f369b-90fa-47cd-84f5-d737ee80de4c", new DateTime(2024, 9, 20, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(4197), "Sydnee.Jerde84@hotmail.com", "Sydnee", "Jerde", "SYDNEE.JERDE84@HOTMAIL.COM", "SYDNEE_JERDE", "AQAAAAIAAYagAAAAEOjuRDoBQanp5wAUALAmVTAyFjuDRXcUOcCj+Tvo9XLRrZA21KCy1MFUS8N/Hfn3UA==", "120-497-1259", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1042.jpg", "Sydnee_Jerde" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8509 Jo Courts, Adityamouth, Mexico", "cd79909d-3ba9-4247-9395-c1828cfb4f1c", new DateTime(2025, 1, 3, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(4406), "Odie_Lindgren67@yahoo.com", "Odie", "Lindgren", "ODIE_LINDGREN67@YAHOO.COM", "ODIE.LINDGREN85", "AQAAAAIAAYagAAAAEKDs/ea3QvlVI3pXJXRDZS9fJcBZUhskpxf6nzFJbRSoCT2MSzFOcZhRAvp0Km/J4Q==", "882-405-7652", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/818.jpg", "Odie.Lindgren85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9372 Mike Greens, Vellamouth, Canada", "a4c80844-f65d-4dcb-969b-22fd9a4d996a", new DateTime(2024, 4, 11, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(4576), "Summer.Maggio@hotmail.com", "Summer", "Maggio", "SUMMER.MAGGIO@HOTMAIL.COM", "SUMMER_MAGGIO96", "AQAAAAIAAYagAAAAEPZFOR5Fm3M5qD4CoQgMOPL7QZYLbhU3MHJYjNhVyub80eEhXHKr67I4GfOlbylGHw==", "705-215-7796", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/618.jpg", "Summer_Maggio96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "3072 Josie Points, Greggville, Belarus", "695985d8-42e4-496c-8b23-0968a9f54786", new DateTime(2024, 4, 3, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(4775), "Quincy.Kovacek@yahoo.com", "Quincy", "Kovacek", "QUINCY.KOVACEK@YAHOO.COM", "QUINCY.KOVACEK29", "AQAAAAIAAYagAAAAEEpIjdiE7C0WAZOvegnnF0dikxom1xAodKI4K7Is98Joluql7YqXqv+m9Tj0Z8P80A==", "106-670-9748", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/663.jpg", "Quincy.Kovacek29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "300 Hayes Points, Calistaborough, Germany", "4ba15f08-714b-4363-8049-16c1595a59a5", new DateTime(2024, 9, 15, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(4970), "Filiberto_Crist52@hotmail.com", "Filiberto", "Crist", "FILIBERTO_CRIST52@HOTMAIL.COM", "FILIBERTO.CRIST", "AQAAAAIAAYagAAAAEKMFp9TEoDezMqej+N8sz/WwxCkk3ZZEaxxsPUZ7N+bDL/TF4ntY192oioi4Rh/wbA==", "829-625-7316", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/317.jpg", "Filiberto.Crist" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "3477 Creola Drives, Bruenmouth, Argentina", "9d67faee-76f3-4e3f-bed2-9a5ea62ae19b", new DateTime(2024, 7, 1, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(5223), "Bethel_Armstrong@hotmail.com", "Bethel", "Armstrong", "BETHEL_ARMSTRONG@HOTMAIL.COM", "BETHEL_ARMSTRONG98", "AQAAAAIAAYagAAAAEF/3C3OQ3/B+PwX8V2K6ytkDpZwR09o9ORyyWFT1KJtz+cyOmCA+PO/vt9Ja5400MQ==", "496-314-6005", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1204.jpg", "Bethel_Armstrong98" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "944 Hagenes Port, Port Elenora, Cambodia", "96876b6c-284e-47e6-a42d-4a09faa57f7e", new DateTime(2024, 7, 4, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(5395), "Mellie.Fadel@gmail.com", "Mellie", "Fadel", "MELLIE.FADEL@GMAIL.COM", "MELLIE_FADEL91", "AQAAAAIAAYagAAAAENe60TH6PNA41VtvbkYM38vWYOtWtauwBrLW7/hpfK7fUxQPfuRGJtzV1535+VsStg==", "924-170-3356", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/325.jpg", "Mellie_Fadel91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "681 Auer Hollow, Lake Rupertmouth, Kazakhstan", "d136c130-f129-4c1d-a066-60d0be6e0940", new DateTime(2024, 9, 25, 7, 10, 19, 800, DateTimeKind.Utc).AddTicks(5594), "Ben_West85@yahoo.com", "Ben", "West", "BEN_WEST85@YAHOO.COM", "BEN.WEST12", "AQAAAAIAAYagAAAAEE2MoLnSDAzxXnKhAX9ULbHKxeF1XydOAJBamyZQWJJ6UaySN0Fn3zESEobRgVAVSg==", "617-541-6810", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/830.jpg", "Ben.West12" });

            migrationBuilder.AddForeignKey(
                name: "FK_FeedbackLikes_AspNetUsers_UserId",
                table: "FeedbackLikes",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FeedbackLikes_Feedbacks_FeedbackId",
                table: "FeedbackLikes",
                column: "FeedbackId",
                principalTable: "Feedbacks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FeedbackReports_AspNetUsers_UserId",
                table: "FeedbackReports",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FeedbackReports_Feedbacks_FeedbackId",
                table: "FeedbackReports",
                column: "FeedbackId",
                principalTable: "Feedbacks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Products_ProductId",
                table: "Feedbacks",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
