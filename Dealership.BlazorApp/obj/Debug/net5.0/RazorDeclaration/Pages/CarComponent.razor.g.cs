// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Dealership.BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\salzaid\source\repos\Dealership\Dealership.BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\salzaid\source\repos\Dealership\Dealership.BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\salzaid\source\repos\Dealership\Dealership.BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\salzaid\source\repos\Dealership\Dealership.BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\salzaid\source\repos\Dealership\Dealership.BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\salzaid\source\repos\Dealership\Dealership.BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\salzaid\source\repos\Dealership\Dealership.BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\salzaid\source\repos\Dealership\Dealership.BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\salzaid\source\repos\Dealership\Dealership.BlazorApp\_Imports.razor"
using Dealership.BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\salzaid\source\repos\Dealership\Dealership.BlazorApp\_Imports.razor"
using Dealership.BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\salzaid\source\repos\Dealership\Dealership.BlazorApp\Pages\CarComponent.razor"
using DealershipLibrary.Vehicle;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\salzaid\source\repos\Dealership\Dealership.BlazorApp\Pages\CarComponent.razor"
using DealershipLibrary.Vehicle.Cars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\salzaid\source\repos\Dealership\Dealership.BlazorApp\Pages\CarComponent.razor"
using DealershipLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\salzaid\source\repos\Dealership\Dealership.BlazorApp\Pages\CarComponent.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\salzaid\source\repos\Dealership\Dealership.BlazorApp\Pages\CarComponent.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\salzaid\source\repos\Dealership\Dealership.BlazorApp\Pages\CarComponent.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/car")]
    public partial class CarComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\salzaid\source\repos\Dealership\Dealership.BlazorApp\Pages\CarComponent.razor"
       
    [Inject]
    ILookupService LookupService { get; set; }

    [Parameter]
    public EventCallback<VehicleDTO> OnAdd { get; set; }

    private VehicleDTO vehicle = new VehicleDTO(null, null,(int)VehicleTypesEnum.Car);
    string msg;

    List<LookupDTO> carColorsList;
    List<LookupDTO> carModelsList;

    protected override void OnInitialized()
    {
        this.carColorsList = this.LookupService.GetColors();
        this.carModelsList = this.LookupService.GetModels(VehicleTypesEnum.Car);
    }

    void SelectColor(string value)
    {
        this.vehicle.SetColor(value);
    }

    void SelectModel(string value)
    {
        this.vehicle.SetModel(value);
    }

    void ValidSubmit()
    {
        var newCar = new VehicleDTO();
         newCar.Clone(vehicle);

        //reset car to null
        vehicle = new VehicleDTO();
        OnAdd.InvokeAsync(newCar);
        msg = "Car Added!";
        Logger.LogInformation("ValidSubmit called");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<Car> Logger { get; set; }
    }
}
#pragma warning restore 1591
