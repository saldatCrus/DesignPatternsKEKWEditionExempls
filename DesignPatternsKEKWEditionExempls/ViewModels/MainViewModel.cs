using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using DesignPatternsKEKWEditionExempls.Services;
using DesignPatternsKEKWEditionExempls.Pages;
using DesignPatternsKEKWEditionExempls.Models;
using System.Windows.Input;
using DesignPatternsKEKWEditionExempls.ViewModels.MessageBusViewModels;
using DesignPatternsKEKWEditionExempls.Pages.MessageBusPages;

namespace DesignPatternsKEKWEditionExempls.ViewModels
{
    class MainViewModel : BindableBase
    {
        #region Constructors

        public Page MemberTrackPage { get; set; }

        #endregion

        public MainViewModel(NavigationService navigation)
        {
            navigation.OnPageChanged += page => MemberTrackPage = page;
            navigation.Navigate(new FirstPage
            {
            });
        }

        public ICommand MessageBassInfo => new DelegateCommand(() => 
        {
            var navigation = new NavigationService();

            navigation.OnPageChanged += page => MemberTrackPage = page;
            navigation.Navigate(new InfoPage
            {
            });
        });
    }
}
