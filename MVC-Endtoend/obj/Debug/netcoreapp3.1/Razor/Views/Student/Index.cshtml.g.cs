#pragma checksum "C:\Users\Yoseph\Desktop\_CrashCourses\2022\C-FullStackTurial\MVC-Endtoend\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a89a23adce4242cdab4a7dbce841cc68f319d280"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\Yoseph\Desktop\_CrashCourses\2022\C-FullStackTurial\MVC-Endtoend\Views\_ViewImports.cshtml"
using MVC_Endtoend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yoseph\Desktop\_CrashCourses\2022\C-FullStackTurial\MVC-Endtoend\Views\_ViewImports.cshtml"
using MVC_Endtoend.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a89a23adce4242cdab4a7dbce841cc68f319d280", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0930337c0bfd4bd2843b13f30b058f0e6e066fd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Student>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Welcome to Student\'s Page</h2>\r\n");
#nullable restore
#line 4 "C:\Users\Yoseph\Desktop\_CrashCourses\2022\C-FullStackTurial\MVC-Endtoend\Views\Student\Index.cshtml"
Write(ViewBag.title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n");
#nullable restore
#line 5 "C:\Users\Yoseph\Desktop\_CrashCourses\2022\C-FullStackTurial\MVC-Endtoend\Views\Student\Index.cshtml"
Write(ViewBag.fname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<ul>\r\n");
#nullable restore
#line 8 "C:\Users\Yoseph\Desktop\_CrashCourses\2022\C-FullStackTurial\MVC-Endtoend\Views\Student\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 10 "C:\Users\Yoseph\Desktop\_CrashCourses\2022\C-FullStackTurial\MVC-Endtoend\Views\Student\Index.cshtml"
       Write(item.FName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 10 "C:\Users\Yoseph\Desktop\_CrashCourses\2022\C-FullStackTurial\MVC-Endtoend\Views\Student\Index.cshtml"
                     Write(item.LName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 11 "C:\Users\Yoseph\Desktop\_CrashCourses\2022\C-FullStackTurial\MVC-Endtoend\Views\Student\Index.cshtml"
        
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Student>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
