using MealMaster.Models;

namespace MealMaster
{
    public interface IIngredientListFactory
    {
        IngredientListModel CreateIngredientListModel(int count, int skipIndex);
    }
}
