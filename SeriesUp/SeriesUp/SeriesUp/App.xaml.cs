using SeriesUp.Services.Navigation;
using SeriesUp.ViewModel.Base;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace SeriesUp
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            BuildDependencies();
            IniNavigation();
            
		}

        async void IniNavigation()
        {
            var navigationService = ViewModelLocator.Instance.Resolve<INavigationService>();
            await navigationService.Initialize();
        }

        private void BuildDependencies()
        {
            ViewModelLocator.Instance.Build();
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
