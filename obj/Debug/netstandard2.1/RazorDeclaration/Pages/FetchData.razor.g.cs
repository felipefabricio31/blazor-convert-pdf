#pragma checksum "C:\PROJETOS E ARQUIVOS DE TRABALHO\PROJETOS\EXEMPLOS\ConvertImageToPdf\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6a77d898b4dcc5cb936f9220179c723cc24f494"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ConvertImageToPdf.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\PROJETOS E ARQUIVOS DE TRABALHO\PROJETOS\EXEMPLOS\ConvertImageToPdf\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\PROJETOS E ARQUIVOS DE TRABALHO\PROJETOS\EXEMPLOS\ConvertImageToPdf\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\PROJETOS E ARQUIVOS DE TRABALHO\PROJETOS\EXEMPLOS\ConvertImageToPdf\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\PROJETOS E ARQUIVOS DE TRABALHO\PROJETOS\EXEMPLOS\ConvertImageToPdf\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\PROJETOS E ARQUIVOS DE TRABALHO\PROJETOS\EXEMPLOS\ConvertImageToPdf\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\PROJETOS E ARQUIVOS DE TRABALHO\PROJETOS\EXEMPLOS\ConvertImageToPdf\_Imports.razor"
using ConvertImageToPdf;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\PROJETOS E ARQUIVOS DE TRABALHO\PROJETOS\EXEMPLOS\ConvertImageToPdf\_Imports.razor"
using ConvertImageToPdf.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\PROJETOS E ARQUIVOS DE TRABALHO\PROJETOS\EXEMPLOS\ConvertImageToPdf\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetJsonAsync<WeatherForecast[]>("sample-data/weather.json");
    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
