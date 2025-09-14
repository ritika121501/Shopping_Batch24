using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shopping_Batch24.Migrations
{
    /// <inheritdoc />
    public partial class new_field_added_in_product_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "product",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "product");
        }
    }
}
