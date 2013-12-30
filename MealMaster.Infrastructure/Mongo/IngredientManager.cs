using System;
using System.Collections.Generic;
using System.Linq;
using MealMaster.Core.Dtos;
using MealMaster.Core.Interfaces;
using MealMaster.Model.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

namespace MealMaster.Infrastructure.Mongo
{
    public class IngredientManager : MongoManager, IIngredientManager
    {
        private readonly MongoCollection _collection;

        public IngredientManager()
        {
            _collection = Database.GetCollection<Ingredient>("ingredients");
        }

        public void UpsertIngredient(IngredientDto ingredient)
        {
            try
            {
                if (ingredient.IngredientId == null)
                {
                    ingredient.IngredientId = "000000000000000000000000";
                }

                var ingredientEntity = new Ingredient
                {
                    _id = new ObjectId(ingredient.IngredientId),
                    Name = ingredient.Name,
                    Description = ingredient.Description,
                    CarbonHydrateWeightPercent = ingredient.CarbonHydrateWeightPercent,
                    EnergyInKcal = ingredient.EnergyInKcal,
                    FatWeightPercent = ingredient.FatWeightPercent,
                    ProteineWeightPercent = ingredient.ProteineWeightPercent,
                    AlcoholVolumePercent = ingredient.AlcoholVolumePercent
                };


                _collection.Save(ingredientEntity);
            }
            catch (Exception e)
            {
                throw new Exception("Failed to insert new ingredient in database", e);
            }
        }

        public List<IngredientDto> GetAllIngredients()
        {
            var ingredients = _collection.FindAllAs<Ingredient>();

            var ingredientDtos = new List<IngredientDto>();

            foreach (var ingredient in ingredients)
            {
                var ingredientDto = new IngredientDto
                {
                    IngredientId = ingredient._id.ToString(),
                    Name = ingredient.Name,
                    Description = ingredient.Description,
                    CarbonHydrateWeightPercent = ingredient.CarbonHydrateWeightPercent,
                    EnergyInKcal = ingredient.EnergyInKcal,
                    FatWeightPercent = ingredient.FatWeightPercent,
                    ProteineWeightPercent = ingredient.ProteineWeightPercent,
                    AlcoholVolumePercent = ingredient.AlcoholVolumePercent
                };

                ingredientDtos.Add(ingredientDto);
            }

            return ingredientDtos;
        }

        public List<IngredientDto> GetIngredients(int count, int skipIndex)
        {
            var ingredients = _collection.AsQueryable<Ingredient>();

            ingredients = ingredients.Skip(skipIndex * count).Take(count);

            var ingredientDtos = new List<IngredientDto>();

            foreach (var ingredient in ingredients)
            {
                var ingredientDto = new IngredientDto
                {
                    IngredientId = ingredient._id.ToString(),
                    Name = ingredient.Name,
                    Description = ingredient.Description,
                    CarbonHydrateWeightPercent = ingredient.CarbonHydrateWeightPercent,
                    EnergyInKcal = ingredient.EnergyInKcal,
                    FatWeightPercent = ingredient.FatWeightPercent,
                    ProteineWeightPercent = ingredient.ProteineWeightPercent,
                    AlcoholVolumePercent = ingredient.AlcoholVolumePercent
                };

                ingredientDtos.Add(ingredientDto);
            }

            return ingredientDtos;
        }

        public IngredientDto GetIngredientById(string id)
        {
            var oid = new ObjectId(id);

            var query = Query.EQ("_id", oid);


            var ingredient = _collection.FindOneAs<Ingredient>(query);

            var ingredientDto = new IngredientDto
            {
                IngredientId = ingredient._id.ToString(),
                Name = ingredient.Name,
                Description = ingredient.Description,
                CarbonHydrateWeightPercent = ingredient.CarbonHydrateWeightPercent,
                EnergyInKcal = ingredient.EnergyInKcal,
                FatWeightPercent = ingredient.FatWeightPercent,
                ProteineWeightPercent = ingredient.ProteineWeightPercent,
                AlcoholVolumePercent = ingredient.AlcoholVolumePercent
            };

            return ingredientDto;
        }
    }
}
