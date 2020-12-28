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
            modelBuilder.Entity<Product>().HasData(
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
                    IsOnSale = true
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
                    IsOnSale = true
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
                    IsOnSale = true
                },

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
                    IsOnSale = true
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
                      IsOnSale = true
                  },
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
                      IsOnSale = true
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
                      IsOnSale = true
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
                      IsOnSale = true
                  },

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
                          IsOnSale = true
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
                           IsOnSale = true
                       },

                        new Product()
                        {
                            ProductId = 11,
                            CategoryId = 4,
                            Title = "Medizer Novid Siyah Gözlüklü Yüz Koruyucu Siperli",
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
                            IsOnSale = true
                        }


        );
            modelBuilder.Entity<Comment>().HasData(
                new Comment() { CommentId = 1, ProductId = 1, Description = "Güzel maske" },
                new Comment() { CommentId = 2, ProductId = 2, Description = "Güzel maske1" }
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
