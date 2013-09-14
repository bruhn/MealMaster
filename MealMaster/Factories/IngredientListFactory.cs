using System.Collections.Generic;
using MealMaster.Core.Interfaces;
using MealMaster.Models;

namespace MealMaster.Factories
{
    public class IngredientListFactory : IIngredientListFactory
    {
        private readonly IIngredientService _ingredientService;

        public IngredientListFactory(IIngredientService ingredientService)
        {
            _ingredientService = ingredientService;
        }

        public IngredientListModel CreateIngredientListModel(int count, int skipIndex)
        {
            var ingredients = _ingredientService.GetIngredients(count, skipIndex);

            var ingredientModels = new List<IngredientModel>();

            foreach (var ingredient in ingredients)
            {
                var ingredientModel = new IngredientModel
                {
                    IngredientId = ingredient.IngredientId,
                    Name = ingredient.Name,
                    Description = ingredient.Description,
                    CarbonHydrateWeightPercent = ingredient.CarbonHydrateWeightPercent,
                    EnergyInKcal = ingredient.EnergyInKcal,
                    FatWeightPercent = ingredient.FatWeightPercent,
                    ProteineWeightPercent = ingredient.ProteineWeightPercent,
                    AlcoholVolumePercent = ingredient.AlcoholVolumePercent
                };
                ingredientModels.Add(ingredientModel);
            }

            var ingredientListModel = new IngredientListModel {Ingredients = ingredientModels};

            ingredientListModel.NextPageNo = skipIndex + 1;

            return ingredientListModel;
        }
    }
}