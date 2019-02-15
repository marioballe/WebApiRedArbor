using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedArbor.Repository.Model;

namespace RedArborRepository.Repositories
{
    public interface IEmployeeRepository
    {
        Employee GetById(int modelId);
        IEnumerable<Employee> GetAll();
        Employee Add(Employee modeltoAdd);
        void Update(Employee modeltoUpdate);
        void Delete(int modelId);
    }
}
