using System;
using MealMaster.Core.Dtos;
using MealMaster.Core.Interfaces;
using MealMaster.Model.Entities;

namespace MealMaster.Infrastructure.Mongo
{
    public class IngredientManager : MongoManager, IIngredientManager
    {
        public void CreateIngredient(IngredientDto ingredient)
        {
            try
            {
                var collection = Database.GetCollection<Ingredient>("ingredients");

                var ingredientEntity = new Ingredient
                {
                    Name = ingredient.Name,
                    Description = ingredient.Description,
                    CarbonHydrateWeightPercent = ingredient.CarbonHydrateWeightPercent,
                    EnergyInKcal = ingredient.EnergyInKcal,
                    FatWeightPercent = ingredient.FatWeightPercent,
                    ProteineWeightPercent = ingredient.ProteineWeightPercent,
                    AlcoholVolumePercent = ingredient.AlcoholVolumePercent
                };


                collection.Insert(ingredientEntity);
            }
            catch (Exception e)
            {
                throw new Exception("Failed to insert new ingredient in database", e);
            }
        }
    }
}
