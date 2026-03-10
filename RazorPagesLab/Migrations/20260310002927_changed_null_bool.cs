using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesLab.Migrations
{
    /// <inheritdoc />
    public partial class changed_null_bool : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Rebuy",
                table: "GroceryList",
                type: "INTEGER",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Rebuy",
                table: "GroceryList",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "INTEGER");
        }
    }
}
