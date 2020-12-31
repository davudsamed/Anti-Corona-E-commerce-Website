using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Anti_Corona.Web.Models
{
    public class ProductEditModel
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Ürünün başlığı belirtiniz.")]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "Ürünün fiyatını belirtiniz.")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Ürünün stok miktarını belirtiniz.")]
        public int Stock { get; set; }
        public bool isHomePage { get; set; }
        public bool isOnSale { get; set; }
        [Required(ErrorMessage = "Ürün kategorisini seçiniz.")]
        public string categoryId { get; set; }
        public string imageUrl { get; set; }

    }
}
