#pragma checksum "C:\Users\stega\Documents\Project\Cursos\curso-profesional\blazor\FundamentosBlazor\FundamentosServer\Pages\FetchData.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4a153af8e85960fbf7f159204c72cda25197ef2cb405872963b8bf41e635a3c4"
// <auto-generated/>
#pragma warning disable 1591
namespace FundamentosServer.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\stega\Documents\Project\Cursos\curso-profesional\blazor\FundamentosBlazor\FundamentosServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\stega\Documents\Project\Cursos\curso-profesional\blazor\FundamentosBlazor\FundamentosServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\stega\Documents\Project\Cursos\curso-profesional\blazor\FundamentosBlazor\FundamentosServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\stega\Documents\Project\Cursos\curso-profesional\blazor\FundamentosBlazor\FundamentosServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\stega\Documents\Project\Cursos\curso-profesional\blazor\FundamentosBlazor\FundamentosServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\stega\Documents\Project\Cursos\curso-profesional\blazor\FundamentosBlazor\FundamentosServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\stega\Documents\Project\Cursos\curso-profesional\blazor\FundamentosBlazor\FundamentosServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\stega\Documents\Project\Cursos\curso-profesional\blazor\FundamentosBlazor\FundamentosServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\stega\Documents\Project\Cursos\curso-profesional\blazor\FundamentosBlazor\FundamentosServer\_Imports.razor"
using FundamentosServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\stega\Documents\Project\Cursos\curso-profesional\blazor\FundamentosBlazor\FundamentosServer\_Imports.razor"
using FundamentosServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\stega\Documents\Project\Cursos\curso-profesional\blazor\FundamentosBlazor\FundamentosServer\Pages\FetchData.razor"
using FundamentosServer.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Web.PageTitle>(0);
            __builder.AddAttribute(1, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(2, "Weather forecast");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.AddMarkupContent(4, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(5, "<p>This component demonstrates fetching data from a service.</p>");
#nullable restore
#line 11 "C:\Users\stega\Documents\Project\Cursos\curso-profesional\blazor\FundamentosBlazor\FundamentosServer\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<p><em>Loading...</em></p>");
#nullable restore
#line 14 "C:\Users\stega\Documents\Project\Cursos\curso-profesional\blazor\FundamentosBlazor\FundamentosServer\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddMarkupContent(9, "<thead><tr><th>Date</th>\r\n                <th>Temp. (C)</th>\r\n                <th>Temp. (F)</th>\r\n                <th>Summary</th></tr></thead>\r\n        ");
            __builder.OpenElement(10, "tbody");
#nullable restore
#line 27 "C:\Users\stega\Documents\Project\Cursos\curso-profesional\blazor\FundamentosBlazor\FundamentosServer\Pages\FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "tr");
            __builder.OpenElement(12, "td");
#nullable restore
#line (30,26)-(30,59) 25 "C:\Users\stega\Documents\Project\Cursos\curso-profesional\blazor\FundamentosBlazor\FundamentosServer\Pages\FetchData.razor"
__builder.AddContent(13, forecast.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "td");
#nullable restore
#line (31,26)-(31,47) 25 "C:\Users\stega\Documents\Project\Cursos\curso-profesional\blazor\FundamentosBlazor\FundamentosServer\Pages\FetchData.razor"
__builder.AddContent(16, forecast.TemperatureC);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
#nullable restore
#line (32,26)-(32,47) 25 "C:\Users\stega\Documents\Project\Cursos\curso-profesional\blazor\FundamentosBlazor\FundamentosServer\Pages\FetchData.razor"
__builder.AddContent(19, forecast.TemperatureF);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "td");
#nullable restore
#line (33,26)-(33,42) 25 "C:\Users\stega\Documents\Project\Cursos\curso-profesional\blazor\FundamentosBlazor\FundamentosServer\Pages\FetchData.razor"
__builder.AddContent(22, forecast.Summary);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\stega\Documents\Project\Cursos\curso-profesional\blazor\FundamentosBlazor\FundamentosServer\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\stega\Documents\Project\Cursos\curso-profesional\blazor\FundamentosBlazor\FundamentosServer\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\stega\Documents\Project\Cursos\curso-profesional\blazor\FundamentosBlazor\FundamentosServer\Pages\FetchData.razor"
       
    private WeatherForecast[]? forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateOnly.FromDateTime(DateTime.Now));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
