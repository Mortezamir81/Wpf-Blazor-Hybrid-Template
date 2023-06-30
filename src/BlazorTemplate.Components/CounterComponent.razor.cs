using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorTemplate.Components;

public partial class CounterComponent : IDisposable
{
	[Inject]
	public CounterViewModel? CounterViewModel { get; set; }

    [Inject]
    public IJSRuntime? JSRuntime { get; set; }


    protected override void OnInitialized()
	{
		CounterViewModel?.AddStateChangeListener(StateHasChanged);
	}

    public void Dispose()
    {
        CounterViewModel?.RemoveStateChangeListener(StateHasChanged);
    }

    public void IncreaseCount()
	{
		CounterViewModel?.IncreamentCount();
	}
}
