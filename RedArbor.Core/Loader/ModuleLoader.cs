using RedArbor.Logic.DependencyResolution;
using RedArbor.Repository.Ado.DependencyResolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace RedArbor.Core.Loader
{
    public class ModuleLoader
    {
        public static void LoadContainer(IUnityContainer container)
        {
            new RegistryForData().Configure(container);
            new RegistryForDomain().Configure(container);
        }
    }
}
