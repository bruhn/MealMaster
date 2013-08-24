using System.Web.Mvc;
using MealMaster.Models;

namespace MealMaster.Controllers
{
    public class IngredientsController : Controller
    {
        //
        // GET: /Ingredients/

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
            
        }

    }
}
