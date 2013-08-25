using System.Collections.Generic;
using MealMaster.Core.Dtos;

namespace MealMaster.Core.Interfaces
{
    public interface IIngredientService
    {
        void CreateIngredient(IngredientDto ingredient);
        List<IngredientDto> GetAllIngredients();
    }
}
