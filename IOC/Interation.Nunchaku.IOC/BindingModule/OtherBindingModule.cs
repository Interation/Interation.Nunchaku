using System.Web.Mvc;
using Interation.Nunchaku.Foundation.Web.Session;
using Ninject.Modules;

namespace Interation.Nunchaku.IOC.BindingModule
{
    public class OtherBindingModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ControllerActionInvoker>().To<InjectionActionInvoker>().InSingletonScope();
            Bind<ISessionProvider>().To<ISessionProvider>().InSingletonScope();
        }
    }
}
