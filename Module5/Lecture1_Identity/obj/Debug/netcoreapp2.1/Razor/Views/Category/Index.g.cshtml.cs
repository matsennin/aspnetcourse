#pragma checksum "C:\Users\caval\Documents\Visual Studio 2017\Projects\Repositories\aspnetcourse\Module4\Lecture1_Identity\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d7462867e6382585222d89efdac4c8dc16ca343"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Category/Index.cshtml", typeof(AspNetCore.Views_Category_Index))]
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
#line 1 "C:\Users\caval\Documents\Visual Studio 2017\Projects\Repositories\aspnetcourse\Module4\Lecture1_Identity\Views\_ViewImports.cshtml"
using Lecture1_Identity;

#line default
#line hidden
#line 2 "C:\Users\caval\Documents\Visual Studio 2017\Projects\Repositories\aspnetcourse\Module4\Lecture1_Identity\Views\_ViewImports.cshtml"
using Lecture1_Identity.Models;

#line default
#line hidden
#line 1 "C:\Users\caval\Documents\Visual Studio 2017\Projects\Repositories\aspnetcourse\Module4\Lecture1_Identity\Views\Category\Index.cshtml"
using Lecture1_Identity.Domain;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d7462867e6382585222d89efdac4c8dc16ca343", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5d8c9cafacda59652f69a1acf8033a1043d5555", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lecture1_Identity.Domain.Category>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\caval\Documents\Visual Studio 2017\Projects\Repositories\aspnetcourse\Module4\Lecture1_Identity\Views\Category\Index.cshtml"
   
    ViewData["Title"] = "Category";
    string idCategoria = Model?.Id != null ? Model?.Id.ToString() : "";

#line default
#line hidden
            BeginContext(194, 8, true);
            WriteLiteral("\r\n<ul>\r\n");
            EndContext();
#line 9 "C:\Users\caval\Documents\Visual Studio 2017\Projects\Repositories\aspnetcourse\Module4\Lecture1_Identity\Views\Category\Index.cshtml"
     foreach(var item in ViewBag.Categories as List<Category>) 
    {

#line default
#line hidden
            BeginContext(274, 55, true);
            WriteLiteral("        <li style=\"cursor:pointer;\">\r\n            <span");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 329, "\"", 347, 2);
            WriteAttributeValue("", 334, "Name_", 334, 5, true);
#line 12 "C:\Users\caval\Documents\Visual Studio 2017\Projects\Repositories\aspnetcourse\Module4\Lecture1_Identity\Views\Category\Index.cshtml"
WriteAttributeValue("", 339, item.Id, 339, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(348, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(350, 9, false);
#line 12 "C:\Users\caval\Documents\Visual Studio 2017\Projects\Repositories\aspnetcourse\Module4\Lecture1_Identity\Views\Category\Index.cshtml"
                                Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(359, 23, true);
            WriteLiteral("</span>\r\n            <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 382, "\"", 426, 3);
            WriteAttributeValue("", 392, "PreencherFormularioById(", 392, 24, true);
#line 13 "C:\Users\caval\Documents\Visual Studio 2017\Projects\Repositories\aspnetcourse\Module4\Lecture1_Identity\Views\Category\Index.cshtml"
WriteAttributeValue("", 416, item.Id, 416, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 424, ");", 424, 2, true);
            EndWriteAttribute();
            BeginContext(427, 27, true);
            WriteLiteral(">Editar</a>\r\n            <a");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 454, "\"", 480, 2);
            WriteAttributeValue("", 459, "DeleteButton_", 459, 13, true);
#line 14 "C:\Users\caval\Documents\Visual Studio 2017\Projects\Repositories\aspnetcourse\Module4\Lecture1_Identity\Views\Category\Index.cshtml"
WriteAttributeValue("", 472, item.Id, 472, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 481, "\"", 551, 4);
            WriteAttributeValue("", 491, "PostDeleteCategory(\'DELETE\',", 491, 28, true);
            WriteAttributeValue(" ", 519, "\'/Category/Delete/\',", 520, 21, true);
#line 14 "C:\Users\caval\Documents\Visual Studio 2017\Projects\Repositories\aspnetcourse\Module4\Lecture1_Identity\Views\Category\Index.cshtml"
WriteAttributeValue(" ", 540, item.Id, 541, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 549, ");", 549, 2, true);
            EndWriteAttribute();
            BeginContext(552, 52, true);
            WriteLiteral(" class=\"btn btn-default\">Delete</a>\r\n        </li>\r\n");
            EndContext();
#line 16 "C:\Users\caval\Documents\Visual Studio 2017\Projects\Repositories\aspnetcourse\Module4\Lecture1_Identity\Views\Category\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(611, 75, true);
            WriteLiteral("</ul>\r\n\r\n<div class=\"form-group\">\r\n    <label for=\"Name\">Name</label>\r\n    ");
            EndContext();
            BeginContext(686, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "576dd57760e241bca80bc49f46bd19e9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 21 "C:\Users\caval\Documents\Visual Studio 2017\Projects\Repositories\aspnetcourse\Module4\Lecture1_Identity\Views\Category\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(743, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(749, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "45608bca39b14441ad4b943bd9119485", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 22 "C:\Users\caval\Documents\Visual Studio 2017\Projects\Repositories\aspnetcourse\Module4\Lecture1_Identity\Views\Category\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(806, 1397, true);
            WriteLiteral(@"
    <button onclick=""PostDeleteCategory('POST', '/Category/Register');"" class=""btn btn-default"">Salvar</button>
</div>

<script>
    IsIdExists();

    function IsIdExists(){
        document.getElementById('DeleteButton').style.visibility = 'hidden';
        if(document.getElementById('Id').value > 0 && document.getElementById('Name').value !== """"){
            document.getElementById('DeleteButton').style.visibility = 'visible';
        }
    }

    function PostDeleteCategory(method, rota, Id)
    {
        rota = PreencherRota(rota, Id);
        var xhttp = new XMLHttpRequest();
        xhttp.onreadystatechange = function() {
            if (this.readyState == 4 && this.status == 200) {
                document.body.innerHTML = this.responseText;
                IsIdExists();
            }
        };
        xhttp.open(method, rota, true);
        xhttp.send();
        IsIdExists();
    }

    function PreencherRota(rota, Id){
        if(Id == null || Id === 0)
            ");
            WriteLiteral(@"Id = document.getElementById('Id').value;

        return rota += ""?Id="" + Id + ""&Name="" + document.getElementById('Name').value;
    }

    function PreencherFormularioById(Id){
        document.getElementById('Id').value = Id;
        document.getElementById('Name').value = document.getElementById('Name_' + Id).innerHTML;
        IsIdExists();
    }
</script>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lecture1_Identity.Domain.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
