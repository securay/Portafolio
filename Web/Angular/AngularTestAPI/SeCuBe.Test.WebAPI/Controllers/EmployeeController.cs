using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;

namespace SeCuBe.Test.WebAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        public HttpResponseMessage Get()
        {
            string Query = @"
            SELECT [Id]
                ,[Name]
                ,[DepartmentId]
                ,CONVERT(VARCHAR(10), [JoiningDate], 120) AS JoiningDate
                ,[Photo]
             FROM [dbo].[Employee]";

            var Table = new DataTable();

            using (var Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeAppDB"].ConnectionString))
            using (var Command = new SqlCommand(Query, Connection))
            using (var DataAdapter = new SqlDataAdapter(Command))
            {
                Command.CommandType = CommandType.Text;
                DataAdapter.Fill(Table);
            }

            return Request.CreateResponse(HttpStatusCode.OK, Table);
        }

        public string Post(Models.Employee employee)
        {
            try
            {
                string Query = @"
                INSERT INTO [dbo].[Employee]
                    ([Name]
                    ,[DepartmentId]
                    ,[JoiningDate]
                    ,[Photo])
                VALUES
                    ('{0}', {1}, '{2}', '{3}')";
                Query = string.Format(Query, employee.Name, employee.DepartmentId, employee.JoiningDate, employee.Photo);

                var Table = new DataTable();

                using (var Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeAppDB"].ConnectionString))
                using (var Command = new SqlCommand(Query, Connection))
                using (var DataAdapter = new SqlDataAdapter(Command))
                {
                    Command.CommandType = CommandType.Text;
                    DataAdapter.Fill(Table);
                }

                return "Added Successfully!";
            }
            catch (Exception ex)
            {
                return string.Format("Failed to Add, {0}", ex.Message);
            }
        }

        public string Put(Models.Employee employee)
        {
            try
            {
                string Query = @"
                UPDATE [dbo].[Employee]
                SET [Name] = '{0}'
                    ,[DepartmentId] = {1}
                    ,[JoiningDate] = '{2}'
                    ,[Photo] = '{3}'
                WHERE
                    [Id] = {4}";
                Query = string.Format(Query, employee.Name, employee.DepartmentId, employee.JoiningDate, employee.Photo, employee.Id);

                var Table = new DataTable();

                using (var Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeAppDB"].ConnectionString))
                using (var Command = new SqlCommand(Query, Connection))
                using (var DataAdapter = new SqlDataAdapter(Command))
                {
                    Command.CommandType = CommandType.Text;
                    DataAdapter.Fill(Table);
                }

                return "Updated Successfully!";
            }
            catch (Exception ex)
            {
                return string.Format("Failed to Update: {0}", ex.Message);
            }
        }

        public string Delete(int Id)
        {
            try
            {
                string Query = @"
                DELETE FROM [dbo].[Employee]
                WHERE [Id] = {0}";
                Query = string.Format(Query, Id);

                var Table = new DataTable();

                using (var Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeAppDB"].ConnectionString))
                using (var Command = new SqlCommand(Query, Connection))
                using (var DataAdapter = new SqlDataAdapter(Command))
                {
                    Command.CommandType = CommandType.Text;
                    DataAdapter.Fill(Table);
                }

                return "Deleted Successfully!";
            }
            catch (Exception ex)
            {
                return string.Format("Failed to Delete: {0}", ex.Message);
            }
        }

        [Route("api/Employee/GetAllDepartmentNames")]
        [HttpGet]
        public HttpResponseMessage GetAllDepartmentNames()
        {
            string Query = @"SELECT [Id], [Name] FROM [dbo].[Department]";

            var Table = new DataTable();

            using (var Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeAppDB"].ConnectionString))
            using (var Command = new SqlCommand(Query, Connection))
            using (var DataAdapter = new SqlDataAdapter(Command))
            {
                Command.CommandType = CommandType.Text;
                DataAdapter.Fill(Table);
            }

            return Request.CreateResponse(HttpStatusCode.OK, Table);
        }

        [Route("api/Employee/SaveFile")]
        public string SaveFile()
        {
            try
            {
                var request = HttpContext.Current.Request;
                var file = request.Files[0];
                string fileName = file.FileName;
                var path = HttpContext.Current.Server.MapPath(string.Format("~/Photos/{0}", fileName));

                file.SaveAs(path);

                return fileName;
            }
            catch(Exception)
            {
                return "anon.png";
            }
        }
    }
}
