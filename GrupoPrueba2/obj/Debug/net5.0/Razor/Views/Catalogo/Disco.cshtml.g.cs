#pragma checksum "C:\Users\diego\Downloads\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Disco.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44dc83ef775d10919cc5c472d879790fd25649ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalogo_Disco), @"mvc.1.0.view", @"/Views/Catalogo/Disco.cshtml")]
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
#line 1 "C:\Users\diego\Downloads\GrupoPrueba2\GrupoPrueba2\Views\_ViewImports.cshtml"
using GrupoPrueba2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\diego\Downloads\GrupoPrueba2\GrupoPrueba2\Views\_ViewImports.cshtml"
using GrupoPrueba2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44dc83ef775d10919cc5c472d879790fd25649ce", @"/Views/Catalogo/Disco.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca2a3f6eee9dcdacc58d46738eadf82486ff659e", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalogo_Disco : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GrupoPrueba2.Models.Catalogo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("catalogo-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\diego\Downloads\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Disco.cshtml"
  
    ViewData["Title"] = "Disco Duro";  

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\'h1-catalogo\'>");
#nullable restore
#line 7 "C:\Users\diego\Downloads\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Disco.cshtml"
                   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n   <div class=\'banner\'></div>\r\n    <div class=\'banner2\'></div>\r\n    <h1>");
#nullable restore
#line 10 "C:\Users\diego\Downloads\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Disco.cshtml"
   Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n       <div id=\"products\" class=\"catalogo-container\">\r\n");
#nullable restore
#line 12 "C:\Users\diego\Downloads\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Disco.cshtml"
             foreach (var item in Model) {
              if(item.Id >= 17 && item.Id < 21){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"catalogo-body\">\r\n                  <div class=\"catalogo-img\">\r\n                    <img class=\"img-responsive\"");
            BeginWriteAttribute("src", "\r\n                       src=\"", 533, "\"", 584, 2);
            WriteAttributeValue("", 563, "/img/", 563, 5, true);
#nullable restore
#line 17 "C:\Users\diego\Downloads\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Disco.cshtml"
WriteAttributeValue("", 568, item.ImagenName, 568, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 585, "\"", 607, 1);
#nullable restore
#line 17 "C:\Users\diego\Downloads\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Disco.cshtml"
WriteAttributeValue("", 591, item.ImagenName, 591, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                  </div>\r\n                  <div class=\'catalogo-text\'>\r\n                    <h5 class=\"catalogo-title\">");
#nullable restore
#line 20 "C:\Users\diego\Downloads\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Disco.cshtml"
                                          Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"catalogo-p\">");
#nullable restore
#line 21 "C:\Users\diego\Downloads\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Disco.cshtml"
                                     Write(Html.DisplayFor(modelItem => item.descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"catalogo-p\">");
#nullable restore
#line 22 "C:\Users\diego\Downloads\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Disco.cshtml"
                                     Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" soles </p>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44dc83ef775d10919cc5c472d879790fd25649ce6971", async() => {
                WriteLiteral("Añadir al carrito");
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
#line 23 "C:\Users\diego\Downloads\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Disco.cshtml"
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
            WriteLiteral("\r\n                  </div>\r\n                </div>\r\n");
#nullable restore
#line 26 "C:\Users\diego\Downloads\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Disco.cshtml"
              }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("       </div>\r\n     \r\n  ");
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
