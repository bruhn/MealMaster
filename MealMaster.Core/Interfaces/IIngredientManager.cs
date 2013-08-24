using MealMaster.Core.Dtos;

namespace MealMaster.Core.Interfaces
{
    public interface IIngredientManager
    {
        void CreateIngredient(IngredientDto ingredient);
    }
}
