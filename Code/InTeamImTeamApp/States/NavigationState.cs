namespace InTeamImTeamApp.States;

public class NavigationState
{
    public event Action? OnPageChanged;

    private string? _currentPage;
    public string? CurrentPage
    {
        get => _currentPage;
        set
        {
            if (_currentPage != value)
            {
                _currentPage = value;
                NotifyPageChanged();
            }
        }
    }

    private void NotifyPageChanged() => OnPageChanged?.Invoke();
}