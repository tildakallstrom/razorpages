#pragma checksum "C:\Users\tilda\source\repos\mom1\mom1\Pages\Razor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d93387bb0bf94682cb45f526eda805e24c7cf65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(mom1.Pages.Pages_Razor), @"mvc.1.0.razor-page", @"/Pages/Razor.cshtml")]
namespace mom1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\tilda\source\repos\mom1\mom1\Pages\_ViewImports.cshtml"
using mom1;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d93387bb0bf94682cb45f526eda805e24c7cf65", @"/Pages/Razor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1243504fc924c5c0646940b07ebd6cd3f991039", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Razor : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\tilda\source\repos\mom1\mom1\Pages\Razor.cshtml"
  

    //todays day
    var dateValue = DateTime.Now;
    string dayOfWeek = dateValue.ToString("dddd");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Razor</h1>\r\n<p>Today it is ");
#nullable restore
#line 13 "C:\Users\tilda\source\repos\mom1\mom1\Pages\Razor.cshtml"
          Write(dateValue.ToString("dddd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<!--if its monday, write it out, if its not, write that out-->\r\n");
#nullable restore
#line 16 "C:\Users\tilda\source\repos\mom1\mom1\Pages\Razor.cshtml"
 if (dayOfWeek == "Monday")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Today is monday</p>\r\n");
#nullable restore
#line 19 "C:\Users\tilda\source\repos\mom1\mom1\Pages\Razor.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>It is not monday</p>\r\n");
#nullable restore
#line 23 "C:\Users\tilda\source\repos\mom1\mom1\Pages\Razor.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 25 "C:\Users\tilda\source\repos\mom1\mom1\Pages\Razor.cshtml"
  
    var date = DateTime.Now;

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    ");
#nullable restore
#line 29 "C:\Users\tilda\source\repos\mom1\mom1\Pages\Razor.cshtml"
Write(date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n");
#nullable restore
#line 32 "C:\Users\tilda\source\repos\mom1\mom1\Pages\Razor.cshtml"
  


    var title = "Courses";
    var courses = new string[]
    {
        "DT057G Webbutveckling I",
        "DT084G Introduktion till programmering med JavaScript",
        "DT163G Digital bildbehandling f??r webb",
        "DT008G Typografi och form f??r webb",
        "DT093G Webbutveckling II",
        "DT003G Databaser",
        "DT068G Webbanv??ndbarhet",
        "DT152G Webbdesign f??r CMS",
        "DT173G Webbutveckling III",
        "IK060G Projektledning",
        "DT071G Programmering i C#.NET"
                    };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>");
#nullable restore
#line 53 "C:\Users\tilda\source\repos\mom1\mom1\Pages\Razor.cshtml"
Write(title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n\r\n<p>Aren\'t you tired of reading about the courses yet?</p>\r\n\r\n<ul>\r\n");
#nullable restore
#line 59 "C:\Users\tilda\source\repos\mom1\mom1\Pages\Razor.cshtml"
     foreach (var course in courses)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 61 "C:\Users\tilda\source\repos\mom1\mom1\Pages\Razor.cshtml"
       Write(course);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 62 "C:\Users\tilda\source\repos\mom1\mom1\Pages\Razor.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<mom1.Pages.RazorModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<mom1.Pages.RazorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<mom1.Pages.RazorModel>)PageContext?.ViewData;
        public mom1.Pages.RazorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
