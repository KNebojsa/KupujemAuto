using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAssigmentAutoKP.Models
{
    public class Automobil
    {
        public int AutomobilId { get; set; }

        [Required(ErrorMessage = "ObaveznoPopuniti")]
        [StringLength(50, ErrorMessage = "Maksimalno50Karaktera")]
        [Display(Name = "KorisnickoIme")]
        public string KorisnickoIme { get; set; }

        [Required(ErrorMessage = "ObaveznoPopuniti")]
        [StringLength(50, ErrorMessage = "Maksimalno50Karaktera")]
        [Display(Name = "Marka")]
        public string Marka { get; set; }


        [Required(ErrorMessage = "ObaveznoPopuniti")]
        [StringLength(50, ErrorMessage = "Maksimalno50Karaktera")]
        [Display(Name = "Model")]
        public string Model { get; set; }


        [Required(ErrorMessage = "ObaveznoPopuniti")]
        [StringLength(50, ErrorMessage = "Maksimalno50Karaktera")]
        [Display(Name = "Godiste")]
        public string Godiste { get; set; }


       
        [StringLength(50, ErrorMessage = "Maksimalno50Karaktera")]
        [Display(Name = "ZapreminaMotora")]
        public string ZapreminaMotora { get; set; }


       
        [StringLength(50, ErrorMessage = "Maksimalno50Karaktera")]
        [Display(Name = "Snaga")]
        public string Snaga { get; set; }

       
        [StringLength(50, ErrorMessage = "Maksimalno50Karaktera")]
        [Display(Name = "Gorivo")]
        public string Gorivo { get; set; }

        
        [StringLength(50, ErrorMessage = "Maksimalno50Karaktera")]
        [Display(Name = "Karoserija")]
        public string Karoserija { get; set; }


        [MaxLength]
        [Display(Name = "Fotografija")]
        public byte[] BinarniPodaci { get; set; }

        [StringLength(20)]
        public string TipFajla { get; set; }


        
        [StringLength(200, ErrorMessage = "Maksimalno200Karaktera")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Opis")]
        public string Opis { get; set; }


        [Required(ErrorMessage = "ObaveznoPopuniti")]
        [Display(Name = "Cena")]
        public double Cena { get; set; }

        [Required(ErrorMessage = "ObaveznoPopuniti")]
        [Display(Name = "Kontakt")]
        public string Kontakt { get; set; }
    }
}
