using System.Web.Http.Controllers;
using System.Web.Mvc;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using MealMaster.Core;
using MealMaster.Core.Interfaces;
using MealMaster.Factories;
using MealMaster.Infrastructure.Mongo;

namespace MealMaster.Installers
{
    public class ContainerInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IIngredientManager>().ImplementedBy<IngredientManager>());
            container.Register(Component.For<IIngredientService>().ImplementedBy<IngredientService>());
            container.Register(Component.For<IIngredientListFactory>().ImplementedBy<IngredientListFactory>());

            container.Register(Classes.FromThisAssembly().BasedOn<IController>().LifestyleTransient());
            container.Register(Classes.FromThisAssembly().BasedOn<IHttpController>().LifestyleTransient());
        }
    }
}