using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestRepo
{
    public class MyTabbedPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public MyTabbedPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService;
        }


    }
}
