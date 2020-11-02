using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SeCuBe.Test.WebAPI.Controllers
{
    public class DepartmentController : ApiController
    {
        public HttpResponseMessage Get()
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

        public string Post(Models.Department department)
        {
            try
            {
                string Query = @"
                INSERT INTO [dbo].[Department]
                    ([Name])
                VALUES
                    ('{0}')";
                Query = string.Format(Query, department.Name);

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

        public string Put(Models.Department department)
        {
            try
            {
                string Query = @"
                UPDATE [dbo].[Department]
                SET [Name] = '{0}'
                WHERE [Id] = {1}";
                Query = string.Format(Query, department.Name, department.Id);

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
                DELETE FROM [dbo].[Department]
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
    }
}
