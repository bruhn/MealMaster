using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Mvc;
using Castle.Windsor;
using Castle.Windsor.Installer;
using MealMaster.Factories;

namespace MealMaster.App_Start
{
    public class WindsorControllerConfig
    {
        private static IWindsorContainer _container;

        public static void BootstrapContainer()
        {
            _container = new WindsorContainer().Install(FromAssembly.This());
            GlobalConfiguration.Configuration.Services.Replace(typeof(IHttpControllerActivator), new WindsorHttpControllerFactory(_container));
            var controllerFactory = new WindsorControllerFactory(_container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }

        public static void DisposeContainer()
        {
            _container.Dispose();
        }
    }
}