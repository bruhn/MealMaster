using System.Collections.Generic;

namespace MealMaster.Models
{
    public class IngredientListModel
    {
        public List<IngredientModel> Ingredients { get; set; }
        public int NextPageNo { get; set; }
    }
}