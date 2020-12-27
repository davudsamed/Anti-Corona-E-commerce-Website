using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Anti_Corona.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: true),
                    Stock = table.Column<int>(nullable: false),
                    IsHomePage = table.Column<bool>(nullable: false),
                    IsOnSale = table.Column<bool>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ImageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_Images_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "maske.jpg", "Maskeler" },
                    { 2, "eldiven.jpg", "Eldivenler" },
                    { 3, "dezenfektan.jpg", "Dezenfektanlar" },
                    { 4, "siperlik.jpg", "Siperlikler" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Date", "Description", "IsHomePage", "IsOnSale", "Price", "Stock", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 12, 27, 13, 30, 50, 0, DateTimeKind.Unspecified), "Hayat Kimya olarak, hijyen ve temizlik kategorilerindeki 33 yıllık deneyimimizi Evony markamızla cerrahi maske kategorisine taşıyoruz. TSE Tip2R ve TSE Güvenli Üretim sertifikalı Evony Maske %99 a kadar bakteri filtrasyonu sağlamaktadır. 3 katmanlı, Melt Blown+ Spunbond cilde dost katmanlar. Tek katmanda değil her katmanda koruma. Pamuksu Yumuşak katmanlarla saatlerce rahat kullanım. Acıtmayan Yumuşak Elastik Kulaklarıyla koruma ve konforu bir arada. Yüze tam uyumlu Burun Teli. Alerji Yapmaz. Latex İçermez. Paraben içermez. Naylon İçermez. CE sertifikalı. TSE Tip2R , EN14683, ISO13485, TSE Güvenli ", true, true, 100.0, 100, "Evony Yumuşak Elastik Kulaklı Maske 100 Adet" },
                    { 2, 1, new DateTime(2020, 12, 26, 12, 30, 50, 0, DateTimeKind.Unspecified), "1 Kutuda 50 adet bulunmaktadır. 2 Kutu Gönderilecektir.Hava Geçiren Yapı.Yumuşak ve Ayarlanabilir, Tahriş etmez, Rahat takılır.Fiberglass ve Lateks İçermiyor.Filtreli, Üç katlı, tek kullanımlık, lastikli, 3 kıvrımlı.Polipropilen / Non-Woven.Yuvarlak lastikli ultrasonik dikişlidir.Kullanımda rahatlık.Lateks içermez.Hava geçirgen, kolay nefes almayı sağlayan RC cerrahi maske non woven kumaştan üretilmiştir.Gipe lastik kullanılan bu maske tek kullanımlık olup hijyenik ve CE'li dir.Yüze tam uyumludur.", true, true, 200.0, 200, "Smask Cerrahi Telli 3 Katlı Nonwoven Filtreli Maske 50'li 2 Adet" },
                    { 3, 1, new DateTime(2020, 12, 26, 12, 30, 50, 0, DateTimeKind.Unspecified), "Happy Yumuşak Elastik Kulaklı 3 Katlı Telli Mavi Cerrahi Maske 50 li x 2 Adet,Acıtmayan yumuşak elastik kulaklarıyla koruma ve konforu bir arada,Yüze tam uyumlu burun teli,Alerji Yapmaz,Latex İçermez,Klor içermez,Naylon İçermez,Ce Sertifikalı,FDA , ISO 13485 ", true, true, 200.0, 200, "3 katmanlı, MeltBlown + Spunbond cilde dost katmanlar,Tek katmanda değil her katmanda koruma,Tek katmanda değil her katmanda koruma" },
                    { 7, 2, new DateTime(2020, 12, 26, 12, 30, 50, 0, DateTimeKind.Unspecified), "Beybi tek kullanımlık eldiven, elin şeklini alarak kolay hareket imkanı sağlar. Tek kullanımlık eldiven ile yemekler hijyenik bir şekilde hazırlanır. Hem temizlik hem de yemek yapımı sırasında ellerin kurumasını, kirlenmesini ve tahriş olmasını önler.Tek kullanımlıkMiktar : Kutu içerisinde 100 AdetRenk : Beyaz", true, true, 200.0, 200, "Beybi Latex Pudralı Çok Amaçlı Kullan At Eldiven Lateks 100' lü (L) Large / Büyük" },
                    { 8, 2, new DateTime(2020, 12, 26, 12, 30, 50, 0, DateTimeKind.Unspecified), "Pudrasız Lateks Eldiven (Large)- Pudrasız Lateks Eldivenler, Hijyen Gerektiren Tüm Ortamlarda, Elle Bulaşması Muhtemel Mikrop, Virüs Ve Bakterilere Karşı Koruyucudur. - Doğal Lateks Hammaddeden Üretilmiştir. - Giymesi Ve Çıkartması Kolaydır. - Yumuşak Ve Elastik Yapısı Sayesinde Elinize Tam Oturur. - Hastaneler, Diş Klinikleri, Veterinerler, Laboratuvarlar, İlaç Sektörü, Deterjan Ve Temizlik, Kozmetik Gibi Çok Çeşitli Endüstrilerde Kullanım İçin İdealdir. - Beyaz Renklidir. - Yuvarlak Hatlı Manşeti Sayesinde Kolayca Giyilir Ve Çıkartılır. Özellikle Hastane Kullanımlarında Çok Hızlı Giyilip Çıkartılabilir.", true, true, 200.0, 200, "Pudrasız Lateks Eldiven (Large)" },
                    { 4, 3, new DateTime(2020, 12, 26, 12, 30, 50, 0, DateTimeKind.Unspecified), "Sağlık bakanlığı tarafından Ruhsatnameli, ISO ve CE sertifikalı, Msds Raporu bulunmaktadır. Toplamda % 70 Alkol oranına sahiptir. (% 58 Ethil % 12 İzopropil).Ürüne kullanım esnasında kokusundan dolayı rahatsız etmemesi amacı ile % 002 esans eklenerek herkes tarafından kullanılabilinir hale getirilmiştir.Elde hızlıca kurumaktadır.", true, true, 93.0, 200, "Dermosept Handplus El Dezenfektanı 5000 ml" },
                    { 5, 3, new DateTime(2020, 12, 26, 12, 30, 50, 0, DateTimeKind.Unspecified), "Cildinizde ekonomik ve sağlıklı bir şekilde virüs, bakteri ve mantarlara karşı %100 doğal koruma sağlayarak, hayatınızın her alanında yanınızda taşıyabilmeniz için tasarlanmış bir üründür.  Crystalin Eco Antiseptik Dezenfektan Hijyenik Yaşam Kiti içerisinde bulunan 1 litrelik şişedeki konsantre ürünle 10 litre anti-septik dezenfektan elde ederek aylarca güvenle kullanabilirsiniz.", true, true, 93.0, 200, "Crystalin Eco Dezenfektan Hijyenik Yaşam Kiti" },
                    { 6, 3, new DateTime(2020, 12, 26, 12, 30, 50, 0, DateTimeKind.Unspecified), "Sağlık bakanlığı tarafından Ruhsatnameli, ISO ve CE sertifikalı, Msds Raporu bulunmaktadır. Toplamda % 70 Alkol oranına sahiptir. (% 58 Ethil % 12 İzopropil).Ürüne kullanım esnasında kokusundan dolayı rahatsız etmemesi amacı ile % 002 esans eklenerek herkes tarafından kullanılabilinir hale getirilmiştir.Elde hızlıca kurumaktadır.", true, true, 93.0, 200, "Deep Fresh Antibakteriyel El Temizleme Jeli 3 x 200 ml" },
                    { 9, 4, new DateTime(2020, 12, 26, 12, 30, 50, 0, DateTimeKind.Unspecified), "ÖzgürceSeç Şeffaf Maske Yikanabilir Yeniden Kullanabilabilir Kulakta yara ve iz bırakmaz.Yumuşak malzemeden üretilmiştir.Başta ağrı ve ağırlık hissi yaratmaz.Herkes rahatlıkla kullanabilir.Her bedene göre ayarlanabilir.Maskemizin en alt kısmından hava sirkülasyonu  gerçekleşmektedir.Korucuyu maskedir.Ürün tek kullanımlık değildir.Yıkanabilir.Uzun kullanım süresi  tanımaktadır.Ürünümüzün CE - ISO belgeleri bulunmaktadır.", true, true, 93.0, 200, "ÖzgürceSeç Şeffaf Maske Yikanabilir Yeniden Kullanabilabilir" },
                    { 10, 4, new DateTime(2020, 12, 26, 12, 30, 50, 0, DateTimeKind.Unspecified), "Siperlik klipsi; Koruyucu maskenin burun, ağız ve çene bölgesinde oluşabilecek boşlukları minimuma indirerek Siperliğin yüze tam oturmasını sağlar.", true, true, 93.0, 200, "Tuğbasan Yüz Koruyucu Siperlik" },
                    { 11, 4, new DateTime(2020, 12, 26, 12, 30, 50, 0, DateTimeKind.Unspecified), "Partikül, tükürük, damlacık, toz ve benzeri küçük cisimlerin yüzünüze (göz, ağız, burun) gelmesini ve sizden karşı tarafa gitmesini engeller.Şeffaf siperliksağlık ürünleri yönetmenliğine uygun; kırılmaz, esnet Pet(polietilen) malzemeden üretilmiştir. Karşılıklı konuşma, işlem (muayene, karşılama, satış, toplantı vb.) esnasında kişisel kullanım içindir.Hafiftir, kullanımı kolaydır, çıkarılıp takılması basittir.  Esnek materyal kullanıldığından yetişkin her başa uyum sağlar. Görüş alanınızı kapatmaz, görüş alanı geniştir. Işık geçirgenliği yüksek olduğundan görüntü kaybına neden olmaz. Ürün dezenfekte edilmiş olarak gönderilir ve dezenfekte edilerek tekrar kullanılabilir.", true, true, 59.899999999999999, 200, "Medizer Novid Siyah Gözlüklü Yüz Koruyucu Siperli" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "Description", "ProductId" },
                values: new object[,]
                {
                    { 1, "Güzel maske", 1 },
                    { 2, "Güzel maske1", 2 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "ImageUrl", "ProductId" },
                values: new object[,]
                {
                    { 15, "dezenfektan1.3.jpg", 4 },
                    { 16, "dezenfektan1.4.jpg", 4 },
                    { 17, "dezenfektan2.1.jpg", 5 },
                    { 18, "dezenfektan2.2.jpg", 5 },
                    { 19, "dezenfektan2.3.jpg", 5 },
                    { 20, "dezenfektan2.4.jpg", 5 },
                    { 21, "dezenfektan2.5.jpg", 5 },
                    { 22, "dezenfektan3.1.jpg", 6 },
                    { 23, "dezenfektan3.2.jpg", 6 },
                    { 24, "dezenfektan3.3.jpg", 6 },
                    { 25, "dezenfektan3.4.jpg", 6 },
                    { 31, "siperlik1.1.jpg", 9 },
                    { 32, "siperlik1.2.jpg", 9 },
                    { 33, "siperlik2.1.jpg", 10 },
                    { 34, "siperlik2.2.jpg", 10 },
                    { 14, "dezenfektan1.2.jpg", 4 },
                    { 13, "dezenfektan1.1.jpg", 4 },
                    { 30, "eldiven2.2.jpg", 8 },
                    { 29, "eldiven2.1.jpg", 8 },
                    { 1, "maske1.1.jpg", 1 },
                    { 2, "maske1.2.jpg", 1 },
                    { 3, "maske1.3.jpg", 1 },
                    { 4, "maske1.4.jpg", 1 },
                    { 5, "maske2.1.jpg", 2 },
                    { 6, "maske2.2.jpg", 2 },
                    { 7, "maske2.3.jpg", 2 },
                    { 8, "maske3.1.jpg", 3 },
                    { 9, "maske3.2.jpg", 3 },
                    { 10, "maske3.3.jpg", 3 },
                    { 11, "maske3.4.jpg", 3 },
                    { 12, "maske3.5.jpg", 3 },
                    { 26, "eldiven1.1.jpg", 7 },
                    { 27, "eldiven1.2.jpg", 7 },
                    { 28, "eldiven1.3.jpg", 7 },
                    { 35, "siperlik3.1.jpg", 11 },
                    { 36, "siperlik3.2.jpg", 11 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ProductId",
                table: "Comments",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductId",
                table: "Images",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
