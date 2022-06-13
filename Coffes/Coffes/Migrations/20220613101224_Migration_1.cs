using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Coffes.Migrations
{
    public partial class Migration_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TableCoffees_Area_AreaID",
                table: "TableCoffees");

            migrationBuilder.DropTable(
                name: "Area");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.RenameColumn(
                name: "AreaID",
                table: "TableCoffees",
                newName: "AreaId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "TableCoffees",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_TableCoffees_AreaID",
                table: "TableCoffees",
                newName: "IX_TableCoffees_AreaId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "ProductTypes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UnitID",
                table: "Products",
                newName: "UnitId");

            migrationBuilder.RenameColumn(
                name: "TypeID",
                table: "Products",
                newName: "TypeId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Products",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TableID",
                table: "Bills",
                newName: "TableId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Bills",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "BillDetail",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "BillID",
                table: "BillDetail",
                newName: "BillId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "BillDetail",
                newName: "Id");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Unit",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "ProductTypes",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Products",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Bills",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "BillDetail",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Account",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Account",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_TableCoffees_Areas_AreaId",
                table: "TableCoffees",
                column: "AreaId",
                principalTable: "Areas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TableCoffees_Areas_AreaId",
                table: "TableCoffees");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Account");

            migrationBuilder.RenameColumn(
                name: "AreaId",
                table: "TableCoffees",
                newName: "AreaID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TableCoffees",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_TableCoffees_AreaId",
                table: "TableCoffees",
                newName: "IX_TableCoffees_AreaID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ProductTypes",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "UnitId",
                table: "Products",
                newName: "UnitID");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "Products",
                newName: "TypeID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Products",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "TableId",
                table: "Bills",
                newName: "TableID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Bills",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "BillDetail",
                newName: "ProductID");

            migrationBuilder.RenameColumn(
                name: "BillId",
                table: "BillDetail",
                newName: "BillID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BillDetail",
                newName: "ID");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Unit",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "ProductTypes",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Bills",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "BillDetail",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Account",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    AreaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.AreaID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailID);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderID",
                table: "OrderDetails",
                column: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_TableCoffees_Area_AreaID",
                table: "TableCoffees",
                column: "AreaID",
                principalTable: "Area",
                principalColumn: "AreaID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
