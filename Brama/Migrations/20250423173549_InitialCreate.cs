using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Brama.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "building",
                columns: table => new
                {
                    building_id = table.Column<Guid>(type: "uuid", nullable: false),
                    street = table.Column<string>(type: "text", nullable: false),
                    number = table.Column<string>(type: "text", nullable: false),
                    letter = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_building", x => x.building_id);
                });

            migrationBuilder.CreateTable(
                name: "person",
                columns: table => new
                {
                    person_id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true),
                    surname = table.Column<string>(type: "text", nullable: true),
                    patronic = table.Column<string>(type: "text", nullable: true),
                    phone = table.Column<string>(type: "text", nullable: true),
                    username = table.Column<string>(type: "text", nullable: true),
                    password = table.Column<string>(type: "text", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_person", x => x.person_id);
                });

            migrationBuilder.CreateTable(
                name: "role",
                columns: table => new
                {
                    person_status_id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    priority = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_role", x => x.person_status_id);
                });

            migrationBuilder.CreateTable(
                name: "building_unit",
                columns: table => new
                {
                    building_unit_id = table.Column<Guid>(type: "uuid", nullable: false),
                    number = table.Column<int>(type: "integer", nullable: false),
                    building_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_building_unit", x => x.building_unit_id);
                    table.ForeignKey(
                        name: "FK_building_unit_building_building_id",
                        column: x => x.building_id,
                        principalTable: "building",
                        principalColumn: "building_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "entrance",
                columns: table => new
                {
                    entrance_id = table.Column<Guid>(type: "uuid", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    building_unit_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entrance", x => x.entrance_id);
                    table.ForeignKey(
                        name: "FK_entrance_building_unit_building_unit_id",
                        column: x => x.building_unit_id,
                        principalTable: "building_unit",
                        principalColumn: "building_unit_id");
                });

            migrationBuilder.CreateTable(
                name: "floor",
                columns: table => new
                {
                    floor_id = table.Column<Guid>(type: "uuid", nullable: false),
                    number = table.Column<int>(type: "integer", nullable: false),
                    building_unit_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_floor", x => x.floor_id);
                    table.ForeignKey(
                        name: "FK_floor_building_unit_building_unit_id",
                        column: x => x.building_unit_id,
                        principalTable: "building_unit",
                        principalColumn: "building_unit_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "entrance_request",
                columns: table => new
                {
                    entrance_request_id = table.Column<Guid>(type: "uuid", nullable: false),
                    entrance_id = table.Column<Guid>(type: "uuid", nullable: false),
                    phone = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entrance_request", x => x.entrance_request_id);
                    table.ForeignKey(
                        name: "FK_entrance_request_entrance_entrance_id",
                        column: x => x.entrance_id,
                        principalTable: "entrance",
                        principalColumn: "entrance_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "accommodation",
                columns: table => new
                {
                    accommodation_id = table.Column<Guid>(type: "uuid", nullable: false),
                    number = table.Column<int>(type: "integer", nullable: false),
                    floor_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accommodation", x => x.accommodation_id);
                    table.ForeignKey(
                        name: "FK_accommodation_floor_floor_id",
                        column: x => x.floor_id,
                        principalTable: "floor",
                        principalColumn: "floor_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "status",
                columns: table => new
                {
                    person_status_id = table.Column<Guid>(type: "uuid", nullable: false),
                    use_amount = table.Column<int>(type: "integer", nullable: false),
                    datetime_active_from = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    datetime_active_to = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    accommodation_id = table.Column<Guid>(type: "uuid", nullable: false),
                    person_id = table.Column<Guid>(type: "uuid", nullable: false),
                    role_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_status", x => x.person_status_id);
                    table.ForeignKey(
                        name: "FK_status_accommodation_accommodation_id",
                        column: x => x.accommodation_id,
                        principalTable: "accommodation",
                        principalColumn: "accommodation_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_status_person_person_id",
                        column: x => x.person_id,
                        principalTable: "person",
                        principalColumn: "person_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_status_role_role_id",
                        column: x => x.role_id,
                        principalTable: "role",
                        principalColumn: "person_status_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "status_log",
                columns: table => new
                {
                    status_log_id = table.Column<Guid>(type: "uuid", nullable: false),
                    date_time_issued = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    status_id_from = table.Column<Guid>(type: "uuid", nullable: false),
                    person_id_to = table.Column<Guid>(type: "uuid", nullable: false),
                    entrance_request_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_status_log", x => x.status_log_id);
                    table.ForeignKey(
                        name: "FK_status_log_entrance_request_entrance_request_id",
                        column: x => x.entrance_request_id,
                        principalTable: "entrance_request",
                        principalColumn: "entrance_request_id");
                    table.ForeignKey(
                        name: "FK_status_log_person_person_id_to",
                        column: x => x.person_id_to,
                        principalTable: "person",
                        principalColumn: "person_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_status_log_status_status_id_from",
                        column: x => x.status_id_from,
                        principalTable: "status",
                        principalColumn: "person_status_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "visit",
                columns: table => new
                {
                    visit_id = table.Column<Guid>(type: "uuid", nullable: false),
                    date_time_visited = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    entrance_id = table.Column<Guid>(type: "uuid", nullable: false),
                    status_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visit", x => x.visit_id);
                    table.ForeignKey(
                        name: "FK_visit_entrance_entrance_id",
                        column: x => x.entrance_id,
                        principalTable: "entrance",
                        principalColumn: "entrance_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_visit_status_status_id",
                        column: x => x.status_id,
                        principalTable: "status",
                        principalColumn: "person_status_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_accommodation_floor_id",
                table: "accommodation",
                column: "floor_id");

            migrationBuilder.CreateIndex(
                name: "IX_building_unit_building_id",
                table: "building_unit",
                column: "building_id");

            migrationBuilder.CreateIndex(
                name: "IX_entrance_building_unit_id",
                table: "entrance",
                column: "building_unit_id");

            migrationBuilder.CreateIndex(
                name: "IX_entrance_request_entrance_id",
                table: "entrance_request",
                column: "entrance_id");

            migrationBuilder.CreateIndex(
                name: "IX_floor_building_unit_id",
                table: "floor",
                column: "building_unit_id");

            migrationBuilder.CreateIndex(
                name: "IX_status_accommodation_id",
                table: "status",
                column: "accommodation_id");

            migrationBuilder.CreateIndex(
                name: "IX_status_person_id",
                table: "status",
                column: "person_id");

            migrationBuilder.CreateIndex(
                name: "IX_status_role_id",
                table: "status",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "IX_status_log_entrance_request_id",
                table: "status_log",
                column: "entrance_request_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_status_log_person_id_to",
                table: "status_log",
                column: "person_id_to");

            migrationBuilder.CreateIndex(
                name: "IX_status_log_status_id_from",
                table: "status_log",
                column: "status_id_from");

            migrationBuilder.CreateIndex(
                name: "IX_visit_entrance_id",
                table: "visit",
                column: "entrance_id");

            migrationBuilder.CreateIndex(
                name: "IX_visit_status_id",
                table: "visit",
                column: "status_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "status_log");

            migrationBuilder.DropTable(
                name: "visit");

            migrationBuilder.DropTable(
                name: "entrance_request");

            migrationBuilder.DropTable(
                name: "status");

            migrationBuilder.DropTable(
                name: "entrance");

            migrationBuilder.DropTable(
                name: "accommodation");

            migrationBuilder.DropTable(
                name: "person");

            migrationBuilder.DropTable(
                name: "role");

            migrationBuilder.DropTable(
                name: "floor");

            migrationBuilder.DropTable(
                name: "building_unit");

            migrationBuilder.DropTable(
                name: "building");
        }
    }
}
