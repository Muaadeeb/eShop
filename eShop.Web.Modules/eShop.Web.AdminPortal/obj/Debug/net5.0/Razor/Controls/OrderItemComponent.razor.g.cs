#pragma checksum "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.AdminPortal\Controls\OrderItemComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c6f38b48be74b5a8f4cd2f5c9ff255d7eb0ac35"
// <auto-generated/>
#pragma warning disable 1591
namespace eShop.Web.AdminPortal.Controls
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.AdminPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.AdminPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.AdminPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.AdminPortal\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.AdminPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.AdminPortal\_Imports.razor"
using eShop.CoreBusiness.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.AdminPortal\_Imports.razor"
using eShop.Web.Common.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.AdminPortal\_Imports.razor"
using eShop.UseCases.AdminPortal.OutstandingOrderScreen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.AdminPortal\_Imports.razor"
using eShop.UseCases.AdminPortal.OrderDetailScreen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.AdminPortal\_Imports.razor"
using eShop.UseCases.AdminPortal.ProcessedOrdersScreen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.AdminPortal\_Imports.razor"
using eShop.Web.AdminPortal.Controls;

#line default
#line hidden
#nullable disable
    public partial class OrderItemComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 2 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.AdminPortal\Controls\OrderItemComponent.razor"
 if (Order != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "tr");
            __builder.OpenElement(1, "td");
#nullable restore
#line 6 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.AdminPortal\Controls\OrderItemComponent.razor"
             if (Order.DatePlaced.HasValue)
            {
                

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, 
#nullable restore
#line 8 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.AdminPortal\Controls\OrderItemComponent.razor"
                 Order.DatePlaced.Value.ToString("yyyy-MM-dd")

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 8 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.AdminPortal\Controls\OrderItemComponent.razor"
                                                              
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.OpenElement(4, "td");
#nullable restore
#line 12 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.AdminPortal\Controls\OrderItemComponent.razor"
             if (!Order.DateProcessed.HasValue)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(5);
            __builder.AddAttribute(6, "href", 
#nullable restore
#line 14 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.AdminPortal\Controls\OrderItemComponent.razor"
                                 $"orderdetail/{Order.OrderId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(8, 
#nullable restore
#line 15 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.AdminPortal\Controls\OrderItemComponent.razor"
                     Order.OrderId

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 17 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.AdminPortal\Controls\OrderItemComponent.razor"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, 
#nullable restore
#line 20 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.AdminPortal\Controls\OrderItemComponent.razor"
                 Order.OrderId

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 20 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.AdminPortal\Controls\OrderItemComponent.razor"
                              
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 23 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.AdminPortal\Controls\OrderItemComponent.razor"
             Order.CustomerCountry

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 24 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.AdminPortal\Controls\OrderItemComponent.razor"
             Order.CustomerStateProvince

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 25 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.AdminPortal\Controls\OrderItemComponent.razor"
             Order.CustomerCity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 26 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.AdminPortal\Controls\OrderItemComponent.razor"
             Order.CustomerName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        <td></td>");
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.AdminPortal\Controls\OrderItemComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.AdminPortal\Controls\OrderItemComponent.razor"
       

    [Parameter]
    public Order Order { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591