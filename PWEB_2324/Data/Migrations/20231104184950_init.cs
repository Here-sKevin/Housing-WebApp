using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PWEB_2324.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminModel",
                columns: table => new
                {
                    Admin_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminModel", x => x.Admin_Id);
                });;

            migrationBuilder.CreateTable(
                name: "ClientModel",
                columns: table => new
                {
                    Client_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Imovel_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientModel", x => x.Client_Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeModel",
                columns: table => new
                {
                    Func_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Manager_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeModel", x => x.Func_Id);
                });

            migrationBuilder.CreateTable(
                name: "Imovel",
                columns: table => new
                {
                    Imovel_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Property = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Wc = table.Column<int>(type: "int", nullable: false),
                    Energy = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Date_init = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data_end = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Min_Time = table.Column<int>(type: "int", nullable: false),
                    Func_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imovel", x => x.Imovel_Id);
                });

            migrationBuilder.CreateTable(
                name: "ManagerModel",
                columns: table => new
                {
                    Manager_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Admin_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerModel", x => x.Manager_Id);
                });


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminModel");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ClientModel");

            migrationBuilder.DropTable(
                name: "EmployeeModel");

            migrationBuilder.DropTable(
                name: "Imovel");

            migrationBuilder.DropTable(
                name: "ManagerModel");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
