using MealMaster.Core.Dtos;
using MealMaster.Core.Interfaces;

namespace MealMaster.Core
{
    public class IngredientService : IIngredientService
    {
        private readonly IIngredientManager _ingredientManager;

        public IngredientService(IIngredientManager ingredientManager)
        {
            _ingredientManager = ingredientManager;
        }

        public void CreateIngredient(IngredientDto ingredient)
        {
            _ingredientManager.CreateIngredient(ingredient);
        }
    }
}
