using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab4_23.Migrations
{
    /// <inheritdoc />
    public partial class InitialSnowWhite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SnowWhite",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SnowWhite", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pitici",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SnowWhiteID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pitici", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pitici_SnowWhite_SnowWhiteID",
                        column: x => x.SnowWhiteID,
                        principalTable: "SnowWhite",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pitici_SnowWhiteID",
                table: "Pitici",
                column: "SnowWhiteID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pitici");

            migrationBuilder.DropTable(
                name: "SnowWhite");
        }
    }
}
