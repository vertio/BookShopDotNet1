using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookShopDotNet1.Models
{
    public class Book
    {
        [Display(Name = ("Identyfikator"))]
        public int id { get; set; }             
        [Display(Name = ("Tytuł"))]
        [StringLength(60, MinimumLength = 5)]
        public string title { get; set; }       

        [DataType(DataType.Date)]               
        [Display(Name = ("Data premiery"))]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = ("Gatunke"))]
        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }
        [Display(Name = ("Cena"))]
        [Range(1, 100)]
        public decimal Price { get; set; }
    }
}
