#pragma checksum "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Controls\CustomerFormComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96bd10d4dc9500efd2a719219d407d642f6b552f"
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
    public partial class CustomerFormComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Customer Form</h3>");
#nullable restore
#line 3 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Controls\CustomerFormComponent.razor"
 if (customer != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Controls\CustomerFormComponent.razor"
                 customer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "class", "form-line");
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Controls\CustomerFormComponent.razor"
                                                            HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n\r\n    ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group");
                __builder2.AddMarkupContent(12, "<label for=\"name\">Name</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "id", "name");
                __builder2.AddAttribute(15, "class", "form-control");
                __builder2.AddAttribute(16, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Controls\CustomerFormComponent.razor"
                                          customer.CustomerName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.CustomerName = __value, customer.CustomerName))));
                __builder2.AddAttribute(18, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => customer.CustomerName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n\r\n    ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group");
                __builder2.AddMarkupContent(22, "<label for=\"address\">Address</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "id", "address");
                __builder2.AddAttribute(25, "class", "form-control");
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Controls\CustomerFormComponent.razor"
                                             customer.CustomerAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.CustomerAddress = __value, customer.CustomerAddress))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => customer.CustomerAddress));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n\r\n    ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group");
                __builder2.AddMarkupContent(32, "<label for=\"city\">City</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(33);
                __builder2.AddAttribute(34, "id", "city");
                __builder2.AddAttribute(35, "class", "form-control");
                __builder2.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Controls\CustomerFormComponent.razor"
                                          customer.CustomerCity

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.CustomerCity = __value, customer.CustomerCity))));
                __builder2.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => customer.CustomerCity));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n\r\n    ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group");
                __builder2.AddMarkupContent(42, "<label for=\"name\">Province</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(43);
                __builder2.AddAttribute(44, "id", "province");
                __builder2.AddAttribute(45, "class", "form-control");
                __builder2.AddAttribute(46, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Controls\CustomerFormComponent.razor"
                                              customer.CustomerStateProvince

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.CustomerStateProvince = __value, customer.CustomerStateProvince))));
                __builder2.AddAttribute(48, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => customer.CustomerStateProvince));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n\r\n    ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "form-group");
                __builder2.AddMarkupContent(52, "<label for=\"name\">Country</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(53);
                __builder2.AddAttribute(54, "id", "country");
                __builder2.AddAttribute(55, "class", "form-control");
                __builder2.AddAttribute(56, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Controls\CustomerFormComponent.razor"
                                             customer.CustomerCountry

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.CustomerCountry = __value, customer.CustomerCountry))));
                __builder2.AddAttribute(58, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => customer.CustomerCountry));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n\r\n    ");
                __builder2.AddMarkupContent(60, "<button type=\"submit\" class=\"btn btn-primary\">Place Order</button>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 36 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Controls\CustomerFormComponent.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\Owner\source\repos\CompleteBlazorCourse_FrankLiu\projects\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Controls\CustomerFormComponent.razor"
       

    private CustomerViewModel customer;

    [Parameter]
    public EventCallback<CustomerViewModel> OnCustomerInfoSubmitted { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();

        customer = new CustomerViewModel();
    }

    private void HandleValidSubmit()
    {
        OnCustomerInfoSubmitted.InvokeAsync(customer);
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
