using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestRepo
{
    public class MainPageViewModel : ViewModelBase
    {

        private string _someParameter;
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
        }

        public string SomeParameter
        {
            get { return _someParameter; }
            set { SetProperty(ref _someParameter, value); }
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            if (parameters.ContainsKey("someparam"))
            {
                SomeParameter = (string)parameters["someparam"];
            }
        }


    }
}
