namespace HappyTravel.Tools.Navigation
{
    internal enum ViewType
    {
        SignIn,
        SignUp,
        MainManager,
        ClientsView,
        ContractView
    }

    interface INavigationModel
    {
        void Navigate(ViewType viewType);
    }
}
