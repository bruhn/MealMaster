using System.Web.Mvc;
using MealMaster.Core.Dtos;
using MealMaster.Core.Interfaces;
using MealMaster.Models;

namespace MealMaster.Controllers
{
    public class IngredientsController : Controller
    {
        //
        // GET: /Ingredients/

        private readonly IIngredientService _ingriIngredientService;


        public IngredientsController(IIngredientService ingredientService)
        {
            _ingriIngredientService = ingredientService;
        }

        public ActionResult IngredientsList()
        {
            return View();
        }

        public ActionResult CreateEditIngredient()
        {
            return View();
        }

        public void CreateIngredient(IngredientModel ingredient)
        {
            var ingredientDto = new IngredientDto
            {
                Name = ingredient.Name,
                Description = ingredient.Description,
                CarbonHydrateWeightPercent = ingredient.CarbonHydrateWeightPercent,
                EnergyInKcal = ingredient.EnergyInKcal,
                FatWeightPercent = ingredient.FatWeightPercent,
                ProteineWeightPercent = ingredient.ProteineWeightPercent,
                AlcoholVolumePercent = ingredient.AlcoholVolumePercent
            };

            _ingriIngredientService.CreateIngredient(ingredientDto);
        }
    }
}
