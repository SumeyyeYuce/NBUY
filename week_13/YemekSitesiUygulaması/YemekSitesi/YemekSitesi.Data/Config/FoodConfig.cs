using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using YemekSitesi.Entity.Concrete;

namespace YemekSitesi.Data.Config
{
    public class FoodConfig : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Id).ValueGeneratedOnAdd();

            builder.Property(f => f.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(f => f.Description)
                .IsRequired();
               

            builder.Property(f => f.Material)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(f => f.ImageUrl)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(f => f.Url)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(f => f.DateAdded)
                .IsRequired()
                .HasDefaultValueSql("date('now')");

            builder.Property(f => f.CookingTime)
                .IsRequired()
                .HasMaxLength(250);

            builder.ToTable("Foods");

            builder.HasData(

            #region Corbalar
          
                new Food
                {
                    Id=1,
                    Name="Sütlü Domates Çorbası",

                    Description= "Öncelikle domatesler rendelenir. Ardından tereyağı ve sıvı yağ tencereye alınır, tereyağı eritilir.Tereyağı eridikten sonra un eklenerek biraz kavrulur. Unun kokusu çıktıktan sonra domates salçası eklenir ve biraz karıştırılarak kavrulurRendelenmiş domatesler eklenir. 3-4 dakika daha kavrulur. 4 su bardağı su eklenerek çırpılır, kısık ateşte pişmeye bırakılır. Dilerseniz bu aşamada veya servisten önce çorbayı blenderdan geçirerek pürüzsüz bir kıvam almasını sağlayabilirsiniz.Tuz ve süt eklenerek karıştırılır. Tuz miktarını kendi damak zevkinize göre ayarlayabilirsiniz. Hazır olan çorba ocaktan alınarak kaselere paylaştırılır. İsteğe göre üzerine kaşar peyniri rendesi ve karabiber serpilir.Nefis Sütlü domates çorbası tarifimiz servise hazır. Deneyeceklere afiyet olsun.",

                    Material= "2 yemek kaşığı sıvı yağ, 1 yemek kaşığı tereyağı, 2 tepeleme yemek kaşığı un, yemek kaşığı domates salçası, 5 adet domates, 4 su bardağı su, Yarım su bardağı süt, 1 silme tatlı kaşığı tuz",
                    ImageUrl="corba1.png",
                    Url="sütlü-domates-corbasi",
                    IsHome=true,
                    IsApproved=false,
                    CookingTime="25dk",                   
                },
                new Food
                {
                    Id=2,
                    Name="Ezogelin Çorbası",
                    Description= "Ezogelin çorbası yapmak için düdüklü tencerede önce rendelemiş olduğumuz soğanı ve ezmiş olduğumuz sarımsağı tereyağında kavuruyoruz.Soğanlar diriliğini kaybetsin yeterli yakmadan orta ateşte kavuralım. Soğanlar kavrulunca naneyi, kırmızı biberi ve salçayı ilave edip. Kavurmaya devam edelim.Bir iki karıştırdıktan sonra yıkadığımız mercimeği, pirinci, bulguru ve tuzunu da ilave ederek karıştıralım.Başka bir tarafta kaynamakta olan 2 litreye yakın suyu üzerine boşaltalım.Düdüklünün kapağını ve düdüğünü kapattıktan sonra 10 dakika pişiriyoruz. Deneyeceklere afiyet olsun.",

                    Material= "1 su bardağı kırmızı mercimek, 1 tatlı kaşığı pirinç, 1 tatlı kaşığı bulgur, 2 çay kaşığı pul biber, 1 yemek kaşığı nane, 2 diş sarımsak, 1 orta boy soğan, 1 yemek kaşığı biber salçası, 1 yemek kaşığı tereyağı, 2 litreye yakın sıcak su, Tuz",
                    ImageUrl="corba2.png",
                    Url="ezogelin-corbasi",
                    IsHome=false,
                    IsApproved=false,
                    CookingTime="10dk",
                },
                new Food
                {
                    Id=3,
                    Name="Kırmızı Mercimek Çorbası",

                    Description= "Kırmızı mercimek çorbası için sıvı yağı tencereye alınarak yemeklik doğranan soğanlar hafif pembeleşinceye kadar kavrulur.Daha sonra un ilave edilerek kısık ateşte kavurmaya devam edilir. Salça kullanılacak ise salça ilave edilir, kavrulduktan sonra küp küp doğranmış havuç ve iyice yıkanıp suyu süzülen mercimekler ilave edilir.Üzerine su eklenerek karıştırılır ve tencerenin kapağı kapatılır. Çorba piştikten sonra el blenderı ile güzelce ezilir.Karabiber, tuz ve isteğe bağlı olarak kimyon eklenir ve karıştırılır. 5 dakika daha pişirelerek ocaktan alınır.Bu arada küçük bir tavaya iki yemek kaşığı tereyağı alınır, kızdırılır ve bir tatlı kaşığı kırmızı toz biber eklenerek ocaktan alınırBir dilim limon ile servis edilir. Deneyeceklere afiyet olsun",

                    Material= "2 su bardağı kırmızı mercimek, 1 adet soğan, 2 yemek kaşığı un, 1 adet havuç, 1 tatlı kaşığı tuz, Yarım çay kaşığı karabiber, 1 çay kaşığı kimyon (isteğe bağlı), 2 litre sıcak su, 5 yemek kaşığı sıvı yağ",
                    ImageUrl="corba3.png",
                    Url="kirmizi-mercimek-corbasi",
                    IsHome=false,
                    IsApproved=false,
                    CookingTime="15dk",
                },
                new Food
                {
                    Id=4,
                    Name="Yoğurt Çorbası",
                    Description= "Öncelikle tenceremize yoğurt, un ve suyu ilave ederek tel çırpıcı yardımı ile pürüzsüz bir kıvam alana kadar çırpalım.Çorbamız kaynadıktan sonra erişteyi ekleyelim ve kısık ateşte ara ara karıştırarak şehriyeler yumuşayıncaya kadar pişirelim.Tuzumuzu da ekleyelim ve 1-2 dakika daha kaynatarak ocağı kapatalım. Çorbamızı 10 dakika kadar dinlenmeye bırakalım.Sosu için uygun bir sos tavasına tereyağını alalım ve eritelim.Üzerine pul biber ve naneyi ekleyerek kızdıralım ve ocaktan alalım.Çorbamızı kaselere alalım ve üzerine sostan gezdirerek servis edelim. ",

                    Material= "1 su bardağı yoğurt, 3 tepeleme yemek kaşığı un, 5 su bardağı su, 1 çay bardağı erişte, 1 silme tatlı kaşığı tuz, 1 yemek kaşığı tereyağı, 1 tatlı kaşığı kırmızı toz biber, 1 tatlı kaşığı nane",
                    ImageUrl="corba4.png",
                    Url="yogurt-corbasi",
                    IsHome=false,
                    IsApproved=false,
                    CookingTime="30dk",
                }, 
                new Food
                {
                    Id = 5,
                    Name = "Brokoli Çorbası",
                    Description = "Brokoliyi, küp küp doğradığınız patatesi, halka halka dilimlenmiş havucu ve doğradığınız soğan bir tencereye koyun.Üzerini geçecek kadar su ilave ederek sebzeler yumuşayana kadar haşlayın. Başka bir tencerede tereyağını eritin ve unu ekleyerek kavurun.Üzerine yavaş yavaş sütü ilave ederek karıştırarak beşamel sosu pişirin. Sebzeleri beşamel sosun üzerine ilave ederek haşlama suyunun da yarısı kadarını tencereye alarak blender ile güzelce ezin.Tuz ve karabiberi ekleyerek 3-4 dakika kadar kaynatın.Son olarak çorbanın süt kremasını ilave edin ve 1-2 taşım kaynattıktan sonra çorbayı ateşten alabilirsiniz. Afiyet olsun.",

                    Material = "500 g brokoli, 1 adet havuç, 1 adet orta boy patates, 1 adet soğan, Sıcak su (üzerini geçecek kadar), 2 su bardağı süt, 1 çay bardağı süt kreması, 2 yemek kaşığı tereyağ, 1 yemek kaşığı un, Tuz, Karabiber",
                    ImageUrl = "corba5.png",
                    Url = "brokoli-corbasi",
                    IsHome = false,
                    IsApproved = false,
                    CookingTime = "20dk",
                },
            #endregion

            #region Kurabiyeler
          
                new Food
                {
                    Id=6,
                    Name="Tuzlu Kurabiye",
                    Description= "İlk olarak sıvı yağ ve tereyağı karıştırılır. Sonra diğer malzemeler eklenir karıştırılır. En son un eklenip kulak memesi kıvamında hamur elde ediyoruz, fazla yumuşakolmasın hamur çünkü kurabiyelerimiz dağılabilir.Resimdeki gibi yada istediğiniz gibi şekil verip üstüne yumurta sarısı sürüp susam, çörek otu serpin. Bu malzemelerden iki tepsi kurabiye çıkmaktadır Afiyet olsun.",

                    Material= "250 gram margarin veya tereyağı, 2 yemek kaşığı sıvı yağ, 2 yemek kaşığı toz şeker, 2 yemek kaşığı sirke, 1 paket kabartma tozu, 1 tatlı kaşığı tuz, Aldığı kadar un,1 yumurta sarısı, Susam ve çörekotu",
                    ImageUrl="kurabiye1.png",
                    Url="tuzlu-kurabiye",
                    IsHome=true,
                    IsApproved=false,
                    CookingTime="15dk",
                }, 
                new Food
                {
                    Id = 7,
                    Name = "Un Kurabiyesi",
                    Description = "Margarin yada tereyağı, sıvı yağ ve pudra şekerinin 1 su bardağını yoğuruyoruz. Kalan yarım bardaklık pudra şekeri üzeri için kullanılacak5 dk. yoğurduktan sonra nişasta ve unu ilave ediyoruz. İyice yoğuracağız çünkü hamur parçalanacaktırŞekil verirken 2 adet ceviz büyüklüğünde bir parça koparıp rulo şekline getirin. Sağ, sol ve üst kısmına çatalla şekil verip yan yan kesinTepsiyi yağlamayın hamur zaten yağlı. Kurabiyeleri tepsiye dizinÖnceden ısıtılmış fakat ılık olmalı 160 derecelik fırında 15 dk. pişirin. Deneyeceklere afiyet olsun",

                    Material = "1 paket tereyağı ya da margarin, 1 kahve fincanı sıvı yağ, 4 çorba kaşığı buğday nişastası, 1 su bardağı pudra şekeri, Aldığı kadar un",
                    ImageUrl = "kurabiye2.png",
                    Url = "un-kurabiyesi",
                    IsHome = true,
                    IsApproved = false,
                    CookingTime = "20dk",
                }, 
                new Food
                {
                    Id = 8,
                    Name = "5 Dakika Kurabiyesi",
                    Description = "İlk olarak yoğurma kabına oda sıcaklığındaki tereyağı, pudra şekeri, yumurta sarısını alarak yoğuralım.Daha sonra un ve kabartma tozu ilave edip kulak memesi kıvamına gelecek şekilde yoğuruyoruz. Ayrı bir kabın içerisine fındık kırığı ile şekeri karıştıralım.Hamurdan parçalar kopartarak yuvarlayıp önce yumurta akına batırıp kırılmış fındık ve şeker karışımına bulayalım.180 derece fırında hafif kızarıncaya kadar yaklaşık 25 dakika pişiriyoruz. Afiyet olsun.",

                    Material = "250 gram tereyağı, 1 su bardağı pudra şekeri, 1 yumurta sarısı (akı üzerine), 1 paket kabartma tozu, Aldığı kadar un, 1 çay bardağı fındık kırığı, 1 yemek kaşığı toz şeker, Yumurta akı",
                    ImageUrl = "kurabiye3.png",
                    Url = "5-dakika-kurabiyesi",
                    IsHome = true,
                    IsApproved = false,
                    CookingTime = "25dk",
                }, 
                new Food
                {
                    Id = 9,
                    Name = "Tarçınlı Cevizli Kurabiye",
                    Description = "Tereyağı nın Üzerine pudra şekeri, sıvı yağ, yumurta akı, vanilya, kabartma tozu, tarçın ve unun bir kısmını alarak yoğuralım. Unu yavaş yavaş ilave ederek ele yapışmayan yumuşak kıvamlı bir hamur elde edelim.Hamurumuz istediğimiz kıvama geldikten sonra cevizi de ekleyelim ve son kez yoğuralım.Tüm hamurumuz bitene kadar şekillendirelim. Kurabiyelerimizi önceden ısıttığımız 160 derece fırında yaklaşık 25 dakika pişmeye bırakalım. Afiyet Olsun",

                    Material = "250 gr margarin veya tereyağı, Yarım çay bardağı sıvı yağ, 1 çay bardağı pudra şekeri, 1 adet yumurta akı, 1 çay bardağı ince dövülmüş ceviz, 1 çay kaşığı tepeleme dolu tarçın, 1 paket vanilya, 1 paket kabartma tozu,4,5-5 su bardağı un",
                    ImageUrl = "kurabiye4.png",
                    Url = "tarcinli-cevizli-kurabiye",
                    IsHome = true,
                    IsApproved = false,
                    CookingTime = "25dk",
                },
                new Food
                {
                    Id = 10,
                    Name = "Damla Çikolatalı Kurabiye",
                    Description = "Oda ısısında yumuşamış margarini ve pudra şekerini iyice karıştıralım. Yumurtayı ekleyip karıştıralım.Un, kabartma tozu ve vanilyayı eleyerek ilave edip yoğuralım. En son damla çikolatayı ekleyip yoğuralım.Önceden ısıtılmış fırında 180 derecede yaklaşık 10-15 dakika kadar pişirelim. Soğuyunca servis yapalım.",

                    Material = "100 gram tereyağı veya margarin, 1 adet yumurta, 1 su bardağı damla çikolata, 1 su bardağı pudra şekeri, 2,5 su bardağı un, 1 paket vanilya, 1 paket kabartma tozu",
                    ImageUrl = "kurabiye5.png",
                    Url = "damla-cikolatali-kurabiye",
                    IsHome = true,
                    IsApproved = false,
                    CookingTime = "15dk",
                },
            #endregion

            #region Tatlılar
      
                new Food
                {

                    Id = 11,
                    Name = "Fırında Sütlaç",
                    Description = "Pirinçleri güzelce yıkadıktan sonra 2 su bardağı su ile pişene kadar haşlayın.Haşlanan pirinçlerin üzerine sütü, vanilyayı ilave edip kaynatınKarışım kaynamaya başlayınca şekeri ve yarım su bardağı sütle karıştırdığınız 3 yemek kaşığı buğday nişastasını ilave ediniz.10 - 15 dk.daha kaynatıp altını kapatın. . Fırın için uygun ısıya dayanıklı sütlaç kaselerine sütlaçlarınızı paylaştırın.Tepsinize soğuk su doldurun ve sütlaç kaplarını fırın tepsinize dizin. Tepsiyi fırınınızın en üst rafına yerleştirin.180 derecede, sütlaçlarınız kızarana kadar fırınlayın. Afiyet olsun.",

                    Material = "1 litre süt,  1 su bardağı şeker,  Yarım su bardağı pirinç,  3 yemek kaşığı buğday nişastası,  1 paket vanilya, 2 su bardağı su, yarım su bardağı süt",

                    ImageUrl ="tatlı1.png",
                    Url ="firinda-sütlaç",
                    IsHome = true,
                    IsApproved = false,
                    CookingTime = "30dk",
                },
                new Food

                {
                   Id = 12,
                   Name = "Sufle", 
                   Description = "Yumurta ve şekeri el çırpıcısı ile çırpıyoruz.Üzerine diğer malzemeleri ekleyip kek kıvamını elde ediyoruz. Sufle kaplarına döküp üzerine parça çikolata koyuyoruz.Tencerenin içine kaynar suyu döküyoruz.İçine sufleleri koyup kapağını kapatıyoruz.Yaklaşık 7 - 8 dakika pişiriyoruz. Afiyet şeker olsun ",

                   Material ="1 adet yumurta, Yarım çay bardağı şeker, Yarım çay bardağı sıvı yağ, Yarım çay bardağı süt, 2,5 3 yemek kaşığı un, 1 yemek kaşığı kakao, 1 paket vanilya, 1 çay kaşığı kabartma tozu,2 parça çikolata",
                   ImageUrl ="tatlı2.png",
                   Url ="sufle",
                   IsHome = false,
                   IsApproved = false,
                   CookingTime = "13dk",

                }

                #endregion
                );
                
        }
    }
}
