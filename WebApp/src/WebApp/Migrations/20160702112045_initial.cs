using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApp.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobInfo",
                columns: table => new
                {
                    jobID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    deadline = table.Column<DateTime>(nullable: false),
                    employeer = table.Column<string>(nullable: true),
                    employeerLogo = table.Column<string>(nullable: true),
                    jobDescriptions = table.Column<string>(nullable: true),
                    jobTitle = table.Column<string>(nullable: true),
                    requirements = table.Column<string>(nullable: true),
                    views = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobInfo", x => x.jobID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobInfo");
        }
    }
}
