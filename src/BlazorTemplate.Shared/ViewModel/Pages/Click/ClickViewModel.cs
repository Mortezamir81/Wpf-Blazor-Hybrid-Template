namespace BlazorTemplate.Shared.ViewModel.Pages.Counter;

public class ClickViewModel : ViewModelBase
{
	public ClickViewModel() : base()
	{
	}

	public string? ClickName { get; private set; }

	public void SetClickName(string name)
	{
		ClickName = name;

		StateHasChanged();
	}
}
