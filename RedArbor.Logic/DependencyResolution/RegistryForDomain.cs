using RedArbor.Domain.Services;
using RedArbor.Logic.Services;
using RedArbor.Repository.Ado.Queries;
using RedArborRepository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace RedArbor.Logic.DependencyResolution
{
    public class RegistryForDomain
    {
        public void Configure(IUnityContainer container)
        {
            container.RegisterType<IEmployeeService, EmployeeService>();
        }
    }
}
