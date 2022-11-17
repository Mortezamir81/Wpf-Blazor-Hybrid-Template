namespace BlazorTemplate.Shared.ViewModel.Pages.Counter;

public class CounterViewModel : ViewModelBase
{
    public CounterViewModel() : base()
    {
    }

    public int Count { get; private set; }

    public void SetCount(int count)
    {
        Count = count;

        StateHasChanged();
    }

    public void IncreamentCount()
    {
        Count++;

        StateHasChanged();
    }
}
