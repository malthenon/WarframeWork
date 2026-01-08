using WarframeWork.Pages;

namespace WarframeWork
{
    public partial class MainPage : FlyoutPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            flyoutPage.flyoutCollectionView.SelectionChanged += OnSelectionChanged;
        }

        void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = e.CurrentSelection.FirstOrDefault() as FlyoutMenuItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                if (!((IFlyoutPageController)this).ShouldShowSplitMode)
                    IsPresented = false;
            }
        }
    }

}
