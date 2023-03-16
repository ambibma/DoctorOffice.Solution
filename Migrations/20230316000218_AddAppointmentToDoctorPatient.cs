using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorOffice.Migrations
{
    public partial class AddAppointmentToDoctorPatient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Appointment",
                table: "Patients");

            migrationBuilder.AddColumn<DateTime>(
                name: "AppointmentDate",
                table: "DoctorPatients",
                type: "datetime(6)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppointmentDate",
                table: "DoctorPatients");

            migrationBuilder.AddColumn<DateTime>(
                name: "Appointment",
                table: "Patients",
                type: "datetime(6)",
                nullable: true);
        }
    }
}
