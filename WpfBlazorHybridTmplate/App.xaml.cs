using BlazorTemplate.Shared.ViewModel.Pages.Counter;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfBlazorHybridTmplate
{
	public partial class App : Application
	{
		private ServiceProvider serviceProvider;

		public App()
		{
			ServiceCollection services = new ServiceCollection();
			ConfigureServices(services);
			serviceProvider = services.BuildServiceProvider();

			Resources.Add("services", serviceProvider);
		}

		private void ConfigureServices(ServiceCollection services)
		{
			services.AddWpfBlazorWebView();
			services.AddSingleton<MainWindow>();
			services.AddSingleton<CounterViewModel>();
			services.AddSingleton<ClickViewModel>();
		}

		private void OnStartup(object sender, StartupEventArgs e)
		{
			var mainWindow =
				serviceProvider.GetService<MainWindow>();

			if (mainWindow == null)
				return;

			mainWindow.Show();
		}
	}
}
