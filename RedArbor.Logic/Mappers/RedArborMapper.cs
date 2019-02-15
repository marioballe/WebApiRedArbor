using RedArbor.Model.DTO;
using RedArbor.Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedArbor.Logic.Mappers
{
    public class RedArborMapper
    {
        public static IEnumerable<EmployeeDTO> Map(IEnumerable<Employee> enumerable)
        {
            foreach (var item in enumerable)
            {
                yield return MapToDto(item);
            }
        }

        public static EmployeeDTO MapToDto(Employee model)
        {
            return new EmployeeDTO()
            {
                CompanyId = model.CompanyId,
                CreatedOn = model.CreatedOn,
                DeletedOn = model.DeletedOn,
                Email = model.Email,
                Fax = model.Fax,
                Name = model.Name,
                Lastlogin = model.Lastlogin,
                Password = model.Password,
                PortalId = model.PortalId,
                RoleId = model.RoleId,
                StatusId = model.StatusId,
                Telephone = model.Telephone,
                UpdatedOn = model.UpdatedOn,
                Username = model.Username
            };
        }

        public static Employee MapToModel(EmployeeDTO dto)
        {
            return new Employee()
            {
                CompanyId = dto.CompanyId,
                CreatedOn = dto.CreatedOn,
                DeletedOn = dto.DeletedOn,
                Email = dto.Email,
                Fax = dto.Fax,
                Name = dto.Name,
                Lastlogin = dto.Lastlogin,
                Password = dto.Password,
                PortalId = dto.PortalId,
                RoleId = dto.RoleId,
                StatusId = dto.StatusId,
                Telephone = dto.Telephone,
                UpdatedOn = dto.UpdatedOn,
                Username = dto.Username
            };
        }
    }
}
