using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoursesManagement.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Instructor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditUnits = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdvisorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                    table.ForeignKey(
                        name: "FK_Students_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseID", "CourseDescription", "CourseName", "CreditUnits", "DateCreated", "Instructor" },
                values: new object[,]
                {
                    { 1050, "Interesting course", "Chemistry", 3, new DateTime(2000, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " John Smith" },
                    { 4022, "Interesting course", "Microeconomics", 3, new DateTime(1997, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " karen Smith" },
                    { 4041, "Interesting course", "Macroeconomics", 3, new DateTime(2002, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " David North" },
                    { 1045, "Interesting course", "Calculus", 4, new DateTime(2001, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " Ryan Reynolds" },
                    { 3141, "Interesting course", "Trigonometry", 4, new DateTime(2000, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " John Lewis" },
                    { 2021, "Interesting course", "Composition", 3, new DateTime(1990, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " West North" },
                    { 2042, "Interesting course", "Literature", 4, new DateTime(2003, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " Allice West" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "AdvisorName", "CourseID", "DateCreated", "StudentEmail", "StudentName", "StudentPhone" },
                values: new object[,]
                {
                    { 5, "Shou las", 1050, new DateTime(2002, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lois@gmail.com", "Yan Li", "111-458-36584" },
                    { 4, "Shou las", 4022, new DateTime(2002, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lois@gmail.com", "Gytis Barzdukas", "111-458-36584" },
                    { 3, "Shou las", 4041, new DateTime(2003, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lois@gmail.com", "Arturo Anand", "111-458-36584" },
                    { 2, "Shou las", 1045, new DateTime(2002, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lois@gmail.com", "Meredith Alonso", "111-458-36584" },
                    { 1, "Shou las", 3141, new DateTime(2005, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lois@gmail.com", "Carson Alexander", "111-458-36584" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_CourseID",
                table: "Students",
                column: "CourseID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
