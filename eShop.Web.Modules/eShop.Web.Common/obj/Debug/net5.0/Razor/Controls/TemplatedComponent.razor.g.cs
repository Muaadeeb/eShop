#pragma checksum "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.Common\Controls\TemplatedComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47a5037b40a0ec5e97f2d750edce4b9eafb14bd2"
// <auto-generated/>
#pragma warning disable 1591
namespace eShop.Web.Common.Controls
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.Common\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.Common\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.Common\_Imports.razor"
using eShop.Web.Common.ViewModels;

#line default
#line hidden
#nullable disable
    public partial class TemplatedComponent<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>TemplatedComponent</h3>\r\n\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, 
#nullable restore
#line 7 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.Common\Controls\TemplatedComponent.razor"
     Header

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
#nullable restore
#line 9 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.Common\Controls\TemplatedComponent.razor"
         foreach(var item in Items)
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, 
#nullable restore
#line 11 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.Common\Controls\TemplatedComponent.razor"
             RepeaterItem(item)

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 11 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.Common\Controls\TemplatedComponent.razor"
                               
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n    \r\n    ");
            __builder.AddContent(7, 
#nullable restore
#line 16 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.Common\Controls\TemplatedComponent.razor"
     Footer

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.Common\Controls\TemplatedComponent.razor"
       

    [Parameter]
    public RenderFragment Header { get; set; }

    [Parameter]
    public RenderFragment Footer { get; set; }

    [Parameter]
    public List<TItem> Items { get; set; }

    [Parameter]
    public RenderFragment<TItem> RepeaterItem { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
