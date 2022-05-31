using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorServerNoteApp.Data.Migrations
{
    public partial class FirstMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    RID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Author = table.Column<string>(type: "TEXT", nullable: false),
                    PubDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", maxLength: 5000, nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Remark = table.Column<string>(type: "TEXT", nullable: false),
                    Tags = table.Column<string>(type: "TEXT", nullable: false),
                    URL = table.Column<string>(type: "TEXT", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: false),
                    CategoryPath = table.Column<string>(type: "TEXT", nullable: false),
                    Topic = table.Column<string>(type: "TEXT", nullable: false),
                    Channel = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.RID);
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "RID", "Author", "Category", "CategoryPath", "Channel", "Content", "CreatedAt", "CreatedBy", "Description", "PubDate", "Remark", "Tags", "Title", "Topic", "URL", "UserName" },
                values: new object[] { -3, "", "", "", "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", " 聯準會不加息？三不，一沒有", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", "美CPI創40年新高？週四聯準會FED升不升息？聯準會的三不一沒有 20211213《楊世光在金錢爆》第2769集", "", "https://www.youtube.com/watch?v=lfVMCJ-H3hE", "" });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "RID", "Author", "Category", "CategoryPath", "Channel", "Content", "CreatedAt", "CreatedBy", "Description", "PubDate", "Remark", "Tags", "Title", "Topic", "URL", "UserName" },
                values: new object[] { -2, "", "", "", "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Polestar will spend the next three years executing a lofty electric vehicle launch schedule that will culminate with the Precept concept.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", "The Polestar Precept is a cypher for the EV automaker", "", "https://techcrunch.com/2021/12/04/the-polestar-precept-is-a-cypher-for-the-ev-automakers-future/", "" });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "RID", "Author", "Category", "CategoryPath", "Channel", "Content", "CreatedAt", "CreatedBy", "Description", "PubDate", "Remark", "Tags", "Title", "Topic", "URL", "UserName" },
                values: new object[] { -1, "", "", "", "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Many apps today are just static files on the front end - HTML and JavaScript", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", "Blazor WebAssembly on Azure Static Web Apps - Scott Hanselman's Blog", "", "https://www.hanselman.com/blog/blazor-webassembly-on-azure-static-web-apps", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notes");
        }
    }
}
