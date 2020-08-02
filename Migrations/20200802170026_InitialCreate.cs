using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolMgmtApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcademicClasses",
                columns: table => new
                {
                    AcademicClassID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(nullable: true),
                    ClassStream = table.Column<string>(nullable: true),
                    ClassSubjectCombination = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "date", nullable: false),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicClasses", x => x.AcademicClassID);
                });

            migrationBuilder.CreateTable(
                name: "LocalGuardians",
                columns: table => new
                {
                    LocalGuardianID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LGName = table.Column<string>(nullable: true),
                    LGAddress = table.Column<string>(nullable: true),
                    LGContactNumer = table.Column<int>(nullable: false),
                    LGOccupation = table.Column<string>(nullable: true),
                    RelationWithParent = table.Column<string>(nullable: true),
                    AdharNumber = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "date", nullable: false),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalGuardians", x => x.LocalGuardianID);
                });

            migrationBuilder.CreateTable(
                name: "ParentDetails",
                columns: table => new
                {
                    ParentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FathersName = table.Column<string>(nullable: false),
                    MothersName = table.Column<string>(nullable: true),
                    ParentAddress = table.Column<string>(nullable: false),
                    ParentContactNumer = table.Column<int>(nullable: false),
                    ParentOccupation = table.Column<string>(nullable: true),
                    AdharNumber = table.Column<string>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "date", nullable: false),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentDetails", x => x.ParentID);
                });

            migrationBuilder.CreateTable(
                name: "StudentDetails",
                columns: table => new
                {
                    StudentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentRollNumber = table.Column<int>(nullable: false),
                    StudentName = table.Column<string>(maxLength: 100, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    studentSex = table.Column<string>(maxLength: 100, nullable: true),
                    CurrentAddress = table.Column<string>(maxLength: 500, nullable: true),
                    PermanentAddress = table.Column<string>(maxLength: 500, nullable: false),
                    ContactNumber = table.Column<int>(nullable: false),
                    Nationality = table.Column<string>(maxLength: 50, nullable: true),
                    AcademicClassID = table.Column<int>(nullable: false),
                    ParentID = table.Column<int>(nullable: false),
                    LocalGuardianID = table.Column<int>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "date", nullable: false),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentDetails", x => x.StudentID);
                    table.ForeignKey(
                        name: "FK_StudentDetails_AcademicClasses_AcademicClassID",
                        column: x => x.AcademicClassID,
                        principalTable: "AcademicClasses",
                        principalColumn: "AcademicClassID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentDetails_LocalGuardians_LocalGuardianID",
                        column: x => x.LocalGuardianID,
                        principalTable: "LocalGuardians",
                        principalColumn: "LocalGuardianID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentDetails_ParentDetails_ParentID",
                        column: x => x.ParentID,
                        principalTable: "ParentDetails",
                        principalColumn: "ParentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentDetails_AcademicClassID",
                table: "StudentDetails",
                column: "AcademicClassID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentDetails_LocalGuardianID",
                table: "StudentDetails",
                column: "LocalGuardianID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentDetails_ParentID",
                table: "StudentDetails",
                column: "ParentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentDetails");

            migrationBuilder.DropTable(
                name: "AcademicClasses");

            migrationBuilder.DropTable(
                name: "LocalGuardians");

            migrationBuilder.DropTable(
                name: "ParentDetails");
        }
    }
}
