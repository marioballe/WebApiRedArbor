using RedArbor.Repository.Model;
using RedArborRepository.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedArbor.Repository.Ado.Queries
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public Employee Add(Employee newEmployee)
        {
            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["Redarbor"].ToString()))
                {
                    con.Open();

                    var query = new SqlCommand("INSERT INTO Employees(CompanyId, CreatedOn, DeletedOn, Email, Fax, Name, Lastlogin, Password, PortalId, RoleId,StatusId, Telephone, UpdatedOn, Username) VALUES (@CompanyId, @CreatedOn, @DeletedOn, @Email, @Fax, @Name, @Lastlogin, @Password, @PortalId, @RoleId, @StatusId, @Telephone, @UpdatedOn, @Username)", con);

                    query.Parameters.AddWithValue("@CompanyId", newEmployee.CompanyId);
                    query.Parameters.AddWithValue("@CreatedOn", newEmployee.CreatedOn);
                    query.Parameters.AddWithValue("@DeletedOn", newEmployee.DeletedOn);
                    query.Parameters.AddWithValue("@Email", newEmployee.Email);
                    query.Parameters.AddWithValue("@Fax", newEmployee.Fax);
                    query.Parameters.AddWithValue("@Name", newEmployee.Name);
                    query.Parameters.AddWithValue("@Lastlogin", newEmployee.Lastlogin);
                    query.Parameters.AddWithValue("@Password", newEmployee.Password);
                    query.Parameters.AddWithValue("@PortalId", newEmployee.PortalId);
                    query.Parameters.AddWithValue("@RoleId", newEmployee.RoleId);
                    query.Parameters.AddWithValue("@StatusId", newEmployee.StatusId);
                    query.Parameters.AddWithValue("@Telephone", newEmployee.Telephone);
                    query.Parameters.AddWithValue("@UpdatedOn", newEmployee.UpdatedOn);
                    query.Parameters.AddWithValue("@Username", newEmployee.Username);

                    query.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return newEmployee;
        }

        public void Delete(int id)
        {
            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["Redarbor"].ToString()))
                {
                    con.Open();

                    var query = new SqlCommand("DELETE FROM Employees WHERE CompanyId = @CompanyId", con);
                    query.Parameters.AddWithValue("@CompanyId", id);

                    query.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<Employee> GetAll()
        {
            var allEmployees = new List<Employee>();

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["Redarbor"].ToString()))
                {
                    con.Open();

                    var query = new SqlCommand("SELECT * FROM Employees", con);
                    using (var dr = query.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                                 
                            var employee = new Employee
                            {
                                CompanyId = Convert.ToInt32(dr["CompanyId"]),
                                CreatedOn = Convert.ToDateTime(dr["CreatedOn"]),
                                DeletedOn = Convert.ToDateTime(dr["DeletedOn"]),
                                Email = dr["Email"].ToString(),
                                Fax = dr["Fax"].ToString(),
                                Name = dr["Name"].ToString(),
                                Lastlogin = Convert.ToDateTime(dr["Lastlogin"]),
                                Password = dr["Password"].ToString(),
                                PortalId = Convert.ToInt32(dr["PortalId"]),
                                RoleId = Convert.ToInt32(dr["RoleId"]),
                                StatusId = Convert.ToInt32(dr["StatusId"]),
                                Telephone = dr["Telephone"].ToString(),
                                UpdatedOn = Convert.ToDateTime(dr["UpdatedOn"]),
                                Username = dr["Username"].ToString(),

                            };

                            allEmployees.Add(employee);
                        }                   
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return allEmployees;
        }

        public Employee GetById(int id)
        {
            Employee foundEmployee = null;

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["Redarbor"].ToString()))
                {
                    con.Open();

                    var query = new SqlCommand("SELECT * FROM Employees WHERE CompanyId = "+ id.ToString(), con);
                    using (var dr = query.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            foundEmployee = new Employee
                            {
                                CompanyId = Convert.ToInt32(dr["CompanyId"]),
                                CreatedOn = Convert.ToDateTime(dr["CreatedOn"]),
                                DeletedOn = Convert.ToDateTime(dr["DeletedOn"]),
                                Email = dr["Email"].ToString(),
                                Fax = dr["Fax"].ToString(),
                                Name = dr["Name"].ToString(),
                                Lastlogin = Convert.ToDateTime(dr["Lastlogin"]),
                                Password = dr["Password"].ToString(),
                                PortalId = Convert.ToInt32(dr["PortalId"]),
                                RoleId = Convert.ToInt32(dr["RoleId"]),
                                StatusId = Convert.ToInt32(dr["StatusId"]),
                                Telephone = dr["Telephone"].ToString(),
                                UpdatedOn = Convert.ToDateTime(dr["UpdatedOn"]),
                                Username = dr["Username"].ToString(),

                            };
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return foundEmployee;
        }

        public void Update(Employee employeeToUpdate)
        {
            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["Redarbor"].ToString()))
                {
                    con.Open();

                    var query = new SqlCommand("UPDATE Employees SET CreatedOn= @CreatedOn , DeletedOn= @DeletedOn , Email= @Email , Fax= @Fax , Name= @Name , Lastlogin= @Lastlogin , Password= @Password , PortalId= @PortalId , RoleId= @RoleId ,StatusId= @StatusId , Telephone= @Telephone , UpdatedOn= @UpdatedOn , Username= @Username WHERE CompanyId = @CompanyId", con);

                    query.Parameters.AddWithValue("@CompanyId", employeeToUpdate.CompanyId);
                    query.Parameters.AddWithValue("@CreatedOn", employeeToUpdate.CreatedOn);
                    query.Parameters.AddWithValue("@DeletedOn", employeeToUpdate.DeletedOn);
                    query.Parameters.AddWithValue("@Email", employeeToUpdate.Email);
                    query.Parameters.AddWithValue("@Fax", employeeToUpdate.Fax);
                    query.Parameters.AddWithValue("@Name", employeeToUpdate.Name);
                    query.Parameters.AddWithValue("@Lastlogin", employeeToUpdate.Lastlogin);
                    query.Parameters.AddWithValue("@Password", employeeToUpdate.Password);
                    query.Parameters.AddWithValue("@PortalId", employeeToUpdate.PortalId);
                    query.Parameters.AddWithValue("@RoleId", employeeToUpdate.RoleId);
                    query.Parameters.AddWithValue("@StatusId", employeeToUpdate.StatusId);
                    query.Parameters.AddWithValue("@Telephone", employeeToUpdate.Telephone);
                    query.Parameters.AddWithValue("@UpdatedOn", employeeToUpdate.UpdatedOn);
                    query.Parameters.AddWithValue("@Username", employeeToUpdate.Username);

                    query.ExecuteNonQuery();

                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
