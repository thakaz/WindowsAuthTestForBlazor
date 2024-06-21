using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Windows認証テスト.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    user_id = table.Column<string>(type: "text", nullable: false, comment: "ユーザーID"),
                    role = table.Column<int>(type: "integer", nullable: false, comment: "権限コード")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.user_id);
                },
                comment: "ログイン管理用");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
