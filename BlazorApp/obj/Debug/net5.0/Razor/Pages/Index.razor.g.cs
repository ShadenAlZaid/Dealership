#pragma checksum "C:\Users\ysallam\source\repos\Dealership\BlazorApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7aa8281092bdfa8638100278074cacda1259bac0"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ysallam\source\repos\Dealership\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ysallam\source\repos\Dealership\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ysallam\source\repos\Dealership\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ysallam\source\repos\Dealership\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ysallam\source\repos\Dealership\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ysallam\source\repos\Dealership\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ysallam\source\repos\Dealership\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ysallam\source\repos\Dealership\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ysallam\source\repos\Dealership\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ysallam\source\repos\Dealership\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ysallam\source\repos\Dealership\BlazorApp\Pages\Index.razor"
using DealershipLibrary.Vehicle.Cars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ysallam\source\repos\Dealership\BlazorApp\Pages\Index.razor"
using DealershipLibrary;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n");
#nullable restore
#line 7 "C:\Users\ysallam\source\repos\Dealership\BlazorApp\Pages\Index.razor"
  
    var types =
    Extensions.GetEnumItems(typeof(VehicleTypes));

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "label");
            __builder.AddContent(2, 
#nullable restore
#line 11 "C:\Users\ysallam\source\repos\Dealership\BlazorApp\Pages\Index.razor"
        car

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenElement(4, "select");
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\ysallam\source\repos\Dealership\BlazorApp\Pages\Index.razor"
                   (e)=>SelectCar(e.Value.ToString())

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 14 "C:\Users\ysallam\source\repos\Dealership\BlazorApp\Pages\Index.razor"
     foreach (var item in types)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "option");
            __builder.AddAttribute(7, "value", 
#nullable restore
#line 16 "C:\Users\ysallam\source\repos\Dealership\BlazorApp\Pages\Index.razor"
                        item

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(8, 
#nullable restore
#line 16 "C:\Users\ysallam\source\repos\Dealership\BlazorApp\Pages\Index.razor"
                               item

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 17 "C:\Users\ysallam\source\repos\Dealership\BlazorApp\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\ysallam\source\repos\Dealership\BlazorApp\Pages\Index.razor"
 
    string car;
    void SelectCar(string value)
    {
        this.car = value;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
