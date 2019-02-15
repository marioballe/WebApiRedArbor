using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedArbor.Model.DTO;

namespace RedArbor.Domain.Services
{
    public interface IEmployeeService
    {
        EmployeeDTO GetById(int id);
        IEnumerable<EmployeeDTO> GetAll();
        EmployeeDTO Add(EmployeeDTO model);
        void Update(EmployeeDTO modelDomain);
        void Delete(int id);
    }
}
