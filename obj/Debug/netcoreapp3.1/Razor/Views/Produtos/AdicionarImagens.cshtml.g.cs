#pragma checksum "C:\C#\Pessoas\Views\Produtos\AdicionarImagens.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6312817d3cfbf76c6a5ae1035683154dc5295094"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produtos_AdicionarImagens), @"mvc.1.0.view", @"/Views/Produtos/AdicionarImagens.cshtml")]
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
#line 1 "C:\C#\Pessoas\Views\_ViewImports.cshtml"
using Pessoas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\C#\Pessoas\Views\_ViewImports.cshtml"
using Pessoas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6312817d3cfbf76c6a5ae1035683154dc5295094", @"/Views/Produtos/AdicionarImagens.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"500ed14fd09ac9f55401c7a837c0ca141f93d20c", @"/Views/_ViewImports.cshtml")]
    public class Views_Produtos_AdicionarImagens : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pessoas.ViewModels.ImagensProdutoViewModel.ListaImagensProduto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Produtos/UploadFile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropzone"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("dropzoneForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeletarImagem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("align", new global::Microsoft.AspNetCore.Html.HtmlString("center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\C#\Pessoas\Views\Produtos\AdicionarImagens.cshtml"
  
    ViewData["Title"] = "Adicionar Imagens ao produto";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3><a href=\"/Produtos/Index\">Produtos</a> > <a");
            BeginWriteAttribute("href", " href=\"", 184, "\"", 233, 3);
            WriteAttributeValue("", 191, "/Produtos/", 191, 10, true);
#nullable restore
#line 6 "C:\C#\Pessoas\Views\Produtos\AdicionarImagens.cshtml"
WriteAttributeValue("", 201, Model.Produto.ProdutoId, 201, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 225, "/Details", 225, 8, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 6 "C:\C#\Pessoas\Views\Produtos\AdicionarImagens.cshtml"
                                                                                             Write(Model.Produto.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> > Imagens do Produto</h3>\r\n\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-1\">\r\n\r\n\r\n    </div>\r\n    <div class=\"col-md-10\">\r\n        <Strong>Adicione as imagens aqui</Strong>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6312817d3cfbf76c6a5ae1035683154dc52950947005", async() => {
                WriteLiteral("\r\n\r\n            <input name=\"produtoId\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 646, "\"", 678, 1);
#nullable restore
#line 20 "C:\C#\Pessoas\Views\Produtos\AdicionarImagens.cshtml"
WriteAttributeValue("", 654, Model.Produto.ProdutoId, 654, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <div class=\"fallback\">\r\n                <input name=\"file\" type=\"file\" multiple />\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <br />
        <div align=""center"">
            <button type=""submit"" class=""btn btn-info"" id=""submit""><i class=""fa fa-floppy-o""></i>Upload</button>
        </div>

        <div class=""panel panel-default"">
            <br />
            <Strong>Lista de imagens do produto</Strong>
            <div class=""row"">
");
#nullable restore
#line 34 "C:\C#\Pessoas\Views\Produtos\AdicionarImagens.cshtml"
                 for (int i = 0; i < Model.ImagensProduto.Count; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card\" style=\"width: 18rem;margin-bottom: 20px;margin-right: 20px;margin-left: 20px;border-top-width: 0px;margin-top: 20px;\">\r\n                        <div class=\"card-body\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1476, "\"", 1516, 1);
#nullable restore
#line 38 "C:\C#\Pessoas\Views\Produtos\AdicionarImagens.cshtml"
WriteAttributeValue("", 1482, Model.ImagensProduto[i].ImagemUrl, 1482, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" style=\"width: 200px;\">\r\n                            <div class=\"card-body\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6312817d3cfbf76c6a5ae1035683154dc529509410959", async() => {
                WriteLiteral("\r\n\r\n                                    <input name=\"imagemId\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1772, "\"", 1820, 1);
#nullable restore
#line 42 "C:\C#\Pessoas\Views\Produtos\AdicionarImagens.cshtml"
WriteAttributeValue("", 1780, Model.ImagensProduto[i].ImagemProdutoId, 1780, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 48 "C:\C#\Pessoas\Views\Produtos\AdicionarImagens.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-1\">\r\n\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        function myParamName() {\r\n            var files = \"files\";\r\n            var produtoId = ");
#nullable restore
#line 63 "C:\C#\Pessoas\Views\Produtos\AdicionarImagens.cshtml"
                       Write(Model.Produto.ProdutoId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
            return produtoId, files;
        }
        Dropzone.options.dropzoneForm = {
               autoProcessQueue: false,
            paramName: myParamName, // The name that will be used to transfer the file
            addRemoveLinks: true,
            uploadMultiple: true,
            parallelUploads: 100,
            acceptedFiles: "".png,.jpg,.gif,.jpeg"",
            init: function () {
                console.log(""active"");
                var wrapperThis = this;

                $(""#submit"").click(function (e) {
                    //var produtoId =  Model.Produto.ProdutoId;
                    //var files = ""files"";
                    //alert(produtoId + files);
                    console.log($(this));
                    e.preventDefault();
                    wrapperThis.processQueue();
                });
            },
            accept: function (file, done) {
                done();
            },
            removedfile: function (file) {
                va");
                WriteLiteral(@"r _ref;
                return (_ref = file.previewElement) != null ? _ref.parentNode.removeChild(file.previewElement) : void 0;
            }
        };
        $.getJSON('/Produtos/ListagemImagens', function (data) {
            $.each(data, function (index, val) {
                var mockFile = { name: val.name, size: val.size };
                thisDropzone.options.addedfile.call(thisDropzone, mockFile);
                thisDropzone.options.thumbnail.call(thisDropzone, mockFile, ""/Produtos/UploadFile"" + val.name);
            });
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pessoas.ViewModels.ImagensProdutoViewModel.ListaImagensProduto> Html { get; private set; }
    }
}
#pragma warning restore 1591
