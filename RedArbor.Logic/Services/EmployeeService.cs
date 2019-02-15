using RedArbor.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedArbor.Model.DTO;
using RedArborRepository.Repositories;
using RedArbor.Logic.Mappers;
using RedArbor.Repository.Model;

namespace RedArbor.Logic.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _repositoryEmployee;

        public EmployeeService(IEmployeeRepository repositoryEmployee)
        {
            _repositoryEmployee = repositoryEmployee;
        }
        public EmployeeDTO Add(EmployeeDTO newEmployee)
        {
            var response = _repositoryEmployee.Add(RedArborMapper.MapToModel(newEmployee));
            return RedArborMapper.MapToDto(response);
        }

        public void Delete(int id)
        {
            _repositoryEmployee.Delete(id);
        }

        public IEnumerable<EmployeeDTO> GetAll()
        {
            return RedArborMapper.Map(_repositoryEmployee.GetAll());
        }

        public EmployeeDTO GetById(int id)
        {
            return RedArborMapper.MapToDto(_repositoryEmployee.GetById(id));
        }

        public void Update(EmployeeDTO employeeToUpdate)
        {
           _repositoryEmployee.Update(RedArborMapper.MapToModel(employeeToUpdate));
        }
    }
}
