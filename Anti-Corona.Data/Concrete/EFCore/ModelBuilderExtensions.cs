using Anti_Corona.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Anti_Corona.Data.Concrete.EFCore
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category() { CategoryId = 1, Name = "Maskeler", ImageUrl = "maske.jpg" },
                new Category() { CategoryId = 2, Name = "Eldivenler", ImageUrl = "eldiven.jpg" },
                new Category() { CategoryId = 3, Name = "Dezenfektanlar", ImageUrl = "dezenfektan.jpg" },
                new Category() { CategoryId = 4, Name = "Siperlikler", ImageUrl = "siperlik.jpg" }
        );

            modelBuilder.Entity<Brand>().HasData(
                new Brand() { Id = 1, Name = "Hayat Kimya", },
                new Brand() { Id = 2, Name = "Smask Cerrahi Maske",},
                new Brand() { Id = 3, Name = "Happy Maske",},
                new Brand() { Id = 4, Name = "Beybi",  },
                new Brand() { Id = 5, Name = "Ergün Eldiven",  },
                new Brand() { Id = 6, Name = "Dermosept",  },
                new Brand() { Id = 7, Name = "Crystalin",  },
                new Brand() { Id = 8, Name = "Deep Fresh",  },
                new Brand() { Id = 9, Name = "Özgürce Seç",  },
                new Brand() { Id = 10, Name = "Tuğbasan",  },
                new Brand() { Id = 11, Name = "Medizer", }
        );

            modelBuilder.Entity<Product>().HasData(
                ///////////////////////////////////////////////////////////////////////////////////////////////Maskeler
                new Product()
                {
                    ProductId = 1,
                    CategoryId = 1,
                    Description = "Hayat Kimya olarak, hijyen ve temizlik kategorilerindeki 33 yıllık deneyimimizi " +
                "Evony markamızla cerrahi maske kategorisine taşıyoruz. TSE Tip2R ve TSE Güvenli Üretim sertifikalı Evony Maske %99 a kadar bakteri filtrasyonu " +
                "sağlamaktadır. 3 katmanlı, Melt Blown+ Spunbond cilde dost katmanlar. Tek katmanda değil her katmanda koruma. Pamuksu Yumuşak katmanlarla saatlerce " +
                "rahat kullanım. Acıtmayan Yumuşak Elastik Kulaklarıyla koruma ve konforu bir arada. Yüze tam uyumlu Burun Teli. Alerji Yapmaz. Latex İçermez. " +
                "Paraben içermez. Naylon İçermez. CE sertifikalı. TSE Tip2R , EN14683, ISO13485, TSE Güvenli ",
                    Title = "Evony Yumuşak Elastik Kulaklı Maske 100 Adet",
                    Price = 100,
                    Stock = 100,
                    Date = new DateTime(2020, 12, 27, 13, 30, 50),
                    IsHomePage = true,
                    IsOnSale = true,
                    BrandId=1,
                },

                new Product()
                {
                    ProductId = 2,
                    CategoryId = 1,
                    Description = "1 Kutuda 50 adet bulunmaktadır. 2 Kutu Gönderilecektir.Hava Geçiren Yapı." +
                "Yumuşak ve Ayarlanabilir, Tahriş etmez, Rahat takılır.Fiberglass ve Lateks İçermiyor.Filtreli, Üç katlı, tek kullanımlık, lastikli, " +
                "3 kıvrımlı.Polipropilen / Non-Woven.Yuvarlak lastikli ultrasonik dikişlidir." +
                "Kullanımda rahatlık.Lateks içermez.Hava geçirgen, kolay nefes almayı sağlayan RC cerrahi maske non woven kumaştan üretilmiştir." +
                "Gipe lastik kullanılan bu maske tek kullanımlık olup hijyenik ve CE'li dir." +
                "Yüze tam uyumludur.",
                    Title = "Smask Cerrahi Telli 3 Katlı Nonwoven Filtreli Maske 50'li 2 Adet",
                    Price = 200,
                    Stock = 200,
                    Date = new DateTime(2020, 12, 26, 12, 30, 50),
                    IsHomePage = true,
                    IsOnSale = true,
                    BrandId = 2
                },

                new Product()
                {
                    ProductId = 3,
                    CategoryId = 1,
                    Title = "Happy Yumuşak Elastik Kulaklı 3 Katlı Telli Mavi Cerrahi Maske 100 Lü",
                    Description = "Happy Yumuşak Elastik Kulaklı 3 Katlı Telli Mavi Cerrahi Maske 50 li x 2 Adet," +
                "Acıtmayan yumuşak elastik kulaklarıyla koruma ve konforu bir arada,Yüze tam uyumlu burun teli,Alerji Yapmaz,Latex İçermez,Klor " +
                "içermez,Naylon İçermez,Ce Sertifikalı,FDA , ISO 13485 ",
                    Price = 200,
                    Stock = 200,
                    Date = new DateTime(2020, 12, 26, 12, 30, 50),
                    IsHomePage = true,
                    IsOnSale = true,
                    BrandId = 3
                },


                /////////////////////////////////////////////////////////////////////////////////////////////////////////// Eldivenler
                new Product()
                {
                    ProductId = 7,
                    CategoryId = 2,
                    Title = "Beybi Latex Pudralı Çok Amaçlı Kullan At Eldiven Lateks 100' lü (L) Large / Büyük",
                    Description = "Beybi tek kullanımlık eldiven, elin şeklini alarak kolay hareket imkanı sağlar. " +
                    "Tek kullanımlık eldiven ile yemekler hijyenik bir şekilde hazırlanır. Hem temizlik hem de yemek yapımı sırasında ellerin " +
                    "kurumasını, kirlenmesini ve tahriş olmasını önler." +
                    "Tek kullanımlık" +
                    "Miktar : Kutu içerisinde 100 Adet" +
                    "Renk : Beyaz",
                    Price = 200,
                    Stock = 200,
                    Date = new DateTime(2020, 12, 26, 12, 30, 50),
                    IsHomePage = true,
                    IsOnSale = true,
                    BrandId = 4
                },
                  new Product()
                  {
                      ProductId = 8,
                      CategoryId = 2,
                      Title = "Pudrasız Lateks Eldiven (Large)",
                      Description = "Pudrasız Lateks Eldiven (Large)- Pudrasız Lateks Eldivenler, Hijyen Gerektiren Tüm Ortamlarda, " +
                      "Elle Bulaşması Muhtemel Mikrop, Virüs Ve Bakterilere Karşı Koruyucudur. - Doğal Lateks Hammaddeden Üretilmiştir. - " +
                      "Giymesi Ve Çıkartması Kolaydır. - Yumuşak Ve Elastik Yapısı Sayesinde Elinize Tam Oturur. - Hastaneler, Diş Klinikleri, " +
                      "Veterinerler, Laboratuvarlar, İlaç Sektörü, Deterjan Ve Temizlik, Kozmetik Gibi Çok Çeşitli Endüstrilerde Kullanım İçin " +
                      "İdealdir. - Beyaz Renklidir. - Yuvarlak Hatlı Manşeti Sayesinde Kolayca Giyilir Ve Çıkartılır. Özellikle Hastane " +
                      "Kullanımlarında Çok Hızlı Giyilip Çıkartılabilir.",
                      Price = 200,
                      Stock = 200,
                      Date = new DateTime(2020, 12, 26, 12, 30, 50),
                      IsHomePage = true,
                      IsOnSale = true,
                      BrandId = 5
                  },

                  ///////////////////////////////////////////////////////////////////////////////////////////////////////////////  Dezenfektanlar
                  new Product()
                  {
                      ProductId = 4,
                      CategoryId = 3,
                      Title = "Dermosept Handplus El Dezenfektanı 5000 ml",
                      Description = "Sağlık bakanlığı tarafından Ruhsatnameli, ISO ve CE sertifikalı, Msds Raporu bulunmaktadır. " +
                        "Toplamda % 70 Alkol oranına sahiptir. (% 58 Ethil % 12 İzopropil).Ürüne" +
                        " kullanım esnasında kokusundan dolayı rahatsız etmemesi amacı ile % 0" +
                            "02 esans eklenerek herkes tarafından kullanılabilinir hale getirilmiştir.Elde hızlıca kurumaktadır.",
                      Price = 93,
                      Stock = 200,
                      Date = new DateTime(2020, 12, 26, 12, 30, 50),
                      IsHomePage = true,
                      IsOnSale = true,
                      BrandId = 6
                  },

                  new Product()
                  {
                      ProductId = 5,
                      CategoryId = 3,
                      Title = "Crystalin Eco Dezenfektan Hijyenik Yaşam Kiti",
                      Description = "Cildinizde ekonomik ve sağlıklı bir şekilde virüs, bakteri ve mantarlara karşı %100 doğal koruma sağlayarak, " +
                      "hayatınızın her alanında yanınızda taşıyabilmeniz için tasarlanmış bir üründür.  Crystalin Eco Antiseptik Dezenfektan Hijyenik" +
                      " Yaşam Kiti içerisinde bulunan 1 litrelik şişedeki konsantre ürünle 10 litre anti-septik dezenfektan elde ederek aylarca güvenle" +
                      " kullanabilirsiniz.",
                      Price = 93,
                      Stock = 200,
                      Date = new DateTime(2020, 12, 26, 12, 30, 50),
                      IsHomePage = true,
                      IsOnSale = true,
                      BrandId = 7
                  },
                  new Product()
                  {
                      ProductId = 6,
                      CategoryId = 3,
                      Title = "Deep Fresh Antibakteriyel El Temizleme Jeli 3 x 200 ml",
                      Description = "Sağlık bakanlığı tarafından Ruhsatnameli, ISO ve CE sertifikalı, Msds Raporu bulunmaktadır. " +
                        "Toplamda % 70 Alkol oranına sahiptir. (% 58 Ethil % 12 İzopropil).Ürüne" +
                        " kullanım esnasında kokusundan dolayı rahatsız etmemesi amacı ile % 0" +
                            "02 esans eklenerek herkes tarafından kullanılabilinir hale getirilmiştir.Elde hızlıca kurumaktadır.",
                      Price = 93,
                      Stock = 200,
                      Date = new DateTime(2020, 12, 26, 12, 30, 50),
                      IsHomePage = true,
                      IsOnSale = true,
                      BrandId = 8
                  },
                      //////////////////////////////////////////////////////////////////////////////////////////////////////////////////// Siperlik
                      new Product()
                      {
                          ProductId = 9,
                          CategoryId = 4,
                          Title = "ÖzgürceSeç Şeffaf Maske Yikanabilir Yeniden Kullanabilabilir",
                          Description = "ÖzgürceSeç Şeffaf Maske Yikanabilir Yeniden Kullanabilabilir" +
                        " Kulakta yara ve iz bırakmaz.Yumuşak malzemeden üretilmiştir.Başta ağrı ve ağırlık hissi yaratmaz.Herkes" +
                        " rahatlıkla kullanabilir.Her bedene göre ayarlanabilir.Maskemizin en alt kısmından hava sirkülasyonu " +
                        " gerçekleşmektedir.Korucuyu maskedir.Ürün tek kullanımlık değildir.Yıkanabilir.Uzun kullanım süresi " +
                        " tanımaktadır.Ürünümüzün CE - ISO belgeleri bulunmaktadır.",
                          Price = 93,
                          Stock = 200,
                          Date = new DateTime(2020, 12, 26, 12, 30, 50),
                          IsHomePage = true,
                          IsOnSale = true,
                          BrandId = 9
                      },

                       new Product()
                       {
                           ProductId = 10,
                           CategoryId = 4,
                           Title = "Tuğbasan Yüz Koruyucu Siperlik",
                           Description = "Siperlik klipsi; Koruyucu maskenin burun, ağız ve çene " +
                           "bölgesinde oluşabilecek boşlukları minimuma indirerek Siperliğin yüze tam oturmasını sağlar.",
                           Price = 93,
                           Stock = 200,
                           Date = new DateTime(2020, 12, 26, 12, 30, 50),
                           IsHomePage = true,
                           IsOnSale = true,
                           BrandId = 10
                       },

                        new Product()
                        {
                            ProductId = 11,
                            CategoryId = 4,
                            Title = "Medizer Novid Siyah Gözlüklü Yüz Koruyucu Siperlik",
                            Description = "Partikül, tükürük, damlacık, toz ve benzeri küçük cisimlerin yüzünüze (göz, ağız, burun)" +
                            " gelmesini ve sizden karşı tarafa gitmesini engeller." +
                             "Şeffaf siperlik" +
                              "sağlık ürünleri yönetmenliğine uygun; kırılmaz, esnet Pet(polietilen) malzemeden üretilmiştir." +
                           " Karşılıklı konuşma, işlem (muayene, karşılama, satış, toplantı vb.) esnasında kişisel kullanım içindir." +
                          "Hafiftir, kullanımı kolaydır, çıkarılıp takılması basittir." +
                          "  Esnek materyal kullanıldığından yetişkin her başa uyum sağlar." +
                           " Görüş alanınızı kapatmaz, görüş alanı geniştir." +
                           " Işık geçirgenliği yüksek olduğundan görüntü kaybına neden olmaz." +
                           " Ürün dezenfekte edilmiş olarak gönderilir ve dezenfekte edilerek tekrar kullanılabilir.",
                            Price = 59.90,
                            Stock = 200,
                            Date = new DateTime(2020, 12, 26, 12, 30, 50),
                            IsHomePage = true,
                            IsOnSale = true,
                            BrandId = 11
                        }


        );
            modelBuilder.Entity<Comment>().HasData(
                //Doğru//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// Maske Yorumları
                new Comment() { CommentId = 1, ProductId = 1, Description = "Yüksek kaliteli ve hızlı kargo. Lakin minyon tipli insanların yüzlerini tam kavramayabilir ve büyük gelebilir." },
                new Comment() { CommentId = 2, ProductId = 1, Description = "Aylardır maske değiştiriyorum en son bir medikal ürünü bulmuştum en iyi o sanıyorum fakat yanılmışım. Şuan kullanılacak en hijyenik paketli en kaliteli maske budur. Tesadüfen markette görmüştüm kulak arkası hoşuma gittiği için 1 paket almıştım fakat trendyola göre çok pahalıydı. Hemen sipariş verdim e-grossmarket sağolsun hızlıca gönderdi. Bundan sonra kullanacağım maske markasını ben buldum herkese de öneririm." },
                new Comment() { CommentId = 3, ProductId = 1, Description = "Sürekli aldığım maske... Yüzü ufak kişiler için biraz büyük kaçıyor ama kalınlığı,kulak acıtmayışı her şeyi ile aldığım en iyi maske derim.." },
                new Comment() { CommentId = 4, ProductId = 1, Description = "En sevdiğim maskem oldu, ne koku ne öksürük hiçbirşey yapmadı. Umarım çok sürmez takmamız ama bitebe kadar favorim Evony" },

                new Comment() { CommentId = 5, ProductId = 2, Description = "Kullandığınız diğer maskeleri çöpe atın. Bu üç katlı ve kalın maske.maskeyi kesip katlarını kontrol ettim." },
                new Comment() { CommentId = 6, ProductId = 2, Description = "Ürün. Gayet iyi ve hesaplı maskeyi takınca nefes alma zorluğu çekmiyorsunuz maskede koku yok havalanması iyi  kulakları acıtmıyor kesinlikle tavsiye ederim" },
                new Comment() { CommentId = 7, ProductId = 2, Description = "Yanaklarımı tam kapattı, önceki maskelerde aralık kalıyordu. Hafif, lastikleri rahatsız etmiyor. Üç katlı. El ile yırttığımda dağılmadan düzgün yırtıldı. Umarım iyi koruyordur," },

                new Comment() { CommentId = 8, ProductId = 3, Description = "Maske kalın ebatları 3 kat hepsi kalın.çok güzel lastikleri hiç acıtmıyor.büyük bir maske benim gibi ufak yüzlüyseniz cok az büyük gelebilir ama sorun yok.kutuları gayet hijyen olarak posetli geldi düzenli konulmuş çok iyi..." },
                new Comment() { CommentId = 9, ProductId = 3, Description = "Piyasadaki çoğu maskeden kat kat güzel. Yanında gönderien hediye için teşekkürler!" },
                new Comment() { CommentId = 10, ProductId = 3, Description = "Fiyatına göre kalitesi idare eder. İlk başya, maskelerin hiçbirinde ip yok  diye iade edecektim. İpi klasik ip değil kendi malzemesinden yapılmış kenardan çekerek ip haline geliyor." },

                //Doğru//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// Eldivenler Yorumları
                new Comment() { CommentId = 11, ProductId = 7, Description = "Memnunum kaliteli hemen yırtılmıyor . Yemek yaparken de temizlik yaparken de kullanıyorum" },
                new Comment() { CommentId = 12, ProductId = 7, Description = "Pandemi döneminde aldık.. Çok memnun kaldık.. Tavsiye ederiz.." },
                new Comment() { CommentId = 13, ProductId = 7, Description = "Önceden de kullandığım bir eldiven, memnunum." },
                new Comment() { CommentId = 14, ProductId = 7, Description = "Ürün kaliteli ve kullanışlı tavsiye edilir" },

                new Comment() { CommentId = 15, ProductId = 8, Description = "Çok kalın değil eldivenler ama kullanışlı ben çift kat kullanıyorum daha garanti sanki." },
                new Comment() { CommentId = 16, ProductId = 8, Description = "Ürün anlatıldığı gibi.sorunsuz alışveriş" },
                new Comment() { CommentId = 17, ProductId = 8, Description = "Ürünün hem fiyatı hemde kalitesi çok iyi harika beğendim" },
                new Comment() { CommentId = 18, ProductId = 8, Description = "Ürün oldukça kaliteli ve rahat kullanıma sahip. Pudrasız olması alerji yapmasını engelliyor." },
                new Comment() { CommentId = 19, ProductId = 8, Description = "Diğer beyaz eldivenleerden kalitesi oldukça iyi" },

                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// Dezenfektanlar Yorumları
                new Comment() { CommentId = 20, ProductId = 4, Description = "1 günde geldi kargo çok hızlı, teşekkürler." },
                new Comment() { CommentId = 21, ProductId = 4, Description = "saglik bakanligi onayli olmasi ve kokusunun aynen parfum gibi olmasi ve elleri tahris etmemesi en onemli faktor. apartman icinde kullaniyoruz. hepimiz memnunuz. kargoda hasar almamisti. paketlemesi iyiydi. sizdirma vs yoktu. siparis verdikten 1 gun sonra teslim aldim. alacaklara kesinlikle tavsiye ederim." },
                new Comment() { CommentId = 22, ProductId = 4, Description = "Kutusunda etiket yoktu. Alkol oranı düşük" },
                new Comment() { CommentId = 23, ProductId = 4, Description = "Müsteri memnuniyeti iyi arayıp ellerindeki ürünün kalmadigini muadil bir urun gondereceklerini soylediler kabul ettim farkli siteleedeki satis fiyati daha pahaliydi denemeye deger gördüm guvenli alisveris yapilabilir diye düşünüyorum madur olmayacaginiz garanti..ürünün kokusu fena degil 10 saat oldu kullanali herhangi bir yan etki veya olumsuzlukla karsilasmadim" },

                new Comment() { CommentId = 24, ProductId = 5, Description = "Ürün güzel ama açıldıktan sonra bir ay içinde tüketmeniz gerekiyor bir ay için bu kadar para verilir mi tartışılır belki kalabalık bir aile ise veya iki üç arkadaş beraber alınıp paylaşılabilir yoksa her ay bu kadar dezenfektan parası verilmez bence" },
                new Comment() { CommentId = 25, ProductId = 5, Description = "Daha önce bir kaç tane dezefektan aldım. Çocuğumun cildi çok hassas olduğu için tahriş oldu. İnternette hassas ciltler için etkili dezenfektan ararken Crystalin markası ile karşılaştım. Sitesini inceledim ve ikna olarak sipariş ettim. Ürün çok güzel. Özellikle hassas cildi, bebeği ve çocukları olanlara tavsiye ederim. Kit hazırlanırken çok profesyonel düşünülmüş. Çok kullanışlı." },
                new Comment() { CommentId = 26, ProductId = 5, Description = "Ürün başarılı, hediye maske hareketi 10 numara :slight_smile:" },
                new Comment() { CommentId = 27, ProductId = 5, Description = "Ürünü her yerde kullanıyorum. Çok memnunum. Koku yok renk yok. Marketten gelenlere sıkıyorum, el yüz sebze meyve için kullanıyorum. Üstelik bereketli. Şu ana kadar 100 ml kadarını kullandım daha. Konstantre şekilde geliyor. Yanında görülen diğer şişeler boş. Sulandırılarak kullanılıyor. Tavsiye ederim." },

                new Comment() { CommentId = 28, ProductId = 6, Description = "Daha önce de kullanıyordum. Set olarak almak çok daha avantajlı oldu. Koku yok yapış yapış hissi yok. Sadece klor alerjisi olanlar almadan önce düşünsün lütfen." },
                new Comment() { CommentId = 29, ProductId = 6, Description = "ürünü tavsiye üzerine aldım. Yaptığım araştırmada ürünün alkolsüz ve cilt ile dost olduğunu tespit etmiştim. Rahatsız edici bir kokusu yok, 1/10 oranında seyreltilip kullanıldığından çok ekonomik. İçinden çeşitli boyutlarda 6 adet yedek şişe çıkıyor. Şişeleri, ölçü kabı ve bilgilendirme kağıdından kalitesi belli oluyor. Benim gibi hijyen konusunda hassas kişilere şiddetle tavsiye ederim." },
                new Comment() { CommentId = 30, ProductId = 6, Description = "Hekimlerin önerdiği çocuklara ve kendinize rahatla kullanacağınız ve diğer dezenfektanlara göre aşırı ekonomik" },
                new Comment() { CommentId = 31, ProductId = 6, Description = "Aslında ürünü daha kullanmadım ama açılınca 1ay içerisinde kullanılması gerekiyormuş bayağı büyük de konsantre olduğu için bunu gözönünde bulundurun" },
                new Comment() { CommentId = 32, ProductId = 6, Description = "Bu kadar hızlı bir kargo deneyimi yaşamamıştım hiç. Ertesi günü elimdeydi. Doktorumuzun tavsiyesi üzerine aldık, çok memnunum. Evde işyerinde arabada hep kullanıyoruz" },

                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// Siperlikler Yorumları
                new Comment() { CommentId = 33, ProductId = 10, Description = "Kısa sürede geldi. Özenli paketlenmiş. Kardeşimin okulda takması için aldım. Ürün çok güzel çok kaliteli. Yüzü tamamen kapatıyor. İçimiz rahat edecek 🙏🏻" },
                new Comment() { CommentId = 34, ProductId = 10, Description = "cok guzel yuzun tüm bölümlerini alın dahil kapsıyor ve maske + siperlik takıyorum,buğulanma hic yapmio,hareketli olmasi da ayrıca kolaylik ve alinda sungerli olmasi hic rahatsiz etmio" },
                new Comment() { CommentId = 35, ProductId = 10, Description = "Bayıldım!! Kesinlikle tavsiye ediyorum verilen ücreti sonuna kadar hak ediyor" },
                new Comment() { CommentId = 36, ProductId = 10, Description = "O kadar rahat ki. Lastikli olmasi basinizda tasirken hafifletiyor ve agirlik yapmiyor. Kalite sahane" },

                new Comment() { CommentId = 37, ProductId = 11, Description = "Eşim öğretmen derste takmasi için aldık. Çok beğendi" },
                new Comment() { CommentId = 38, ProductId = 11, Description = "ürün çok güzel ve kaliteli yüzü tamamen kapatıyor ." },
                new Comment() { CommentId = 39, ProductId = 11, Description = "baş agrıtmayan cok guzel dusunulmuş bir ürün 😊😊" },
                new Comment() { CommentId = 40, ProductId = 11, Description = "Gayet güzel güven veriyor kaliteli bozulmuyor yıpranmıyor" }
            );
            modelBuilder.Entity<Image>().HasData(
                new Image() { ImageId = 1, ProductId = 1, ImageUrl = "maske1.1.jpg" },
                new Image() { ImageId = 2, ProductId = 1, ImageUrl = "maske1.2.jpg" },
                new Image() { ImageId = 3, ProductId = 1, ImageUrl = "maske1.3.jpg" },
                new Image() { ImageId = 4, ProductId = 1, ImageUrl = "maske1.4.jpg" },

                new Image() { ImageId = 5, ProductId = 2, ImageUrl = "maske2.1.jpg" },
                new Image() { ImageId = 6, ProductId = 2, ImageUrl = "maske2.2.jpg" },
                new Image() { ImageId = 7, ProductId = 2, ImageUrl = "maske2.3.jpg" },

                new Image() { ImageId = 8, ProductId = 3, ImageUrl = "maske3.1.jpg" },
                new Image() { ImageId = 9, ProductId = 3, ImageUrl = "maske3.2.jpg" },
                new Image() { ImageId = 10, ProductId = 3, ImageUrl = "maske3.3.jpg" },
                new Image() { ImageId = 11, ProductId = 3, ImageUrl = "maske3.4.jpg" },
                new Image() { ImageId = 12, ProductId = 3, ImageUrl = "maske3.5.jpg" },

                new Image() { ImageId = 13, ProductId = 4, ImageUrl = "dezenfektan1.1.jpg" },
                new Image() { ImageId = 14, ProductId = 4, ImageUrl = "dezenfektan1.2.jpg" },
                new Image() { ImageId = 15, ProductId = 4, ImageUrl = "dezenfektan1.3.jpg" },
                new Image() { ImageId = 16, ProductId = 4, ImageUrl = "dezenfektan1.4.jpg" },

                new Image() { ImageId = 17, ProductId = 5, ImageUrl = "dezenfektan2.1.jpg" },
                new Image() { ImageId = 18, ProductId = 5, ImageUrl = "dezenfektan2.2.jpg" },
                new Image() { ImageId = 19, ProductId = 5, ImageUrl = "dezenfektan2.3.jpg" },
                new Image() { ImageId = 20, ProductId = 5, ImageUrl = "dezenfektan2.4.jpg" },
                new Image() { ImageId = 21, ProductId = 5, ImageUrl = "dezenfektan2.5.jpg" },

                new Image() { ImageId = 22, ProductId = 6, ImageUrl = "dezenfektan3.1.jpg" },
                new Image() { ImageId = 23, ProductId = 6, ImageUrl = "dezenfektan3.2.jpg" },
                new Image() { ImageId = 24, ProductId = 6, ImageUrl = "dezenfektan3.3.jpg" },
                new Image() { ImageId = 25, ProductId = 6, ImageUrl = "dezenfektan3.4.jpg" },

                new Image() { ImageId = 26, ProductId = 7, ImageUrl = "eldiven1.1.jpg" },
                new Image() { ImageId = 27, ProductId = 7, ImageUrl = "eldiven1.2.jpg" },
                new Image() { ImageId = 28, ProductId = 7, ImageUrl = "eldiven1.3.jpg" },

                new Image() { ImageId = 29, ProductId = 8, ImageUrl = "eldiven2.1.jpg" },
                new Image() { ImageId = 30, ProductId = 8, ImageUrl = "eldiven2.2.jpg" },

                new Image() { ImageId = 31, ProductId = 9, ImageUrl = "siperlik1.1.jpg" },
                new Image() { ImageId = 32, ProductId = 9, ImageUrl = "siperlik1.2.jpg" },

                new Image() { ImageId = 33, ProductId = 10, ImageUrl = "siperlik2.1.jpg" },
                new Image() { ImageId = 34, ProductId = 10, ImageUrl = "siperlik2.2.jpg" },

                new Image() { ImageId = 35, ProductId = 11, ImageUrl = "siperlik3.1.jpg" },
                new Image() { ImageId = 36, ProductId = 11, ImageUrl = "siperlik3.2.jpg" }
            );

        }
    }
}
