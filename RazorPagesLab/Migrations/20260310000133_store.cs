using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesLab.Migrations
{
    /// <inheritdoc />
    public partial class store : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Rebuy",
                table: "GroceryList",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "GroceryList",
                type: "decimal(18, 2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "GroceryList",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Store",
                table: "GroceryList",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Store",
                table: "GroceryList");

            migrationBuilder.AlterColumn<bool>(
                name: "Rebuy",
                table: "GroceryList",
                type: "INTEGER",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "GroceryList",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "GroceryList",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }
    }
}
