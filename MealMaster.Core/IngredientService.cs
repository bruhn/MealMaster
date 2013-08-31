using System.Collections.Generic;
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

        public void SaveIngredient(IngredientDto ingredient)
        {
            _ingredientManager.UpsertIngredient(ingredient);
        }

        public List<IngredientDto> GetAllIngredients()
        {
            return _ingredientManager.GetAllIngredients();
        }

        public IngredientDto GetIngredientById(string id)
        {
            return _ingredientManager.GetIngredientById(id);
        }
    }
}
