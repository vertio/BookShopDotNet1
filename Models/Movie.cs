using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookShopDotNet1.Models
{
    public class Movie
    {
        [Display(Name = ("Identyfikator"))]
        public int id { get; set; }             // propertis
        [Display(Name = ("Tytuł"))]
        [StringLength(60, MinimumLength = 5)]
        public string title { get; set; }       // propertis

        [DataType(DataType.Date)]               // propertis adv
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
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

    }
}
