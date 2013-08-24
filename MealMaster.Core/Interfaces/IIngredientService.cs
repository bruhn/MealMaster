using MealMaster.Core.Dtos;

namespace MealMaster.Core.Interfaces
{
    public interface IIngredientService
    {
        void CreateIngredient(IngredientDto ingredient);
    }
}
