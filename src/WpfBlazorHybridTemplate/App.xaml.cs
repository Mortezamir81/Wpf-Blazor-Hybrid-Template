using BlazorTemplate.Shared.ViewModel.Pages.Counter;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;

namespace WpfBlazorHybridTemplate;

public partial class App : Application
{
	private ServiceProvider _serviceProvider;

	public App()
	{
		var services = new ServiceCollection();

		ConfigureServices(services);

		_serviceProvider = services.BuildServiceProvider();

		Resources.Add("services", _serviceProvider);
	}

	private void ConfigureServices(ServiceCollection services)
	{
		services.AddWpfBlazorWebView();
		services.AddBlazorWebViewDeveloperTools();
		services.AddSingleton<MainWindow>();
		services.AddSingleton<CounterViewModel>();
		services.AddSingleton<ClickViewModel>();
	}

	private void OnStartup(object sender, StartupEventArgs e)
	{
		var mainWindow =
			_serviceProvider.GetService<MainWindow>();

		if (mainWindow == null)
			return;

		mainWindow.Show();
	}
}
