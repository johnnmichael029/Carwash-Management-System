

using Carwash_Management_System.Components.Pages;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Carwash_Management_System.Components.Layout // Ensure this matches PublicNav.razor
{
    public partial class PublicNav
    {
        private string ActiveSection { get; set; } = "home-section";
        private bool collapseNavMenu = true;

        [Inject] private IJSRuntime JSRuntime { get; set; } = default!;
        private DotNetObjectReference<PublicNav>? objRef;

        // 1. ADD THIS: This variable holds the current active state

        [JSInvokable]
        public void UpdateActiveSection(string sectionId)
        {
            // Force the menu to close as soon as scrolling is detected
            if (collapseNavMenu == false)
            {
                collapseNavMenu = true;
            }

            // Only update the section highlight if it actually changed
            if (ActiveSection != sectionId)
            {
                ActiveSection = sectionId;
            }

            StateHasChanged();
        }

        // 2. ADD THIS: This handles manual clicks from the Navbar


        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                objRef = DotNetObjectReference.Create(this);
                await JSRuntime.InvokeVoidAsync("initScrollSpy", objRef);
            }
        }

        public void Dispose()
        {
            objRef?.Dispose();
        }
        private void ShowMenu()
        {
            collapseNavMenu = !collapseNavMenu;
            StateHasChanged(); // Essential for separate files
        }

        private void CloseMenu()
        {
            collapseNavMenu = true;
            StateHasChanged();
        }

        private void SetActive(string section)
        {
            if (ActiveSection != section)
            {
                ActiveSection = section;
                collapseNavMenu = true;
                StateHasChanged();
            }
        }

    }
}