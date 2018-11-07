using Microsoft.EntityFrameworkCore.Migrations;

namespace jualapi.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "Title", "Votes" },
                values: new object[,]
                {
                    { -1, "Code works with pure and simple magic, there is no rhyme or reason, it is literally generated from thin air", "How does code work?", 0 },
                    { -2, "Code works with pure and simple magic, there is no rhyme or reason, it is literally generated from thin air", "How does code work?", 10 },
                    { -3, "Code works with pure and simple magic, there is no rhyme or reason, it is literally generated from thin air", "How does code work?", 110 },
                    { -4, "Code works with pure and simple magic, there is no rhyme or reason, it is literally generated from thin air", "How does code work?", 10 },
                    { -5, "Code works with pure and simple magic, there is no rhyme or reason, it is literally generated from thin air", "How does code work?", 11 },
                    { -6, "Code works with pure and simple magic, there is no rhyme or reason, it is literally generated from thin air", "How does code work?", 9 },
                    { -7, "Code works with pure and simple magic, there is no rhyme or reason, it is literally generated from thin air", "How does code work?", 10 },
                    { -8, "Code works with pure and simple magic, there is no rhyme or reason, it is literally generated from thin air", "How does code work?", 0 },
                    { -9, "Code works with pure and simple magic, there is no rhyme or reason, it is literally generated from thin air", "How does code work?", 0 },
                    { -10, "Code works with pure and simple magic, there is no rhyme or reason, it is literally generated from thin air", "How does code work?", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
