using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Anti_Corona.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

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
                    CategoryId = table.Column<int>(nullable: false),
                    BrandId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
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

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Hayat Kimya" },
                    { 2, "Smask Cerrahi Maske" },
                    { 3, "Happy Maske" },
                    { 4, "Beybi" },
                    { 5, "Ergün Eldiven" },
                    { 6, "Dermosept" },
                    { 7, "Crystalin" },
                    { 8, "Deep Fresh" },
                    { 9, "Özgürce Seç" },
                    { 10, "Tuğbasan" },
                    { 11, "Medizer" }
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
                columns: new[] { "ProductId", "BrandId", "CategoryId", "Date", "Description", "IsHomePage", "IsOnSale", "Price", "Stock", "Title" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2020, 12, 27, 13, 30, 50, 0, DateTimeKind.Unspecified), "Hayat Kimya olarak, hijyen ve temizlik kategorilerindeki 33 yıllık deneyimimizi Evony markamızla cerrahi maske kategorisine taşıyoruz. TSE Tip2R ve TSE Güvenli Üretim sertifikalı Evony Maske %99 a kadar bakteri filtrasyonu sağlamaktadır. 3 katmanlı, Melt Blown+ Spunbond cilde dost katmanlar. Tek katmanda değil her katmanda koruma. Pamuksu Yumuşak katmanlarla saatlerce rahat kullanım. Acıtmayan Yumuşak Elastik Kulaklarıyla koruma ve konforu bir arada. Yüze tam uyumlu Burun Teli. Alerji Yapmaz. Latex İçermez. Paraben içermez. Naylon İçermez. CE sertifikalı. TSE Tip2R , EN14683, ISO13485, TSE Güvenli ", true, true, 100.0, 100, "Evony Yumuşak Elastik Kulaklı Maske 100 Adet" },
                    { 2, 2, 1, new DateTime(2020, 12, 26, 12, 30, 50, 0, DateTimeKind.Unspecified), "1 Kutuda 50 adet bulunmaktadır. 2 Kutu Gönderilecektir.Hava Geçiren Yapı.Yumuşak ve Ayarlanabilir, Tahriş etmez, Rahat takılır.Fiberglass ve Lateks İçermiyor.Filtreli, Üç katlı, tek kullanımlık, lastikli, 3 kıvrımlı.Polipropilen / Non-Woven.Yuvarlak lastikli ultrasonik dikişlidir.Kullanımda rahatlık.Lateks içermez.Hava geçirgen, kolay nefes almayı sağlayan RC cerrahi maske non woven kumaştan üretilmiştir.Gipe lastik kullanılan bu maske tek kullanımlık olup hijyenik ve CE'li dir.Yüze tam uyumludur.", true, true, 200.0, 200, "Smask Cerrahi Telli 3 Katlı Nonwoven Filtreli Maske 50'li 2 Adet" },
                    { 3, 3, 1, new DateTime(2020, 12, 26, 12, 30, 50, 0, DateTimeKind.Unspecified), "Happy Yumuşak Elastik Kulaklı 3 Katlı Telli Mavi Cerrahi Maske 50 li x 2 Adet,Acıtmayan yumuşak elastik kulaklarıyla koruma ve konforu bir arada,Yüze tam uyumlu burun teli,Alerji Yapmaz,Latex İçermez,Klor içermez,Naylon İçermez,Ce Sertifikalı,FDA , ISO 13485 ", true, true, 200.0, 200, "Happy Yumuşak Elastik Kulaklı 3 Katlı Telli Mavi Cerrahi Maske 100 Lü" },
                    { 7, 4, 2, new DateTime(2020, 12, 26, 12, 30, 50, 0, DateTimeKind.Unspecified), "Beybi tek kullanımlık eldiven, elin şeklini alarak kolay hareket imkanı sağlar. Tek kullanımlık eldiven ile yemekler hijyenik bir şekilde hazırlanır. Hem temizlik hem de yemek yapımı sırasında ellerin kurumasını, kirlenmesini ve tahriş olmasını önler.Tek kullanımlıkMiktar : Kutu içerisinde 100 AdetRenk : Beyaz", true, true, 200.0, 200, "Beybi Latex Pudralı Çok Amaçlı Kullan At Eldiven Lateks 100' lü (L) Large / Büyük" },
                    { 8, 5, 2, new DateTime(2020, 12, 26, 12, 30, 50, 0, DateTimeKind.Unspecified), "Pudrasız Lateks Eldiven (Large)- Pudrasız Lateks Eldivenler, Hijyen Gerektiren Tüm Ortamlarda, Elle Bulaşması Muhtemel Mikrop, Virüs Ve Bakterilere Karşı Koruyucudur. - Doğal Lateks Hammaddeden Üretilmiştir. - Giymesi Ve Çıkartması Kolaydır. - Yumuşak Ve Elastik Yapısı Sayesinde Elinize Tam Oturur. - Hastaneler, Diş Klinikleri, Veterinerler, Laboratuvarlar, İlaç Sektörü, Deterjan Ve Temizlik, Kozmetik Gibi Çok Çeşitli Endüstrilerde Kullanım İçin İdealdir. - Beyaz Renklidir. - Yuvarlak Hatlı Manşeti Sayesinde Kolayca Giyilir Ve Çıkartılır. Özellikle Hastane Kullanımlarında Çok Hızlı Giyilip Çıkartılabilir.", true, true, 200.0, 200, "Pudrasız Lateks Eldiven (Large)" },
                    { 4, 6, 3, new DateTime(2020, 12, 26, 12, 30, 50, 0, DateTimeKind.Unspecified), "Sağlık bakanlığı tarafından Ruhsatnameli, ISO ve CE sertifikalı, Msds Raporu bulunmaktadır. Toplamda % 70 Alkol oranına sahiptir. (% 58 Ethil % 12 İzopropil).Ürüne kullanım esnasında kokusundan dolayı rahatsız etmemesi amacı ile % 002 esans eklenerek herkes tarafından kullanılabilinir hale getirilmiştir.Elde hızlıca kurumaktadır.", true, true, 93.0, 200, "Dermosept Handplus El Dezenfektanı 5000 ml" },
                    { 5, 7, 3, new DateTime(2020, 12, 26, 12, 30, 50, 0, DateTimeKind.Unspecified), "Cildinizde ekonomik ve sağlıklı bir şekilde virüs, bakteri ve mantarlara karşı %100 doğal koruma sağlayarak, hayatınızın her alanında yanınızda taşıyabilmeniz için tasarlanmış bir üründür.  Crystalin Eco Antiseptik Dezenfektan Hijyenik Yaşam Kiti içerisinde bulunan 1 litrelik şişedeki konsantre ürünle 10 litre anti-septik dezenfektan elde ederek aylarca güvenle kullanabilirsiniz.", true, true, 93.0, 200, "Crystalin Eco Dezenfektan Hijyenik Yaşam Kiti" },
                    { 6, 8, 3, new DateTime(2020, 12, 26, 12, 30, 50, 0, DateTimeKind.Unspecified), "Sağlık bakanlığı tarafından Ruhsatnameli, ISO ve CE sertifikalı, Msds Raporu bulunmaktadır. Toplamda % 70 Alkol oranına sahiptir. (% 58 Ethil % 12 İzopropil).Ürüne kullanım esnasında kokusundan dolayı rahatsız etmemesi amacı ile % 002 esans eklenerek herkes tarafından kullanılabilinir hale getirilmiştir.Elde hızlıca kurumaktadır.", true, true, 93.0, 200, "Deep Fresh Antibakteriyel El Temizleme Jeli 3 x 200 ml" },
                    { 9, 9, 4, new DateTime(2020, 12, 26, 12, 30, 50, 0, DateTimeKind.Unspecified), "ÖzgürceSeç Şeffaf Maske Yikanabilir Yeniden Kullanabilabilir Kulakta yara ve iz bırakmaz.Yumuşak malzemeden üretilmiştir.Başta ağrı ve ağırlık hissi yaratmaz.Herkes rahatlıkla kullanabilir.Her bedene göre ayarlanabilir.Maskemizin en alt kısmından hava sirkülasyonu  gerçekleşmektedir.Korucuyu maskedir.Ürün tek kullanımlık değildir.Yıkanabilir.Uzun kullanım süresi  tanımaktadır.Ürünümüzün CE - ISO belgeleri bulunmaktadır.", true, true, 93.0, 200, "ÖzgürceSeç Şeffaf Maske Yikanabilir Yeniden Kullanabilabilir" },
                    { 10, 10, 4, new DateTime(2020, 12, 26, 12, 30, 50, 0, DateTimeKind.Unspecified), "Siperlik klipsi; Koruyucu maskenin burun, ağız ve çene bölgesinde oluşabilecek boşlukları minimuma indirerek Siperliğin yüze tam oturmasını sağlar.", true, true, 93.0, 200, "Tuğbasan Yüz Koruyucu Siperlik" },
                    { 11, 11, 4, new DateTime(2020, 12, 26, 12, 30, 50, 0, DateTimeKind.Unspecified), "Partikül, tükürük, damlacık, toz ve benzeri küçük cisimlerin yüzünüze (göz, ağız, burun) gelmesini ve sizden karşı tarafa gitmesini engeller.Şeffaf siperliksağlık ürünleri yönetmenliğine uygun; kırılmaz, esnet Pet(polietilen) malzemeden üretilmiştir. Karşılıklı konuşma, işlem (muayene, karşılama, satış, toplantı vb.) esnasında kişisel kullanım içindir.Hafiftir, kullanımı kolaydır, çıkarılıp takılması basittir.  Esnek materyal kullanıldığından yetişkin her başa uyum sağlar. Görüş alanınızı kapatmaz, görüş alanı geniştir. Işık geçirgenliği yüksek olduğundan görüntü kaybına neden olmaz. Ürün dezenfekte edilmiş olarak gönderilir ve dezenfekte edilerek tekrar kullanılabilir.", true, true, 59.899999999999999, 200, "Medizer Novid Siyah Gözlüklü Yüz Koruyucu Siperlik" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "Description", "ProductId" },
                values: new object[,]
                {
                    { 1, "Yüksek kaliteli ve hızlı kargo. Lakin minyon tipli insanların yüzlerini tam kavramayabilir ve büyük gelebilir.", 1 },
                    { 17, "Ürünün hem fiyatı hemde kalitesi çok iyi harika beğendim", 8 },
                    { 18, "Ürün oldukça kaliteli ve rahat kullanıma sahip. Pudrasız olması alerji yapmasını engelliyor.", 8 },
                    { 19, "Diğer beyaz eldivenleerden kalitesi oldukça iyi", 8 },
                    { 20, "1 günde geldi kargo çok hızlı, teşekkürler.", 4 },
                    { 22, "Kutusunda etiket yoktu. Alkol oranı düşük", 4 },
                    { 23, "Müsteri memnuniyeti iyi arayıp ellerindeki ürünün kalmadigini muadil bir urun gondereceklerini soylediler kabul ettim farkli siteleedeki satis fiyati daha pahaliydi denemeye deger gördüm guvenli alisveris yapilabilir diye düşünüyorum madur olmayacaginiz garanti..ürünün kokusu fena degil 10 saat oldu kullanali herhangi bir yan etki veya olumsuzlukla karsilasmadim", 4 },
                    { 24, "Ürün güzel ama açıldıktan sonra bir ay içinde tüketmeniz gerekiyor bir ay için bu kadar para verilir mi tartışılır belki kalabalık bir aile ise veya iki üç arkadaş beraber alınıp paylaşılabilir yoksa her ay bu kadar dezenfektan parası verilmez bence", 5 },
                    { 25, "Daha önce bir kaç tane dezefektan aldım. Çocuğumun cildi çok hassas olduğu için tahriş oldu. İnternette hassas ciltler için etkili dezenfektan ararken Crystalin markası ile karşılaştım. Sitesini inceledim ve ikna olarak sipariş ettim. Ürün çok güzel. Özellikle hassas cildi, bebeği ve çocukları olanlara tavsiye ederim. Kit hazırlanırken çok profesyonel düşünülmüş. Çok kullanışlı.", 5 },
                    { 26, "Ürün başarılı, hediye maske hareketi 10 numara :slight_smile:", 5 },
                    { 27, "Ürünü her yerde kullanıyorum. Çok memnunum. Koku yok renk yok. Marketten gelenlere sıkıyorum, el yüz sebze meyve için kullanıyorum. Üstelik bereketli. Şu ana kadar 100 ml kadarını kullandım daha. Konstantre şekilde geliyor. Yanında görülen diğer şişeler boş. Sulandırılarak kullanılıyor. Tavsiye ederim.", 5 },
                    { 28, "Daha önce de kullanıyordum. Set olarak almak çok daha avantajlı oldu. Koku yok yapış yapış hissi yok. Sadece klor alerjisi olanlar almadan önce düşünsün lütfen.", 6 },
                    { 29, "ürünü tavsiye üzerine aldım. Yaptığım araştırmada ürünün alkolsüz ve cilt ile dost olduğunu tespit etmiştim. Rahatsız edici bir kokusu yok, 1/10 oranında seyreltilip kullanıldığından çok ekonomik. İçinden çeşitli boyutlarda 6 adet yedek şişe çıkıyor. Şişeleri, ölçü kabı ve bilgilendirme kağıdından kalitesi belli oluyor. Benim gibi hijyen konusunda hassas kişilere şiddetle tavsiye ederim.", 6 },
                    { 30, "Hekimlerin önerdiği çocuklara ve kendinize rahatla kullanacağınız ve diğer dezenfektanlara göre aşırı ekonomik", 6 },
                    { 31, "Aslında ürünü daha kullanmadım ama açılınca 1ay içerisinde kullanılması gerekiyormuş bayağı büyük de konsantre olduğu için bunu gözönünde bulundurun", 6 },
                    { 32, "Bu kadar hızlı bir kargo deneyimi yaşamamıştım hiç. Ertesi günü elimdeydi. Doktorumuzun tavsiyesi üzerine aldık, çok memnunum. Evde işyerinde arabada hep kullanıyoruz", 6 },
                    { 33, "Kısa sürede geldi. Özenli paketlenmiş. Kardeşimin okulda takması için aldım. Ürün çok güzel çok kaliteli. Yüzü tamamen kapatıyor. İçimiz rahat edecek 🙏🏻", 10 },
                    { 34, "cok guzel yuzun tüm bölümlerini alın dahil kapsıyor ve maske + siperlik takıyorum,buğulanma hic yapmio,hareketli olmasi da ayrıca kolaylik ve alinda sungerli olmasi hic rahatsiz etmio", 10 },
                    { 35, "Bayıldım!! Kesinlikle tavsiye ediyorum verilen ücreti sonuna kadar hak ediyor", 10 },
                    { 36, "O kadar rahat ki. Lastikli olmasi basinizda tasirken hafifletiyor ve agirlik yapmiyor. Kalite sahane", 10 },
                    { 37, "Eşim öğretmen derste takmasi için aldık. Çok beğendi", 11 },
                    { 38, "ürün çok güzel ve kaliteli yüzü tamamen kapatıyor .", 11 },
                    { 39, "baş agrıtmayan cok guzel dusunulmuş bir ürün 😊😊", 11 },
                    { 40, "Gayet güzel güven veriyor kaliteli bozulmuyor yıpranmıyor", 11 },
                    { 16, "Ürün anlatıldığı gibi.sorunsuz alışveriş", 8 },
                    { 15, "Çok kalın değil eldivenler ama kullanışlı ben çift kat kullanıyorum daha garanti sanki.", 8 },
                    { 21, "saglik bakanligi onayli olmasi ve kokusunun aynen parfum gibi olmasi ve elleri tahris etmemesi en onemli faktor. apartman icinde kullaniyoruz. hepimiz memnunuz. kargoda hasar almamisti. paketlemesi iyiydi. sizdirma vs yoktu. siparis verdikten 1 gun sonra teslim aldim. alacaklara kesinlikle tavsiye ederim.", 4 },
                    { 6, "Ürün. Gayet iyi ve hesaplı maskeyi takınca nefes alma zorluğu çekmiyorsunuz maskede koku yok havalanması iyi  kulakları acıtmıyor kesinlikle tavsiye ederim", 2 },
                    { 5, "Kullandığınız diğer maskeleri çöpe atın. Bu üç katlı ve kalın maske.maskeyi kesip katlarını kontrol ettim.", 2 },
                    { 7, "Yanaklarımı tam kapattı, önceki maskelerde aralık kalıyordu. Hafif, lastikleri rahatsız etmiyor. Üç katlı. El ile yırttığımda dağılmadan düzgün yırtıldı. Umarım iyi koruyordur,", 2 },
                    { 8, "Maske kalın ebatları 3 kat hepsi kalın.çok güzel lastikleri hiç acıtmıyor.büyük bir maske benim gibi ufak yüzlüyseniz cok az büyük gelebilir ama sorun yok.kutuları gayet hijyen olarak posetli geldi düzenli konulmuş çok iyi...", 3 },
                    { 9, "Piyasadaki çoğu maskeden kat kat güzel. Yanında gönderien hediye için teşekkürler!", 3 },
                    { 4, "En sevdiğim maskem oldu, ne koku ne öksürük hiçbirşey yapmadı. Umarım çok sürmez takmamız ama bitebe kadar favorim Evony", 1 },
                    { 10, "Fiyatına göre kalitesi idare eder. İlk başya, maskelerin hiçbirinde ip yok  diye iade edecektim. İpi klasik ip değil kendi malzemesinden yapılmış kenardan çekerek ip haline geliyor.", 3 },
                    { 11, "Memnunum kaliteli hemen yırtılmıyor . Yemek yaparken de temizlik yaparken de kullanıyorum", 7 },
                    { 12, "Pandemi döneminde aldık.. Çok memnun kaldık.. Tavsiye ederiz..", 7 },
                    { 13, "Önceden de kullandığım bir eldiven, memnunum.", 7 },
                    { 14, "Ürün kaliteli ve kullanışlı tavsiye edilir", 7 },
                    { 2, "Aylardır maske değiştiriyorum en son bir medikal ürünü bulmuştum en iyi o sanıyorum fakat yanılmışım. Şuan kullanılacak en hijyenik paketli en kaliteli maske budur. Tesadüfen markette görmüştüm kulak arkası hoşuma gittiği için 1 paket almıştım fakat trendyola göre çok pahalıydı. Hemen sipariş verdim e-grossmarket sağolsun hızlıca gönderdi. Bundan sonra kullanacağım maske markasını ben buldum herkese de öneririm.", 1 },
                    { 3, "Sürekli aldığım maske... Yüzü ufak kişiler için biraz büyük kaçıyor ama kalınlığı,kulak acıtmayışı her şeyi ile aldığım en iyi maske derim..", 1 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "ImageUrl", "ProductId" },
                values: new object[,]
                {
                    { 22, "dezenfektan3.1.jpg", 6 },
                    { 23, "dezenfektan3.2.jpg", 6 },
                    { 24, "dezenfektan3.3.jpg", 6 },
                    { 27, "eldiven1.2.jpg", 7 },
                    { 4, "maske1.4.jpg", 1 },
                    { 31, "siperlik1.1.jpg", 9 },
                    { 32, "siperlik1.2.jpg", 9 },
                    { 3, "maske1.3.jpg", 1 },
                    { 2, "maske1.2.jpg", 1 },
                    { 33, "siperlik2.1.jpg", 10 },
                    { 34, "siperlik2.2.jpg", 10 },
                    { 1, "maske1.1.jpg", 1 },
                    { 25, "dezenfektan3.4.jpg", 6 },
                    { 5, "maske2.1.jpg", 2 },
                    { 20, "dezenfektan2.4.jpg", 5 },
                    { 7, "maske2.3.jpg", 2 },
                    { 28, "eldiven1.3.jpg", 7 },
                    { 12, "maske3.5.jpg", 3 },
                    { 29, "eldiven2.1.jpg", 8 },
                    { 30, "eldiven2.2.jpg", 8 },
                    { 11, "maske3.4.jpg", 3 },
                    { 35, "siperlik3.1.jpg", 11 },
                    { 10, "maske3.3.jpg", 3 },
                    { 9, "maske3.2.jpg", 3 },
                    { 6, "maske2.2.jpg", 2 },
                    { 13, "dezenfektan1.1.jpg", 4 },
                    { 15, "dezenfektan1.3.jpg", 4 },
                    { 16, "dezenfektan1.4.jpg", 4 },
                    { 8, "maske3.1.jpg", 3 },
                    { 17, "dezenfektan2.1.jpg", 5 },
                    { 18, "dezenfektan2.2.jpg", 5 },
                    { 19, "dezenfektan2.3.jpg", 5 },
                    { 26, "eldiven1.1.jpg", 7 },
                    { 21, "dezenfektan2.5.jpg", 5 },
                    { 14, "dezenfektan1.2.jpg", 4 },
                    { 36, "siperlik3.2.jpg", 11 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ProductId",
                table: "Comments",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductId",
                table: "Images",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
