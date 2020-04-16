using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BSAFWebApi.Migrations
{
    public partial class addphoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "Beneficiaries",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Beneficiaries");
        }
    }
}
