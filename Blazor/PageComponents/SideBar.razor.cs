using Microsoft.AspNetCore.Components;

namespace Blazor.PageComponents;
public partial class SideBar
{
    private bool _collapsed = false;
    public void ToggleSidebar()
    {
        _collapsed = !_collapsed;
        StateHasChanged();
    }

    public string GetClass()
    {
        string baseClass = "sidebar-container ";
        string stateClass = _collapsed ? "sidebar-container-collapsed" : "sidebar-container-open";
        return baseClass + stateClass;
    }

    public void NavigateTo(string destination)
    {
        _navMan.NavigateTo(destination);
    }
}