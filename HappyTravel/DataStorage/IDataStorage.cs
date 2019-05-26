using HappyTravel.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTravel.DataStorage
{
    internal interface IDataStorage
    {
        ObservableCollection<Client> GetClients();
        ObservableCollection<Contract> GetContract();
        //bool UserExists(string login);

        //User GetUserByLogin(string login);

        //void AddUser(User user);
    }
}
