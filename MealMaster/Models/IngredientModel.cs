using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MealMaster.Models
{
    public class IngredientModel
    {
        [HiddenInput]
        public string IngredientId { get; set; }

        [Required(ErrorMessage = "Navn er påkrævet")]
        [DisplayName("Navn:")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Beskrivelse er påkrævet")]
        [DisplayName("Beskrivelse")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Energiindhold er påkrævet")]
        [DisplayName("Energiindhold:")]
        public decimal EnergyInKcal { get; set; }

        [Required(ErrorMessage = "Proteinindhold er påkrævet")]
        [DisplayName("Protein:")]
        public decimal ProteineWeightPercent { get; set; }

        [Required(ErrorMessage = "Kulhydratindhold er påkrævet")]
        [DisplayName("Kulhydrat:")]
        public decimal CarbonHydrateWeightPercent { get; set; }

        [Required(ErrorMessage = "Fedtindhold er påkrævet")]
        [DisplayName("Fedt:")]
        public decimal FatWeightPercent { get; set; }

        [DisplayName("Alkohol:")]
        public decimal AlcoholVolumePercent { get; set; }
    }
}