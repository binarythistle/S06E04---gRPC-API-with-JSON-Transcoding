using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoGrpc.Migrations
{
    /// <inheritdoc />
    public partial class AddState : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ToDoStatus",
                table: "ToDoItems",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ToDoStatus",
                table: "ToDoItems");
        }
    }
}
