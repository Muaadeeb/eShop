#pragma checksum "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Controls\CartComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dbddca913d036165a015dfad3b95f61014114d5"
// <auto-generated/>
#pragma warning disable 1591
namespace eShop.Web.CustomerPortal.Controls
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using eShop.CoreBusiness.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using eShop.UseCases.SearchProductScreen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using eShop.UseCases.ViewProductScreen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using eShop.UseCases.ViewProductScreen.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using eShop.UseCases.ShoppingCartScreen.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using eShop.UseCases.PluginInterfaces.StateStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using eShop.UseCases.OrderConfirmationScreen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using eShop.Web.Common.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using eShop.Web.CustomerPortal.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using eShop.Web.CustomerPortal.ViewModels;

#line default
#line hidden
#nullable disable
    public partial class CartComponent : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n    Cart:&nbsp; ");
            __builder.AddContent(2, 
#nullable restore
#line 6 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Controls\CartComponent.razor"
                 lineItemsCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Controls\CartComponent.razor"
       

    private int lineItemsCount = 0;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            _shoppingCartStateStore.AddStateChangeListeners(HandleShoppingCartStateChange);
            lineItemsCount = await _shoppingCartStateStore.GetItemsCount();
            StateHasChanged();
        }
    }

    private async void HandleShoppingCartStateChange()
    {
        lineItemsCount = await _shoppingCartStateStore.GetItemsCount();
        StateHasChanged();
    }

    public void Dispose()
    {
        _shoppingCartStateStore.RemoveStateChangeListeners(HandleShoppingCartStateChange);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IShoppingCartStateStore _shoppingCartStateStore { get; set; }
    }
}
#pragma warning restore 1591
