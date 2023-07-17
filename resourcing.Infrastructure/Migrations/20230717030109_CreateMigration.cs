using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Resourcing.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreateMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Job",
                columns: table => new
                {
                    JobID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job", x => x.JobID);
                });

            migrationBuilder.CreateTable(
                name: "Temp",
                columns: table => new
                {
                    TempID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temp", x => x.TempID);
                    table.ForeignKey(
                        name: "FK_Temp_Job_JobID",
                        column: x => x.JobID,
                        principalTable: "Job",
                        principalColumn: "JobID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Temp_JobID",
                table: "Temp",
                column: "JobID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Temp");

            migrationBuilder.DropTable(
                name: "Job");
        }
    }
}
