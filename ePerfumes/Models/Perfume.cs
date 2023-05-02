using ePerfumes.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePerfumes.Models
{
    public class Perfume
    {
        [Key]
        public int Perfume_ID { get; set; }
        [Display(Name = "Nome do Perfume")]
        public string Perfume_Name { get; set; }
        [Display(Name = "Foto do Perfume")]
        public string Perfume_Pic_URL { get; set;}
        [Display(Name = "Tamanho em ml")]
        public int Tamanho { get; set; }
        [Display(Name = "Preço(€)")]
        public double Price { get; set; }
        [Display(Name = "Para:")]
        public PerfumeType PerfumeType { get; set; }
        [Display(Name = "Tipo de Perfume")]
        public PerfumeVersion PerfumeVersion { get; set; }


       //Marca
       public int Marca_ID { get; set; }
       public Marca Marca { get; set; }
    }
}
