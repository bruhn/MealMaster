namespace MealMaster.Models
{
    public class IngredientModel
    {
        public string IngredientId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal EnergyInKcal { get; set; }
        public decimal CarbonHydrateWeightPercent { get; set; }
        public decimal FatWeightPercent { get; set; }
        public decimal ProteineWeightPercent { get; set; }
        public decimal AlcoholVolumePercent { get; set; }
    }
}