#pragma checksum "/Users/Max/Desktop/Epicodus/UniversityTracker.Solution/UniversityTracker/Views/Student/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc91c8eec7f5cebcaa9a27e1f707de5636f8b729"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Create), @"mvc.1.0.view", @"/Views/Student/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Create.cshtml", typeof(AspNetCore.Views_Student_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc91c8eec7f5cebcaa9a27e1f707de5636f8b729", @"/Views/Student/Create.cshtml")]
    public class Views_Student_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UniversityTracker.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Max/Desktop/Epicodus/UniversityTracker.Solution/UniversityTracker/Views/Student/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(68, 27, true);
            WriteLiteral("<h1>Add a new Student</h1>\n");
            EndContext();
#line 7 "/Users/Max/Desktop/Epicodus/UniversityTracker.Solution/UniversityTracker/Views/Student/Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(128, 34, false);
#line 9 "/Users/Max/Desktop/Epicodus/UniversityTracker.Solution/UniversityTracker/Views/Student/Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(168, 36, false);
#line 10 "/Users/Max/Desktop/Epicodus/UniversityTracker.Solution/UniversityTracker/Views/Student/Create.cshtml"
Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(210, 44, false);
#line 11 "/Users/Max/Desktop/Epicodus/UniversityTracker.Solution/UniversityTracker/Views/Student/Create.cshtml"
Write(Html.LabelFor(model => model.EnrollmentDate));

#line default
#line hidden
            EndContext();
            BeginContext(260, 46, false);
#line 12 "/Users/Max/Desktop/Epicodus/UniversityTracker.Solution/UniversityTracker/Views/Student/Create.cshtml"
Write(Html.TextBoxFor(model => model.EnrollmentDate));

#line default
#line hidden
            EndContext();
            BeginContext(307, 75, true);
            WriteLiteral("    <input type=\"submit\" value=\"Add a new student\" class=\"btn btn-info\" />\n");
            EndContext();
#line 14 "/Users/Max/Desktop/Epicodus/UniversityTracker.Solution/UniversityTracker/Views/Student/Create.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UniversityTracker.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591