using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestRepo
{
    public class TabTwoPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public TabTwoPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
