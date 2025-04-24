using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Practice2025_Gusev.Migrations
{
    /// <inheritdoc />
    public partial class RunemData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Specialties",
                table: "Specialties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Institutes",
                table: "Institutes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Groups",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "institut_id",
                table: "Specialties");

            migrationBuilder.RenameTable(
                name: "Specialties",
                newName: "specialties");

            migrationBuilder.RenameTable(
                name: "Institutes",
                newName: "institutes");

            migrationBuilder.RenameTable(
                name: "Groups",
                newName: "groups");

            migrationBuilder.RenameColumn(
                name: "specialty_name",
                table: "specialties",
                newName: "SpecialtyName");

            migrationBuilder.RenameColumn(
                name: "specialty_identifier",
                table: "specialties",
                newName: "InstitutId");

            migrationBuilder.RenameColumn(
                name: "specialty_id",
                table: "specialties",
                newName: "SpecialtyId");

            migrationBuilder.RenameColumn(
                name: "title_dean",
                table: "institutes",
                newName: "TitleDean");

            migrationBuilder.RenameColumn(
                name: "name_institute",
                table: "institutes",
                newName: "NameInstitute");

            migrationBuilder.RenameColumn(
                name: "full_name",
                table: "institutes",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "institut_id",
                table: "institutes",
                newName: "InstitutId");

            migrationBuilder.RenameColumn(
                name: "group_number",
                table: "groups",
                newName: "GroupNumber");

            migrationBuilder.RenameColumn(
                name: "group_id",
                table: "groups",
                newName: "GroupId");

            migrationBuilder.AddColumn<string>(
                name: "SpecialtyIdentifier",
                table: "specialties",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "InstitutId",
                table: "groups",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpecialtyId",
                table: "groups",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_specialties",
                table: "specialties",
                column: "SpecialtyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_institutes",
                table: "institutes",
                column: "InstitutId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_groups",
                table: "groups",
                column: "GroupId");

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FullName = table.Column<string>(type: "text", nullable: false),
                    YearAmission = table.Column<int>(type: "integer", nullable: false),
                    DateBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    group_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_students_groups_group_id",
                        column: x => x.group_id,
                        principalTable: "groups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_groups_institut_id",
                table: "groups",
                column: "institut_id");

            migrationBuilder.CreateIndex(
                name: "IX_groups_specialty_id",
                table: "groups",
                column: "specialty_id");

            migrationBuilder.CreateIndex(
                name: "IX_students_group_id",
                table: "students",
                column: "group_id");

            migrationBuilder.AddForeignKey(
                name: "FK_groups_institutes_institut_id",
                table: "groups",
                column: "institut_id",
                principalTable: "institutes",
                principalColumn: "InstitutId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_groups_specialties_specialty_id",
                table: "groups",
                column: "specialty_id",
                principalTable: "specialties",
                principalColumn: "SpecialtyId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_groups_institutes_institut_id",
                table: "groups");

            migrationBuilder.DropForeignKey(
                name: "FK_groups_specialties_specialty_id",
                table: "groups");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_specialties",
                table: "specialties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_institutes",
                table: "institutes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_groups",
                table: "groups");

            migrationBuilder.DropIndex(
                name: "IX_groups_institut_id",
                table: "groups");

            migrationBuilder.DropIndex(
                name: "IX_groups_specialty_id",
                table: "groups");

            migrationBuilder.DropColumn(
                name: "SpecialtyIdentifier",
                table: "specialties");

            migrationBuilder.DropColumn(
                name: "InstitutId",
                table: "groups");

            migrationBuilder.DropColumn(
                name: "SpecialtyId",
                table: "groups");

            migrationBuilder.RenameTable(
                name: "specialties",
                newName: "Specialties");

            migrationBuilder.RenameTable(
                name: "institutes",
                newName: "Institutes");

            migrationBuilder.RenameTable(
                name: "groups",
                newName: "Groups");

            migrationBuilder.RenameColumn(
                name: "SpecialtyName",
                table: "Specialties",
                newName: "specialty_name");

            migrationBuilder.RenameColumn(
                name: "InstitutId",
                table: "Specialties",
                newName: "specialty_identifier");

            migrationBuilder.RenameColumn(
                name: "SpecialtyId",
                table: "Specialties",
                newName: "specialty_id");

            migrationBuilder.RenameColumn(
                name: "TitleDean",
                table: "Institutes",
                newName: "title_dean");

            migrationBuilder.RenameColumn(
                name: "NameInstitute",
                table: "Institutes",
                newName: "name_institute");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Institutes",
                newName: "full_name");

            migrationBuilder.RenameColumn(
                name: "InstitutId",
                table: "Institutes",
                newName: "institut_id");

            migrationBuilder.RenameColumn(
                name: "GroupNumber",
                table: "Groups",
                newName: "group_number");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "Groups",
                newName: "group_id");

            migrationBuilder.AddColumn<int>(
                name: "institut_id",
                table: "Specialties",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Specialties",
                table: "Specialties",
                column: "specialty_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Institutes",
                table: "Institutes",
                column: "institut_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Groups",
                table: "Groups",
                column: "group_id");

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    student_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    date_birth = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    full_name = table.Column<char>(type: "character(1)", nullable: false),
                    group_id = table.Column<int>(type: "integer", nullable: false),
                    year_admission = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.student_id);
                });
        }
    }
}
