using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcomAppProject.Migrations
{
    /// <inheritdoc />
    public partial class AddCustomerPhone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BillingAddress",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "ShippingAddress",
                table: "Customers",
                newName: "Phone");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Customers",
                newName: "ShippingAddress");

            migrationBuilder.AddColumn<string>(
                name: "BillingAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
