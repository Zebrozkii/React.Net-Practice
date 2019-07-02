using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace ApiTest.Models
{
    public class TicketModel
    {
        public TicketModel(int id, string url, string status)
        {
            Id = id;
            Url = url;
            Status = status;
        }
        public int Id { get; set; }
        public string Url { get; set; }
        public string Status { get; set; }



        public static List<TicketModel> GetAll()
        {
            List<TicketModel> allTickets = new List<TicketModel> { };
            MySqlConnection conn = DB.Connection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"SELECT * FROM Tickets;";
            MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
            while (rdr.Read())
            {
                int ticketId = rdr.GetInt32(0);
                string ticketUrl = rdr.GetString(1);
                string ticketStatus = rdr.GetString(2);
                TicketModel newTicketModel = new TicketModel(ticketId, ticketUrl, ticketStatus);
                allTickets.Add(newTicketModel);
            }
            if (conn != null)
            {
                conn.Dispose();
            }
            return allTickets;
        }
    }
 }
