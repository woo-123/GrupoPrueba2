#pragma checksum "D:\PROGRA I\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Pc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a63086455b3307ec4ff6b14e93458e5d0bfa9668"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalogo_Pc), @"mvc.1.0.view", @"/Views/Catalogo/Pc.cshtml")]
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
#line 1 "D:\PROGRA I\GrupoPrueba2\GrupoPrueba2\Views\_ViewImports.cshtml"
using GrupoPrueba2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PROGRA I\GrupoPrueba2\GrupoPrueba2\Views\_ViewImports.cshtml"
using GrupoPrueba2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a63086455b3307ec4ff6b14e93458e5d0bfa9668", @"/Views/Catalogo/Pc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca2a3f6eee9dcdacc58d46738eadf82486ff659e", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalogo_Pc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GrupoPrueba2.Models.Catalogo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\PROGRA I\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Pc.cshtml"
  
    ViewData["Title"] = "PC Armadas";  

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"text-decoration:none;\r\n    font-size: 4em;\r\n    color:#fa9600;\r\n    text-align: center;\r\n    font-weight: bold;\">");
#nullable restore
#line 11 "D:\PROGRA I\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Pc.cshtml"
                   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n  <div>\r\n    <h1>");
#nullable restore
#line 13 "D:\PROGRA I\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Pc.cshtml"
   Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <div class=\"row\">\r\n      <div class=\"col\">\r\n        <div id=\"products\" class=\"mb-3\">\r\n          <div class=\"row\">\r\n");
#nullable restore
#line 18 "D:\PROGRA I\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Pc.cshtml"
             foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-sm-4"">
              <div class=""card mb-3"" style=""margin-left: 10%; margin-right: 30%;"" >
                <div class=""card-body"">
                  <div class=""card-img-actions"">
                    <img class=""img-responsive"" width=""96"" height=""150"" style=""margin-left:35%;""");
            BeginWriteAttribute("src", " \r\n                       src=\"", 766, "\"", 821, 2);
            WriteAttributeValue("", 797, "/images/", 797, 8, true);
#nullable restore
#line 24 "D:\PROGRA I\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Pc.cshtml"
WriteAttributeValue("", 805, item.ImagenName, 805, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 822, "\"", 844, 1);
#nullable restore
#line 24 "D:\PROGRA I\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Pc.cshtml"
WriteAttributeValue("", 828, item.ImagenName, 828, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  />\r\n                  </div>\r\n                </div>\r\n                <div class=\"card-body\">\r\n                  <h5 class=\"card-title\">");
#nullable restore
#line 28 "D:\PROGRA I\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Pc.cshtml"
                                    Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                  <p class=\"card-text\">");
#nullable restore
#line 29 "D:\PROGRA I\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Pc.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                  <p class=\"card-text\">");
#nullable restore
#line 30 "D:\PROGRA I\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Pc.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <b>soles </b></p>\r\n                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a63086455b3307ec4ff6b14e93458e5d0bfa96687040", async() => {
                WriteLiteral("Add");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "D:\PROGRA I\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Pc.cshtml"
                                                                WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n              </div>\r\n            </div>\r\n");
#nullable restore
#line 35 "D:\PROGRA I\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Pc.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("         </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </div> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GrupoPrueba2.Models.Catalogo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
