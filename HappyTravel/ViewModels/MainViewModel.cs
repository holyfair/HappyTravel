using HappyTravel.Tools;
using HappyTravel.Tools.Managers;

namespace HappyTravel.ViewModels
{
    internal class MainViewModel : BaseViewModel
    {
        public string CurrentUser
        {
            get
            {
                return $"Current User {StationManager.CurrentUser}";
            }
        }

    }
}
