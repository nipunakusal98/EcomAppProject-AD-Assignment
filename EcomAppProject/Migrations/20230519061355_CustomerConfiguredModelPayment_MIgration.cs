using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcomAppProject.Migrations
{
    /// <inheritdoc />
    public partial class CustomerConfiguredModelPayment_MIgration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerConfiguredModelPayments",
                columns: table => new
                {
                    CustomerConfiguredModelPaymentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerConfiguredModelOrderID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerConfiguredModelPayments", x => x.CustomerConfiguredModelPaymentID);
                    table.ForeignKey(
                        name: "FK_CustomerConfiguredModelPayments_CustomerConfiguredModelOrders_CustomerConfiguredModelOrderID",
                        column: x => x.CustomerConfiguredModelOrderID,
                        principalTable: "CustomerConfiguredModelOrders",
                        principalColumn: "CustomerConfiguredModelOrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerConfiguredModelPayments_CustomerConfiguredModelOrderID",
                table: "CustomerConfiguredModelPayments",
                column: "CustomerConfiguredModelOrderID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerConfiguredModelPayments");
        }
    }
}
