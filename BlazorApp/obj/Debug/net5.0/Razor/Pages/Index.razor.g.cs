#pragma checksum "/home/runner/BlazorTest/BlazorApp/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22e3f73aee3dbeda6afe768ba9dd670c1c74ed9e"
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
#line 1 "/home/runner/BlazorTest/BlazorApp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/runner/BlazorTest/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/runner/BlazorTest/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/runner/BlazorTest/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/runner/BlazorTest/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/runner/BlazorTest/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/runner/BlazorTest/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/runner/BlazorTest/BlazorApp/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/runner/BlazorTest/BlazorApp/_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/runner/BlazorTest/BlazorApp/_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Welcome to My Blazor App</h1>\n\n");
            __builder.AddMarkupContent(1, "<p>This is a basic Blazor app created in Replit.</p>\n\n");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "class", "btn btn-primary");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "/home/runner/BlazorTest/BlazorApp/Pages/Index.razor"
                                          ShowMessage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, "Click me!");
            __builder.CloseElement();
#nullable restore
#line 9 "/home/runner/BlazorTest/BlazorApp/Pages/Index.razor"
 if (showMessage)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<p>Hello, you clicked the button!</p>");
#nullable restore
#line 12 "/home/runner/BlazorTest/BlazorApp/Pages/Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "/home/runner/BlazorTest/BlazorApp/Pages/Index.razor"
       
    private bool showMessage = false;

    private void ShowMessage()
    {
        showMessage = true;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
