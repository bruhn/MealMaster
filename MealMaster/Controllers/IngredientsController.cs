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

        private readonly IIngredientService _ingredientService;
        private readonly IIngredientListFactory _ingredientListFactory;


        public IngredientsController(IIngredientService ingredientService, IIngredientListFactory ingredientListFactory)
        {
            _ingredientService = ingredientService;
            _ingredientListFactory = ingredientListFactory;
        }

        public ActionResult IngredientsList()
        {
            var ingredientList = _ingredientListFactory.CreateIngredientListModel();
            
            return View(ingredientList);
        }

        public ActionResult CreateEditIngredient()
        {
            return View();
        }

        public ActionResult OpenEditIngredient(string id)
        {
            var ingredient = _ingredientService.GetIngredientById(id);

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

            return View("EditIngredient", ingredientModel);
        }

        public ActionResult SaveIngredient(IngredientModel ingredient)
        {
            if (ModelState.IsValid)
            {
                var ingredientDto = new IngredientDto
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

                _ingredientService.SaveIngredient(ingredientDto);

                RedirectToAction("IngredientsList", "Ingredients");
            }

            return View("CreateEditIngredient", ingredient);
        }
    }
}
