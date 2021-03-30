using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using DesignPatternsKEKWEditionExempls.Services;
using DesignPatternsKEKWEditionExempls.Pages;

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
            navigation.Navigate(new FirstPage());
        }
    }
}
