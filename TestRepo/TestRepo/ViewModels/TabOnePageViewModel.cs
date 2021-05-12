using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestRepo
{
    public class TabOnePageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private DelegateCommand<string> _ButtonCommand;
        public DelegateCommand<string> ButtonCommand => _ButtonCommand ?? (_ButtonCommand = new DelegateCommand<string>(async l => await ButtonClicked(l)));

        public TabOnePageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService;
        }

        private async Task ButtonClicked(string someparam)
        {
            var parameters = new NavigationParameters
            {
                { "someparam", someparam }
            };

            await _navigationService.NavigateAsync("MainPage", parameters, false, true);

        }
    }
}
