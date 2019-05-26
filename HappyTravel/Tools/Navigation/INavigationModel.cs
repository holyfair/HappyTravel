namespace HappyTravel.Tools.Navigation
{
    internal enum ViewType
    {
        SignIn,
        SignUp,
        MainManager,
        ClientsView
    }

    interface INavigationModel
    {
        void Navigate(ViewType viewType);
    }
}
