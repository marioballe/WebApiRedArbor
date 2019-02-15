using RedArbor.Repository.Ado.Queries;
using RedArborRepository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace RedArbor.Repository.Ado.DependencyResolution
{
    public class RegistryForData
    {
        public void Configure(IUnityContainer container)
        {
            container.RegisterType<IEmployeeRepository, EmployeeRepository>();
        }
    }
}
