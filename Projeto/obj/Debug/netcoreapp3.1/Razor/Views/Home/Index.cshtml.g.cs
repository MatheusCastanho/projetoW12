#pragma checksum "/home/matheusprcastanho/projetoW12/Projeto/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "221f16f0b359b4b2c43b3a7e9813c2734c69dc6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/home/matheusprcastanho/projetoW12/Projeto/Views/_ViewImports.cshtml"
using Projeto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/matheusprcastanho/projetoW12/Projeto/Views/_ViewImports.cshtml"
using Projeto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"221f16f0b359b4b2c43b3a7e9813c2734c69dc6c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d4dfd97469170fe8b85a6370378ea67b5320a14", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Projeto.Models.Proxy.RepositoriesProxy>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "221f16f0b359b4b2c43b3a7e9813c2734c69dc6c2976", async() => {
                WriteLiteral("\r\n\r\n");
                WriteLiteral("\r\n");
#nullable restore
#line 5 "/home/matheusprcastanho/projetoW12/Projeto/Views/Home/Index.cshtml"
      ViewData["Title"] = "Meus Repositórios";

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n<link rel=\"stylesheet\" type=\"text/css\" href=\"css/stylesheet.css\">\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("     \r\n\r\n\r\n\r\n<div id=\"repositorios\">\r\n    <h2>Repositórios:</h2>   \r\n</div>\r\n\r\n");
#nullable restore
#line 17 "/home/matheusprcastanho/projetoW12/Projeto/Views/Home/Index.cshtml"
 foreach (var item in Model)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"linkRepositorios\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 355, "\"", 403, 1);
#nullable restore
#line 21 "/home/matheusprcastanho/projetoW12/Projeto/Views/Home/Index.cshtml"
WriteAttributeValue("", 362, Url.Action("Detail",new{repo=item.Name}), 362, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 21 "/home/matheusprcastanho/projetoW12/Projeto/Views/Home/Index.cshtml"
                                                        Write(item.Full_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n     </div> \r\n");
#nullable restore
#line 23 "/home/matheusprcastanho/projetoW12/Projeto/Views/Home/Index.cshtml"

 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    \r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Projeto.Models.Proxy.RepositoriesProxy>> Html { get; private set; }
    }
}
#pragma warning restore 1591
