using System.Collections.Generic;
using MealMaster.Core.Dtos;

namespace MealMaster.Core.Interfaces
{
    public interface IIngredientManager
    {
        void UpsertIngredient(IngredientDto ingredient);
        List<IngredientDto> GetAllIngredients();
        List<IngredientDto> GetIngredients(int count, int skipIndex);
        IngredientDto GetIngredientById(string id);
    }
}
