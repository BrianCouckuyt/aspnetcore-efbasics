using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CoreCourse.EFBasics.Web.Migrations
{
    public partial class CourseLecturerOptional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Teachers_LecturerId",
                table: "Courses");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Teachers_LecturerId",
                table: "Courses",
                column: "LecturerId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Teachers_LecturerId",
                table: "Courses");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Teachers_LecturerId",
                table: "Courses",
                column: "LecturerId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
