using HappyTravel.Models;
using HappyTravel.Tools;
using HappyTravel.Tools.Managers;
using System.Collections.ObjectModel;
using System.Windows.Data;

namespace HappyTravel.ViewModels
{
    internal class ClientsViewModel : BaseViewModel
    {
        public ObservableCollection<Client> Clients { get; private set; }
        public CollectionViewSource ViewSource { get; private set; }

        internal ClientsViewModel()
        {
            Clients = StationManager.DataStorage.GetClients();
            this.ViewSource = new CollectionViewSource();
            ViewSource.Source = this.Clients;
        }
    }
}
