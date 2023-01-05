using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YemekSitesi.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Material = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    IsHome = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsApproved = table.Column<bool>(type: "INTEGER", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "date('now')"),
                    CookingTime = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodCategory",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCategory", x => new { x.FoodId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_FoodCategory_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodCategory_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "Sizler için özenle hazırlanmış Çorba Tariflerimiz burada bulunmaktadır", "Çorba", "corba" },
                    { 2, "Sizler için özenle hazırlanmış Kurabiye Tariflerimiz burada bulunmaktadır", "Kurabiye", "kurabiye" },
                    { 3, "Sizler için özenle hazırlanmış Tatlı Tariflerimiz burada bulunmaktadır", "Tatlı", "tatlı" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CookingTime", "Description", "ImageUrl", "IsApproved", "IsHome", "Material", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "25dk", "Öncelikle domatesler rendelenir. Ardından tereyağı ve sıvı yağ tencereye alınır, tereyağı eritilir.Tereyağı eridikten sonra un eklenerek biraz kavrulur. Unun kokusu çıktıktan sonra domates salçası eklenir ve biraz karıştırılarak kavrulurRendelenmiş domatesler eklenir. 3-4 dakika daha kavrulur. 4 su bardağı su eklenerek çırpılır, kısık ateşte pişmeye bırakılır. Dilerseniz bu aşamada veya servisten önce çorbayı blenderdan geçirerek pürüzsüz bir kıvam almasını sağlayabilirsiniz.Tuz ve süt eklenerek karıştırılır. Tuz miktarını kendi damak zevkinize göre ayarlayabilirsiniz. Hazır olan çorba ocaktan alınarak kaselere paylaştırılır. İsteğe göre üzerine kaşar peyniri rendesi ve karabiber serpilir.Nefis Sütlü domates çorbası tarifimiz servise hazır. Deneyeceklere afiyet olsun.", "corba1.png", true, true, "2 yemek kaşığı sıvı yağ, 1 yemek kaşığı tereyağı, 2 tepeleme yemek kaşığı un, yemek kaşığı domates salçası, 5 adet domates, 4 su bardağı su, Yarım su bardağı süt, 1 silme tatlı kaşığı tuz", "Sütlü Domates Çorbası", "sütlü-domates-corbasi" },
                    { 2, "10dk", "Ezogelin çorbası yapmak için düdüklü tencerede önce rendelemiş olduğumuz soğanı ve ezmiş olduğumuz sarımsağı tereyağında kavuruyoruz.Soğanlar diriliğini kaybetsin yeterli yakmadan orta ateşte kavuralım. Soğanlar kavrulunca naneyi, kırmızı biberi ve salçayı ilave edip. Kavurmaya devam edelim.Bir iki karıştırdıktan sonra yıkadığımız mercimeği, pirinci, bulguru ve tuzunu da ilave ederek karıştıralım.Başka bir tarafta kaynamakta olan 2 litreye yakın suyu üzerine boşaltalım.Düdüklünün kapağını ve düdüğünü kapattıktan sonra 10 dakika pişiriyoruz. Deneyeceklere afiyet olsun.", "corba2.png", false, false, "1 su bardağı kırmızı mercimek, 1 tatlı kaşığı pirinç, 1 tatlı kaşığı bulgur, 2 çay kaşığı pul biber, 1 yemek kaşığı nane, 2 diş sarımsak, 1 orta boy soğan, 1 yemek kaşığı biber salçası, 1 yemek kaşığı tereyağı, 2 litreye yakın sıcak su, Tuz", "Ezogelin Çorbası", "ezogelin-corbasi" },
                    { 3, "15dk", "Kırmızı mercimek çorbası için sıvı yağı tencereye alınarak yemeklik doğranan soğanlar hafif pembeleşinceye kadar kavrulur.Daha sonra un ilave edilerek kısık ateşte kavurmaya devam edilir. Salça kullanılacak ise salça ilave edilir, kavrulduktan sonra küp küp doğranmış havuç ve iyice yıkanıp suyu süzülen mercimekler ilave edilir.Üzerine su eklenerek karıştırılır ve tencerenin kapağı kapatılır. Çorba piştikten sonra el blenderı ile güzelce ezilir.Karabiber, tuz ve isteğe bağlı olarak kimyon eklenir ve karıştırılır. 5 dakika daha pişirelerek ocaktan alınır.Bu arada küçük bir tavaya iki yemek kaşığı tereyağı alınır, kızdırılır ve bir tatlı kaşığı kırmızı toz biber eklenerek ocaktan alınırBir dilim limon ile servis edilir. Deneyeceklere afiyet olsun", "corba3.png", true, false, "2 su bardağı kırmızı mercimek, 1 adet soğan, 2 yemek kaşığı un, 1 adet havuç, 1 tatlı kaşığı tuz, Yarım çay kaşığı karabiber, 1 çay kaşığı kimyon (isteğe bağlı), 2 litre sıcak su, 5 yemek kaşığı sıvı yağ", "Kırmızı Mercimek Çorbası", "kirmizi-mercimek-corbasi" },
                    { 4, "30dk", "Öncelikle tenceremize yoğurt, un ve suyu ilave ederek tel çırpıcı yardımı ile pürüzsüz bir kıvam alana kadar çırpalım.Çorbamız kaynadıktan sonra erişteyi ekleyelim ve kısık ateşte ara ara karıştırarak şehriyeler yumuşayıncaya kadar pişirelim.Tuzumuzu da ekleyelim ve 1-2 dakika daha kaynatarak ocağı kapatalım. Çorbamızı 10 dakika kadar dinlenmeye bırakalım.Sosu için uygun bir sos tavasına tereyağını alalım ve eritelim.Üzerine pul biber ve naneyi ekleyerek kızdıralım ve ocaktan alalım.Çorbamızı kaselere alalım ve üzerine sostan gezdirerek servis edelim. ", "corba4.png", false, false, "1 su bardağı yoğurt, 3 tepeleme yemek kaşığı un, 5 su bardağı su, 1 çay bardağı erişte, 1 silme tatlı kaşığı tuz, 1 yemek kaşığı tereyağı, 1 tatlı kaşığı kırmızı toz biber, 1 tatlı kaşığı nane", "Yoğurt Çorbası", "yogurt-corbasi" },
                    { 5, "20dk", "Brokoliyi, küp küp doğradığınız patatesi, halka halka dilimlenmiş havucu ve doğradığınız soğan bir tencereye koyun.Üzerini geçecek kadar su ilave ederek sebzeler yumuşayana kadar haşlayın. Başka bir tencerede tereyağını eritin ve unu ekleyerek kavurun.Üzerine yavaş yavaş sütü ilave ederek karıştırarak beşamel sosu pişirin. Sebzeleri beşamel sosun üzerine ilave ederek haşlama suyunun da yarısı kadarını tencereye alarak blender ile güzelce ezin.Tuz ve karabiberi ekleyerek 3-4 dakika kadar kaynatın.Son olarak çorbanın süt kremasını ilave edin ve 1-2 taşım kaynattıktan sonra çorbayı ateşten alabilirsiniz. Afiyet olsun.", "corba5.png", false, false, "500 g brokoli, 1 adet havuç, 1 adet orta boy patates, 1 adet soğan, Sıcak su (üzerini geçecek kadar), 2 su bardağı süt, 1 çay bardağı süt kreması, 2 yemek kaşığı tereyağ, 1 yemek kaşığı un, Tuz, Karabiber", "Brokoli Çorbası", "brokoli-corbasi" },
                    { 6, "15dk", "İlk olarak sıvı yağ ve tereyağı karıştırılır. Sonra diğer malzemeler eklenir karıştırılır. En son un eklenip kulak memesi kıvamında hamur elde ediyoruz, fazla yumuşakolmasın hamur çünkü kurabiyelerimiz dağılabilir.Resimdeki gibi yada istediğiniz gibi şekil verip üstüne yumurta sarısı sürüp susam, çörek otu serpin. Bu malzemelerden iki tepsi kurabiye çıkmaktadır Afiyet olsun.", "kurabiye1.png", true, true, "250 gram margarin veya tereyağı, 2 yemek kaşığı sıvı yağ, 2 yemek kaşığı toz şeker, 2 yemek kaşığı sirke, 1 paket kabartma tozu, 1 tatlı kaşığı tuz, Aldığı kadar un,1 yumurta sarısı, Susam ve çörekotu", "Tuzlu Kurabiye", "tuzlu-kurabiye" },
                    { 7, "20dk", "Margarin yada tereyağı, sıvı yağ ve pudra şekerinin 1 su bardağını yoğuruyoruz. Kalan yarım bardaklık pudra şekeri üzeri için kullanılacak5 dk. yoğurduktan sonra nişasta ve unu ilave ediyoruz. İyice yoğuracağız çünkü hamur parçalanacaktırŞekil verirken 2 adet ceviz büyüklüğünde bir parça koparıp rulo şekline getirin. Sağ, sol ve üst kısmına çatalla şekil verip yan yan kesinTepsiyi yağlamayın hamur zaten yağlı. Kurabiyeleri tepsiye dizinÖnceden ısıtılmış fakat ılık olmalı 160 derecelik fırında 15 dk. pişirin. Deneyeceklere afiyet olsun", "kurabiye2.png", false, true, "1 paket tereyağı ya da margarin, 1 kahve fincanı sıvı yağ, 4 çorba kaşığı buğday nişastası, 1 su bardağı pudra şekeri, Aldığı kadar un", "Un Kurabiyesi", "un-kurabiyesi" },
                    { 8, "25dk", "İlk olarak yoğurma kabına oda sıcaklığındaki tereyağı, pudra şekeri, yumurta sarısını alarak yoğuralım.Daha sonra un ve kabartma tozu ilave edip kulak memesi kıvamına gelecek şekilde yoğuruyoruz. Ayrı bir kabın içerisine fındık kırığı ile şekeri karıştıralım.Hamurdan parçalar kopartarak yuvarlayıp önce yumurta akına batırıp kırılmış fındık ve şeker karışımına bulayalım.180 derece fırında hafif kızarıncaya kadar yaklaşık 25 dakika pişiriyoruz. Afiyet olsun.", "kurabiye3.png", false, true, "250 gram tereyağı, 1 su bardağı pudra şekeri, 1 yumurta sarısı (akı üzerine), 1 paket kabartma tozu, Aldığı kadar un, 1 çay bardağı fındık kırığı, 1 yemek kaşığı toz şeker, Yumurta akı", "5 Dakika Kurabiyesi", "5-dakika-kurabiyesi" },
                    { 9, "25dk", "Tereyağı nın Üzerine pudra şekeri, sıvı yağ, yumurta akı, vanilya, kabartma tozu, tarçın ve unun bir kısmını alarak yoğuralım. Unu yavaş yavaş ilave ederek ele yapışmayan yumuşak kıvamlı bir hamur elde edelim.Hamurumuz istediğimiz kıvama geldikten sonra cevizi de ekleyelim ve son kez yoğuralım.Tüm hamurumuz bitene kadar şekillendirelim. Kurabiyelerimizi önceden ısıttığımız 160 derece fırında yaklaşık 25 dakika pişmeye bırakalım. Afiyet Olsun", "kurabiye4.png", false, true, "250 gr margarin veya tereyağı, Yarım çay bardağı sıvı yağ, 1 çay bardağı pudra şekeri, 1 adet yumurta akı, 1 çay bardağı ince dövülmüş ceviz, 1 çay kaşığı tepeleme dolu tarçın, 1 paket vanilya, 1 paket kabartma tozu,4,5-5 su bardağı un", "Tarçınlı Cevizli Kurabiye", "tarcinli-cevizli-kurabiye" },
                    { 10, "15dk", "Oda ısısında yumuşamış margarini ve pudra şekerini iyice karıştıralım. Yumurtayı ekleyip karıştıralım.Un, kabartma tozu ve vanilyayı eleyerek ilave edip yoğuralım. En son damla çikolatayı ekleyip yoğuralım.Önceden ısıtılmış fırında 180 derecede yaklaşık 10-15 dakika kadar pişirelim. Soğuyunca servis yapalım.", "kurabiye5.png", true, true, "100 gram tereyağı veya margarin, 1 adet yumurta, 1 su bardağı damla çikolata, 1 su bardağı pudra şekeri, 2,5 su bardağı un, 1 paket vanilya, 1 paket kabartma tozu", "Damla Çikolatalı Kurabiye", "damla-cikolatali-kurabiye" },
                    { 11, "30dk", "Pirinçleri güzelce yıkadıktan sonra 2 su bardağı su ile pişene kadar haşlayın.Haşlanan pirinçlerin üzerine sütü, vanilyayı ilave edip kaynatınKarışım kaynamaya başlayınca şekeri ve yarım su bardağı sütle karıştırdığınız 3 yemek kaşığı buğday nişastasını ilave ediniz.10 - 15 dk.daha kaynatıp altını kapatın. . Fırın için uygun ısıya dayanıklı sütlaç kaselerine sütlaçlarınızı paylaştırın.Tepsinize soğuk su doldurun ve sütlaç kaplarını fırın tepsinize dizin. Tepsiyi fırınınızın en üst rafına yerleştirin.180 derecede, sütlaçlarınız kızarana kadar fırınlayın. Afiyet olsun.", "tatlı1.png", false, true, "1 litre süt,  1 su bardağı şeker,  Yarım su bardağı pirinç,  3 yemek kaşığı buğday nişastası,  1 paket vanilya, 2 su bardağı su, yarım su bardağı süt", "Fırında Sütlaç", "firinda-sütlaç" },
                    { 12, "13dk", "Yumurta ve şekeri el çırpıcısı ile çırpıyoruz.Üzerine diğer malzemeleri ekleyip kek kıvamını elde ediyoruz. Sufle kaplarına döküp üzerine parça çikolata koyuyoruz.Tencerenin içine kaynar suyu döküyoruz.İçine sufleleri koyup kapağını kapatıyoruz.Yaklaşık 7 - 8 dakika pişiriyoruz. Afiyet şeker olsun ", "tatlı2.png", true, true, "1 adet yumurta, Yarım çay bardağı şeker, Yarım çay bardağı sıvı yağ, Yarım çay bardağı süt, 2,5 3 yemek kaşığı un, 1 yemek kaşığı kakao, 1 paket vanilya, 1 çay kaşığı kabartma tozu,2 parça çikolata", "Sufle", "sufle" }
                });

            migrationBuilder.InsertData(
                table: "FoodCategory",
                columns: new[] { "CategoryId", "FoodId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 3, 7 },
                    { 3, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 3, 10 },
                    { 3, 11 },
                    { 2, 12 },
                    { 3, 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodCategory_CategoryId",
                table: "FoodCategory",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodCategory");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Foods");
        }
    }
}
