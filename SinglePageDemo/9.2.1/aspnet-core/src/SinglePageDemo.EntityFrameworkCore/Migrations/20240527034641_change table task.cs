using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinglePageDemo.Migrations
{
    /// <inheritdoc />
    public partial class changetabletask : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "AppTasks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AppTasks");
        }
    }
}
