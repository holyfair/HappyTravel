using HappyTravel.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HappyTravel.DataStorage
{
    internal class SerializedDataStorage : IDataStorage
    {
        private readonly List<User> _users;

        internal SerializedDataStorage()
        {
            //MessageBox.Show("yeah");
            //MySqlCommand comm = conn.CreateCommand();
            //comm.CommandText = "INSERT INTO users(login,password) VALUES(?login,?password)";
            //comm.Parameters.Add("?login", MySqlDbType.VarChar).Value = "admin";
            //comm.Parameters.Add("?password", MySqlDbType.VarChar).Value = "1111";
            //comm.ExecuteNonQuery();
            //conn.Close();
            //try
            //{
            //    _users = SerializationManager.Deserialize<List<User>>(FileFolderHelper.StorageFilePath);
            //}
            //catch (FileNotFoundException)
            //{
            //    _users = new List<User>();
            //}
        }

        //private void SaveChanges()
        //{
        //    SerializationManager.Serialize(_users, FileFolderHelper.StorageFilePath);
        //}

    }
}
