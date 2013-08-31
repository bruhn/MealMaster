using MongoDB.Bson;

namespace MealMaster.Model.Entities
{
    public class Ingredient
    {
        public ObjectId _id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal EnergyInKcal { get; set; }
        public decimal CarbonHydrateWeightPercent { get; set; }
        public decimal FatWeightPercent { get; set; }
        public decimal ProteineWeightPercent { get; set; }
        public decimal AlcoholVolumePercent { get; set; }
    }
}
