#pragma checksum "C:\Users\stega\Documents\Project\Cursos\curso-profesional\blazor\FundamentosBlazor\FundamentosServer\Shared\MainLayout.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4b376977ec2c9df3aaecd819d04848bfa7ae16a2bdae9fd98890a25d10bf50a8"
// <auto-generated/>
#pragma warning disable 1591
namespace FundamentosServer.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Web.PageTitle>(0);
            __builder.AddAttribute(1, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(2, "FundamentosServer");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "page");
            __builder.AddAttribute(6, "b-mhjx0qd6hv");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "sidebar");
            __builder.AddAttribute(9, "b-mhjx0qd6hv");
            __builder.OpenComponent<global::FundamentosServer.Shared.NavMenu>(10);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n    ");
            __builder.OpenElement(12, "main");
            __builder.AddAttribute(13, "b-mhjx0qd6hv");
            __builder.AddMarkupContent(14, "<div class=\"top-row px-4\" b-mhjx0qd6hv><a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\" b-mhjx0qd6hv>About</a></div>\r\n\r\n        ");
            __builder.OpenElement(15, "article");
            __builder.AddAttribute(16, "class", "content px-4");
            __builder.AddAttribute(17, "b-mhjx0qd6hv");
#nullable restore
#line (16,14)-(16,18) 25 "C:\Users\stega\Documents\Project\Cursos\curso-profesional\blazor\FundamentosBlazor\FundamentosServer\Shared\MainLayout.razor"
__builder.AddContent(18, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
