using HappyTravel.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace HappyTravel.DataStorage
{
    internal class SerializedDataStorage : IDataStorage
    {
        private readonly List<User> _users;
        private ObservableCollection<Client> _clients;
        private ObservableCollection<Contract> _contracts;

        internal SerializedDataStorage()
        {
            _clients = new ObservableCollection<Client>();
            try
            {
                SerializeClients();
            }
            catch (Exception e)
            {
                MessageBox.Show("blyt");
            }
        }

        public ObservableCollection<Client> GetClients()
        {
            return _clients;
        }

        private void SerializeClients()
        {
            string connStr = "server=us-cdbr-gcp-east-01.cleardb.net;user=b08c8f9d8c7549;database=gcp_b59f698ea7b4607d7c34;password=1ab93de2;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string sql = "SELECT * FROM client";
                MySqlCommand comand = new MySqlCommand(sql, conn);
                using (MySqlDataReader reader = comand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var client_code = reader.GetString(0);
                        var passport_number = reader.GetString(1);
                        var surname = reader.GetString(2);
                        var name = reader.GetString(3);
                        var fathers_name = reader.GetString(4);
                        var birth_date = reader.GetDateTime(5);
                        var age = reader.GetInt32(6);
                        var email = reader.GetString(7);
                        _clients.Add(new Client(client_code, passport_number, surname, name, fathers_name, birth_date, age, email));
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
        }

        //private void SaveChanges()
        //{
        //    SerializationManager.Serialize(_users, FileFolderHelper.StorageFilePath);
        //}

    }
}
