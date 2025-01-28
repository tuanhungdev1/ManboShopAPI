using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ManboShopAPI.Infrastructure.Migrations
{
	/// <inheritdoc />
	public partial class seeddatarole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityRole");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, null, "Admin", "ADMIN" },
                    { 2, null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "66003 Homenick Lake, Adityabury, Hungary", "d4c1b196-09f4-46ee-8d4b-4df6b7c914a7", new DateTime(2024, 8, 4, 6, 16, 28, 815, DateTimeKind.Utc).AddTicks(7733), "Ernesto_McCullough51@yahoo.com", "Ernesto", "McCullough", "ERNESTO_MCCULLOUGH51@YAHOO.COM", "ERNESTO_MCCULLOUGH62", "AQAAAAIAAYagAAAAEL8zIMR/ejV/7bAazthFiyfIoLx4U4Tl+UjNkhBki9D0Od5m4eALSZrsdUWpP1u6yQ==", "520-689-3514", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1179.jpg", "Ernesto_McCullough62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7629 Lemke Manors, North Ezekiel, Rwanda", "81b35fd3-1cdc-48ec-945e-6307eda9b22e", new DateTime(2024, 9, 29, 6, 16, 28, 817, DateTimeKind.Utc).AddTicks(3222), "Stanford_Stanton@yahoo.com", "Stanford", "Stanton", "STANFORD_STANTON@YAHOO.COM", "STANFORD.STANTON", "AQAAAAIAAYagAAAAEHiI3vFwhTJAmpRWldWgsSLsLw948KVmnb9bmIx+dN6RH9HgqMXQ6cnCeqkjNdWb7Q==", "956-393-9387", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/446.jpg", "Stanford.Stanton" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "09818 Bergstrom Lake, Jacobiport, Lao People's Democratic Republic", "c54cfb0f-430b-4796-acf2-2c84e2ae4d6a", new DateTime(2024, 11, 8, 6, 16, 28, 817, DateTimeKind.Utc).AddTicks(3586), "Kennedi_Pfeffer@hotmail.com", "Kennedi", "Pfeffer", "KENNEDI_PFEFFER@HOTMAIL.COM", "KENNEDI_PFEFFER45", "AQAAAAIAAYagAAAAEOHq7q41Y1akneoos0Gdk/p87zecK1xJu/UvPANkkBKuX+WRxz8HyiNTKj4xpAHOHw==", "144-267-8535", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/748.jpg", "Kennedi_Pfeffer45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9639 Ryan Points, North Rogelio, Kenya", "c9a804f6-677d-42ec-ab9f-6b76399e9a3e", new DateTime(2024, 4, 16, 6, 16, 28, 817, DateTimeKind.Utc).AddTicks(3917), "Monserrate51@hotmail.com", "Monserrate", "Armstrong", "MONSERRATE51@HOTMAIL.COM", "MONSERRATE34", "AQAAAAIAAYagAAAAEOp7RSmBSr0RGJLG0I4s7bN1kI0SvWYZPC7r/gTEdDuHp2rkDJuyXDmn17jtLRN9xQ==", "320-267-1917", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1155.jpg", "Monserrate34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "712 Smith Station, Lake Tyreemouth, Saint Barthelemy", "1423b08e-e12d-4735-bae7-feea797f870c", new DateTime(2024, 9, 14, 6, 16, 28, 817, DateTimeKind.Utc).AddTicks(4225), "Skye_Gutmann23@yahoo.com", "Skye", "Gutmann", "SKYE_GUTMANN23@YAHOO.COM", "SKYE_GUTMANN", "AQAAAAIAAYagAAAAEHsUZEYec12PVUi/CtpEvHTeToZfRWgsP6xj+0bmGvQ0eqO83QskovkVjIra84FBKA==", "776-507-1524", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/631.jpg", "Skye_Gutmann" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "29965 Georgiana Highway, Lake Rosalia, Turks and Caicos Islands", "58c48a1f-962b-4a1a-b402-ba01cae30d81", new DateTime(2024, 4, 9, 6, 16, 28, 817, DateTimeKind.Utc).AddTicks(4584), "Candido_Connelly@yahoo.com", "Candido", "Connelly", "CANDIDO_CONNELLY@YAHOO.COM", "CANDIDO78", "AQAAAAIAAYagAAAAEBq4YDPeYynoV9h5+WKPviDaPjSAfind0PgZh2tsxcwDe9XPyQh960sicJ/mep0hPA==", "915-747-6535", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/955.jpg", "Candido78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "98071 Hodkiewicz Squares, North Elyssa, Anguilla", "4595a8ab-ee38-441b-b5ad-5617878d8549", new DateTime(2024, 7, 3, 6, 16, 28, 817, DateTimeKind.Utc).AddTicks(4988), "Nicholaus_Purdy40@gmail.com", "Nicholaus", "Purdy", "NICHOLAUS_PURDY40@GMAIL.COM", "NICHOLAUS_PURDY", "AQAAAAIAAYagAAAAEKs/T4XVlxOByAVUHnTr4cZO4u0o6M47dbdjAClrvnQiW5wN75BZ/fTdFZCbuJ+JhQ==", "022-596-5661", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/235.jpg", "Nicholaus_Purdy" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "72137 Sigurd Shoal, Port Jaceyfurt, Bermuda", "9db26c41-3385-4ce3-888f-8a82fa745ee1", new DateTime(2024, 5, 19, 6, 16, 28, 817, DateTimeKind.Utc).AddTicks(5460), "Quentin45@hotmail.com", "Quentin", "Franecki", "QUENTIN45@HOTMAIL.COM", "QUENTIN55", "AQAAAAIAAYagAAAAEPt7aCFanV+oVOSh4cEuWL3Xz/jCnFpnOSfOC/1rNUhAlXtp5ValUJDNUAzOvMoFrg==", "054-527-2349", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/892.jpg", "Quentin55" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "49439 Savanna Cape, Gustside, Tuvalu", "6571b475-ca98-4399-8514-511d2cc5c465", new DateTime(2024, 7, 30, 6, 16, 28, 817, DateTimeKind.Utc).AddTicks(5846), "Hadley27@hotmail.com", "Hadley", "Corwin", "HADLEY27@HOTMAIL.COM", "HADLEY.CORWIN", "AQAAAAIAAYagAAAAEMvYu3gDi6aOTtFG0NZ/fAuZ68MITnVu+flQ4Cgss8ZpNZ+WdPo0K0d+75AG6uFBvA==", "686-549-2603", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1141.jpg", "Hadley.Corwin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "3816 Abigale Rapid, New Zoey, Burundi", "e53c13cd-c6da-4447-9e44-109217d14afb", new DateTime(2024, 12, 7, 6, 16, 28, 817, DateTimeKind.Utc).AddTicks(6392), "Maudie74@hotmail.com", "Maudie", "Carroll", "MAUDIE74@HOTMAIL.COM", "MAUDIE41", "AQAAAAIAAYagAAAAEI/rxowShHGGG8mTPIjn5NQD2//nfu1q1A5whuLgSp7PbXFLER4WLpabLr0J3gklIg==", "397-995-0096", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/929.jpg", "Maudie41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "766 Daugherty Corners, Oberbrunnermouth, Saint Barthelemy", "a59f73df-76e2-4382-b933-fc834c302d90", new DateTime(2023, 12, 24, 6, 16, 28, 817, DateTimeKind.Utc).AddTicks(6742), "Marcella20@hotmail.com", "Marcella", "Auer", "MARCELLA20@HOTMAIL.COM", "MARCELLA_AUER", "AQAAAAIAAYagAAAAEJxJJjYPWVX9Z3WDKSvPOM9bjaOyQ/5wqiu/+tk77L/9sft4YImVQiQ9OMjAA5QQPw==", "209-550-6827", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/950.jpg", "Marcella_Auer" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "909 Mireille Burg, Colestad, Pitcairn Islands", "60a5ab73-0714-42bf-b685-8c1879388453", new DateTime(2024, 7, 21, 6, 16, 28, 817, DateTimeKind.Utc).AddTicks(7061), "Shaun60@hotmail.com", "Shaun", "Gislason", "SHAUN60@HOTMAIL.COM", "SHAUN47", "AQAAAAIAAYagAAAAEJ/Gvjx83WI0Zg2iKOF2aPugzQylGglBkbVsaL5ngtIIOvqGLBllRQ+ptle7f/rOsw==", "275-826-8500", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/238.jpg", "Shaun47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "3492 Treutel Well, East Bonitastad, Guinea-Bissau", "9d8df44f-e1ce-49d0-b60e-7618bcf89291", new DateTime(2024, 1, 14, 6, 16, 28, 817, DateTimeKind.Utc).AddTicks(7311), "Allan_Prohaska31@hotmail.com", "Allan", "Prohaska", "ALLAN_PROHASKA31@HOTMAIL.COM", "ALLAN.PROHASKA4", "AQAAAAIAAYagAAAAEOfwpCW+075pn6p/WbBtXjMVMI4GqS+S7bSK1rd1/IgrzDmqWq/Z9wqohCcYr7WHsA==", "158-526-8760", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/908.jpg", "Allan.Prohaska4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "736 Elinor Key, North Larissa, Venezuela", "fe33410e-a5bc-4b07-ab16-8d137bf54f28", new DateTime(2024, 6, 26, 6, 16, 28, 817, DateTimeKind.Utc).AddTicks(7568), "Shyann_Schroeder@hotmail.com", "Shyann", "Schroeder", "SHYANN_SCHROEDER@HOTMAIL.COM", "SHYANN21", "AQAAAAIAAYagAAAAEOZNJTETRQBGJuqksTuPOgMfg9TVgUjwF8mCDymg0klglM3JvIRRgoJWel83TAnXRQ==", "231-011-4612", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/714.jpg", "Shyann21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "50700 Kassandra Orchard, Wendychester, Ethiopia", "ce0abdc2-4c53-4f83-9e1b-79709ed8cd1b", new DateTime(2024, 5, 20, 6, 16, 28, 817, DateTimeKind.Utc).AddTicks(7787), "Miller24@gmail.com", "Miller", "Becker", "MILLER24@GMAIL.COM", "MILLER.BECKER", "AQAAAAIAAYagAAAAEP4D7Ow0jH6FEXWiTYhLXJsWFvLk5Zs7Y0SBhF/XsLw2Qpb6qT2y4Rc4rk+0NbBlSw==", "203-057-0775", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1108.jpg", "Miller.Becker" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "52639 Cheyanne Valleys, East Una, Cape Verde", "5c7d79a2-4837-4908-98c0-a631fc117d98", new DateTime(2024, 4, 11, 6, 16, 28, 817, DateTimeKind.Utc).AddTicks(8071), "Loma.Smith@yahoo.com", "Loma", "Smith", "LOMA.SMITH@YAHOO.COM", "LOMA29", "AQAAAAIAAYagAAAAENeiUPNURbMsXAQcJ2a/DA30JX5RMF58x4vm3lYTujfVmNA/wh7a3/VxSvFDRWMerg==", "006-157-3221", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1242.jpg", "Loma29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "24609 Parker Circle, East Wilmastad, Central African Republic", "e611af34-bc13-43f6-914a-97684ff62d3a", new DateTime(2024, 8, 1, 6, 16, 28, 817, DateTimeKind.Utc).AddTicks(8315), "Destany_Beatty99@hotmail.com", "Destany", "Beatty", "DESTANY_BEATTY99@HOTMAIL.COM", "DESTANY64", "AQAAAAIAAYagAAAAEPljCtQ1FvahBBojyxEFZ5Cg7R/Ry1HXtvZiQ5Zdo/F7fGZc/iTWoWuHMydd0wAQPw==", "569-165-3646", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/933.jpg", "Destany64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "25791 Gislason Fork, Nolaton, Swaziland", "380ba960-7b20-4e2d-af01-799474be9951", new DateTime(2024, 11, 21, 6, 16, 28, 817, DateTimeKind.Utc).AddTicks(8592), "Charlotte.Kessler@hotmail.com", "Charlotte", "Kessler", "CHARLOTTE.KESSLER@HOTMAIL.COM", "CHARLOTTE_KESSLER", "AQAAAAIAAYagAAAAECFi8JM6dIoX1EfyyTD2+Qx/IG9NrGCT/Vm/RM6u5rclg6P18CgD2UxzhR9EsrgfKQ==", "367-595-3276", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/971.jpg", "Charlotte_Kessler" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9714 Emile Place, Port Neoma, Estonia", "8b6858db-bd19-4cb1-aea8-3dcc607f2327", new DateTime(2024, 3, 5, 6, 16, 28, 817, DateTimeKind.Utc).AddTicks(8808), "Vilma6@yahoo.com", "Vilma", "Hickle", "VILMA6@YAHOO.COM", "VILMA50", "AQAAAAIAAYagAAAAEFY7SqMJnZjDdca39whCi4J3qB3BVoxcvHLZYOLL42JVh+7JhsbEqRky7eY7Ljbelw==", "023-193-2542", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/24.jpg", "Vilma50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "529 Foster Canyon, Mayertbury, Lebanon", "5c5879b9-38a3-4c29-a33c-90cc13ddc029", new DateTime(2024, 1, 26, 6, 16, 28, 817, DateTimeKind.Utc).AddTicks(9052), "Marques.Russel75@hotmail.com", "Marques", "Russel", "MARQUES.RUSSEL75@HOTMAIL.COM", "MARQUES42", "AQAAAAIAAYagAAAAENCN8ODkKPLNe4HDJCca9atA9RmJDJkrRZ0bE7oAeKuoUpvp8C7gkDJCylnH+Mdl5g==", "950-256-5605", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1218.jpg", "Marques42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "02546 Eunice Expressway, Obieville, Latvia", "08d78b2d-3896-4400-a66e-dcba04356da0", new DateTime(2024, 11, 16, 6, 16, 28, 817, DateTimeKind.Utc).AddTicks(9296), "Alfonso_Macejkovic@yahoo.com", "Alfonso", "Macejkovic", "ALFONSO_MACEJKOVIC@YAHOO.COM", "ALFONSO.MACEJKOVIC71", "AQAAAAIAAYagAAAAEP5kt5ZoZlB8t/WS4/80Q8Y2qBRaWy571aP3j/iJlsg069mPmPTD+1lPFnz8deJnPw==", "813-289-5769", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/245.jpg", "Alfonso.Macejkovic71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "22351 Sipes Springs, North Kayden, France", "d3f1fab7-1504-4f67-ae64-4315553f7282", new DateTime(2024, 4, 3, 6, 16, 28, 817, DateTimeKind.Utc).AddTicks(9564), "Pearlie_Gaylord@yahoo.com", "Pearlie", "Gaylord", "PEARLIE_GAYLORD@YAHOO.COM", "PEARLIE.GAYLORD", "AQAAAAIAAYagAAAAEDFXNYune426NHLQMeY2q/3N/aCfTEpQJoU70UDXtMVYHQ9YRrnE+npylreSVcIcjg==", "736-884-2158", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1035.jpg", "Pearlie.Gaylord" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7488 Cheyanne Alley, South Adaside, Haiti", "65fbf397-0509-4ef1-b193-857dacfa1c64", new DateTime(2024, 10, 25, 6, 16, 28, 817, DateTimeKind.Utc).AddTicks(9835), "Aric.Kiehn@gmail.com", "Aric", "Kiehn", "ARIC.KIEHN@GMAIL.COM", "ARIC_KIEHN", "AQAAAAIAAYagAAAAEDvyLEgYYdWsj3NQ9dzTt2ZNFuWJo+XjUp3WZASXyxFqtlA5cvPYt/Q8HTn0CbQhmQ==", "807-180-0640", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/449.jpg", "Aric_Kiehn" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "11441 McLaughlin Greens, Noahberg, India", "f2bd669d-6e29-4cc1-8e9b-49979889ea37", new DateTime(2024, 2, 19, 6, 16, 28, 818, DateTimeKind.Utc).AddTicks(274), "Dillan.Mueller73@hotmail.com", "Dillan", "Mueller", "DILLAN.MUELLER73@HOTMAIL.COM", "DILLAN_MUELLER39", "AQAAAAIAAYagAAAAEG0+NY72VJtqPfSXXEW1Rjnls5YCcsCXpjzdeILjJHvePnSiTx+z2s1UsxniemjFwQ==", "288-358-0834", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/109.jpg", "Dillan_Mueller39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "74142 Labadie Glen, Johnathonside, Greenland", "d2ca9b54-6b2a-449b-b569-0cfd7e495284", new DateTime(2024, 9, 9, 6, 16, 28, 818, DateTimeKind.Utc).AddTicks(676), "Providenci.Schaefer@gmail.com", "Providenci", "Schaefer", "PROVIDENCI.SCHAEFER@GMAIL.COM", "PROVIDENCI_SCHAEFER0", "AQAAAAIAAYagAAAAEOUlAMjc+FNd+YpGevPMSurAFtvSn4nuhJJss9F/HvQteUVPhVInX0nMPyl1sgN+/A==", "356-126-8964", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/10.jpg", "Providenci_Schaefer0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "095 Jayme Plaza, South Rebecca, Burkina Faso", "743435d2-a695-4554-ade1-acbeb6ccf864", new DateTime(2024, 10, 27, 6, 16, 28, 818, DateTimeKind.Utc).AddTicks(1124), "Winnifred7@gmail.com", "Winnifred", "Dietrich", "WINNIFRED7@GMAIL.COM", "WINNIFRED_DIETRICH39", "AQAAAAIAAYagAAAAEMU8mXNUuqYA5xMebiJt2adBdY1qNWL7CSVuDp6UOS/77JpNXJxwtY+iG9iFH08ntg==", "795-985-8512", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/751.jpg", "Winnifred_Dietrich39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "3862 Keshaun Lock, Lake Rowland, Djibouti", "d2597b33-fd60-4e62-ae57-01aae3b0dabd", new DateTime(2024, 8, 14, 6, 16, 28, 818, DateTimeKind.Utc).AddTicks(1571), "Guido40@hotmail.com", "Guido", "Harvey", "GUIDO40@HOTMAIL.COM", "GUIDO_HARVEY15", "AQAAAAIAAYagAAAAEHEfFhLIgMWaHxT5h6hD8sarPf+6a6SgXbYlvE+LMF43Xwk0iOyv+8JBaxoQ5k0z6Q==", "286-907-1156", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/943.jpg", "Guido_Harvey15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "40231 Leonora Rapid, Lake Percivaltown, Mali", "0d79dc2e-63a1-42c2-9231-d2e7908ceff4", new DateTime(2024, 9, 22, 6, 16, 28, 818, DateTimeKind.Utc).AddTicks(1902), "Mandy.Gleichner46@yahoo.com", "Mandy", "Gleichner", "MANDY.GLEICHNER46@YAHOO.COM", "MANDY.GLEICHNER", "AQAAAAIAAYagAAAAEFzZ9fCtv+xDjNRFXx8RvtuynB0SJvQVJelM5mQF2mR2F7XZYTmNuwZLx4zQ+kim5w==", "619-804-6741", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/547.jpg", "Mandy.Gleichner" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "962 Brendon Spur, Adellview, Western Sahara", "928f2871-142e-496b-bc18-15ae474add4b", new DateTime(2024, 6, 2, 6, 16, 28, 818, DateTimeKind.Utc).AddTicks(2153), "Joana49@yahoo.com", "Joana", "Watsica", "JOANA49@YAHOO.COM", "JOANA.WATSICA97", "AQAAAAIAAYagAAAAEHNRYEXxpmjuFWWPB7j5WzRI/mV3H/7H2XOuRskkLTnMA+jbzZcOY6i1oLYFhnTiww==", "303-593-3607", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/164.jpg", "Joana.Watsica97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1248 Fahey Spurs, West Jerad, Bouvet Island (Bouvetoya)", "5571d611-88ff-4f31-96a5-08d3fa3b6648", new DateTime(2024, 12, 18, 6, 16, 28, 818, DateTimeKind.Utc).AddTicks(2389), "Susan_Mitchell@yahoo.com", "Susan", "Mitchell", "SUSAN_MITCHELL@YAHOO.COM", "SUSAN_MITCHELL", "AQAAAAIAAYagAAAAED6q2mHVM+6hK7L5uRMAIgCmMYxbkXquGeqRSsfZ8d/Ks7v47Qa/CBFGlXh6zB4hpQ==", "130-313-6019", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/40.jpg", "Susan_Mitchell" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "210 Monroe Divide, Bayleeport, Chile", "a2beb235-1828-482a-b1ff-6503b0a37200", new DateTime(2024, 8, 5, 6, 16, 28, 818, DateTimeKind.Utc).AddTicks(2638), "Brooks.Homenick86@gmail.com", "Brooks", "Homenick", "BROOKS.HOMENICK86@GMAIL.COM", "BROOKS_HOMENICK50", "AQAAAAIAAYagAAAAECIvaUaTJ40yPnhRUdXeHbF9r1kAGOXpTahwtIe0WzAwxCA1vfHOTtbVZcKQvRqRew==", "341-906-0051", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1067.jpg", "Brooks_Homenick50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "21458 Barton Crossroad, Darylberg, Costa Rica", "82ab71b6-08e8-4447-8d46-eea2376c0e5e", new DateTime(2024, 5, 30, 6, 16, 28, 818, DateTimeKind.Utc).AddTicks(2861), "Nathaniel.Rogahn@hotmail.com", "Nathaniel", "Rogahn", "NATHANIEL.ROGAHN@HOTMAIL.COM", "NATHANIEL_ROGAHN", "AQAAAAIAAYagAAAAEFK0FsP2XlMUIbOg4JgJNyNNT+7C7dBQcSl/h0OglZh1eGB68SwU4eRsZrOiREixcw==", "730-602-6285", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/903.jpg", "Nathaniel_Rogahn" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "494 Concepcion Creek, Candelariostad, American Samoa", "ccd45284-fc64-4cdb-9b81-568b7460f54d", new DateTime(2024, 3, 2, 6, 16, 28, 818, DateTimeKind.Utc).AddTicks(3118), "Vivienne89@hotmail.com", "Vivienne", "Spinka", "VIVIENNE89@HOTMAIL.COM", "VIVIENNE.SPINKA", "AQAAAAIAAYagAAAAEJdKB9x3BudRfdZEczYwLBuC7C1Mn+eJYgeB2ioMoJBLoIxMo9h2GTlJ+XItCYbixQ==", "740-865-6099", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/374.jpg", "Vivienne.Spinka" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "801 Boyle Meadow, East Reganbury, Iraq", "d1e60906-0786-4b8e-9416-ffff75cc1ebe", new DateTime(2024, 11, 6, 6, 16, 28, 818, DateTimeKind.Utc).AddTicks(3326), "Jeff_Altenwerth48@yahoo.com", "Jeff", "Altenwerth", "JEFF_ALTENWERTH48@YAHOO.COM", "JEFF.ALTENWERTH", "AQAAAAIAAYagAAAAEI+zRVVWVhIP98Q6CWMc7Mcr6qbnksaOOwLGvJ/703WxwkbJ39EHOADNDIBwUn+aIQ==", "835-876-9523", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/842.jpg", "Jeff.Altenwerth" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9954 Jakubowski Mews, Milfordshire, Pakistan", "f0d1a5cc-602f-4c4b-abf9-5150a98d6f67", new DateTime(2024, 10, 4, 6, 16, 28, 819, DateTimeKind.Utc).AddTicks(4580), "Adeline.OReilly@yahoo.com", "Adeline", "O'Reilly", "ADELINE.OREILLY@YAHOO.COM", "ADELINE86", "AQAAAAIAAYagAAAAENv46iHL+8AqYfTKwDFRDZ4Yq8zOfaLMfi6iNwvqv9SH4RIg4xctzcB8GFTkaXi8LQ==", "176-885-0788", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/81.jpg", "Adeline86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "957 Mack Ville, Schowalterport, Iraq", "5fbdae16-2f7f-42fc-9783-8f956cc64194", new DateTime(2024, 1, 4, 6, 16, 28, 819, DateTimeKind.Utc).AddTicks(4938), "Lina5@hotmail.com", "Lina", "Prohaska", "LINA5@HOTMAIL.COM", "LINA_PROHASKA88", "AQAAAAIAAYagAAAAEEktNM0z3B3JGOQC6HXeVOJ9R9TvskxAmvNMI/sH58tEJWQNRcRyfZYF4pBEjOoKQg==", "983-760-9960", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/651.jpg", "Lina_Prohaska88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "2812 Lind Burgs, Jacintoville, Paraguay", "ff0dad32-130e-4b99-9908-2526c7243a1f", new DateTime(2024, 3, 17, 6, 16, 28, 819, DateTimeKind.Utc).AddTicks(5215), "Beaulah53@yahoo.com", "Beaulah", "Herzog", "BEAULAH53@YAHOO.COM", "BEAULAH_HERZOG", "AQAAAAIAAYagAAAAEABsp47UpkGCkn61ilfRFULzJVIJRX68t6wXC0K2+n3qZ6TJ/jmwm5H6VXhwVT4uJw==", "416-151-8643", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/197.jpg", "Beaulah_Herzog" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "845 Susan Streets, Port Jameson, Hungary", "5102cf28-c84e-4b7d-a488-fc8b79028255", new DateTime(2024, 5, 26, 6, 16, 28, 819, DateTimeKind.Utc).AddTicks(5449), "Madisyn.Wunsch@yahoo.com", "Madisyn", "Wunsch", "MADISYN.WUNSCH@YAHOO.COM", "MADISYN77", "AQAAAAIAAYagAAAAEEKU75WI9XxCOWyHX+l8YSuI0H3xYPl5/YNdtCG0rljfwIgNHIUckGNIcxP7MjyLHA==", "346-816-9552", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1159.jpg", "Madisyn77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6963 Josianne Courts, North Summer, Cocos (Keeling) Islands", "a699c12d-9bbf-4c84-bbfd-a785e8d1f89a", new DateTime(2024, 8, 28, 6, 16, 28, 819, DateTimeKind.Utc).AddTicks(5703), "Prince33@hotmail.com", "Prince", "Weissnat", "PRINCE33@HOTMAIL.COM", "PRINCE_WEISSNAT8", "AQAAAAIAAYagAAAAEIe9vG1fy+57X6Qwte7D5D/ffPOpgGVMSAs8FnobvhaCrZCT0IePj0hVTxci5MqpQw==", "871-718-6358", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/33.jpg", "Prince_Weissnat8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "199 Rory Stream, Koeppport, Saint Kitts and Nevis", "9ba6245e-f21d-44b4-8ea9-86879776f574", new DateTime(2024, 5, 31, 6, 16, 28, 819, DateTimeKind.Utc).AddTicks(5964), "Delilah.Luettgen11@gmail.com", "Delilah", "Luettgen", "DELILAH.LUETTGEN11@GMAIL.COM", "DELILAH_LUETTGEN", "AQAAAAIAAYagAAAAEMQ7i0bBGkReWvMfZ1U3usDTZBY4oiwxPcx+h34c5/oLb1fYcvAnlv1e/aAwnGRPVQ==", "994-377-8615", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/231.jpg", "Delilah_Luettgen" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5116));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5119));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5125));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5126));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 31, 87, DateTimeKind.Utc).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(582));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(605));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(608));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 6, 16, 28, 782, DateTimeKind.Utc).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 131, 4, new DateTime(2024, 12, 20, 6, 16, 28, 772, DateTimeKind.Utc).AddTicks(9183), "Sản phẩm được làm từ Vải Linen. Co giãn tốt. Phù hợp cho các dịp văn phòng", "Adidas Váy Liền Hiện Đại", 2306452.7544153676407804773239m, 2025999.970534564700000m, 280, "Kích thước: XS, XL, L. Màu sắc: Xanh Navy, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 194, 2, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(7581), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp văn phòng", "H&M Áo Thun Thời Thượng", 2222888.4771251925756016374914m, 1891535.591538910850000m, 345, "Kích thước: XL, XS, S. Màu sắc: Xanh Navy, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 35, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(7801), "Sản phẩm được làm từ Vải Organic. Co giãn tốt. Phù hợp cho các dịp thể thao", "Nike Áo Thun Cổ Điển", 2260075.6175193936645310949393m, 1912214.893789743350000m, 487, "Kích thước: XL, XS, M. Màu sắc: Đỏ, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 124, 4, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(7852), "Sản phẩm được làm từ Vải Châu Âu. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Adidas Áo Polo Sang Trọng", 2885155.4195858001701876584251m, 2182975.831347354950000m, 232, "Kích thước: XXL, XL, S. Màu sắc: Xám, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 134, 5, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(7893), "Sản phẩm được làm từ Sợi Bamboo. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "Louis Vuitton Váy Liền Thoải Mái", 3446332.3696598464889802984208m, 2522191.831409720750000m, 379, "Kích thước: M, L, XL. Màu sắc: Trắng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 29, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(7986), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Zara Váy Liền Thoải Mái", 1758375.3677460720046390964106m, 1308099.909681492350000m, 224, "Kích thước: S, L, XXL. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 183, 5, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(8024), "Sản phẩm được làm từ Chất liệu Nhật Bản. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "Uniqlo Áo Len Sang Trọng", 3611792.1303946927341862138305m, 3212559.993648510950000m, 391, "Kích thước: XS, XL, XXL. Màu sắc: Hồng, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 79, 1, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(8071), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "Louis Vuitton Áo Sơ Mi Thời Thượng", 3777252.9615623825328168956289m, 2666372.6694582950000m, 39, "Kích thước: XXL, L, XS. Màu sắc: Đỏ, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 142, 2, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(8113), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp thể thao", "Uniqlo Quần Jogger Cổ Điển", 6263931.4421860720463869136593m, 4347900.783982637150000m, 144, "Kích thước: S, M, XS. Màu sắc: Xanh Navy, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 178, 5, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(8185), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Gucci Blazer Thoải Mái", 5548589.0673165344367289623634m, 4733087.427447543950000m, 383, "Kích thước: XL, XS, M. Màu sắc: Hồng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 69, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(8220), "Sản phẩm được làm từ Vải Châu Âu. Co giãn tốt. Phù hợp cho các dịp văn phòng", "Chanel Blazer Sang Trọng", 2337003.8831590389962577114460m, 1573405.996313171300000m, 121, "Kích thước: XXL, XS, XL. Màu sắc: Trắng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 95, 5, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(8254), "Sản phẩm được làm từ Vải Linen. Co giãn tốt. Phù hợp cho các dịp dạo phố", "Uniqlo Áo Khoác Hiện Đại", 4480203.5807134686239248605746m, 3832632.85918466300000m, 25, "Kích thước: XXL, M, XS. Màu sắc: Đen, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 53, 2, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(8321), "Sản phẩm được làm từ Vải Organic. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "Chanel Quần Jogger Năng Động", 6215580.3471279152098479092158m, 4237240.663015138850000m, 123, "Kích thước: S, XXL, XL. Màu sắc: Xám, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 116, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(8358), "Sản phẩm được làm từ Vải Linen. Thoáng mát. Phù hợp cho các dịp thể thao", "Louis Vuitton Áo Len Thoải Mái", 2256347.5384879883696212785243m, 1776973.780983788150000m, 309, "Kích thước: XXL, XS, XL. Màu sắc: Xám, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 99, 3, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(8396), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp tiệc tùng", "Nike Áo Polo Sang Trọng", 5158560.2226471225941274818384m, 3439230.894515617250000m, 193, "Kích thước: XXL, XS, S. Màu sắc: Đen, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 185, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(8431), "Sản phẩm được làm từ Sợi Bamboo. Co giãn tốt. Phù hợp cho các dịp văn phòng", "Louis Vuitton Blazer Cổ Điển", 6134578.7672730580346752677817m, 4262128.869218794700000m, 411, "Kích thước: XL, M, L. Màu sắc: Hồng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 105, 3, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(8499), "Sản phẩm được làm từ Vải Organic. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "Uniqlo Quần Tây Thời Thượng", 1782280.3147195015864933910036m, 1556835.478584829250000m, 302, "Kích thước: S, XS, XL. Màu sắc: Đen, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 179, 3, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(8536), "Sản phẩm được làm từ Cotton cao cấp. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Uniqlo Váy Liền Cổ Điển", 2396692.1009212159293885435030m, 1729905.804183982100000m, 311, "Kích thước: L, S, M. Màu sắc: Đỏ, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 184, 1, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(8571), "Sản phẩm được làm từ Sợi Bamboo. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "Louis Vuitton Đầm Dạ Hội Hiện Đại", 1382572.7476796331478405352663m, 975496.625713452650000m, 424, "Kích thước: XXL, XL, L. Màu sắc: Đen, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 91, 2, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(8638), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "Louis Vuitton Quần Jean Thời Thượng", 5705057.6114266846679568934057m, 4403184.860380942850000m, 77, "Kích thước: XL, XS, L. Màu sắc: Đỏ, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 26, 2, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(8744), "Sản phẩm được làm từ Sợi Bamboo. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Chanel Váy Liền Năng Động", 459756.93147078380413430282663m, 346128.3180480955550000m, 494, "Kích thước: M, S, XS. Màu sắc: Hồng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 164, 1, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(8803), "Sản phẩm được làm từ Vải Linen. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "Adidas Áo Thun Sang Trọng", 3494515.7567730766094211220441m, 3108204.374413015850000m, 21, "Kích thước: XS, XXL, XL. Màu sắc: Trắng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 73, 4, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(8859), "Sản phẩm được làm từ Vải Organic. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Zara Váy Liền Hiện Đại", 5981902.3654649307425659081600m, 4575057.326524664600000m, 461, "Kích thước: XS, S, XL. Màu sắc: Đỏ, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 175, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(8915), "Sản phẩm được làm từ Cotton cao cấp. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Adidas Áo Polo Cổ Điển", 3197597.2230320796311452340050m, 2394451.453269724700000m, 497, "Kích thước: L, S, XL. Màu sắc: Đen, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 128, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(9046), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp dạo phố", "H&M Blazer Cổ Điển", 3948015.3187580832356399328151m, 3102379.656595639700000m, 367, "Kích thước: M, S, XS. Màu sắc: Xám, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 163, 4, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(9091), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "H&M Áo Khoác Hiện Đại", 1599854.2271934612717168131302m, 1158726.201828347300000m, 111, "Kích thước: L, M, XS. Màu sắc: Xám, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 192, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(9138), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp dạo phố", "Adidas Quần Short Năng Động", 2189474.7917411749382589248727m, 1587271.217631551600000m, 499, "Kích thước: XL, S, XS. Màu sắc: Đỏ, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 85, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(9230), "Sản phẩm được làm từ Chất liệu Nhật Bản. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "Uniqlo Áo Khoác Sang Trọng", 2002258.1060409072492959825071m, 1799288.71875586400000m, 228, "Kích thước: L, M, S. Màu sắc: Trắng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 49, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(9296), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "Uniqlo Quần Jogger Thoải Mái", 2415327.3382068327441111911725m, 1842599.717538966050000m, 21, "Kích thước: XS, XXL, S. Màu sắc: Xám, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 38, 5, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(9350), "Sản phẩm được làm từ Vải Linen. Co giãn tốt. Phù hợp cho các dịp thể thao", "Louis Vuitton Blazer Thời Thượng", 83473.84162238101326455635189m, 60287.92756689458750000m, 451, "Kích thước: XL, XXL, S. Màu sắc: Đen, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 60, 4, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(9408), "Sản phẩm được làm từ Vải Organic. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "Louis Vuitton Blazer Cổ Điển", 1659579.3132431164283615568017m, 1467099.640936230350000m, 102, "Kích thước: XL, XS, M. Màu sắc: Hồng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 148, 4, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(9504), "Sản phẩm được làm từ Vải Organic. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Zara Áo Thun Thời Thượng", 2037847.3520089776073242639016m, 1490349.741516177800000m, 77, "Kích thước: L, XS, S. Màu sắc: Đen, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 184, 1, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(9540), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Gucci Quần Jogger Trẻ Trung", 7105283.8401079690109128639970m, 4951871.852374978250000m, 210, "Kích thước: S, L, XS. Màu sắc: Đỏ, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 5, 2, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(9574), "Sản phẩm được làm từ Sợi Bamboo. Thoáng mát. Phù hợp cho các dịp dạo phố", "Adidas Váy Liền Năng Động", 899327.6890515184823996009254m, 739860.796630910300000m, 173, "Kích thước: M, XXL, XS. Màu sắc: Hồng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 76, 5, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(9608), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Gucci Áo Thun Năng Động", 6426256.8924300171052353494885m, 4487167.650758394200000m, 79, "Kích thước: XS, S, L. Màu sắc: Xanh Navy, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 43, 1, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(9691), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "Nike Váy Liền Trẻ Trung", 6078230.6176612804655004552491m, 4129618.623894651200000m, 86, "Kích thước: S, XXL, L. Màu sắc: Hồng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 148, 2, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(9727), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp thể thao", "Zara Quần Short Trẻ Trung", 390412.94344890725666131407950m, 300442.8746616788750000m, 356, "Kích thước: XXL, M, XS. Màu sắc: Đỏ, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 61, 1, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(9760), "Sản phẩm được làm từ Cotton cao cấp. Co giãn tốt. Phù hợp cho các dịp dạo phố", "Nike Quần Short Trẻ Trung", 2644849.6853819737368232861250m, 2221709.599964255450000m, 75, "Kích thước: L, XXL, M. Màu sắc: Hồng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 105, 1, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(9830), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Zara Quần Jean Sang Trọng", 5659069.4482302018958933248514m, 4601459.148045611450000m, 191, "Kích thước: S, M, XXL. Màu sắc: Hồng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 61, 5, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(9865), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thoáng mát. Phù hợp cho các dịp tiệc tùng", "Gucci Áo Sơ Mi Sang Trọng", 2062644.9459311378252811853793m, 1445609.465063765600000m, 200, "Kích thước: S, M, XS. Màu sắc: Xám, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 112, 1, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(9901), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Louis Vuitton Váy Liền Thoải Mái", 5100042.8608451050695235311670m, 4090943.98524121250000m, 324, "Kích thước: XXL, XL, L. Màu sắc: Xanh Navy, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 12, 2, new DateTime(2024, 12, 20, 6, 16, 28, 779, DateTimeKind.Utc).AddTicks(9936), "Sản phẩm được làm từ Vải Organic. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Nike Quần Tây Sang Trọng", 2929632.8888272078623330687958m, 2240868.031176213950000m, 352, "Kích thước: XXL, M, XS. Màu sắc: Đỏ, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 125, 2, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(6), "Sản phẩm được làm từ Vải Linen. Thoáng mát. Phù hợp cho các dịp văn phòng", "H&M Áo Len Thời Thượng", 459856.34282697510116984943023m, 386981.8941422491250000m, 465, "Kích thước: XS, XL, S. Màu sắc: Trắng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 90, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(42), "Sản phẩm được làm từ Sợi Bamboo. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "H&M Áo Thun Thoải Mái", 2382780.0479435233956945940531m, 1798281.251439507950000m, 68, "Kích thước: M, S, L. Màu sắc: Đỏ, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 26, 2, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(76), "Sản phẩm được làm từ Vải Châu Âu. Thoáng mát. Phù hợp cho các dịp thể thao", "Louis Vuitton Quần Tây Năng Động", 5225118.8137404171370608191562m, 4644668.933216898800000m, 65, "Kích thước: L, XS, XL. Màu sắc: Trắng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 105, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(110), "Sản phẩm được làm từ Sợi Bamboo. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Chanel Quần Jean Hiện Đại", 4879076.0023776804691766982822m, 3253416.36728585450000m, 124, "Kích thước: S, L, XS. Màu sắc: Xanh Navy, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 50, 1, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(182), "Sản phẩm được làm từ Cotton cao cấp. Co giãn tốt. Phù hợp cho các dịp thể thao", "Zara Áo Khoác Hiện Đại", 147206.10956801580090354630147m, 108663.8431281851300000m, 332, "Kích thước: M, S, XS. Màu sắc: Đen, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 69, 4, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(216), "Sản phẩm được làm từ Sợi Bamboo. Thoáng mát. Phù hợp cho các dịp dạo phố", "Chanel Quần Jogger Trẻ Trung", 5028592.9998561216324538175320m, 4205825.860375052600000m, 450, "Kích thước: M, L, S. Màu sắc: Đen, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 139, 2, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(249), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "Adidas Quần Short Thời Thượng", 1684479.2116053664908389551173m, 1295043.204715118600000m, 497, "Kích thước: L, M, S. Màu sắc: Xanh Navy, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 16, 1, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(317), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp văn phòng", "H&M Áo Sơ Mi Cổ Điển", 986016.2916706444604290678768m, 733559.725648936400000m, 208, "Kích thước: XS, S, XL. Màu sắc: Đỏ, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 96, 5, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(354), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp dạo phố", "Nike Áo Thun Thời Thượng", 1077894.5303046724715244488961m, 778705.789235458100000m, 275, "Kích thước: XL, XS, S. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 174, 1, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(459), "Sản phẩm được làm từ Vải Linen. Thoáng mát. Phù hợp cho các dịp tiệc tùng", "Adidas Áo Khoác Sang Trọng", 5178199.7174172533319302972188m, 3892004.044856893850000m, 286, "Kích thước: L, M, XS. Màu sắc: Đỏ, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 141, 1, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(497), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp tiệc tùng", "Chanel Quần Jean Cổ Điển", 4281449.7321555537271030484080m, 3743579.230998498050000m, 60, "Kích thước: M, XS, XL. Màu sắc: Xanh Navy, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 18, 1, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(569), "Sản phẩm được làm từ Vải Linen. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Chanel Áo Sơ Mi Thoải Mái", 1451505.4271950054823528125953m, 1090274.625672185750000m, 23, "Kích thước: XS, XXL, S. Màu sắc: Xám, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 96, 5, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(605), "Sản phẩm được làm từ Cotton cao cấp. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Adidas Áo Polo Thời Thượng", 3087769.3253567088984390003416m, 2232603.87616455800000m, 89, "Kích thước: M, XXL, XL. Màu sắc: Trắng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 41, 4, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(640), "Sản phẩm được làm từ Vải Organic. Thoáng mát. Phù hợp cho các dịp tiệc tùng", "Adidas Áo Polo Trẻ Trung", 1176130.7007719789558590564111m, 987150.817293963800000m, 429, "Kích thước: XL, M, L. Màu sắc: Hồng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 54, 1, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(676), "Sản phẩm được làm từ Sợi Bamboo. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Zara Blazer Cổ Điển", 827165.4803337124724916863613m, 559976.633800680200000m, 259, "Kích thước: XS, XXL, L. Màu sắc: Đen, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 40, 5, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(735), "Sản phẩm được làm từ Sợi Bamboo. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Uniqlo Quần Short Hiện Đại", 5289862.8647602659699747530935m, 3552696.283121217050000m, 115, "Kích thước: XS, M, XL. Màu sắc: Hồng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 72, 5, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(770), "Sản phẩm được làm từ Vải Châu Âu. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Nike Quần Jogger Năng Động", 2464591.6109109401817333663584m, 2193396.187001818100000m, 253, "Kích thước: XS, XXL, M. Màu sắc: Hồng, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 45, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(805), "Sản phẩm được làm từ Vải Châu Âu. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "H&M Quần Tây Sang Trọng", 1060588.9402624920343279957012m, 734569.353423591350000m, 112, "Kích thước: L, S, XS. Màu sắc: Hồng, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 95, 3, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(884), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Louis Vuitton Áo Thun Trẻ Trung", 4683054.7336885829527531433813m, 3683958.02477876300000m, 103, "Kích thước: L, M, XXL. Màu sắc: Đen, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 179, 2, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(921), "Sản phẩm được làm từ Vải Linen. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Uniqlo Blazer Trẻ Trung", 4224373.2219149417925194307934m, 3656974.457840586800000m, 355, "Kích thước: XXL, S, XL. Màu sắc: Đen, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 87, 2, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(956), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "Louis Vuitton Quần Short Hiện Đại", 2141094.8173649695752939908212m, 1646384.266949128250000m, 488, "Kích thước: M, XS, XL. Màu sắc: Hồng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 124, 3, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(991), "Sản phẩm được làm từ Cotton cao cấp. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Uniqlo Áo Sơ Mi Sang Trọng", 4380055.3370633061620105282348m, 3175751.771008522700000m, 171, "Kích thước: M, XS, XXL. Màu sắc: Đỏ, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 176, 5, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(1068), "Sản phẩm được làm từ Vải Organic. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "Chanel Quần Jean Trẻ Trung", 3381655.6530840469797195807507m, 2559696.228498163100000m, 401, "Kích thước: L, XXL, S. Màu sắc: Trắng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 182, 4, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(1104), "Sản phẩm được làm từ Vải Organic. Thiết kế hiện đại. Phù hợp cho các dịp văn phòng", "Gucci Quần Tây Trẻ Trung", 3939812.8517737759677281707523m, 2802824.85020942300000m, 149, "Kích thước: XS, S, XL. Màu sắc: Xanh Navy, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 148, 5, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(1139), "Sản phẩm được làm từ Sợi Bamboo. Thiết kế hiện đại. Phù hợp cho các dịp văn phòng", "Adidas Áo Len Thoải Mái", 3930612.4720440454230122749623m, 2667998.928247597400000m, 109, "Kích thước: M, XS, S. Màu sắc: Trắng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 172, 2, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(1173), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Gucci Áo Thun Năng Động", 2675913.9487328393569856843487m, 2297199.966923511050000m, 134, "Kích thước: M, L, XL. Màu sắc: Đỏ, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 170, 4, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(1243), "Sản phẩm được làm từ Vải Châu Âu. Co giãn tốt. Phù hợp cho các dịp dạo phố", "Chanel Quần Jogger Thoải Mái", 905502.3847715658752453144552m, 669687.800680934150000m, 302, "Kích thước: S, XS, M. Màu sắc: Trắng, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 112, 5, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(1276), "Sản phẩm được làm từ Vải Organic. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Adidas Quần Jean Sang Trọng", 1008901.5336785557790646737605m, 734370.554110580150000m, 286, "Kích thước: L, M, XXL. Màu sắc: Đỏ, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 2, 4, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(1312), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp thể thao", "Adidas Quần Tây Trẻ Trung", 5577122.8112908457057286237465m, 4027405.290244340900000m, 372, "Kích thước: M, XXL, XL. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 167, 3, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(1345), "Sản phẩm được làm từ Vải Châu Âu. Thoáng mát. Phù hợp cho các dịp dạo phố", "Nike Váy Liền Sang Trọng", 4476880.5854426122632140635101m, 3734042.740311421400000m, 259, "Kích thước: L, S, M. Màu sắc: Đen, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 123, 1, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(1413), "Sản phẩm được làm từ Sợi Bamboo. Thoáng mát. Phù hợp cho các dịp dạo phố", "Adidas Quần Tây Năng Động", 3179340.8567785500501888448710m, 2281111.610504715950000m, 145, "Kích thước: S, XXL, XS. Màu sắc: Đỏ, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 57, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(1446), "Sản phẩm được làm từ Cotton cao cấp. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "Zara Váy Liền Hiện Đại", 6222817.7706368141383860391517m, 4562428.972812138950000m, 443, "Kích thước: L, XL, XS. Màu sắc: Hồng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 39, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(1480), "Sản phẩm được làm từ Chất liệu Nhật Bản. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "Gucci Quần Jean Thoải Mái", 1253870.3412625480386156633164m, 974209.586058339350000m, 10, "Kích thước: L, XXL, XL. Màu sắc: Trắng, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 71, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(1552), "Sản phẩm được làm từ Vải Châu Âu. Co giãn tốt. Phù hợp cho các dịp văn phòng", "Uniqlo Áo Len Cổ Điển", 1782556.6722508200807796843011m, 1565876.50325097800000m, 188, "Kích thước: XL, XXL, L. Màu sắc: Hồng, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 195, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(1589), "Sản phẩm được làm từ Vải Châu Âu. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Gucci Quần Tây Thời Thượng", 2025807.1276772638896660053976m, 1595193.509135477300000m, 180, "Kích thước: S, XS, M. Màu sắc: Hồng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 11, 3, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(1623), "Sản phẩm được làm từ Vải Linen. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Louis Vuitton Đầm Dạ Hội Cổ Điển", 4621258.1094528184647360327802m, 3083253.786468395600000m, 396, "Kích thước: S, XXL, L. Màu sắc: Trắng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 116, 3, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(1657), "Sản phẩm được làm từ Cotton cao cấp. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "Chanel Blazer Cổ Điển", 1302674.3860356229653050078549m, 979755.590047578800000m, 495, "Kích thước: S, XXL, XL. Màu sắc: Xám, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 184, 2, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(1727), "Sản phẩm được làm từ Sợi Bamboo. Thoáng mát. Phù hợp cho các dịp dạo phố", "H&M Quần Jean Thoải Mái", 5490341.7034586583481011699516m, 4282189.115239980950000m, 135, "Kích thước: XL, S, M. Màu sắc: Hồng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 67, 4, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(1762), "Sản phẩm được làm từ Sợi Bamboo. Thoáng mát. Phù hợp cho các dịp tiệc tùng", "Nike Quần Tây Năng Động", 212502.95984590181377235528699m, 174179.6405722083200000m, 224, "Kích thước: XXL, S, XS. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 39, 4, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(1797), "Sản phẩm được làm từ Vải Organic. Thiết kế hiện đại. Phù hợp cho các dịp văn phòng", "Chanel Quần Short Sang Trọng", 5960958.5003175097753689665145m, 4133085.558261853550000m, 70, "Kích thước: L, XL, XXL. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 9, 1, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(1831), "Sản phẩm được làm từ Vải Linen. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Louis Vuitton Blazer Thời Thượng", 2105501.9413781385331556301578m, 1753655.841488598800000m, 500, "Kích thước: L, XXL, M. Màu sắc: Trắng, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 98, 2, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(1899), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Chanel Áo Khoác Năng Động", 3213664.4179296551441285684266m, 2695366.592384751950000m, 377, "Kích thước: XS, XXL, XL. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 26, 1, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(1932), "Sản phẩm được làm từ Vải Organic. Co giãn tốt. Phù hợp cho các dịp thể thao", "Chanel Áo Thun Thời Thượng", 1184232.2221383824978582461345m, 887707.489503567650000m, 303, "Kích thước: S, M, XS. Màu sắc: Hồng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 194, 4, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(1966), "Sản phẩm được làm từ Vải Châu Âu. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "Louis Vuitton Váy Liền Năng Động", 4957269.8845786378072809877933m, 3322857.494333198750000m, 86, "Kích thước: XS, XL, XXL. Màu sắc: Đỏ, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 29, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(2020), "Sản phẩm được làm từ Vải Linen. Thoáng mát. Phù hợp cho các dịp thể thao", "Gucci Áo Khoác Cổ Điển", 2623820.6103997531615846832032m, 2094445.77135284750000m, 342, "Kích thước: M, XS, XL. Màu sắc: Đen, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 129, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(2055), "Sản phẩm được làm từ Sợi Bamboo. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "Nike Quần Jean Năng Động", 5010231.9877146992284523466942m, 4278498.156858974900000m, 436, "Kích thước: XXL, XS, M. Màu sắc: Xám, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 143, 2, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(2088), "Sản phẩm được làm từ Vải Châu Âu. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "Adidas Quần Tây Năng Động", 6359941.4334854108653807325622m, 4566994.814406910550000m, 100, "Kích thước: XS, XXL, S. Màu sắc: Hồng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 73, 1, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(2121), "Sản phẩm được làm từ Vải Linen. Phù hợp nhiều dáng người. Phù hợp cho các dịp thể thao", "Louis Vuitton Váy Liền Năng Động", 1681893.7715669662093315290609m, 1327532.120472873650000m, 346, "Kích thước: L, XS, S. Màu sắc: Hồng, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 7, 4, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(2193), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "Nike Áo Khoác Sang Trọng", 571477.72279212435697921924440m, 424104.3008709883250000m, 225, "Kích thước: M, XS, XXL. Màu sắc: Đỏ, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 17, 3, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(2226), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thoáng mát. Phù hợp cho các dịp thể thao", "Louis Vuitton Áo Thun Sang Trọng", 5629087.0127895777963174149379m, 4536426.456170898800000m, 204, "Kích thước: XL, XXL, XS. Màu sắc: Xanh Navy, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 85, 3, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(2261), "Sản phẩm được làm từ Cotton cao cấp. Co giãn tốt. Phù hợp cho các dịp văn phòng", "Nike Quần Tây Trẻ Trung", 1096426.3995007479337822899126m, 887572.421834512100000m, 471, "Kích thước: M, XS, S. Màu sắc: Xám, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 183, 5, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(2296), "Sản phẩm được làm từ Vải Linen. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Gucci Quần Tây Sang Trọng", 6617604.9067094010327645000360m, 4425154.921219473050000m, 382, "Kích thước: M, L, XS. Màu sắc: Đen, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 34, 3, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(2435), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Uniqlo Váy Liền Thoải Mái", 1252786.0410170950074989739236m, 1001391.904565499650000m, 170, "Kích thước: XXL, XS, S. Màu sắc: Hồng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 181, 2, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(2468), "Sản phẩm được làm từ Sợi Bamboo. Thoáng mát. Phù hợp cho các dịp dạo phố", "Adidas Áo Polo Thời Thượng", 2394493.6573744169978113872003m, 2068507.549761300950000m, 301, "Kích thước: S, XL, M. Màu sắc: Đỏ, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 110, 5, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(2503), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thoáng mát. Phù hợp cho các dịp văn phòng", "Nike Áo Thun Cổ Điển", 4583248.7192843243167269465306m, 3330102.300506205350000m, 118, "Kích thước: L, XS, S. Màu sắc: Xanh Navy, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 193, 5, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(2571), "Sản phẩm được làm từ Cotton cao cấp. Co giãn tốt. Phù hợp cho các dịp dạo phố", "Zara Áo Khoác Trẻ Trung", 5629697.4607244176546509162479m, 4471815.09736021550000m, 271, "Kích thước: XL, XS, L. Màu sắc: Xanh Navy, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 129, 4, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(2606), "Sản phẩm được làm từ Vải Organic. Co giãn tốt. Phù hợp cho các dịp văn phòng", "Zara Quần Tây Thời Thượng", 989693.6283030279317057134087m, 773982.82584275450000m, 332, "Kích thước: S, M, L. Màu sắc: Xám, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 155, 1, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(2640), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp thể thao", "Louis Vuitton Đầm Dạ Hội Thời Thượng", 3400073.2893952654417363535825m, 2376270.389516107100000m, 283, "Kích thước: XXL, S, XS. Màu sắc: Hồng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 167, 5, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(2674), "Sản phẩm được làm từ Sợi Bamboo. Co giãn tốt. Phù hợp cho các dịp văn phòng", "Nike Áo Len Cổ Điển", 5190041.7835562862859693229286m, 3708176.893540470950000m, 154, "Kích thước: XS, XXL, S. Màu sắc: Đen, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 184, 1, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(2738), "Sản phẩm được làm từ Sợi Bamboo. Thoáng mát. Phù hợp cho các dịp dạo phố", "Louis Vuitton Váy Liền Sang Trọng", 2857232.1969524787324676000516m, 2103609.551435835800000m, 177, "Kích thước: L, M, XL. Màu sắc: Trắng, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 163, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(2772), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Nike Blazer Năng Động", 5225628.6562972667128345234790m, 3829253.273709277100000m, 450, "Kích thước: XXL, L, XL. Màu sắc: Đỏ, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 75, 4, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(2806), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp thể thao", "Zara Quần Tây Năng Động", 3676257.9602847133279401153732m, 2480550.926784950750000m, 118, "Kích thước: XL, M, XS. Màu sắc: Trắng, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 28, 2, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(2840), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "H&M Quần Short Năng Động", 354800.86123366817120242875039m, 315698.8029326297150000m, 429, "Kích thước: XS, M, XXL. Màu sắc: Đen, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 24, 4, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(2909), "Sản phẩm được làm từ Chất liệu Nhật Bản. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Louis Vuitton Áo Polo Thoải Mái", 4110265.9001285347506679353359m, 3620670.150591866300000m, 395, "Kích thước: L, S, M. Màu sắc: Hồng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 37, 1, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(2941), "Sản phẩm được làm từ Vải Linen. Phù hợp nhiều dáng người. Phù hợp cho các dịp thể thao", "Uniqlo Đầm Dạ Hội Thoải Mái", 5148112.3396061457675393342244m, 3483451.075362741950000m, 198, "Kích thước: S, XS, XL. Màu sắc: Đỏ, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 166, 5, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(2974), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thiết kế hiện đại. Phù hợp cho các dịp văn phòng", "Louis Vuitton Quần Jogger Cổ Điển", 7184013.9270735173523293035595m, 4855272.418204699100000m, 372, "Kích thước: M, XL, L. Màu sắc: Trắng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 178, 3, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(3009), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp văn phòng", "H&M Quần Short Trẻ Trung", 2261831.8359560447594300580849m, 1650807.622301840150000m, 199, "Kích thước: XS, M, XL. Màu sắc: Đen, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 190, 1, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(3081), "Sản phẩm được làm từ Vải Organic. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Zara Áo Polo Trẻ Trung", 2190533.9888599307729595290725m, 1954941.358081368200000m, 229, "Kích thước: S, XS, XXL. Màu sắc: Đỏ, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 138, 5, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(3115), "Sản phẩm được làm từ Vải Organic. Thoáng mát. Phù hợp cho các dịp tiệc tùng", "Gucci Váy Liền Năng Động", 375298.80871360119067308175787m, 307042.2866639863400000m, 494, "Kích thước: XL, M, XXL. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 161, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(3148), "Sản phẩm được làm từ Vải Organic. Thoáng mát. Phù hợp cho các dịp thể thao", "H&M Quần Jogger Năng Động", 4327366.5544045767618483071590m, 3513678.757544592950000m, 251, "Kích thước: XS, XXL, L. Màu sắc: Đen, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 125, 3, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(3218), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp văn phòng", "Uniqlo Váy Liền Cổ Điển", 167576.02204184948539992060590m, 112068.687284735450000m, 271, "Kích thước: XS, XL, S. Màu sắc: Xám, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 57, 3, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(3253), "Sản phẩm được làm từ Vải Châu Âu. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "Chanel Blazer Sang Trọng", 1446981.8377076930949341430895m, 981327.548198116850000m, 254, "Kích thước: S, M, L. Màu sắc: Hồng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 169, 3, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(3284), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp văn phòng", "Adidas Quần Tây Sang Trọng", 3148934.5013819996791794150367m, 2110246.197395921150000m, 299, "Kích thước: S, M, XL. Màu sắc: Đỏ, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 97, 2, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(3317), "Sản phẩm được làm từ Sợi Bamboo. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "Zara Blazer Năng Động", 446776.70142409075512525230836m, 343136.4696941078750000m, 167, "Kích thước: L, XS, M. Màu sắc: Hồng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 161, 3, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(3373), "Sản phẩm được làm từ Chất liệu Nhật Bản. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "H&M Quần Tây Năng Động", 2900702.3878329660041489964194m, 2516238.540592613600000m, 181, "Kích thước: XS, XXL, XL. Màu sắc: Đen, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 193, 4, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(3407), "Sản phẩm được làm từ Chất liệu Nhật Bản. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "H&M Áo Khoác Hiện Đại", 2905402.0822168708978198330229m, 2526601.674133741550000m, 417, "Kích thước: M, XXL, S. Màu sắc: Đỏ, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 180, 3, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(3443), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "Chanel Quần Jean Cổ Điển", 1286225.2102892039075912614947m, 1000775.266673648900000m, 271, "Kích thước: XXL, XL, XS. Màu sắc: Đen, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 166, 2, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(3476), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp tiệc tùng", "Louis Vuitton Blazer Cổ Điển", 2842610.5798926644089448514128m, 2213824.691957878400000m, 143, "Kích thước: XS, S, L. Màu sắc: Trắng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 156, 1, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(3552), "Sản phẩm được làm từ Vải Organic. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Louis Vuitton Quần Tây Thời Thượng", 709333.38900316833587685555080m, 533927.4857254314950000m, 419, "Kích thước: XXL, XS, M. Màu sắc: Đỏ, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 19, 1, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(3585), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thiết kế hiện đại. Phù hợp cho các dịp văn phòng", "Adidas Áo Len Sang Trọng", 2621518.1720155612467200722646m, 1936305.011034687650000m, 136, "Kích thước: XL, S, M. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 172, 4, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(3619), "Sản phẩm được làm từ Cotton cao cấp. Co giãn tốt. Phù hợp cho các dịp dạo phố", "Gucci Váy Liền Thời Thượng", 480050.35509235549086502879128m, 329889.0757777213550000m, 331, "Kích thước: XL, XXL, XS. Màu sắc: Xám, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 188, 1, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(3700), "Sản phẩm được làm từ Vải Organic. Thoáng mát. Phù hợp cho các dịp dạo phố", "Gucci Áo Khoác Sang Trọng", 3138039.5836842004009350554330m, 2493044.361532712300000m, 274, "Kích thước: XXL, XS, S. Màu sắc: Xám, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 199, 3, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(3735), "Sản phẩm được làm từ Vải Linen. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Zara Váy Liền Thoải Mái", 5616487.3969779068555837356256m, 3992816.435704034900000m, 44, "Kích thước: XL, L, M. Màu sắc: Đen, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 41, 3, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(3770), "Sản phẩm được làm từ Vải Châu Âu. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Gucci Váy Liền Thoải Mái", 3123486.4893158297572980389210m, 2120529.307217454050000m, 131, "Kích thước: M, L, XS. Màu sắc: Xanh Navy, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 164, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(3803), "Sản phẩm được làm từ Vải Châu Âu. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "Uniqlo Quần Tây Cổ Điển", 1282871.7378649663705841082133m, 918741.643722941450000m, 340, "Kích thước: XS, L, M. Màu sắc: Trắng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 64, 4, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(3870), "Sản phẩm được làm từ Sợi Bamboo. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "H&M Áo Polo Cổ Điển", 612411.95101339836882149409725m, 513593.1004082234450000m, 460, "Kích thước: M, XS, S. Màu sắc: Đen, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 93, 2, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(3906), "Sản phẩm được làm từ Vải Organic. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "Chanel Váy Liền Sang Trọng", 4176548.3656811362234098284954m, 3420913.603620813800000m, 442, "Kích thước: M, XXL, XL. Màu sắc: Hồng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 124, 1, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(3940), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp thể thao", "Nike Quần Jogger Hiện Đại", 1990058.1682464652119119435035m, 1488042.097497029750000m, 86, "Kích thước: XL, XXL, M. Màu sắc: Đen, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 147, 5, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(3973), "Sản phẩm được làm từ Vải Linen. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "H&M Quần Jogger Cổ Điển", 2477924.7587085239716809538995m, 2221197.134812430450000m, 274, "Kích thước: XS, L, XXL. Màu sắc: Đen, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 27, 3, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(4043), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Louis Vuitton Áo Sơ Mi Sang Trọng", 168595.94337018612854392827542m, 144343.2500396884850000m, 186, "Kích thước: XS, XXL, L. Màu sắc: Đen, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 77, 2, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(4079), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp thể thao", "Louis Vuitton Quần Jean Cổ Điển", 6034126.7951341888986001383582m, 4221121.782579996200000m, 63, "Kích thước: M, XS, L. Màu sắc: Đen, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 42, 1, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(4112), "Sản phẩm được làm từ Vải Châu Âu. Thoáng mát. Phù hợp cho các dịp tiệc tùng", "Uniqlo Quần Jean Trẻ Trung", 5487281.6927934274482582731455m, 4523257.764491479700000m, 90, "Kích thước: XS, XXL, L. Màu sắc: Trắng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 30, 2, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(4182), "Sản phẩm được làm từ Vải Organic. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Zara Quần Short Thời Thượng", 4609904.6238453662403469590829m, 3874990.012348782200000m, 273, "Kích thước: XXL, XL, XS. Màu sắc: Đỏ, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 25, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(4218), "Sản phẩm được làm từ Sợi Bamboo. Co giãn tốt. Phù hợp cho các dịp thể thao", "H&M Đầm Dạ Hội Trẻ Trung", 852722.8073861772835387777348m, 688001.684101395350000m, 69, "Kích thước: XS, XXL, M. Màu sắc: Hồng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 186, 5, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(4252), "Sản phẩm được làm từ Vải Linen. Co giãn tốt. Phù hợp cho các dịp dạo phố", "H&M Áo Len Cổ Điển", 1761092.9776597206073611148751m, 1187408.702707717550000m, 449, "Kích thước: L, XXL, S. Màu sắc: Đen, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 118, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(4286), "Sản phẩm được làm từ Sợi Bamboo. Thoáng mát. Phù hợp cho các dịp thể thao", "Uniqlo Blazer Thoải Mái", 6479257.5874529716160421466222m, 4860074.483956004450000m, 122, "Kích thước: S, XXL, L. Màu sắc: Xám, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 83, 5, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(4350), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp văn phòng", "Gucci Áo Khoác Trẻ Trung", 5502574.1830101255705787241784m, 3728457.640126558850000m, 262, "Kích thước: L, XS, S. Màu sắc: Xám, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 129, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(4385), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp thể thao", "Adidas Quần Jean Cổ Điển", 79571.39305767466723784854479m, 56368.00519222683200000m, 155, "Kích thước: M, XXL, S. Màu sắc: Hồng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 36, 2, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(4419), "Sản phẩm được làm từ Vải Châu Âu. Thoáng mát. Phù hợp cho các dịp văn phòng", "H&M Áo Khoác Thời Thượng", 5869547.3403465442568941236584m, 4500499.699297696550000m, 32, "Kích thước: S, XXL, XL. Màu sắc: Xám, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 191, 4, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(4451), "Sản phẩm được làm từ Vải Organic. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Nike Quần Jean Hiện Đại", 611434.43111562689464944445434m, 460421.8543597350200000m, 466, "Kích thước: L, XS, M. Màu sắc: Đen, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 82, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(4520), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thoáng mát. Phù hợp cho các dịp văn phòng", "Zara Áo Len Trẻ Trung", 3443490.1078647018761107108011m, 2591827.02298649300000m, 166, "Kích thước: XS, L, XXL. Màu sắc: Xám, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 184, 4, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(4554), "Sản phẩm được làm từ Sợi Bamboo. Thiết kế hiện đại. Phù hợp cho các dịp văn phòng", "Gucci Đầm Dạ Hội Hiện Đại", 3632802.2533373453414625739303m, 2601160.287321861050000m, 51, "Kích thước: M, XXL, S. Màu sắc: Trắng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 83, 4, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(4588), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Chanel Váy Liền Thoải Mái", 2558253.5168459835683388122054m, 2089432.057259324750000m, 266, "Kích thước: L, XXL, XL. Màu sắc: Xám, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 17, 2, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(4623), "Sản phẩm được làm từ Chất liệu Nhật Bản. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "Gucci Áo Sơ Mi Trẻ Trung", 4911074.8711044029595848002353m, 4366462.350151024700000m, 10, "Kích thước: XL, XXL, XS. Màu sắc: Xanh Navy, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 78, 4, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(4678), "Sản phẩm được làm từ Vải Organic. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Adidas Quần Jogger Thoải Mái", 6188590.9714606666537682907204m, 4128747.007762986350000m, 395, "Kích thước: XS, XL, XXL. Màu sắc: Đen, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 76, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(4713), "Sản phẩm được làm từ Vải Linen. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Adidas Áo Thun Sang Trọng", 220883.83526146301189417946936m, 192912.7062555693050000m, 31, "Kích thước: S, L, XS. Màu sắc: Đỏ, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 169, 3, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(4747), "Sản phẩm được làm từ Sợi Bamboo. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "H&M Quần Short Trẻ Trung", 3309558.8683761424127133976963m, 2615484.800711520050000m, 365, "Kích thước: L, XL, XXL. Màu sắc: Hồng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 116, 4, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(4822), "Sản phẩm được làm từ Vải Organic. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Gucci Blazer Trẻ Trung", 2331430.7356742093672254793123m, 2115131.10860279300000m, 414, "Kích thước: S, XL, L. Màu sắc: Xanh Navy, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 54, 1, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(4857), "Sản phẩm được làm từ Vải Organic. Thoáng mát. Phù hợp cho các dịp tiệc tùng", "Uniqlo Quần Tây Cổ Điển", 3913633.1543895193558550042185m, 2644488.105521689850000m, 30, "Kích thước: L, XS, XXL. Màu sắc: Xám, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 117, 3, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(4893), "Sản phẩm được làm từ Cotton cao cấp. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Zara Váy Liền Thời Thượng", 4513212.6889087275915251538330m, 3997481.959797104300000m, 322, "Kích thước: L, XXL, S. Màu sắc: Xanh Navy, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 91, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(4927), "Sản phẩm được làm từ Sợi Bamboo. Thoáng mát. Phù hợp cho các dịp thể thao", "H&M Đầm Dạ Hội Sang Trọng", 382972.55258217038798241776753m, 329084.708816482250000m, 94, "Kích thước: XXL, XL, M. Màu sắc: Xám, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 103, 1, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(5036), "Sản phẩm được làm từ Sợi Bamboo. Co giãn tốt. Phù hợp cho các dịp dạo phố", "H&M Quần Jogger Thoải Mái", 816980.1565111162321169519368m, 578482.630155233600000m, 356, "Kích thước: XL, XXL, XS. Màu sắc: Đen, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 192, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(5071), "Sản phẩm được làm từ Cotton cao cấp. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Adidas Váy Liền Thời Thượng", 3535709.4958885638373287124554m, 2422131.335031746750000m, 89, "Kích thước: S, XL, XS. Màu sắc: Hồng, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 90, 4, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(5105), "Sản phẩm được làm từ Vải Organic. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Uniqlo Quần Short Hiện Đại", 5460308.4311240290673280472286m, 4451819.915323158350000m, 265, "Kích thước: XS, S, M. Màu sắc: Xanh Navy, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 105, 5, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(5139), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp thể thao", "Gucci Quần Jean Thời Thượng", 1624396.8470279459347282114655m, 1291734.389325308450000m, 216, "Kích thước: XS, XXL, XL. Màu sắc: Đen, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 48, 1, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(5224), "Sản phẩm được làm từ Vải Linen. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "Nike Quần Jogger Trẻ Trung", 883657.6815460922676035568009m, 680918.305363961450000m, 307, "Kích thước: S, XL, M. Màu sắc: Hồng, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 184, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(5259), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Chanel Áo Khoác Thoải Mái", 2486407.7737660205461460735441m, 2051842.733341310750000m, 328, "Kích thước: M, XXL, XS. Màu sắc: Đỏ, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 36, 4, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(5292), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thoáng mát. Phù hợp cho các dịp tiệc tùng", "Zara Áo Sơ Mi Sang Trọng", 6621629.1469087413470533771082m, 4676586.190102386950000m, 52, "Kích thước: M, L, S. Màu sắc: Hồng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 168, 3, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(5383), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Uniqlo Quần Short Hiện Đại", 4753236.8733511414750524706651m, 3266223.564092158400000m, 204, "Kích thước: XL, XXL, XS. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 92, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(5450), "Sản phẩm được làm từ Vải Linen. Thoáng mát. Phù hợp cho các dịp dạo phố", "Chanel Blazer Năng Động", 4208199.4895071785002206172997m, 2805760.61825251550000m, 64, "Kích thước: S, XXL, XS. Màu sắc: Xanh Navy, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 71, 4, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(5508), "Sản phẩm được làm từ Vải Organic. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Chanel Quần Tây Năng Động", 1242097.1824121805796992900945m, 1006742.011594780400000m, 425, "Kích thước: M, XXL, L. Màu sắc: Xanh Navy, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 79, 4, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(5553), "Sản phẩm được làm từ Chất liệu Nhật Bản. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "Louis Vuitton Áo Sơ Mi Sang Trọng", 2885398.1275652411097970930775m, 2382919.717846566200000m, 346, "Kích thước: XL, S, L. Màu sắc: Hồng, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 182, 5, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(5631), "Sản phẩm được làm từ Sợi Bamboo. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Zara Áo Khoác Sang Trọng", 4890474.6616933625199253373354m, 3621772.503343675400000m, 296, "Kích thước: XL, XXL, M. Màu sắc: Xám, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 183, 5, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(5666), "Sản phẩm được làm từ Sợi Bamboo. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "Chanel Váy Liền Năng Động", 5462552.5060393997697370794372m, 4852229.084293650350000m, 491, "Kích thước: S, XL, L. Màu sắc: Đen, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 188, 4, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(5700), "Sản phẩm được làm từ Vải Organic. Thoáng mát. Phù hợp cho các dịp văn phòng", "Nike Đầm Dạ Hội Năng Động", 456004.00004241902167158993747m, 372597.5699477445200000m, 159, "Kích thước: XS, XL, S. Màu sắc: Đỏ, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 107, 3, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(5733), "Sản phẩm được làm từ Vải Châu Âu. Thoáng mát. Phù hợp cho các dịp thể thao", "Chanel Quần Tây Thoải Mái", 2428958.3571638595425752550986m, 2032862.072137563650000m, 190, "Kích thước: XL, L, M. Màu sắc: Hồng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 126, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(5804), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp thể thao", "Adidas Quần Jean Năng Động", 6472260.3110170022891870052106m, 4876841.132875894550000m, 326, "Kích thước: XXL, S, XL. Màu sắc: Xanh Navy, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 166, 2, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(5840), "Sản phẩm được làm từ Vải Linen. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "Nike Áo Len Thời Thượng", 3948824.8462183093723707096980m, 3170418.846394274150000m, 367, "Kích thước: S, XXL, L. Màu sắc: Đen, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 110, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(5873), "Sản phẩm được làm từ Vải Linen. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "Uniqlo Blazer Hiện Đại", 4806950.2739389421114171663663m, 3438788.447276746250000m, 498, "Kích thước: S, XL, XXL. Màu sắc: Xám, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 71, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(5906), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Uniqlo Đầm Dạ Hội Hiện Đại", 1446937.0013282550478723825270m, 1170707.801080188200000m, 159, "Kích thước: S, L, XXL. Màu sắc: Đen, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 161, 4, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(5971), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "Adidas Áo Len Thời Thượng", 6311527.7274562869224274758952m, 4940953.843377262100000m, 322, "Kích thước: L, XXL, S. Màu sắc: Đỏ, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 97, 4, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(6005), "Sản phẩm được làm từ Vải Châu Âu. Thoáng mát. Phù hợp cho các dịp dạo phố", "Gucci Áo Khoác Cổ Điển", 194276.21253094312300886018812m, 174267.3490369955600000m, 335, "Kích thước: XL, M, XS. Màu sắc: Đỏ, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 87, 2, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(6038), "Sản phẩm được làm từ Vải Organic. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Adidas Quần Short Sang Trọng", 5505526.7455123734205597131234m, 3929315.609079046400000m, 35, "Kích thước: XXL, M, XS. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 10, 5, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(6092), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thoáng mát. Phù hợp cho các dịp văn phòng", "Gucci Áo Len Thoải Mái", 3339286.7018311609368031207177m, 2319523.333424223800000m, 51, "Kích thước: S, M, XS. Màu sắc: Đỏ, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 28, 1, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(6125), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp dạo phố", "Gucci Áo Thun Sang Trọng", 3577866.9761032456745495160329m, 2856723.675779348600000m, 468, "Kích thước: XS, XL, XXL. Màu sắc: Hồng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 160, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(6159), "Sản phẩm được làm từ Chất liệu Nhật Bản. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Uniqlo Đầm Dạ Hội Cổ Điển", 4808292.7455572339595845085350m, 3273382.358106998450000m, 481, "Kích thước: XS, XL, XXL. Màu sắc: Đỏ, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 82, 4, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(6193), "Sản phẩm được làm từ Sợi Bamboo. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Uniqlo Áo Sơ Mi Cổ Điển", 451040.25906210860084494387441m, 303641.6516619443150000m, 489, "Kích thước: L, XXL, M. Màu sắc: Trắng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 176, 4, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(6270), "Sản phẩm được làm từ Vải Linen. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "Adidas Quần Short Năng Động", 3322400.1055250040647525915697m, 2693961.217497439400000m, 373, "Kích thước: XXL, S, XL. Màu sắc: Trắng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 102, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(6305), "Sản phẩm được làm từ Vải Châu Âu. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "Gucci Áo Khoác Năng Động", 1309727.5028494053516626858724m, 1182355.859853056300000m, 201, "Kích thước: XS, L, S. Màu sắc: Trắng, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 112, 1, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(6340), "Sản phẩm được làm từ Cotton cao cấp. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Uniqlo Đầm Dạ Hội Thoải Mái", 3886920.2802393067257731824973m, 2686584.650122915250000m, 151, "Kích thước: XS, XXL, S. Màu sắc: Hồng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 62, 2, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(6375), "Sản phẩm được làm từ Sợi Bamboo. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Zara Blazer Thoải Mái", 2108737.3018039357431970624225m, 1613058.620982475100000m, 237, "Kích thước: XL, M, XXL. Màu sắc: Đen, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 53, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(6455), "Sản phẩm được làm từ Vải Organic. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Chanel Quần Short Sang Trọng", 4631311.0666299941943397530068m, 3970229.146038500900000m, 387, "Kích thước: XXL, XS, S. Màu sắc: Đỏ, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 119, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(6491), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "Zara Quần Jean Hiện Đại", 4008872.5047179592631323551920m, 3024116.267651978900000m, 185, "Kích thước: M, XS, XL. Màu sắc: Đen, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 61, 5, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(6525), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thiết kế hiện đại. Phù hợp cho các dịp văn phòng", "Uniqlo Áo Sơ Mi Thời Thượng", 6598820.8794125050413978404112m, 4685233.695695433050000m, 360, "Kích thước: S, XL, M. Màu sắc: Xám, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 27, 1, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(6593), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thoáng mát. Phù hợp cho các dịp dạo phố", "H&M Quần Short Cổ Điển", 5401777.4093950727654936889725m, 3670002.782547290150000m, 13, "Kích thước: XL, M, L. Màu sắc: Xám, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 153, 3, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(6627), "Sản phẩm được làm từ Vải Châu Âu. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "H&M Blazer Sang Trọng", 3615320.3032047433072711317132m, 2901275.263874349950000m, 313, "Kích thước: M, L, S. Màu sắc: Trắng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 44, 5, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(6660), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thoáng mát. Phù hợp cho các dịp thể thao", "Nike Áo Khoác Năng Động", 4564644.8783546732981181096196m, 3581873.242122968600000m, 394, "Kích thước: XXL, XS, XL. Màu sắc: Đen, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 135, 3, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(6693), "Sản phẩm được làm từ Cotton cao cấp. Co giãn tốt. Phù hợp cho các dịp văn phòng", "Louis Vuitton Quần Jogger Thời Thượng", 603093.75181567094156682424296m, 410056.0276058408300000m, 482, "Kích thước: XXL, S, XL. Màu sắc: Xám, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 141, 4, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(6768), "Sản phẩm được làm từ Vải Organic. Co giãn tốt. Phù hợp cho các dịp dạo phố", "Chanel Quần Jean Năng Động", 2362532.2415702940247259705678m, 2112952.847666161550000m, 70, "Kích thước: XXL, L, S. Màu sắc: Trắng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 180, 1, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(6801), "Sản phẩm được làm từ Vải Linen. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "Uniqlo Áo Sơ Mi Cổ Điển", 1899157.9779790480457860773741m, 1267292.56540035650000m, 476, "Kích thước: M, XL, S. Màu sắc: Xanh Navy, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 124, 5, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(6834), "Sản phẩm được làm từ Vải Organic. Thoáng mát. Phù hợp cho các dịp dạo phố", "Louis Vuitton Áo Polo Hiện Đại", 5452979.5086811528644537538881m, 4523073.980439787250000m, 13, "Kích thước: XXL, L, XS. Màu sắc: Hồng, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 67, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(6868), "Sản phẩm được làm từ Sợi Bamboo. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "Louis Vuitton Quần Jean Năng Động", 1595026.4169187711604296621163m, 1141700.189390957300000m, 173, "Kích thước: M, XS, XL. Màu sắc: Xám, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 114, 1, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(6972), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "Adidas Áo Khoác Trẻ Trung", 3131194.7725281979882654344505m, 2321145.621472446950000m, 340, "Kích thước: XXL, XL, XS. Màu sắc: Đen, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 52, 4, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(7006), "Sản phẩm được làm từ Cotton cao cấp. Co giãn tốt. Phù hợp cho các dịp dạo phố", "Adidas Đầm Dạ Hội Thoải Mái", 744118.23664899579055404258122m, 520209.021142627250000m, 458, "Kích thước: XS, XXL, M. Màu sắc: Đỏ, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 133, 1, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(7040), "Sản phẩm được làm từ Sợi Bamboo. Phù hợp nhiều dáng người. Phù hợp cho các dịp thể thao", "Adidas Váy Liền Hiện Đại", 4250550.8569623382455169112466m, 3321979.104288750350000m, 152, "Kích thước: S, M, XS. Màu sắc: Đỏ, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 159, 4, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(7106), "Sản phẩm được làm từ Vải Châu Âu. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Louis Vuitton Quần Jogger Sang Trọng", 2089244.8727003509560606252828m, 1761048.286080400850000m, 81, "Kích thước: M, XL, XS. Màu sắc: Xám, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 67, 2, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(7142), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "Uniqlo Áo Thun Năng Động", 4368140.9242511790130749118870m, 3098900.433268609700000m, 301, "Kích thước: XXL, S, M. Màu sắc: Xanh Navy, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 1, new DateTime(2024, 12, 20, 6, 16, 28, 780, DateTimeKind.Utc).AddTicks(7176), "Sản phẩm được làm từ Vải Linen. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Nike Áo Len Hiện Đại", 2452430.6971761280393857283077m, 2220805.159704217850000m, 185, "Kích thước: XS, L, XXL. Màu sắc: Đỏ, Xanh Navy" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.CreateTable(
                name: "IdentityRole",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "745 Bernard Mills, Port Modestaside, Tunisia", "f08e8d2a-b3ec-4114-b42e-950ee584c4ba", new DateTime(2024, 6, 29, 6, 20, 3, 674, DateTimeKind.Utc).AddTicks(160), "Branson98@hotmail.com", "Branson", "Walsh", "BRANSON98@HOTMAIL.COM", "BRANSON_WALSH19", "AQAAAAIAAYagAAAAEBArX7vBHnZbS+CORxQWfDOGur8czbmpdt5zVs22FADa3XE8W+JFBQFRDF6kFV9D/Q==", "156-460-6825", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1016.jpg", "Branson_Walsh19" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "4269 Harold Isle, Langmouth, Svalbard & Jan Mayen Islands", "5fb63b79-621f-4939-b2b2-052c4beef708", new DateTime(2024, 10, 1, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(1878), "Kirsten.Dicki9@yahoo.com", "Kirsten", "Dicki", "KIRSTEN.DICKI9@YAHOO.COM", "KIRSTEN13", "AQAAAAIAAYagAAAAEBMQLgSzwG5lOOm2OZCoCRXOvWnUkFjZ3ApCK1qW43ScNpdUzFXvHc06A62UR3S5nQ==", "023-946-7592", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/107.jpg", "Kirsten13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "882 Medhurst Corners, Swaniawskiport, Micronesia", "a0ff7ca1-1bc2-4491-acd1-257cbd25c156", new DateTime(2024, 11, 7, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(2165), "Laurel51@hotmail.com", "Laurel", "Fay", "LAUREL51@HOTMAIL.COM", "LAUREL.FAY58", "AQAAAAIAAYagAAAAEAY/hCW7GedNfmHWQ05kue8UmHP+c0x3SvIxudwfI6uiBMcXfWQR+nBp6VMJqD/UOw==", "722-942-7727", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/182.jpg", "Laurel.Fay58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "505 Kaleigh Radial, Port Lessieton, Saudi Arabia", "c7a2003a-c9c1-4a77-8b39-bcd455078160", new DateTime(2024, 7, 14, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(2396), "Myriam.Rau@gmail.com", "Myriam", "Rau", "MYRIAM.RAU@GMAIL.COM", "MYRIAM66", "AQAAAAIAAYagAAAAECINYbyRxq3yRneZpgRVA7qutST4VcAPGoERyeEctSN2oZgJ4n/PrvntDlpYGBIkSQ==", "877-967-2828", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/164.jpg", "Myriam66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "41667 Flavie Isle, Baileeberg, Tunisia", "c8a813df-ca3a-4185-9da2-6f237047c257", new DateTime(2024, 6, 18, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(2590), "Megane61@yahoo.com", "Megane", "Ernser", "MEGANE61@YAHOO.COM", "MEGANE.ERNSER39", "AQAAAAIAAYagAAAAECtnYjiuCAZcV9FXPuvXenLuJOYCtPtFSshvZI7C9l0ywz1T62PomWemu1ugWBXqUQ==", "394-733-8144", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1200.jpg", "Megane.Ernser39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8765 Medhurst Glens, Port Ewaldstad, Bulgaria", "0eecbb02-31da-4ac8-84bf-11b3210e6fb8", new DateTime(2024, 4, 22, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(2837), "Gloria_Hyatt@yahoo.com", "Gloria", "Hyatt", "GLORIA_HYATT@YAHOO.COM", "GLORIA.HYATT", "AQAAAAIAAYagAAAAEFjZ12Y9uRXXVdbT6AQeoTBd1rqDcnz/2Ov0FHpZUDfCGB9rMur9QAHponeBG0sYqQ==", "199-907-4370", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/405.jpg", "Gloria.Hyatt" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "291 Harvey Knolls, Littelburgh, Taiwan", "3900e6e5-0a25-490f-8be0-d693a87187f0", new DateTime(2024, 10, 20, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(4128), "Gussie23@hotmail.com", "Gussie", "Bergnaum", "GUSSIE23@HOTMAIL.COM", "GUSSIE_BERGNAUM92", "AQAAAAIAAYagAAAAEHSP9DGzK4H0SkVqNrA2Rsy0NhW4f9CBz/6AE7b9m3XjkhM3+zOsCo1fD/9svWvy3A==", "515-588-7919", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1221.jpg", "Gussie_Bergnaum92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "03232 Corwin Shoal, Tremayneville, Liechtenstein", "76c8eace-6855-41a8-ab58-e7f31d100f75", new DateTime(2024, 10, 9, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(4400), "Antoinette90@yahoo.com", "Antoinette", "McKenzie", "ANTOINETTE90@YAHOO.COM", "ANTOINETTE.MCKENZIE", "AQAAAAIAAYagAAAAEIRpAYDGHRob4T3zcizbDU/6s+1eT2qVRPYP9izOLjEJCGTyYh26QHTJDsk2Qa4UpA==", "852-714-3807", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/908.jpg", "Antoinette.McKenzie" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "07497 Lilliana Garden, East Reaganstad, Norfolk Island", "21438169-e857-4e90-806c-1dc4fdf36e9b", new DateTime(2024, 2, 10, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(4649), "Delphia86@hotmail.com", "Delphia", "Breitenberg", "DELPHIA86@HOTMAIL.COM", "DELPHIA44", "AQAAAAIAAYagAAAAEJnlJHDquolT8eaLKVZKoVRXsAuKlDO1rHTEaLUW/msJv61UfVsZbq08wPjAmCsE9Q==", "247-496-5855", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1109.jpg", "Delphia44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "9167 Heber Crossing, East Dedric, Grenada", "905c4488-a1a4-4430-a366-f9f0826c099a", new DateTime(2024, 5, 20, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(4833), "Berniece.Walter0@gmail.com", "Berniece", "Walter", "BERNIECE.WALTER0@GMAIL.COM", "BERNIECE40", "AQAAAAIAAYagAAAAEIX8bUq2maRwwmxsc3PcnPcnkIaiBMcjTutIs8GYsbMpHQRiFDBbj8JDinf6eZuvfA==", "832-311-0472", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1050.jpg", "Berniece40" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "283 Lurline Drive, Leuschkeberg, Poland", "def0538b-dcb5-412a-935b-bf35954c7502", new DateTime(2024, 10, 8, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(5100), "Shanelle65@yahoo.com", "Shanelle", "Mante", "SHANELLE65@YAHOO.COM", "SHANELLE.MANTE42", "AQAAAAIAAYagAAAAEEbEBmuIUFH3CNF4CVQS6HooAFwiWkXh5EmEfkOS/7ijKCFX2UWUA2WQuJ1ej9L3JA==", "717-553-3544", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/287.jpg", "Shanelle.Mante42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "975 Hauck Island, Mosciskiview, Guernsey", "c85a05a0-3936-4a9a-bcda-ddb30d9666b9", new DateTime(2024, 11, 16, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(5343), "Ava61@yahoo.com", "Ava", "Herzog", "AVA61@YAHOO.COM", "AVA_HERZOG24", "AQAAAAIAAYagAAAAENbaKTcqp6IOnTADVaur9xPhlGX3xrJyxf/rFusq6YcZFImB+4CLhEGXFoteXR7nNg==", "655-727-2139", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/914.jpg", "Ava_Herzog24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8419 Haley View, O'Keefeside, Oman", "08d7b943-f752-4746-85e4-f9620d3c4c31", new DateTime(2024, 8, 19, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(5556), "Jasper_Reinger@yahoo.com", "Jasper", "Reinger", "JASPER_REINGER@YAHOO.COM", "JASPER.REINGER26", "AQAAAAIAAYagAAAAEDBAgVvlcz+6GBv/56bycsnge738+j5VWSAR0zTGDZrrOfObaZ2Oa2FMuhXLl2Tb3Q==", "487-261-0449", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/199.jpg", "Jasper.Reinger26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "428 Mackenzie Points, Aylinfurt, Lesotho", "cc3b2e0f-779d-4f62-89da-5583a88072bb", new DateTime(2024, 10, 13, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(5783), "Reid60@hotmail.com", "Reid", "O'Conner", "REID60@HOTMAIL.COM", "REID64", "AQAAAAIAAYagAAAAEB7SD9v3PpMS2KRt1VGsXatkIveuXtqb7yBi/zNHaHXRlVIvhEmHmziKge4jPoOewA==", "746-430-1742", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/858.jpg", "Reid64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7440 Volkman Springs, West Anderson, Canada", "45509207-8a90-4f6c-8d00-250837bf5fbf", new DateTime(2024, 3, 13, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(5964), "Elbert.Mueller74@yahoo.com", "Elbert", "Mueller", "ELBERT.MUELLER74@YAHOO.COM", "ELBERT36", "AQAAAAIAAYagAAAAEHy437+nRHH3HUwlqh1vbhr65s0RRlJhUMWFOFJ5ApTPr7LBYBmdUDFTHZv1O//sPw==", "487-117-7312", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/679.jpg", "Elbert36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "46239 Bailee Pike, Hickleberg, Macedonia", "ff4d6e84-271b-40c8-8a70-de58d98b16c4", new DateTime(2024, 3, 8, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(6165), "Gudrun32@hotmail.com", "Gudrun", "Kovacek", "GUDRUN32@HOTMAIL.COM", "GUDRUN_KOVACEK", "AQAAAAIAAYagAAAAEGH8VS3TAlVgGucsmebbvY1mtfkRklRwL+g08jQbLfBifHDlqK6lOO+xGlPuA48c3w==", "889-245-8982", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1204.jpg", "Gudrun_Kovacek" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "2207 Kellie Gateway, Todchester, Dominica", "aa9ef4c8-bd89-4b95-8b8b-44a720aa00c9", new DateTime(2024, 9, 7, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(6345), "Jalyn52@hotmail.com", "Jalyn", "Nikolaus", "JALYN52@HOTMAIL.COM", "JALYN56", "AQAAAAIAAYagAAAAEN16ReaZZPKKK8FkaHcmXOyMLIn/pHl72B0zMLsibKy9kPzRqw7YEqgj69SgcLNMVg==", "680-885-0797", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/876.jpg", "Jalyn56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "6106 Will Tunnel, Dietrichville, Equatorial Guinea", "fca66930-df3e-459c-b306-f2299f2c0226", new DateTime(2024, 8, 29, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(6561), "Providenci65@gmail.com", "Providenci", "Doyle", "PROVIDENCI65@GMAIL.COM", "PROVIDENCI_DOYLE49", "AQAAAAIAAYagAAAAEJrNue6KAkflrQfSnccOq7BerGAXRKENo6o/psbRJn+1QNk/CZUMsPraQaLq2I5WmQ==", "440-194-6015", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/166.jpg", "Providenci_Doyle49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8313 Kimberly Estate, Reichelhaven, Togo", "6a8120b1-0971-4d08-bee4-815f988349f4", new DateTime(2024, 6, 18, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(6734), "Ciara.Heathcote54@gmail.com", "Ciara", "Heathcote", "CIARA.HEATHCOTE54@GMAIL.COM", "CIARA46", "AQAAAAIAAYagAAAAEICjCPWt0WeKesgwbDQmWNoWjtVM62iKD09IFPWqZi9qxo4mjzXFWRXyC351ABQ+8w==", "210-102-1733", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/683.jpg", "Ciara46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "156 Fatima Estate, Leonoramouth, Guatemala", "e368a6d9-dec9-4db6-8ea0-c87f1c5114b9", new DateTime(2023, 12, 26, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(6925), "Emery_Spinka@yahoo.com", "Emery", "Spinka", "EMERY_SPINKA@YAHOO.COM", "EMERY_SPINKA", "AQAAAAIAAYagAAAAEPt/J/8Iz3PryiMqswMgCsk1N7NAd3C8I2wcgHVVeHUcR2DHJRdzATM85EjqkQTZRQ==", "910-577-5632", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/172.jpg", "Emery_Spinka" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "7132 Janet Crescent, Trystanmouth, Bangladesh", "c41a6d96-81fb-4e7e-a197-6733c772d181", new DateTime(2023, 12, 28, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(7087), "Bonita53@hotmail.com", "Bonita", "Stokes", "BONITA53@HOTMAIL.COM", "BONITA.STOKES", "AQAAAAIAAYagAAAAEKSt8Y/A1OGkDIUM7Qz4Kx+JjD7oF1hFxHDr/+KHqtgC7BSYvcCtxk+UrpCfTii//A==", "929-514-5288", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/14.jpg", "Bonita.Stokes" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8163 Rosa Glen, Walshmouth, Saint Barthelemy", "370ac733-851f-4130-8b63-cceb3c5dbb97", new DateTime(2024, 1, 20, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(7303), "Darrell_McDermott@hotmail.com", "Darrell", "McDermott", "DARRELL_MCDERMOTT@HOTMAIL.COM", "DARRELL47", "AQAAAAIAAYagAAAAEKXD0ORj55lFkunH4WKQYmmwFcTBMTsdkRyYso4Z5RWMcpJxRvD9SzmyypwVe5iwHA==", "435-109-3363", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/531.jpg", "Darrell47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "735 Geovanny Street, Dayanachester, Algeria", "7483a7fd-7202-4d1c-9f18-19ef8ba0ebe5", new DateTime(2024, 8, 20, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(7470), "Laverne.Kihn13@hotmail.com", "Laverne", "Kihn", "LAVERNE.KIHN13@HOTMAIL.COM", "LAVERNE_KIHN86", "AQAAAAIAAYagAAAAEE3j1msHUXkvZ5ELV9y3vwhbCxGtWSz8OD2YRLyDXvW6UktfM7WEkbdsvOHaRk6UMA==", "301-724-5202", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/295.jpg", "Laverne_Kihn86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "881 Rosalind Track, Port Juliofurt, Australia", "36006cce-7b10-470d-a03d-52d4ecd0e471", new DateTime(2024, 11, 24, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(7661), "Jed.Kuhic@yahoo.com", "Jed", "Kuhic", "JED.KUHIC@YAHOO.COM", "JED31", "AQAAAAIAAYagAAAAEBr0KIs9MqUWIfH+PAPhE49Vy+Ay3wqJ+LwWKGNmOPsmLQ2OnIqrjVYOF2ac0EHXPA==", "417-956-6729", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1035.jpg", "Jed31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "44370 Emmerich Locks, New Haleymouth, Barbados", "1bcfafb1-c1bb-4224-aa51-0f1ccd4541a2", new DateTime(2024, 6, 1, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(7835), "Louisa_Rogahn89@yahoo.com", "Louisa", "Rogahn", "LOUISA_ROGAHN89@YAHOO.COM", "LOUISA87", "AQAAAAIAAYagAAAAEBguNrXjl4Dwln4yPfppdHL5sfhS0+FUOehcDkniJt71N3y4HefRY4dlEYdiwgso7Q==", "457-737-8847", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/582.jpg", "Louisa87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "8645 Bradtke Underpass, West Eudora, Micronesia", "1cc2edab-92c2-4bf0-ac7d-340e86b85bb1", new DateTime(2024, 2, 6, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(8107), "Greta77@gmail.com", "Greta", "Johnston", "GRETA77@GMAIL.COM", "GRETA65", "AQAAAAIAAYagAAAAEGC6X3oQGDLXDk/6UKAyUDyqYknpsxSbRRVjI1DkWZior9KGK/mtZNRKmWnTKFj09A==", "853-727-6667", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/103.jpg", "Greta65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "410 Gutkowski Harbor, Generalburgh, Tuvalu", "b23ae18b-be0a-4260-a59a-333a64915a08", new DateTime(2024, 9, 1, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(8286), "Henri.Rice@gmail.com", "Henri", "Rice", "HENRI.RICE@GMAIL.COM", "HENRI0", "AQAAAAIAAYagAAAAEBJOkgWjUfXx5psplEmbvdYD0/UPDa3oEbEqon/qKgqS71XP8vxCggtGiRIgRUX4og==", "900-224-3702", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/311.jpg", "Henri0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "98369 Adam Turnpike, New Urbanchester, Tanzania", "4930464b-d5a3-463b-a266-eb7f43d899f5", new DateTime(2024, 4, 16, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(8531), "Moriah.Schamberger24@gmail.com", "Moriah", "Schamberger", "MORIAH.SCHAMBERGER24@GMAIL.COM", "MORIAH42", "AQAAAAIAAYagAAAAED3sSMnPZ7uCAC16xpJy1p40RSCD/JFsCh9TayYasmLwFT0dnx9n+bADoARQkL6Kmw==", "982-258-8659", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/160.jpg", "Moriah42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "00664 Krystel Mountain, Giovannishire, Rwanda", "dd51b8ec-30f9-429f-a9b9-c5bf8b326e1a", new DateTime(2024, 12, 12, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(8768), "Skylar2@yahoo.com", "Skylar", "Gottlieb", "SKYLAR2@YAHOO.COM", "SKYLAR.GOTTLIEB", "AQAAAAIAAYagAAAAEJ/JHEDpHCt2wDWkKimBs7eq4KnpR7DeL7ZAx9apUMeU7AV0IudZ0XGOeX/aks4enw==", "399-599-7289", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/388.jpg", "Skylar.Gottlieb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "1320 Malika Mountain, New Sim, Kuwait", "46935894-dd6c-40d9-9fe9-80d99fc25105", new DateTime(2024, 11, 2, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(8988), "Bianka.Wintheiser74@gmail.com", "Bianka", "Wintheiser", "BIANKA.WINTHEISER74@GMAIL.COM", "BIANKA.WINTHEISER", "AQAAAAIAAYagAAAAENKm5onDpv/N9Zi5afMj88SjEr07AyDomEdvUAnxZF/Ix47/Yo9F95dAo/a1faVI6g==", "044-710-1785", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/505.jpg", "Bianka.Wintheiser" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "390 Willie Drives, South Abnerhaven, Serbia", "ddf7cdcd-1de9-483f-90d6-daaab5a82cfb", new DateTime(2024, 12, 3, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(9254), "Clair_Erdman44@yahoo.com", "Clair", "Erdman", "CLAIR_ERDMAN44@YAHOO.COM", "CLAIR30", "AQAAAAIAAYagAAAAEI59mXviCcVNB3lg3WTVAZ6Tkm1JZJpyJTcB5wHRI6U4n0+aiiWXuPH1l1K+yxQDvg==", "151-028-0427", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/477.jpg", "Clair30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "772 Cummerata Union, New Imatown, Sudan", "81fc9517-82ce-40ad-82db-f738f374e43c", new DateTime(2024, 1, 2, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(9459), "Martin_Muller@hotmail.com", "Martin", "Muller", "MARTIN_MULLER@HOTMAIL.COM", "MARTIN.MULLER75", "AQAAAAIAAYagAAAAEFHvcU9oEDtIF9PYH/5XlpFG6mIfHaaGtsNjlXXx0xqqgmF346rAwvd/v1T8mD9vpw==", "138-787-0129", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/967.jpg", "Martin.Muller75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "133 Braun Groves, Port Jeniferview, New Caledonia", "47cea0b0-fa11-4439-9f2b-1afd535fe1ca", new DateTime(2024, 9, 13, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(9779), "Rachel_King81@hotmail.com", "Rachel", "King", "RACHEL_KING81@HOTMAIL.COM", "RACHEL.KING53", "AQAAAAIAAYagAAAAEN/iktSho0tWzOFpjMXQ1cyA59cLWr9aqKQ8wCD+b0K9npNHts3056XXXhG1xPgrYw==", "197-529-5569", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/950.jpg", "Rachel.King53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "94206 Mueller Manors, North Emmanuellebury, Micronesia", "cf4909e6-f28b-41b2-95bc-6f57774d6076", new DateTime(2024, 11, 15, 6, 20, 3, 675, DateTimeKind.Utc).AddTicks(9996), "Margarete.Kunze2@yahoo.com", "Margarete", "Kunze", "MARGARETE.KUNZE2@YAHOO.COM", "MARGARETE_KUNZE65", "AQAAAAIAAYagAAAAECECLbsBA8+m9CGiQ+W9djSjYxy4CQkJb3h31afmWQWMWPbbTp0myxK1m/Jy5nYPUA==", "884-193-0365", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/87.jpg", "Margarete_Kunze65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "623 Robel Wall, Naderbury, Aruba", "0471d0fe-178c-4d57-977a-1ee501c41abc", new DateTime(2024, 9, 27, 6, 20, 3, 676, DateTimeKind.Utc).AddTicks(210), "Lon_Rowe@yahoo.com", "Lon", "Rowe", "LON_ROWE@YAHOO.COM", "LON29", "AQAAAAIAAYagAAAAENB7olJ9ZLCsRRL9e/f/badp/QtW8VNxUna7oWjR3nE8IdbFNhyofnno9/ImY5mbGQ==", "462-380-8359", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/195.jpg", "Lon29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "219 Sharon Fall, New Ashton, Lithuania", "967ac62f-ac45-487a-b82e-646d846a1542", new DateTime(2024, 4, 8, 6, 20, 3, 676, DateTimeKind.Utc).AddTicks(373), "Rae_Hilll28@hotmail.com", "Rae", "Hilll", "RAE_HILLL28@HOTMAIL.COM", "RAE41", "AQAAAAIAAYagAAAAEA/7IQ5rFopMQxaZIj6bgT5cpHwp4a6KYhJSZckHuzxLjWYdHWEZihMX37p36HkTBQ==", "769-104-8531", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1247.jpg", "Rae41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "013 Johns Canyon, Verdieberg, Hungary", "9efed32d-2e8d-4567-bbd3-72843d4b3abf", new DateTime(2024, 1, 21, 6, 20, 3, 676, DateTimeKind.Utc).AddTicks(569), "Ashleigh52@gmail.com", "Ashleigh", "Wunsch", "ASHLEIGH52@GMAIL.COM", "ASHLEIGH.WUNSCH79", "AQAAAAIAAYagAAAAENZLOil0+OP0mGCyB3bhNq6WM4G78KtwcpERHz0uqrnmQ4vmhmLugQKdJra1JLCj5Q==", "601-358-3963", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/692.jpg", "Ashleigh.Wunsch79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "790 Wisozk Harbors, Batzland, Malaysia", "6372049c-e34e-4699-9a2c-e8056754f415", new DateTime(2024, 8, 13, 6, 20, 3, 676, DateTimeKind.Utc).AddTicks(732), "Sibyl_Price@gmail.com", "Sibyl", "Price", "SIBYL_PRICE@GMAIL.COM", "SIBYL.PRICE6", "AQAAAAIAAYagAAAAEHthkYs+cxbexv8gWho0jExv4E/D8sBjUpqwNQ7qBLba8PBJ0Wwkd2hx7nSrhFCS6g==", "326-285-0557", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1028.jpg", "Sibyl.Price6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "40968 Gutkowski Crest, Doylestad, Macedonia", "fbf7f149-5101-4457-bbef-2ea1d8f0b195", new DateTime(2024, 3, 23, 6, 20, 3, 676, DateTimeKind.Utc).AddTicks(893), "Gerard93@hotmail.com", "Gerard", "Spinka", "GERARD93@HOTMAIL.COM", "GERARD7", "AQAAAAIAAYagAAAAEKSJk2XKDzUH4fPymQr0B6Y/3LnowhULaC1UwWOtGj8jvMZU3O3uL+3msjeAOzaRzA==", "687-090-8040", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/874.jpg", "Gerard7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "ProfilePictureUrl", "UserName" },
                values: new object[] { "638 Ashleigh Extensions, West Edmondburgh, Tuvalu", "2f686cd2-693c-44d8-80d8-47d5bec9bc95", new DateTime(2024, 4, 1, 6, 20, 3, 676, DateTimeKind.Utc).AddTicks(1083), "Amber_Wuckert@gmail.com", "Amber", "Wuckert", "AMBER_WUCKERT@GMAIL.COM", "AMBER.WUCKERT3", "AQAAAAIAAYagAAAAELsoOIlfc8iI0bVMV4IIjNmWPW/y6Wgq/SaB+mnuc7ekR8ygVewUSuigEyqZKz9PLA==", "326-838-3685", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/996.jpg", "Amber.Wuckert3" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 5, 473, DateTimeKind.Utc).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6441));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 6, 20, 3, 651, DateTimeKind.Utc).AddTicks(6454));

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Admin", "ADMIN" },
                    { "2", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 88, 3, new DateTime(2024, 12, 18, 6, 20, 3, 644, DateTimeKind.Utc).AddTicks(6015), "Sản phẩm được làm từ Vải Organic. Thoáng mát. Phù hợp cho các dịp dạo phố", "Chanel Áo Len Cổ Điển", 2757911.6597977134020084075990m, 2439687.481218123350000m, 110, "Kích thước: M, L, XXL. Màu sắc: Xám, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 40, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(45), "Sản phẩm được làm từ Sợi Bamboo. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Adidas Đầm Dạ Hội Trẻ Trung", 303926.48028816805991469321746m, 252688.7843753966600000m, 324, "Kích thước: S, XL, XS. Màu sắc: Đỏ, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 132, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(213), "Sản phẩm được làm từ Vải Linen. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Louis Vuitton Áo Thun Sang Trọng", 6974661.0500281025990669083666m, 4826068.14839207900000m, 311, "Kích thước: M, L, XXL. Màu sắc: Hồng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 154, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(253), "Sản phẩm được làm từ Vải Linen. Thoáng mát. Phù hợp cho các dịp dạo phố", "Adidas Quần Tây Năng Động", 2503264.8096885861234949417672m, 1701221.111562743600000m, 289, "Kích thước: XXL, XL, M. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 55, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(313), "Sản phẩm được làm từ Vải Organic. Thiết kế hiện đại. Phù hợp cho các dịp văn phòng", "H&M Quần Short Sang Trọng", 899431.9145513259622600839557m, 629135.461551683300000m, 38, "Kích thước: L, M, XXL. Màu sắc: Xanh Navy, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 52, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(346), "Sản phẩm được làm từ Chất liệu Nhật Bản. Phù hợp nhiều dáng người. Phù hợp cho các dịp thể thao", "Nike Quần Tây Sang Trọng", 6154215.6471008754936578864126m, 4300517.212080581750000m, 350, "Kích thước: XL, S, M. Màu sắc: Đen, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 85, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(379), "Sản phẩm được làm từ Sợi Bamboo. Thoáng mát. Phù hợp cho các dịp thể thao", "Adidas Đầm Dạ Hội Cổ Điển", 4035458.0243999272369379456168m, 2812037.583476340950000m, 227, "Kích thước: XL, XXL, M. Màu sắc: Xám, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 162, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(409), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "H&M Áo Sơ Mi Hiện Đại", 2354629.6533797403011200341974m, 1708178.680546133900000m, 460, "Kích thước: XL, L, S. Màu sắc: Đỏ, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 147, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(483), "Sản phẩm được làm từ Sợi Bamboo. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Louis Vuitton Đầm Dạ Hội Cổ Điển", 5144420.4624919057005907159810m, 3738010.90412618600000m, 465, "Kích thước: L, XS, S. Màu sắc: Xám, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 121, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(516), "Sản phẩm được làm từ Sợi Bamboo. Thoáng mát. Phù hợp cho các dịp dạo phố", "Nike Váy Liền Năng Động", 1869539.4235842354148095859987m, 1275307.081417344200000m, 256, "Kích thước: S, XXL, XS. Màu sắc: Đen, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 184, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(546), "Sản phẩm được làm từ Vải Linen. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Adidas Đầm Dạ Hội Thoải Mái", 5573599.3091296281955639408730m, 4769287.10921153750000m, 78, "Kích thước: XL, S, M. Màu sắc: Trắng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 75, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(577), "Sản phẩm được làm từ Vải Organic. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Gucci Blazer Thời Thượng", 2757770.0211902554565065641546m, 2205324.924354125150000m, 36, "Kích thước: XXL, S, XS. Màu sắc: Đen, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 191, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(636), "Sản phẩm được làm từ Sợi Bamboo. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "Adidas Quần Tây Trẻ Trung", 5626175.9427893990750369403464m, 3950522.933354915450000m, 346, "Kích thước: M, S, L. Màu sắc: Hồng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 7, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(666), "Sản phẩm được làm từ Vải Linen. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Chanel Áo Khoác Năng Động", 6565243.3363599197172941491194m, 4881568.577027541800000m, 92, "Kích thước: S, XL, XXL. Màu sắc: Trắng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 113, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(697), "Sản phẩm được làm từ Vải Linen. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "Uniqlo Áo Khoác Thời Thượng", 3264903.1736207790467991841248m, 2595353.909500376150000m, 374, "Kích thước: S, M, L. Màu sắc: Hồng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 108, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(751), "Sản phẩm được làm từ Cotton cao cấp. Co giãn tốt. Phù hợp cho các dịp thể thao", "Louis Vuitton Áo Thun Cổ Điển", 5950464.0527942864618166740464m, 4618323.566653990550000m, 200, "Kích thước: XS, L, S. Màu sắc: Xám, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 68, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(780), "Sản phẩm được làm từ Cotton cao cấp. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "Adidas Áo Polo Thời Thượng", 619043.90889470163726604972406m, 458390.9665143468050000m, 318, "Kích thước: S, XXL, L. Màu sắc: Đỏ, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 96, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(807), "Sản phẩm được làm từ Vải Organic. Co giãn tốt. Phù hợp cho các dịp thể thao", "Uniqlo Quần Tây Trẻ Trung", 605485.87138144781348127617693m, 530157.9430345393850000m, 288, "Kích thước: XL, M, L. Màu sắc: Xám, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 157, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(836), "Sản phẩm được làm từ Vải Organic. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Nike Đầm Dạ Hội Hiện Đại", 4971117.0034383616860055096429m, 3343333.587874172150000m, 316, "Kích thước: S, XL, XXL. Màu sắc: Xanh Navy, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 165, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(888), "Sản phẩm được làm từ Vải Organic. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "H&M Quần Jogger Năng Động", 2257428.9857896414580682878619m, 1681835.37190307150000m, 208, "Kích thước: XS, S, XL. Màu sắc: Đỏ, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 81, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(918), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Louis Vuitton Quần Short Năng Động", 4453946.1659219400502000220282m, 2973806.94404519600000m, 74, "Kích thước: XXL, S, XL. Màu sắc: Đỏ, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 78, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(948), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Louis Vuitton Quần Tây Thời Thượng", 4976348.8891319975611393653919m, 3591977.011307111300000m, 63, "Kích thước: L, S, XL. Màu sắc: Trắng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 195, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(976), "Sản phẩm được làm từ Cotton cao cấp. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "Chanel Quần Tây Cổ Điển", 4630124.9550871639156462899512m, 3126410.648005560800000m, 132, "Kích thước: L, XXL, XS. Màu sắc: Đỏ, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 193, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1028), "Sản phẩm được làm từ Vải Châu Âu. Thoáng mát. Phù hợp cho các dịp dạo phố", "Adidas Áo Thun Trẻ Trung", 5604011.8444516004676897555619m, 3989708.130357878450000m, 242, "Kích thước: L, S, XXL. Màu sắc: Trắng, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 125, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1057), "Sản phẩm được làm từ Vải Châu Âu. Thoáng mát. Phù hợp cho các dịp thể thao", "Adidas Quần Jogger Trẻ Trung", 6335751.7343909634047971171409m, 4838028.682921256300000m, 382, "Kích thước: XXL, M, XL. Màu sắc: Trắng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 76, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1085), "Sản phẩm được làm từ Vải Linen. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "Nike Quần Jean Năng Động", 4115381.5240720033139185829404m, 2837188.082327549450000m, 326, "Kích thước: M, XXL, S. Màu sắc: Đen, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 122, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1135), "Sản phẩm được làm từ Vải Organic. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Adidas Áo Polo Thời Thượng", 4422876.2818169361122279332186m, 3577759.0834248950000m, 340, "Kích thước: XL, M, L. Màu sắc: Trắng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 153, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1166), "Sản phẩm được làm từ Sợi Bamboo. Co giãn tốt. Phù hợp cho các dịp thể thao", "Chanel Áo Sơ Mi Thời Thượng", 3864180.8411210609885686908149m, 2690463.096334357250000m, 75, "Kích thước: S, XS, M. Màu sắc: Đen, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 82, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1194), "Sản phẩm được làm từ Sợi Bamboo. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Chanel Áo Thun Năng Động", 3629388.7163155256201817926479m, 3049717.297680049100000m, 246, "Kích thước: XL, M, XXL. Màu sắc: Đỏ, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 5, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1220), "Sản phẩm được làm từ Vải Châu Âu. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Uniqlo Quần Jogger Hiện Đại", 6656686.6044769860359669193615m, 4452018.087800626700000m, 186, "Kích thước: XXL, L, XL. Màu sắc: Xanh Navy, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 59, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1271), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Louis Vuitton Đầm Dạ Hội Năng Động", 2652906.4151394488579424045185m, 2260142.020104215450000m, 223, "Kích thước: XXL, XS, S. Màu sắc: Hồng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 91, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1300), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Zara Blazer Trẻ Trung", 3133768.5187917698182121366679m, 2824825.308100404350000m, 437, "Kích thước: XL, XXL, XS. Màu sắc: Trắng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 166, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1328), "Sản phẩm được làm từ Vải Châu Âu. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Louis Vuitton Quần Short Hiện Đại", 3757533.8905814923965502354484m, 3026704.963438248350000m, 253, "Kích thước: S, M, XS. Màu sắc: Xám, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 153, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1358), "Sản phẩm được làm từ Sợi Bamboo. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "Zara Quần Short Trẻ Trung", 1765694.0150702707528157743175m, 1224231.338392930400000m, 78, "Kích thước: XXL, S, XS. Màu sắc: Đỏ, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 43, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1402), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Nike Áo Khoác Năng Động", 2272445.9216333485293146570688m, 1607654.782793535800000m, 118, "Kích thước: XS, M, XXL. Màu sắc: Xám, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 25, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1431), "Sản phẩm được làm từ Cotton cao cấp. Co giãn tốt. Phù hợp cho các dịp thể thao", "Zara Áo Khoác Trẻ Trung", 5441484.3591964368101740329355m, 4495632.975044076200000m, 11, "Kích thước: XL, L, XS. Màu sắc: Xanh Navy, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 67, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1460), "Sản phẩm được làm từ Sợi Bamboo. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "Louis Vuitton Đầm Dạ Hội Thời Thượng", 1145650.6380785156590899564521m, 828144.065132619350000m, 118, "Kích thước: XL, L, XXL. Màu sắc: Hồng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 101, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1517), "Sản phẩm được làm từ Sợi Bamboo. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Gucci Quần Jogger Trẻ Trung", 2196601.4103211829884339840578m, 1685444.452740096350000m, 189, "Kích thước: XXL, L, XS. Màu sắc: Trắng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 93, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1547), "Sản phẩm được làm từ Vải Linen. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Zara Quần Jean Năng Động", 899307.3838476888934149852754m, 633252.309320827850000m, 368, "Kích thước: M, XS, L. Màu sắc: Đỏ, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 112, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1577), "Sản phẩm được làm từ Vải Châu Âu. Thoáng mát. Phù hợp cho các dịp dạo phố", "Chanel Áo Polo Trẻ Trung", 186012.62705255858913713341217m, 126473.5506689894300000m, 39, "Kích thước: XS, S, XXL. Màu sắc: Trắng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 13, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1606), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "H&M Áo Khoác Thời Thượng", 7123180.8905097201703129693215m, 4988715.008141289650000m, 255, "Kích thước: XXL, XL, S. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 147, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1664), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp văn phòng", "Nike Áo Khoác Năng Động", 6393546.4642991457053162956685m, 4792445.240571009950000m, 471, "Kích thước: S, XL, XXL. Màu sắc: Hồng, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 19, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1694), "Sản phẩm được làm từ Cotton cao cấp. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Gucci Váy Liền Thời Thượng", 1561803.0751327553259370043048m, 1234682.796272221400000m, 396, "Kích thước: S, XXL, L. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 22, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1722), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Uniqlo Áo Polo Cổ Điển", 2984642.0117755017865612845923m, 2468127.308005220900000m, 58, "Kích thước: XS, L, XXL. Màu sắc: Đỏ, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 20, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1750), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thoáng mát. Phù hợp cho các dịp dạo phố", "Adidas Áo Khoác Thoải Mái", 346102.61972253612147892962425m, 292207.1104501480850000m, 310, "Kích thước: XL, XXL, L. Màu sắc: Xám, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 101, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1803), "Sản phẩm được làm từ Vải Organic. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Nike Váy Liền Năng Động", 921330.1773067938411812634218m, 749370.962839341650000m, 340, "Kích thước: L, M, S. Màu sắc: Hồng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 27, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1831), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp thể thao", "Adidas Quần Short Hiện Đại", 6943351.5731985510941362101032m, 4669644.63896488850000m, 468, "Kích thước: M, S, XXL. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 109, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1859), "Sản phẩm được làm từ Vải Organic. Thoáng mát. Phù hợp cho các dịp dạo phố", "Chanel Váy Liền Sang Trọng", 1246041.3718756773921085774258m, 1087491.279329775050000m, 492, "Kích thước: XS, M, L. Màu sắc: Đỏ, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 79, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1887), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp văn phòng", "H&M Áo Thun Sang Trọng", 1988789.5405566635963315061954m, 1677404.553316430900000m, 11, "Kích thước: XXL, S, M. Màu sắc: Đỏ, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 7, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1943), "Sản phẩm được làm từ Vải Châu Âu. Co giãn tốt. Phù hợp cho các dịp dạo phố", "Nike Áo Sơ Mi Năng Động", 3381996.9353690988469566721312m, 2552167.046430233600000m, 130, "Kích thước: XXL, XL, XS. Màu sắc: Hồng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 54, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(1972), "Sản phẩm được làm từ Vải Organic. Co giãn tốt. Phù hợp cho các dịp văn phòng", "Chanel Blazer Trẻ Trung", 4202136.2368072006226018238390m, 3476494.463277335450000m, 66, "Kích thước: XL, S, XXL. Màu sắc: Hồng, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 28, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2052), "Sản phẩm được làm từ Sợi Bamboo. Thoáng mát. Phù hợp cho các dịp văn phòng", "Adidas Váy Liền Trẻ Trung", 2926171.1221681955310359806666m, 2187679.167089143700000m, 131, "Kích thước: S, M, XXL. Màu sắc: Đen, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 92, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2105), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp dạo phố", "Nike Áo Khoác Cổ Điển", 671594.85907792264699243357081m, 561170.772275424800000m, 462, "Kích thước: S, L, XXL. Màu sắc: Trắng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 140, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2135), "Sản phẩm được làm từ Vải Châu Âu. Thoáng mát. Phù hợp cho các dịp văn phòng", "Gucci Áo Khoác Hiện Đại", 5564630.3475342192777011154279m, 4065713.402427295250000m, 186, "Kích thước: S, XXL, M. Màu sắc: Đỏ, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 129, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2163), "Sản phẩm được làm từ Vải Organic. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Nike Quần Short Thoải Mái", 4821798.1038147513174180187242m, 3606344.140176687200000m, 337, "Kích thước: XS, XL, S. Màu sắc: Trắng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 156, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2191), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "H&M Váy Liền Thoải Mái", 5610330.2192021877436105856874m, 4340322.233236549400000m, 26, "Kích thước: XS, XXL, M. Màu sắc: Xám, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 154, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2242), "Sản phẩm được làm từ Vải Organic. Co giãn tốt. Phù hợp cho các dịp văn phòng", "Louis Vuitton Áo Polo Năng Động", 5979971.0247516784018115473353m, 4075394.166319677800000m, 210, "Kích thước: XS, XL, XXL. Màu sắc: Hồng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 126, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2270), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Chanel Đầm Dạ Hội Thoải Mái", 651250.64568458005968047259436m, 469264.1960767191800000m, 121, "Kích thước: M, S, XL. Màu sắc: Hồng, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 46, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2298), "Sản phẩm được làm từ Cotton cao cấp. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Uniqlo Quần Jogger Thời Thượng", 3730795.7274507645379554910216m, 3186608.525537422100000m, 113, "Kích thước: M, XS, XXL. Màu sắc: Trắng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 112, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2326), "Sản phẩm được làm từ Cotton cao cấp. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Nike Áo Thun Thoải Mái", 3550960.4931102051882136632438m, 2670319.129671329900000m, 131, "Kích thước: M, S, XS. Màu sắc: Trắng, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 71, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2382), "Sản phẩm được làm từ Vải Organic. Co giãn tốt. Phù hợp cho các dịp thể thao", "Zara Quần Jean Hiện Đại", 1509638.8976274897240993022293m, 1257721.329990332300000m, 60, "Kích thước: S, M, XS. Màu sắc: Trắng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 147, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2410), "Sản phẩm được làm từ Sợi Bamboo. Phù hợp nhiều dáng người. Phù hợp cho các dịp thể thao", "H&M Quần Short Sang Trọng", 5907331.9652419549822060969352m, 4412977.657373776100000m, 115, "Kích thước: L, XS, S. Màu sắc: Xám, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 57, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2438), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp tiệc tùng", "H&M Váy Liền Trẻ Trung", 752362.47421975521800453598049m, 607732.813240364300000m, 127, "Kích thước: L, XL, S. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 9, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2481), "Sản phẩm được làm từ Cotton cao cấp. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Zara Áo Sơ Mi Thời Thượng", 1281194.9890073405766429739641m, 1146500.610230572250000m, 345, "Kích thước: M, XL, XS. Màu sắc: Trắng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 65, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2510), "Sản phẩm được làm từ Vải Organic. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Uniqlo Đầm Dạ Hội Thoải Mái", 5751514.3605751169559657346759m, 4984848.453209778950000m, 410, "Kích thước: XXL, S, XS. Màu sắc: Xám, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 107, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2537), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Adidas Áo Khoác Thời Thượng", 2750751.0788324117417794257133m, 2317906.204475306450000m, 110, "Kích thước: S, XL, M. Màu sắc: Trắng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 143, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2564), "Sản phẩm được làm từ Cotton cao cấp. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Adidas Đầm Dạ Hội Sang Trọng", 183480.19746152377160146723667m, 126594.042719998100000m, 185, "Kích thước: S, M, XS. Màu sắc: Đen, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 87, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2622), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Uniqlo Quần Jogger Trẻ Trung", 2197284.4835231291978151025803m, 1480142.094006569900000m, 276, "Kích thước: L, M, S. Màu sắc: Đỏ, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 37, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2650), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Louis Vuitton Quần Jogger Thoải Mái", 3395463.6960029403101437399051m, 2361895.461269809250000m, 163, "Kích thước: S, L, M. Màu sắc: Đỏ, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 150, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2678), "Sản phẩm được làm từ Vải Châu Âu. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "Nike Áo Sơ Mi Hiện Đại", 5453964.4691579894854198394974m, 4539400.538007263450000m, 307, "Kích thước: XXL, L, M. Màu sắc: Đỏ, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 155, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2705), "Sản phẩm được làm từ Vải Organic. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Gucci Blazer Cổ Điển", 5491679.5251307100138417283576m, 4807013.530137435050000m, 440, "Kích thước: XS, XL, XXL. Màu sắc: Hồng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 9, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2763), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Adidas Váy Liền Thoải Mái", 1796702.5840936833088096010688m, 1277352.051601963100000m, 123, "Kích thước: L, XL, XXL. Màu sắc: Hồng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 88, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2791), "Sản phẩm được làm từ Vải Châu Âu. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Gucci Áo Thun Sang Trọng", 1148290.9892400416938724943061m, 779399.901037702400000m, 451, "Kích thước: M, XL, XXL. Màu sắc: Đỏ, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 26, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2818), "Sản phẩm được làm từ Vải Organic. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Louis Vuitton Quần Jogger Năng Động", 5812926.5859792301953740634892m, 4115814.066923437400000m, 236, "Kích thước: L, XXL, M. Màu sắc: Đỏ, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 198, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2868), "Sản phẩm được làm từ Vải Organic. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "Nike Đầm Dạ Hội Năng Động", 6130635.3414360408908694168380m, 4236594.658793531600000m, 113, "Kích thước: S, L, XS. Màu sắc: Trắng, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 64, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2897), "Sản phẩm được làm từ Vải Organic. Co giãn tốt. Phù hợp cho các dịp thể thao", "Zara Đầm Dạ Hội Thoải Mái", 7146407.6648674334749372233382m, 4864052.957429378300000m, 127, "Kích thước: XS, XXL, XL. Màu sắc: Đỏ, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 157, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2926), "Sản phẩm được làm từ Cotton cao cấp. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Louis Vuitton Đầm Dạ Hội Cổ Điển", 3332610.8689099156498968803998m, 2378323.886586734300000m, 380, "Kích thước: S, M, XXL. Màu sắc: Trắng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 54, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(2954), "Sản phẩm được làm từ Sợi Bamboo. Thoáng mát. Phù hợp cho các dịp tiệc tùng", "Chanel Quần Jean Thời Thượng", 5440057.2197061371267297054986m, 4276013.656204595750000m, 398, "Kích thước: XL, S, L. Màu sắc: Xám, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 175, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3006), "Sản phẩm được làm từ Vải Linen. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "Zara Áo Khoác Sang Trọng", 5223911.3391946167988693235910m, 4193440.086470105300000m, 23, "Kích thước: XL, XS, L. Màu sắc: Xanh Navy, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 135, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3035), "Sản phẩm được làm từ Sợi Bamboo. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "H&M Áo Sơ Mi Cổ Điển", 2086827.5201612944308178336560m, 1802458.22861783300000m, 212, "Kích thước: L, S, XXL. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 112, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3063), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp dạo phố", "Gucci Quần Tây Sang Trọng", 2963430.0586561040604179440459m, 2182506.455245733600000m, 89, "Kích thước: L, XXL, M. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 181, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3091), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thoáng mát. Phù hợp cho các dịp thể thao", "H&M Áo Khoác Trẻ Trung", 6370913.8327244739492321125136m, 4254322.553730112550000m, 221, "Kích thước: M, XXL, S. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 99, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3144), "Sản phẩm được làm từ Vải Organic. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Louis Vuitton Blazer Năng Động", 5708665.7795782825498720740087m, 4159027.057163710550000m, 123, "Kích thước: XXL, S, XS. Màu sắc: Hồng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 42, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3173), "Sản phẩm được làm từ Vải Linen. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "Adidas Quần Short Năng Động", 860070.8936734745346364307647m, 750900.48558376550000m, 469, "Kích thước: M, XS, XL. Màu sắc: Xanh Navy, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 113, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3201), "Sản phẩm được làm từ Vải Linen. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Gucci Quần Tây Năng Động", 648237.00837926097545794162894m, 481015.1043475267100000m, 141, "Kích thước: L, M, S. Màu sắc: Xanh Navy, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 183, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3229), "Sản phẩm được làm từ Sợi Bamboo. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "Louis Vuitton Quần Short Thoải Mái", 764279.26961116370742432124958m, 566141.364925379600000m, 283, "Kích thước: L, XL, XS. Màu sắc: Đen, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 156, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3278), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp tiệc tùng", "Zara Váy Liền Sang Trọng", 1167637.9111095501763434268698m, 1005252.176841106100000m, 216, "Kích thước: S, L, XL. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 186, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3307), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Gucci Quần Jogger Thời Thượng", 1782664.6491557824654888918853m, 1388518.430547966800000m, 203, "Kích thước: XL, XXL, XS. Màu sắc: Đỏ, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 6, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3335), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Nike Áo Thun Sang Trọng", 3140132.6398724178122971889416m, 2372425.616289673400000m, 283, "Kích thước: M, L, XS. Màu sắc: Đỏ, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 154, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3389), "Sản phẩm được làm từ Vải Linen. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Gucci Blazer Hiện Đại", 438480.38466178803917512929720m, 383833.5091889745200000m, 101, "Kích thước: M, L, XXL. Màu sắc: Trắng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 173, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3417), "Sản phẩm được làm từ Vải Organic. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Adidas Quần Tây Trẻ Trung", 4916100.9864019089371904133413m, 4399472.929299510650000m, 185, "Kích thước: XL, M, L. Màu sắc: Đỏ, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 105, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3447), "Sản phẩm được làm từ Sợi Bamboo. Thiết kế hiện đại. Phù hợp cho các dịp văn phòng", "Zara Áo Thun Thời Thượng", 3607730.2142197036427383849828m, 3058877.843047996700000m, 226, "Kích thước: XS, M, XL. Màu sắc: Hồng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 62, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3476), "Sản phẩm được làm từ Sợi Bamboo. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Chanel Đầm Dạ Hội Cổ Điển", 2632569.1175258092312789819619m, 2222416.53885576650000m, 304, "Kích thước: XL, XS, M. Màu sắc: Đen, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 78, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3522), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp dạo phố", "Nike Áo Khoác Sang Trọng", 3816252.7571281365653906106079m, 2747518.321870966550000m, 300, "Kích thước: XXL, XL, XS. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 89, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3550), "Sản phẩm được làm từ Cotton cao cấp. Co giãn tốt. Phù hợp cho các dịp dạo phố", "H&M Đầm Dạ Hội Cổ Điển", 4963237.2398038436584218691141m, 4431251.264579028950000m, 410, "Kích thước: S, XL, XXL. Màu sắc: Hồng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 91, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3579), "Sản phẩm được làm từ Vải Organic. Thoáng mát. Phù hợp cho các dịp dạo phố", "Adidas Áo Thun Hiện Đại", 5351548.3500396245487873780481m, 3778965.617674144100000m, 161, "Kích thước: XXL, S, XS. Màu sắc: Đen, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 191, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3608), "Sản phẩm được làm từ Vải Organic. Thoáng mát. Phù hợp cho các dịp văn phòng", "Adidas Áo Polo Sang Trọng", 1755829.5507440446882981776229m, 1594669.296513625700000m, 85, "Kích thước: XXL, M, L. Màu sắc: Đỏ, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 55, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3666), "Sản phẩm được làm từ Vải Organic. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Uniqlo Áo Sơ Mi Thoải Mái", 2559901.5509147675105632085909m, 2209109.876138895350000m, 416, "Kích thước: S, XXL, XL. Màu sắc: Hồng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 119, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3695), "Sản phẩm được làm từ Vải Linen. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Adidas Quần Jogger Hiện Đại", 3434586.0704023135135744363626m, 2604443.507322198800000m, 476, "Kích thước: XS, XL, S. Màu sắc: Hồng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 39, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3723), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp dạo phố", "Chanel Áo Sơ Mi Trẻ Trung", 1400630.8467564928723686223630m, 1133989.318828263650000m, 248, "Kích thước: XS, M, S. Màu sắc: Hồng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 78, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3779), "Sản phẩm được làm từ Vải Châu Âu. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "Chanel Quần Short Năng Động", 3172499.6125116980490978493047m, 2658296.19112883150000m, 418, "Kích thước: S, XXL, XS. Màu sắc: Đen, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 35, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3808), "Sản phẩm được làm từ Vải Châu Âu. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Uniqlo Đầm Dạ Hội Cổ Điển", 972846.3809201830113238381043m, 710064.302706554900000m, 359, "Kích thước: XS, S, L. Màu sắc: Xám, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 192, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3837), "Sản phẩm được làm từ Cotton cao cấp. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Gucci Đầm Dạ Hội Thoải Mái", 2226386.7993096081719071327186m, 2003480.505648131900000m, 498, "Kích thước: L, M, S. Màu sắc: Trắng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 29, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3866), "Sản phẩm được làm từ Vải Organic. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Louis Vuitton Áo Khoác Hiện Đại", 3699418.1144343219631784076733m, 2683247.156984884550000m, 55, "Kích thước: L, M, XS. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 64, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3918), "Sản phẩm được làm từ Vải Linen. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Zara Blazer Thoải Mái", 6449343.5636034674051957366495m, 4882228.20441140450000m, 285, "Kích thước: XS, L, XL. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 72, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3947), "Sản phẩm được làm từ Vải Châu Âu. Thoáng mát. Phù hợp cho các dịp văn phòng", "Uniqlo Áo Thun Hiện Đại", 5355178.7967038194592863929531m, 3808673.773531298600000m, 439, "Kích thước: XXL, L, XS. Màu sắc: Hồng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 103, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(3974), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Gucci Quần Tây Thời Thượng", 797863.8618858095811849665512m, 555402.892940721050000m, 153, "Kích thước: L, XL, XXL. Màu sắc: Xám, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 176, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4001), "Sản phẩm được làm từ Sợi Bamboo. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Zara Đầm Dạ Hội Trẻ Trung", 5001003.8738672493232553260535m, 3645029.159267646650000m, 212, "Kích thước: M, S, L. Màu sắc: Đỏ, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 170, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4051), "Sản phẩm được làm từ Chất liệu Nhật Bản. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "Nike Váy Liền Thoải Mái", 72571.310221556242469863113017m, 53050.592331143629250000m, 125, "Kích thước: L, XXL, S. Màu sắc: Trắng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 103, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4079), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thoáng mát. Phù hợp cho các dịp thể thao", "H&M Áo Khoác Năng Động", 6863729.2431706348402681894993m, 4941292.994625943400000m, 478, "Kích thước: XS, XXL, S. Màu sắc: Xanh Navy, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 3, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4107), "Sản phẩm được làm từ Cotton cao cấp. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "H&M Áo Sơ Mi Thời Thượng", 3307396.3970103127249067177049m, 2369367.375308777750000m, 393, "Kích thước: XS, L, M. Màu sắc: Xám, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 50, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4158), "Sản phẩm được làm từ Vải Châu Âu. Co giãn tốt. Phù hợp cho các dịp văn phòng", "Gucci Áo Thun Trẻ Trung", 5527975.1633222089356007233753m, 4458827.89264042400000m, 57, "Kích thước: XL, XS, XXL. Màu sắc: Đen, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 124, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4187), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp thể thao", "Nike Áo Len Cổ Điển", 3594500.9767528117436720129137m, 2409354.127570767800000m, 208, "Kích thước: XS, L, S. Màu sắc: Đen, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 148, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4214), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Chanel Áo Polo Hiện Đại", 1627670.3844955492347997503214m, 1120410.73215457700000m, 108, "Kích thước: S, L, XXL. Màu sắc: Xám, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 108, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4242), "Sản phẩm được làm từ Cotton cao cấp. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "H&M Áo Thun Năng Động", 5169549.5790326197734717975506m, 3794388.215597585600000m, 457, "Kích thước: L, XL, S. Màu sắc: Trắng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 110, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4292), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Chanel Quần Tây Sang Trọng", 4646322.5257986967490471561030m, 3542725.11849809900000m, 335, "Kích thước: XXL, XL, M. Màu sắc: Trắng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 111, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4319), "Sản phẩm được làm từ Vải Organic. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Uniqlo Áo Sơ Mi Thoải Mái", 4209451.3517370406976316124943m, 3573884.375695201100000m, 378, "Kích thước: L, XXL, XS. Màu sắc: Trắng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 179, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4347), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Louis Vuitton Váy Liền Thời Thượng", 3610073.0842668451812632040259m, 3078917.617374690800000m, 351, "Kích thước: S, XS, M. Màu sắc: Đỏ, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 175, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4375), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Adidas Blazer Sang Trọng", 255942.16284688942525676395412m, 210243.7828511905550000m, 131, "Kích thước: XXL, L, XL. Màu sắc: Xanh Navy, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 173, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4426), "Sản phẩm được làm từ Vải Châu Âu. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Gucci Đầm Dạ Hội Trẻ Trung", 2095106.6258818978866010932104m, 1525129.201809546800000m, 362, "Kích thước: XS, XL, M. Màu sắc: Trắng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 165, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4454), "Sản phẩm được làm từ Vải Organic. Thoáng mát. Phù hợp cho các dịp văn phòng", "Uniqlo Áo Len Cổ Điển", 4131664.6496911978141580580059m, 3561570.43888006400000m, 208, "Kích thước: XS, S, XL. Màu sắc: Trắng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 98, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4482), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Chanel Quần Jean Hiện Đại", 6053659.0359690865104652556271m, 4312273.516293432200000m, 298, "Kích thước: XS, L, S. Màu sắc: Trắng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 58, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4509), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Gucci Áo Sơ Mi Sang Trọng", 3893414.3566267239290774341329m, 2829979.549427550800000m, 106, "Kích thước: XXL, S, XS. Màu sắc: Hồng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 65, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4553), "Sản phẩm được làm từ Cotton cao cấp. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Gucci Áo Polo Sang Trọng", 161953.88847846271522123779972m, 140649.6106866980300000m, 264, "Kích thước: XXL, M, S. Màu sắc: Đỏ, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 2, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4581), "Sản phẩm được làm từ Vải Châu Âu. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Nike Đầm Dạ Hội Sang Trọng", 988899.2170768381147829367496m, 753491.405791436900000m, 226, "Kích thước: XL, L, XXL. Màu sắc: Đen, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 87, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4609), "Sản phẩm được làm từ Vải Linen. Thoáng mát. Phù hợp cho các dịp tiệc tùng", "Zara Áo Polo Thời Thượng", 4222473.2172993163771876626910m, 3306709.261968740600000m, 486, "Kích thước: S, XXL, L. Màu sắc: Đỏ, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 166, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4665), "Sản phẩm được làm từ Cotton cao cấp. Co giãn tốt. Phù hợp cho các dịp thể thao", "Zara Đầm Dạ Hội Thoải Mái", 844002.1931195293605978224645m, 563542.606813888850000m, 238, "Kích thước: L, M, XXL. Màu sắc: Đen, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 143, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4694), "Sản phẩm được làm từ Vải Organic. Co giãn tốt. Phù hợp cho các dịp văn phòng", "Nike Đầm Dạ Hội Hiện Đại", 5055271.1674357762044495251761m, 4214751.491632923950000m, 145, "Kích thước: XXL, XL, M. Màu sắc: Xám, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 90, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4724), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Louis Vuitton Blazer Thoải Mái", 4726480.0358167252182752750415m, 3154130.765109334400000m, 122, "Kích thước: S, XS, L. Màu sắc: Đỏ, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 35, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4752), "Sản phẩm được làm từ Sợi Bamboo. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Gucci Áo Sơ Mi Thoải Mái", 1777767.1605581130018861253447m, 1333833.340850347100000m, 463, "Kích thước: M, L, XL. Màu sắc: Xanh Navy, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 44, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4819), "Sản phẩm được làm từ Cotton cao cấp. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Gucci Quần Jogger Thời Thượng", 2230652.0420418930781646470151m, 1631949.624218009750000m, 194, "Kích thước: S, XL, XXL. Màu sắc: Đỏ, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 128, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4846), "Sản phẩm được làm từ Vải Organic. Phù hợp nhiều dáng người. Phù hợp cho các dịp thể thao", "Adidas Quần Jogger Sang Trọng", 5904534.3266716896740199661656m, 4120127.338460542700000m, 273, "Kích thước: S, XS, XL. Màu sắc: Trắng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 185, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4873), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp thể thao", "H&M Quần Jogger Thoải Mái", 5471876.2250002195859962640359m, 4127495.374019081300000m, 469, "Kích thước: XL, XXL, L. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 198, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4902), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "Uniqlo Quần Short Trẻ Trung", 3788438.2226036753237117799039m, 2613982.839265532300000m, 34, "Kích thước: XXL, S, L. Màu sắc: Xám, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 69, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4955), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thoáng mát. Phù hợp cho các dịp dạo phố", "H&M Đầm Dạ Hội Cổ Điển", 3159335.8072563532797807748991m, 2210667.578726033300000m, 237, "Kích thước: M, XXL, S. Màu sắc: Hồng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 169, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(4985), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp dạo phố", "Adidas Blazer Thoải Mái", 836150.7429097773163110769021m, 655746.443905573850000m, 126, "Kích thước: S, L, XL. Màu sắc: Hồng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 194, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5013), "Sản phẩm được làm từ Sợi Bamboo. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Louis Vuitton Váy Liền Thoải Mái", 3998672.6336918190257594217497m, 3055731.957415125950000m, 473, "Kích thước: XS, S, M. Màu sắc: Hồng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 106, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5063), "Sản phẩm được làm từ Cotton cao cấp. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Chanel Quần Jean Hiện Đại", 4631588.5891396046310575765274m, 3457129.851486021650000m, 111, "Kích thước: L, M, XS. Màu sắc: Đen, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 181, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5092), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Adidas Quần Tây Hiện Đại", 1369589.4175994318029817326187m, 1237383.222508709600000m, 23, "Kích thước: M, XXL, XS. Màu sắc: Đen, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 186, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5120), "Sản phẩm được làm từ Chất liệu Nhật Bản. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "Adidas Áo Len Sang Trọng", 670195.71307574490939267865857m, 509228.6543265571700000m, 382, "Kích thước: XS, L, S. Màu sắc: Xám, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 61, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5149), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Chanel Quần Jogger Thời Thượng", 809649.9067194977179002329527m, 610039.115521105550000m, 66, "Kích thước: L, S, XS. Màu sắc: Xám, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 48, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5200), "Sản phẩm được làm từ Vải Linen. Co giãn tốt. Phù hợp cho các dịp dạo phố", "Zara Quần Jogger Thời Thượng", 7006680.4361335151067343361469m, 4861348.898518540400000m, 239, "Kích thước: XXL, S, XL. Màu sắc: Xanh Navy, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 195, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5228), "Sản phẩm được làm từ Vải Organic. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Louis Vuitton Váy Liền Cổ Điển", 4216273.0007935874150207167328m, 3667930.830839246900000m, 274, "Kích thước: XXL, XS, M. Màu sắc: Trắng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 113, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5255), "Sản phẩm được làm từ Vải Linen. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "Louis Vuitton Quần Jogger Hiện Đại", 3830973.9519848872153233779235m, 3218420.054563718900000m, 244, "Kích thước: XXL, XL, M. Màu sắc: Xám, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 71, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5283), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Nike Blazer Sang Trọng", 644857.76260145180012298714460m, 519009.5434018027550000m, 73, "Kích thước: XL, XXL, M. Màu sắc: Xám, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 147, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5334), "Sản phẩm được làm từ Cotton cao cấp. Thiết kế hiện đại. Phù hợp cho các dịp văn phòng", "Chanel Blazer Thoải Mái", 1358891.6560239263257949263228m, 1130285.405845248350000m, 392, "Kích thước: XL, S, XXL. Màu sắc: Xám, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 137, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5359), "Sản phẩm được làm từ Sợi Bamboo. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "H&M Blazer Thoải Mái", 1439603.1523593701435459770708m, 1138157.827631877200000m, 25, "Kích thước: L, M, XXL. Màu sắc: Đỏ, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 122, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5387), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Louis Vuitton Quần Jogger Thời Thượng", 3267859.6422309878865905600490m, 2618863.948615197200000m, 26, "Kích thước: S, XL, L. Màu sắc: Xám, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 110, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5438), "Sản phẩm được làm từ Vải Organic. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Chanel Áo Len Sang Trọng", 3184729.5390629351213688983238m, 2774693.266531852550000m, 324, "Kích thước: S, XS, XXL. Màu sắc: Hồng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 100, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5466), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Adidas Quần Tây Trẻ Trung", 223268.68099411189576463155896m, 149716.2225002776250000m, 114, "Kích thước: L, M, S. Màu sắc: Đen, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 92, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5494), "Sản phẩm được làm từ Vải Organic. Co giãn tốt. Phù hợp cho các dịp văn phòng", "Louis Vuitton Áo Thun Cổ Điển", 6856183.8861916722315389267295m, 4720235.2831686200000m, 359, "Kích thước: XL, S, L. Màu sắc: Hồng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 14, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5524), "Sản phẩm được làm từ Vải Organic. Thiết kế hiện đại. Phù hợp cho các dịp văn phòng", "Adidas Áo Khoác Sang Trọng", 2376890.2163308865985979367946m, 1589279.046264048650000m, 210, "Kích thước: M, XXL, XS. Màu sắc: Trắng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 44, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5568), "Sản phẩm được làm từ Vải Organic. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Adidas Áo Khoác Sang Trọng", 3169897.4438834434956056671578m, 2179688.855613182600000m, 427, "Kích thước: XL, XS, S. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 72, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5596), "Sản phẩm được làm từ Vải Organic. Thiết kế hiện đại. Phù hợp cho các dịp thể thao", "Uniqlo Áo Polo Thoải Mái", 1340221.6061397974968065694703m, 962817.653316672950000m, 419, "Kích thước: L, S, XS. Màu sắc: Xanh Navy, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 62, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5624), "Sản phẩm được làm từ Sợi Bamboo. Co giãn tốt. Phù hợp cho các dịp dạo phố", "H&M Quần Tây Sang Trọng", 5219661.8789799238479504996543m, 4544494.617841358900000m, 265, "Kích thước: S, XS, XL. Màu sắc: Hồng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 120, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5653), "Sản phẩm được làm từ Vải Linen. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "Uniqlo Quần Short Sang Trọng", 1044101.3863687243732326842382m, 944614.069377130850000m, 259, "Kích thước: M, XS, XL. Màu sắc: Đỏ, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 66, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5713), "Sản phẩm được làm từ Vải Linen. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Gucci Váy Liền Thoải Mái", 5724983.9386108898762415127678m, 4697609.237421042200000m, 120, "Kích thước: M, S, XL. Màu sắc: Đỏ, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 42, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5741), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp dạo phố", "H&M Đầm Dạ Hội Năng Động", 1287111.4292578532730422538081m, 986701.694306813600000m, 380, "Kích thước: L, XS, S. Màu sắc: Đen, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 87, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5769), "Sản phẩm được làm từ Sợi Bamboo. Co giãn tốt. Phù hợp cho các dịp thể thao", "H&M Quần Jogger Sang Trọng", 4493179.4967692978295263180418m, 3011652.547835372600000m, 237, "Kích thước: XL, S, XS. Màu sắc: Đỏ, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 87, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5828), "Sản phẩm được làm từ Vải Organic. Thoáng mát. Phù hợp cho các dịp văn phòng", "Uniqlo Blazer Năng Động", 3535888.4758314065382610743954m, 3140587.639558284800000m, 93, "Kích thước: L, M, XXL. Màu sắc: Đỏ, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 9, 116, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5857), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Louis Vuitton Quần Short Thời Thượng", 1679789.5147387626898884307937m, 1510553.650038484100000m, 432, "Kích thước: XS, S, M. Màu sắc: Trắng, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 23, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5885), "Sản phẩm được làm từ Chất liệu Nhật Bản. Phù hợp nhiều dáng người. Phù hợp cho các dịp thể thao", "Uniqlo Áo Len Trẻ Trung", 458517.44387185352991374700506m, 340996.0047632389400000m, 351, "Kích thước: L, S, XXL. Màu sắc: Đen, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 176, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5913), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "H&M Áo Sơ Mi Năng Động", 1589956.3236291133544575409956m, 1222366.551004234850000m, 460, "Kích thước: XS, XL, XXL. Màu sắc: Xanh Navy, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 194, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5964), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Chanel Blazer Thoải Mái", 754689.66185174937488076751810m, 552926.791953202100000m, 207, "Kích thước: M, L, S. Màu sắc: Đỏ, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 20, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(5994), "Sản phẩm được làm từ Sợi Bamboo. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "H&M Váy Liền Sang Trọng", 4595349.5652296421055643382807m, 4148680.193947511150000m, 178, "Kích thước: S, XS, M. Màu sắc: Đen, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 172, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6023), "Sản phẩm được làm từ Vải Linen. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "Uniqlo Áo Polo Trẻ Trung", 2950114.8934588542185965538724m, 2379493.018031407250000m, 160, "Kích thước: M, XL, L. Màu sắc: Xanh Navy, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 126, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6051), "Sản phẩm được làm từ Vải Organic. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Adidas Quần Tây Sang Trọng", 3950804.8885138787683836415928m, 2722072.855814794850000m, 176, "Kích thước: S, M, XXL. Màu sắc: Đỏ, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 26, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6101), "Sản phẩm được làm từ Cotton cao cấp. Thoáng mát. Phù hợp cho các dịp tiệc tùng", "Gucci Blazer Trẻ Trung", 914671.8343354245129776644948m, 614410.448484952850000m, 191, "Kích thước: L, XS, S. Màu sắc: Xanh Navy, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 48, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6128), "Sản phẩm được làm từ Cotton cao cấp. Co giãn tốt. Phù hợp cho các dịp văn phòng", "Gucci Áo Khoác Năng Động", 1767442.2668901362532969862729m, 1229806.758877374650000m, 267, "Kích thước: XL, M, L. Màu sắc: Trắng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 61, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6155), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thoáng mát. Phù hợp cho các dịp văn phòng", "Chanel Quần Jogger Trẻ Trung", 2187705.1122483531224150558597m, 1905523.720051837550000m, 409, "Kích thước: M, XS, XXL. Màu sắc: Đen, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 87, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6182), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "Louis Vuitton Đầm Dạ Hội Sang Trọng", 4909120.9390325874140652547765m, 3746792.340111333650000m, 209, "Kích thước: XL, M, XXL. Màu sắc: Xám, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 65, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6235), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp thể thao", "H&M Quần Jogger Thoải Mái", 3439363.8714990150601217323719m, 2389173.413404630550000m, 351, "Kích thước: L, XS, XL. Màu sắc: Đỏ, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 18, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6264), "Sản phẩm được làm từ Vải Châu Âu. Phù hợp nhiều dáng người. Phù hợp cho các dịp thể thao", "Uniqlo Áo Thun Thoải Mái", 487837.31748045867144242176325m, 418550.1627296781050000m, 262, "Kích thước: L, XXL, XL. Màu sắc: Đỏ, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 50, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6291), "Sản phẩm được làm từ Vải Linen. Co giãn tốt. Phù hợp cho các dịp thể thao", "Chanel Áo Thun Thoải Mái", 5776151.4917655563282966195932m, 4531343.574055879850000m, 409, "Kích thước: XL, S, XS. Màu sắc: Xanh Navy, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 185, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6339), "Sản phẩm được làm từ Vải Châu Âu. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Gucci Áo Len Năng Động", 4565964.6151188179052350760454m, 3757172.460164155400000m, 292, "Kích thước: L, XS, M. Màu sắc: Trắng, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 44, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6366), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thoáng mát. Phù hợp cho các dịp thể thao", "Gucci Quần Jean Năng Động", 3873501.8576441199456820017300m, 3041466.511069671800000m, 483, "Kích thước: M, S, XS. Màu sắc: Xám, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 3, 109, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6395), "Sản phẩm được làm từ Vải Châu Âu. Phù hợp nhiều dáng người. Phù hợp cho các dịp dạo phố", "Nike Áo Polo Thời Thượng", 5430243.8153772659338027056871m, 3872921.503474921100000m, 41, "Kích thước: L, S, XS. Màu sắc: Xám, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 162, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6423), "Sản phẩm được làm từ Chất liệu Nhật Bản. Thoáng mát. Phù hợp cho các dịp dạo phố", "Adidas Đầm Dạ Hội Thời Thượng", 4082874.9735456561769395209046m, 3008239.321248701600000m, 285, "Kích thước: XXL, M, L. Màu sắc: Trắng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 180, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6503), "Sản phẩm được làm từ Cotton cao cấp. Thiết kế hiện đại. Phù hợp cho các dịp tiệc tùng", "Uniqlo Áo Len Năng Động", 4980156.1592486694016204531823m, 4208655.60759278300000m, 127, "Kích thước: XXL, XL, S. Màu sắc: Trắng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 78, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6532), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp văn phòng", "Nike Áo Khoác Sang Trọng", 6089570.9921383557826795103320m, 4189929.678241466450000m, 160, "Kích thước: XS, XXL, L. Màu sắc: Đen, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 5, 155, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6561), "Sản phẩm được làm từ Vải Châu Âu. Thoáng mát. Phù hợp cho các dịp dạo phố", "Zara Áo Khoác Cổ Điển", 3180780.9014640401164846357118m, 2530463.813442680450000m, 277, "Kích thước: M, XL, S. Màu sắc: Đỏ, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 110, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6588), "Sản phẩm được làm từ Cotton cao cấp. Thiết kế hiện đại. Phù hợp cho các dịp dạo phố", "Uniqlo Áo Thun Thời Thượng", 4541479.3578003853814710574297m, 3793139.286586581200000m, 271, "Kích thước: M, XS, L. Màu sắc: Xám, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 57, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6642), "Sản phẩm được làm từ Sợi Bamboo. Phù hợp nhiều dáng người. Phù hợp cho các dịp thể thao", "Gucci Áo Sơ Mi Trẻ Trung", 3276361.1134667819814504083832m, 2444697.447643217750000m, 199, "Kích thước: S, XL, M. Màu sắc: Hồng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 120, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6669), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Gucci Quần Short Năng Động", 5790123.9152646159122819839424m, 3885416.1600868850000m, 285, "Kích thước: S, XL, XS. Màu sắc: Trắng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 2, 66, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6697), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Chanel Áo Thun Trẻ Trung", 6221039.7145867057984710535212m, 4722152.983751254100000m, 98, "Kích thước: XXL, L, M. Màu sắc: Hồng, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 26, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6750), "Sản phẩm được làm từ Vải Linen. Phù hợp nhiều dáng người. Phù hợp cho các dịp tiệc tùng", "H&M Áo Len Thời Thượng", 3039426.8703837624670558519728m, 2331789.48615675200000m, 382, "Kích thước: S, XL, M. Màu sắc: Trắng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 52, 4, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6779), "Sản phẩm được làm từ Cotton cao cấp. Co giãn tốt. Phù hợp cho các dịp tiệc tùng", "H&M Quần Short Hiện Đại", 4692756.6864019323623014697242m, 3365328.70298146550000m, 125, "Kích thước: XL, XXL, L. Màu sắc: Xanh Navy, Trắng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 6, 113, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6807), "Sản phẩm được làm từ Vải Linen. Thoáng mát. Phù hợp cho các dịp tiệc tùng", "Gucci Quần Short Cổ Điển", 1807970.1984211338110794864303m, 1211591.608316570750000m, 226, "Kích thước: S, XS, M. Màu sắc: Xanh Navy, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 88, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6835), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Uniqlo Quần Jogger Cổ Điển", 5331076.9838202001824131320238m, 3564307.920708790700000m, 260, "Kích thước: XL, L, M. Màu sắc: Đen, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 104, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6885), "Sản phẩm được làm từ Vải Linen. Kiểu dáng thanh lịch. Phù hợp cho các dịp tiệc tùng", "Zara Áo Polo Hiện Đại", 2581673.4183825295847968693744m, 2103351.676556590850000m, 24, "Kích thước: L, S, M. Màu sắc: Trắng, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 26, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6913), "Sản phẩm được làm từ Cotton cao cấp. Kiểu dáng thanh lịch. Phù hợp cho các dịp dạo phố", "Uniqlo Quần Jogger Năng Động", 1093888.1125638469516272804471m, 906261.079609972850000m, 86, "Kích thước: L, S, XS. Màu sắc: Đỏ, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 8, 42, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6940), "Sản phẩm được làm từ Vải Châu Âu. Phù hợp nhiều dáng người. Phù hợp cho các dịp thể thao", "Chanel Quần Jogger Năng Động", 6217087.1708433305277499836466m, 4904458.019507287400000m, 393, "Kích thước: L, XXL, S. Màu sắc: Xanh Navy, Đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 63, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(6968), "Sản phẩm được làm từ Cotton cao cấp. Phù hợp nhiều dáng người. Phù hợp cho các dịp văn phòng", "Nike Blazer Trẻ Trung", 5495994.1819706704694597651287m, 4278556.790655122750000m, 360, "Kích thước: L, S, XL. Màu sắc: Hồng, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 4, 189, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(7021), "Sản phẩm được làm từ Chất liệu Nhật Bản. Co giãn tốt. Phù hợp cho các dịp văn phòng", "Louis Vuitton Áo Len Thời Thượng", 4239134.4299067639041943470190m, 3020705.150026370900000m, 141, "Kích thước: L, M, XXL. Màu sắc: Trắng, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 148, 5, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(7048), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp thể thao", "Adidas Quần Jean Trẻ Trung", 2449970.6064999089382327011168m, 2155377.589457608400000m, 406, "Kích thước: S, M, XXL. Màu sắc: Xám, Hồng" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 59, 2, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(7075), "Sản phẩm được làm từ Vải Châu Âu. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Nike Áo Polo Hiện Đại", 4446856.7660200368582189331194m, 3624607.140151986950000m, 71, "Kích thước: S, XL, L. Màu sắc: Đỏ, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 10, 190, 3, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(7102), "Sản phẩm được làm từ Vải Linen. Thiết kế hiện đại. Phù hợp cho các dịp văn phòng", "Uniqlo Áo Thun Sang Trọng", 3071381.1926098650647162526491m, 2170079.200285752200000m, 60, "Kích thước: XS, M, XL. Màu sắc: Xanh Navy, Xám" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 105, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(7144), "Sản phẩm được làm từ Sợi Bamboo. Co giãn tốt. Phù hợp cho các dịp thể thao", "Adidas Áo Polo Trẻ Trung", 7043161.2251754733099654997585m, 4997875.970511508100000m, 453, "Kích thước: S, XL, XS. Màu sắc: Xanh Navy, Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "BrandId", "BuyTurn", "CategoryId", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 1, 156, 1, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(7171), "Sản phẩm được làm từ Sợi Bamboo. Co giãn tốt. Phù hợp cho các dịp dạo phố", "Gucci Quần Jogger Thời Thượng", 5200330.5966708094727369046765m, 4003248.670625323850000m, 37, "Kích thước: XL, S, XXL. Màu sắc: Đỏ, Xanh Navy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "BrandId", "BuyTurn", "CreatedAt", "Description", "Name", "OldPrice", "Price", "Quantity", "Specification" },
                values: new object[] { 7, 177, new DateTime(2024, 12, 18, 6, 20, 3, 650, DateTimeKind.Utc).AddTicks(7198), "Sản phẩm được làm từ Chất liệu Nhật Bản. Kiểu dáng thanh lịch. Phù hợp cho các dịp văn phòng", "Chanel Blazer Trẻ Trung", 105765.56470719666104799259474m, 93421.94532541170800000m, 89, "Kích thước: XL, L, M. Màu sắc: Hồng, Xanh Navy" });
        }
    }
}
