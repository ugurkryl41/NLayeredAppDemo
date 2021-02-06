using Ninject;
using Northwind.Business.DependencyResolvers.Ninject;

namespace Northwind.Business.DependencyResolvers
{
    public class InstanceFactory
    {
        public static T GetInstance<T>()
        {
            var kernel = new StandardKernel(new BusinessModule());
            return kernel.Get<T>();
        }
    }
}
