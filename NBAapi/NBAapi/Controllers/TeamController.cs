using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data;
using NBAapi.Models;
using Microsoft.Data.Sqlite;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Hosting;

namespace NBAapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _env;

        public TeamController(IConfiguration configuration, IWebHostEnvironment env)
        {
            _configuration = configuration;
            _env = env;
        }

        [HttpGet]
        public JsonResult Get()
        {
            DataTable table = new DataTable();
            table.Columns.Add("TeamId", typeof(string));
            table.Columns.Add("Name", typeof(string));
            //List<string> tableResults = new List<string>();
            DataRow myDataRow;
            using (var connection = new SqliteConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"
                    select TeamId, Name from Team";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //var name = reader.GetString();
                        myDataRow = table.NewRow();
                        myDataRow["TeamId"] = Convert.ToInt32(reader["TeamId"]);
                        myDataRow["Name"] = Convert.ToString(reader["Name"]);
                        table.Rows.Add(myDataRow);
                    }   
                }
            }
            return new JsonResult(table);

        }

        [HttpPost]
        public JsonResult Post(Team te)
        {
            DataTable table = new DataTable();
            using (var connection = new SqliteConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"
                    insert into Team (Name) values 
                    ('" + te.Name + @"')
                    ";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Put:  {reader}");
                        var name = reader;
                        table.Load(name);

                    }
                }

            }
            return new JsonResult("Added Successfully");

        }


        [HttpPut]
        public JsonResult Put(Team te)
        {
            string query = @"
                    update dbo.Team set 
                    Name = '" + te.Name + @"'
                    where TeamId = " + te.TeamId + @" 
                    ";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader); ;

                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Updated Successfully");
        }


        //[HttpDelete("{id}")]
        //public JsonResult Delete(int id)
        //{
        //    string query = @"
        //            delete from dbo.Team
        //            where TeamId = " + id + @" 
        //            ";
        //    DataTable table = new DataTable();
        //    string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
        //    SqlDataReader myReader;
        //    using (SqlConnection myCon = new SqlConnection(sqlDataSource))
        //    {
        //        myCon.Open();
        //        using (SqlCommand myCommand = new SqlCommand(query, myCon))
        //        {
        //            myReader = myCommand.ExecuteReader();
        //            table.Load(myReader); ;

        //            myReader.Close();
        //            myCon.Close();
        //        }
        //    }

        //    return new JsonResult("Deleted Successfully");
        //}

        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            DataTable table = new DataTable();
            using (var connection = new SqliteConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"
                    DELETE FROM Team WHERE TeamId =
                    " + id + @"
                    ";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"DELETE:  {reader}");
                        var name = reader;
                        table.Load(name);
                    }
                }
            }
            return new JsonResult("Deleted Successfully");
        }
    }
}
