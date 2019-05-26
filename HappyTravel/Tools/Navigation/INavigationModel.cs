namespace HappyTravel.Tools.Navigation
{
    internal enum ViewType
    {
        SignIn,
        SignUp,
        MainManager,
        ClientsView,
        AddClientView
    }

    interface INavigationModel
    {
        void Navigate(ViewType viewType);
    }
}
