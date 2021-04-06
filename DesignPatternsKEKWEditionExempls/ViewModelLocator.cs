using DesignPatternsKEKWEditionExempls.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsKEKWEditionExempls.Services;
using DesignPatternsKEKWEditionExempls.ViewModels.MessageBusViewModels;

namespace DesignPatternsKEKWEditionExempls
{
    class ViewModelLocator
    {
        private static ServiceProvider _provaider;


        public static void Init()
        {
            var services = new ServiceCollection();

            //My ViewModels
            services.AddTransient<MainViewModel>();
            services.AddScoped<FirstPageViewModel>();

            services.AddScoped<InfoPageViewModel>();
            services.AddScoped<RecipientMessageViewModel>();
            services.AddScoped<SenderMessageViewModel>();


            // My service
            services.AddSingleton<NavigationService>();
            //services.AddSingleton<EventBus>();
            services.AddSingleton<MessageBus>();

            _provaider = services.BuildServiceProvider();

            foreach (var item in services)
            {
                _provaider.GetRequiredService(item.ServiceType);
            }
        }

        public MainViewModel MainViewModel => _provaider.GetRequiredService<MainViewModel>();

        public FirstPageViewModel FirstPageViewModel => _provaider.GetRequiredService<FirstPageViewModel>();



        public InfoPageViewModel InfoPageViewModel => _provaider.GetRequiredService<InfoPageViewModel>();

        public RecipientMessageViewModel RecipientMessageViewModel => _provaider.GetRequiredService<RecipientMessageViewModel>();

        public SenderMessageViewModel SenderMessageViewModel => _provaider.GetRequiredService<SenderMessageViewModel>();

    }
}
