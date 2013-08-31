﻿using System.Collections.Generic;
using MealMaster.Core.Dtos;

namespace MealMaster.Core.Interfaces
{
    public interface IIngredientService
    {
        void SaveIngredient(IngredientDto ingredient);
        List<IngredientDto> GetAllIngredients();
        IngredientDto GetIngredientById(string id);
    }
}
