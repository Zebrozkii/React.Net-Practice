using MySql.Data.MySqlClient;
using System.Collections.Generic;
using ApiTest;
using System;

namespace ApiTest.Models
{
    public class DataBaseModel
    {
        public DataBaseModel(string id, string userName, string passWord)
        {
            Id = id;
            UserName = userName;
            PassWord = passWord;
        }

        public string Id { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }



        public static List<DataBaseModel> GetAll()
        {
            List<DataBaseModel> allDataBase = new List<DataBaseModel> { };
            MySqlConnection conn = DB.Connection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"SELECT * FROM table1;";
            MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
            while (rdr.Read())
            {
                string Id = rdr.GetString(0);
                string userName = rdr.GetString(1);
                string passWord = rdr.GetString(2);
                DataBaseModel newDataBaseModel = new DataBaseModel(Id, userName, passWord);
                allDataBase.Add(newDataBaseModel);
            }
            if (conn != null)
            {
                conn.Dispose();
            }
            return allDataBase;
        }
    }
}
