#pragma checksum "D:\PROGRA I\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Tarjeta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17577e37f5b0fca85497d1a1165fc3812c07b74e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalogo_Tarjeta), @"mvc.1.0.view", @"/Views/Catalogo/Tarjeta.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17577e37f5b0fca85497d1a1165fc3812c07b74e", @"/Views/Catalogo/Tarjeta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca2a3f6eee9dcdacc58d46738eadf82486ff659e", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalogo_Tarjeta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GrupoPrueba2.Models.Catalogo>>
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
#line 3 "D:\PROGRA I\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Tarjeta.cshtml"
  
    ViewData["Title"] = "Tarjetas Gráficas";  

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\'h1-catalogo\'>");
#nullable restore
#line 7 "D:\PROGRA I\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Tarjeta.cshtml"
                   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n   \r\n    <h1>");
#nullable restore
#line 9 "D:\PROGRA I\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Tarjeta.cshtml"
   Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    \r\n      <div id=\"products\" class=\"catalogo-container\">\r\n");
#nullable restore
#line 12 "D:\PROGRA I\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Tarjeta.cshtml"
             foreach (var item in Model) {
              if(item.Id >= 5 && item.Id < 9){

#line default
#line hidden
#nullable disable
            WriteLiteral("          <div class=\"catalogo-body\">\r\n                  <div class=\"catalogo-img\">\r\n                    <img class=\"img-responsive\"");
            BeginWriteAttribute("src", "\r\n                       src=\"", 482, "\"", 533, 2);
            WriteAttributeValue("", 512, "/img/", 512, 5, true);
#nullable restore
#line 17 "D:\PROGRA I\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Tarjeta.cshtml"
WriteAttributeValue("", 517, item.ImagenName, 517, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 534, "\"", 556, 1);
#nullable restore
#line 17 "D:\PROGRA I\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Tarjeta.cshtml"
WriteAttributeValue("", 540, item.ImagenName, 540, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                  </div>\r\n                  <div class=\'catalogo-text\'>\r\n                    <h5 class=\"catalogo-title\">");
#nullable restore
#line 20 "D:\PROGRA I\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Tarjeta.cshtml"
                                          Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"catalogo-p\">");
#nullable restore
#line 21 "D:\PROGRA I\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Tarjeta.cshtml"
                                     Write(Html.DisplayFor(modelItem => item.descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"catalogo-p\">");
#nullable restore
#line 22 "D:\PROGRA I\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Tarjeta.cshtml"
                                     Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" soles </p>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17577e37f5b0fca85497d1a1165fc3812c07b74e6787", async() => {
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
#line 23 "D:\PROGRA I\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Tarjeta.cshtml"
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
#line 26 "D:\PROGRA I\GrupoPrueba2\GrupoPrueba2\Views\Catalogo\Tarjeta.cshtml"
              }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n     \r\n ");
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
