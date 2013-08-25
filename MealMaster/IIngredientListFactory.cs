using MealMaster.Models;

namespace MealMaster
{
    public interface IIngredientListFactory
    {
        IngredientListModel CreateIngredientListModel();
    }
}
