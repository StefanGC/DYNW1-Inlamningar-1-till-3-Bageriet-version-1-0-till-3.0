using Microsoft.EntityFrameworkCore.Migrations;

namespace Bakery.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Breads",
                columns: table => new
                {
                    BreadId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    LongDescription = table.Column<string>(nullable: true),
                    AllergyInformation = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    ImageThumbnailUrl = table.Column<string>(nullable: true),
                    IsBreadOfTheWeek = table.Column<bool>(nullable: false),
                    InStock = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Breads", x => x.BreadId);
                    table.ForeignKey(
                        name: "FK_Breads_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "White breads", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Dark breads", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Coffee breads", null });

            migrationBuilder.InsertData(
                table: "Breads",
                columns: new[] { "BreadId", "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsBreadOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, "", 1, "https://cdn.pixabay.com/photo/2017/04/01/12/36/bread-2193537_960_720.jpg", "https://cdn.pixabay.com/photo/2017/04/01/12/36/bread-2193537_960_720.jpg", true, true, "Älskade limpmacka! Nu Sverige mest sålda limpa. PågenLimpan var en av de första skivade limporna när den lanserades i början av 90-talet. Den klassiska svenska limpan är bakad på vete och siktat rågmjöl som tillsammans med surdeg och sirap ger en härlig mjuk och saftigt limpa. Njut av en Svensk klassiker!", "Limpan", 20m, "Älskade limpmacka!" },
                    { 2, "", 1, "https://cdn.pixabay.com/photo/2018/10/09/20/27/bread-3735903_960_720.jpg", "https://cdn.pixabay.com/photo/2018/10/09/20/27/bread-3735903_960_720.jpg", true, false, "Fantastiskt gott osötat surdegsbröd bakat på de allra finaste råvarorna. Bakat med solmoget vete och få ingredienser – inga konstigheter. Njut av en skiva Levain eller två, när du blir sugen på något gott och härligt!", "Levain", 20m, "Fantastiskt gott osötat surdegsbröd" },
                    { 3, "", 1, "https://cdn.pixabay.com/photo/2015/12/05/11/04/toast-1077984_960_720.jpg", "https://cdn.pixabay.com/photo/2015/12/05/11/04/toast-1077984_960_720.jpg", true, false, "Härligt rostbröd med tydlig och balanserad smak - Jättegott! Lanserades 1960 och är Sveriges första skivade formfranska. Idén kom från USA där just skivad formfranska var oerhört populärt. I Sverige tog vi snabbt till oss den amerikanska trenden med att rosta brödet och JätteFranska blev folkets favorit.", "Jättefranska", 20m, "Härligt rostbröd." },
                    { 4, "", 2, "https://cdn.pixabay.com/photo/2016/10/22/17/10/bread-1761197_960_720.jpg", "https://cdn.pixabay.com/photo/2016/10/22/17/10/bread-1761197_960_720.jpg", true, false, "Bästa starten på dagen! Mer lingon och mindre socker gör LingonGrova Special till ett lite nyttigare alternativ. Sveriges mest älskade bröd ger en riktigt god start på vilken morgon som helst.", "LingonGrova Special", 20m, "Bästa starten på dagen!" },
                    { 5, "", 2, "https://cdn.pixabay.com/photo/2019/11/21/14/46/white-bread-4642686_960_720.jpg", "https://cdn.pixabay.com/photo/2019/11/21/14/46/white-bread-4642686_960_720.jpg", true, false, "Bästa starten på dagen! Sveriges mest älskade bröd är en oumbärlig del av frukosten. Fullkorn, surdeg och svenska lingon gör LingonGrova till en riktigt god start på vilken morgon som helst.", "LingonGrova", 20m, "Bästa starten på dagen!" },
                    { 6, "", 2, "https://cdn.pixabay.com/photo/2018/06/19/09/34/bread-3484107_960_720.jpg", "https://cdn.pixabay.com/photo/2018/06/19/09/34/bread-3484107_960_720.jpg", true, false, "Smakrikt rustikt surdegsbröd med malt och groddade rågkärnor. Bakat med mjöl från vår egen kvarn och få ingredienser – inga konstigheter. Njut av den gyllengräddade skorpan och den milt syrliga smaken!", "Råg Levain", 20m, "Smakrikt rustikt surdegsbröd" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Breads_CategoryId",
                table: "Breads",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Breads");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
