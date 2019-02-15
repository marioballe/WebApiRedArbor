using RedArbor.Domain.Services;
using RedArbor.Model.DTO;
using System;
using System.Web.Http;

namespace WebApiRedArbor.Controllers
{
    [RoutePrefix("api/redarbor")]
    public class EmployeeController : ApiController
    {
        private IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        [Route("GetAll")]
        public IHttpActionResult Get()
        {
            try
            {
                var result = _employeeService.GetAll();
                return Ok(result);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpGet]
        [Route("GetById")]
        public IHttpActionResult Get(int id)
        {
            try
            {
                var result = _employeeService.GetById(id);
                return Ok(result);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpPost]
        [Route("Add")]
        public IHttpActionResult Post(EmployeeDTO newEmployee)
        {
            try
            {
                var result = _employeeService.Add(newEmployee);
                return Ok(result);             
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpPut]
        [Route("Update")]
        public void Put(int id, EmployeeDTO updatedEmployee)
        {
            try
            {
                _employeeService.Update(updatedEmployee);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpDelete]
        [Route("Delete")]
        public void Delete(int id)
        {
            try
            {
                _employeeService.Delete(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }         
    }
}