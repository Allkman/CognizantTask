using Microsoft.EntityFrameworkCore.Migrations;

namespace ProgramingCompetition.DAL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RootObjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clientId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    clientSecret = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    script = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    stdin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    language = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    versionIndex = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RootObjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Challenges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RootobjectId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Challenges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Challenges_RootObjects_RootobjectId",
                        column: x => x.RootobjectId,
                        principalTable: "RootObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClassificatorTaskType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChallengeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassificatorTaskType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassificatorTaskType_Challenges_ChallengeId",
                        column: x => x.ChallengeId,
                        principalTable: "Challenges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ClassificatorTaskType",
                columns: new[] { "Id", "ChallengeId", "TaskDescription", "TaskTitle" },
                values: new object[] { 1, null, "Write a code snippet to display first 25 fib numbers", "FibbonacciSequence" });

            migrationBuilder.InsertData(
                table: "ClassificatorTaskType",
                columns: new[] { "Id", "ChallengeId", "TaskDescription", "TaskTitle" },
                values: new object[] { 2, null, "Write a code snippet to display first 25 primary numbers", "PrimaryNumber" });

            migrationBuilder.CreateIndex(
                name: "IX_Challenges_RootobjectId",
                table: "Challenges",
                column: "RootobjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassificatorTaskType_ChallengeId",
                table: "ClassificatorTaskType",
                column: "ChallengeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassificatorTaskType");

            migrationBuilder.DropTable(
                name: "Challenges");

            migrationBuilder.DropTable(
                name: "RootObjects");
        }
    }
}
