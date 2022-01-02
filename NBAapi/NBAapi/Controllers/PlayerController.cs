using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;
using NBAapi.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Data.Sqlite;

namespace NBAapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _env;

        public PlayerController(IConfiguration configuration, IWebHostEnvironment env)
        {
            _configuration = configuration;
            _env = env;
        }

        //[HttpGet]
        //public JsonResult Get()
        //{
        //    string query = @"
        //            select PlayerId, Name, Team,
        //            convert(varchar(10),Joined,120) as Joined
        //            ,PhotoPath
        //            from dbo.Player
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

        //    return new JsonResult(table);
        //}

        [HttpGet]
        public JsonResult Get()
        {
            DataTable table = new DataTable();
            table.Columns.Add("PlayerId", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Team", typeof(string));
            table.Columns.Add("Joined", typeof(string));
            table.Columns.Add("PhotoPath", typeof(string));
            //List<string> tableResults = new List<string>();
            DataRow myDataRow;
            using (var connection = new SqliteConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"
                    select PlayerId, Name, Team, Joined, PhotoPath from Player";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //var name = reader.GetString();
                        myDataRow = table.NewRow();
                        myDataRow["PlayerId"] = Convert.ToInt32(reader["PlayerId"]);
                        myDataRow["Name"] = Convert.ToString(reader["Name"]);
                        myDataRow["Team"] = Convert.ToString(reader["Team"]);
                        myDataRow["Joined"] = Convert.ToDateTime(reader["Joined"]);
                        myDataRow["PhotoPath"] = Convert.ToString(reader["PhotoPath"]);
                        table.Rows.Add(myDataRow);
                    }
                }
            }
            return new JsonResult(table);

        }


        [HttpPost]
        public JsonResult Post(Player play)
        {
            string query = @"
                    insert into dbo.Player 
                    (Name,Team,Joined,PhotoPath)
                    values 
                    (
                    '" + play.Name + @"'
                    ,'" + play.Team + @"'
                    ,'" + play.Joined + @"'
                    ,'" + play.PhotoPath + @"'
                    )
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

            return new JsonResult("Added Successfully");
        }


        [HttpPut]
        public JsonResult Put(Player play)
        {
            string query = @"
                    update dbo.Player set 
                    Name = '" + play.Name + @"'
                    ,Team = '" + play.Team + @"'
                    ,Joined = '" + play.Joined + @"'
                    where PlayerId = " + play.PlayerId + @" 
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


        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            string query = @"
                    delete from dbo.Player
                    where PlayerId = " + id + @" 
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

            return new JsonResult("Deleted Successfully");
        }


        [Route("SaveFile")]
        [HttpPost]
        public JsonResult SaveFile()
        {
            try
            {
                var httpRequest = Request.Form;
                var postedFile = httpRequest.Files[0];
                string filename = postedFile.FileName;
                var physicalPath = _env.ContentRootPath + "/Photos/" + filename;

                using(var stream = new FileStream(physicalPath, FileMode.Create))
                {
                    postedFile.CopyTo(stream);
                }

                return new JsonResult(filename);
            }
            catch (Exception)
            {

                return new JsonResult("anonymous.png");
            }
        }


        [Route("GetAllTeamNames")]
        public JsonResult GetAllTeamNames()
        {
            string query = @"
                    select Name from dbo.Team
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

            return new JsonResult(table);
        }


    }
}
