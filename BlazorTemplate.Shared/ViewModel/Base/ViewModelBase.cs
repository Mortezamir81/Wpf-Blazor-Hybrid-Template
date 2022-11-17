namespace BlazorTemplate.Shared.ViewModel.Base;

public class ViewModelBase
{
	protected Action? _listeners;

	public void AddStateChangeListener(Action listener)
	{
		_listeners += listener;
	}

	public void RemoveStateChangeListener(Action listener)
	{
		if (_listeners != null)
		{
			_listeners -= listener;
		}
	}

	public void StateHasChanged()
	{
		if (_listeners != null)
		_listeners.Invoke();
	}
}