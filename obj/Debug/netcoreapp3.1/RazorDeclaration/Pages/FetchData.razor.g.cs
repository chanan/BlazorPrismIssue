#pragma checksum "A:\deleteme\testprism\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ac85b68c44f442d1f5de21cf8dc31e857e524ab"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace testprism.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "A:\deleteme\testprism\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "A:\deleteme\testprism\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "A:\deleteme\testprism\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "A:\deleteme\testprism\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "A:\deleteme\testprism\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "A:\deleteme\testprism\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "A:\deleteme\testprism\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "A:\deleteme\testprism\_Imports.razor"
using testprism;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "A:\deleteme\testprism\_Imports.razor"
using testprism.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "A:\deleteme\testprism\Pages\FetchData.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata/{measureVersionId}")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "A:\deleteme\testprism\Pages\FetchData.razor"
       
    [Parameter]
    public string measureVersionId { get; set; }

    public string JsonData { get; set; }
    public JToken jsonpretty { get; set; }

    protected override async Task OnParametersSetAsync()
    {

        this.SetJsonData();
        this.jsonpretty = JsonPrettify(this.JsonData);
    }



    public static JToken JsonPrettify(string json)
    {
        if (string.IsNullOrEmpty(json))
        {
            return "[]";
        }
        return JToken.Parse(json);
    }

    public void SetJsonData()
    {
        this.JsonData = @"[{""type"":""text"",""name"":""firstName"",""validators"":{""required"":true},""ui"":{""label"":""First Name"",""placeholder"":""Enter Your First Name""}},{""type"":""select"",""name"":""country"",""ui"":{""label"":""Country"",""placeholder"":""Select...""},""validators"":{""required"":true},""source"":[{""value"":1,""text"":""India""},{""value"":2,""text"":""Canada""},{""value"":1,""text"":""USA""}]}]";
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
