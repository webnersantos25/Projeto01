#pragma checksum "C:\Users\Benes\Documents\ASPNET\DESENVOLVIMENTO WEB\Site01\Projeto01\Site01\Views\Contato\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8767ff00b523617752cf31bad847a52668e90c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contato_Index), @"mvc.1.0.view", @"/Views/Contato/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contato/Index.cshtml", typeof(AspNetCore.Views_Contato_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8767ff00b523617752cf31bad847a52668e90c2", @"/Views/Contato/Index.cshtml")]
    public class Views_Contato_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Benes\Documents\ASPNET\DESENVOLVIMENTO WEB\Site01\Projeto01\Site01\Views\Contato\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\Benes\Documents\ASPNET\DESENVOLVIMENTO WEB\Site01\Projeto01\Site01\Views\Contato\Index.cshtml"
  

    ViewBag.Title = "Contato";

#line default
#line hidden
            BeginContext(99, 167, true);
            WriteLiteral("\r\n\r\n<form method=\"post\" action=\"/contato/recebercontato\">\r\n    <div class=\"form-group\">\r\n        <label for=\"nome\">Nome</label>\r\n        <input type=\"text\" name=\"nome\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 266, "\"", 295, 1);
#line 15 "C:\Users\Benes\Documents\ASPNET\DESENVOLVIMENTO WEB\Site01\Projeto01\Site01\Views\Contato\Index.cshtml"
WriteAttributeValue("", 274, ViewBag.Contato.Nome, 274, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(296, 74, true);
            WriteLiteral(" class=\"form-control\" id=\"nome\" placeholder=\"Digite o seu nome\">\r\n        ");
            EndContext();
            BeginContext(371, 30, false);
#line 16 "C:\Users\Benes\Documents\ASPNET\DESENVOLVIMENTO WEB\Site01\Projeto01\Site01\Views\Contato\Index.cshtml"
   Write(Html.ValidationMessage("nome"));

#line default
#line hidden
            EndContext();
            BeginContext(401, 128, true);
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <label for=\"email\">E-mail</label>\r\n        <input type=\"text\" name=\"email\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 529, "\"", 559, 1);
#line 21 "C:\Users\Benes\Documents\ASPNET\DESENVOLVIMENTO WEB\Site01\Projeto01\Site01\Views\Contato\Index.cshtml"
WriteAttributeValue("", 537, ViewBag.Contato.Email, 537, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(560, 77, true);
            WriteLiteral(" class=\"form-control\" id=\"email\" placeholder=\"Digite o seu e-mail\">\r\n        ");
            EndContext();
            BeginContext(638, 31, false);
#line 22 "C:\Users\Benes\Documents\ASPNET\DESENVOLVIMENTO WEB\Site01\Projeto01\Site01\Views\Contato\Index.cshtml"
   Write(Html.ValidationMessage("email"));

#line default
#line hidden
            EndContext();
            BeginContext(669, 133, true);
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <label for=\"assunto\">Assunto</label>\r\n        <input type=\"text\" name=\"assunto\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 802, "\"", 834, 1);
#line 27 "C:\Users\Benes\Documents\ASPNET\DESENVOLVIMENTO WEB\Site01\Projeto01\Site01\Views\Contato\Index.cshtml"
WriteAttributeValue("", 810, ViewBag.Contato.Assunto, 810, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(835, 76, true);
            WriteLiteral(" class=\"form-control\" id=\"assunto\" placeholder=\"Digite o assunto\">\r\n        ");
            EndContext();
            BeginContext(912, 33, false);
#line 28 "C:\Users\Benes\Documents\ASPNET\DESENVOLVIMENTO WEB\Site01\Projeto01\Site01\Views\Contato\Index.cshtml"
   Write(Html.ValidationMessage("assunto"));

#line default
#line hidden
            EndContext();
            BeginContext(945, 163, true);
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <label for=\"mensagem\">Mensagem</label>\r\n        <textarea name=\"mensagem\" class=\"form-control\" id=\"mensagem\">");
            EndContext();
            BeginContext(1109, 24, false);
#line 33 "C:\Users\Benes\Documents\ASPNET\DESENVOLVIMENTO WEB\Site01\Projeto01\Site01\Views\Contato\Index.cshtml"
                                                                Write(ViewBag.Contato.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(1133, 21, true);
            WriteLiteral("</textarea>\r\n        ");
            EndContext();
            BeginContext(1155, 34, false);
#line 34 "C:\Users\Benes\Documents\ASPNET\DESENVOLVIMENTO WEB\Site01\Projeto01\Site01\Views\Contato\Index.cshtml"
   Write(Html.ValidationMessage("mensagem"));

#line default
#line hidden
            EndContext();
            BeginContext(1189, 92, true);
            WriteLiteral("\r\n    </div>\r\n\r\n    <button type=\"submit\" class=\"btn btn-primary\">Enviar</button>\r\n</form>\r\n");
            EndContext();
            BeginContext(1282, 16, false);
#line 39 "C:\Users\Benes\Documents\ASPNET\DESENVOLVIMENTO WEB\Site01\Projeto01\Site01\Views\Contato\Index.cshtml"
Write(ViewBag.Mensagem);

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
