using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobHub.Migrations
{
    /// <inheritdoc />
    public partial class Wyczyszczenie_bazy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
