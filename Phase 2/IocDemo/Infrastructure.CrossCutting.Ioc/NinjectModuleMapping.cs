using IocDemo.Domain;
using IocDemo.Repository;
using Ninject;

namespace Infrastructure.CrossCutting.Ioc
{
    public static class NinjectModuleMapping
    {
        public static void Load(IKernel kernel)
        {
            kernel.Bind<IProgramYearService>().To<ProgramYearService>();
            kernel.Bind<IProgramYearRepository>().To<ProgramYearRepository>();
        }
    }
}
