#pragma checksum "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d59fa86ca59ec33c58697739071e20ede8944d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gallery_Search), @"mvc.1.0.view", @"/Views/Gallery/Search.cshtml")]
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
#line 1 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\_ViewImports.cshtml"
using ASP.NET_Team_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\_ViewImports.cshtml"
using ASP.NET_Team_1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d59fa86ca59ec33c58697739071e20ede8944d7", @"/Views/Gallery/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18e37aacfd35dc807419fd66fbdd7ab3e24ee5c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Gallery_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Gallery/GalleryPage.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Search.cshtml"
  
    ViewData["Title"] = "Index";
    string sessionId = (string)ViewData["sessionId"];
    string userId = (string)ViewData["UserId"];
    var products = (List<Product>)ViewData["products"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d59fa86ca59ec33c58697739071e20ede8944d74182", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n<table>\r\n");
#nullable restore
#line 15 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Search.cshtml"
     for (int i = 0; i < products.Count; i += 3)
    {
        int j;


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n");
#nullable restore
#line 20 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Search.cshtml"
             for (j = 0; j < 3 && i + j < products.Count; j++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    <table class=\"inner-table\">\r\n                        <tr>\r\n                            <td>\r\n");
#nullable restore
#line 26 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Search.cshtml"
                                  
                                    string url = "/Images/" + products[i + j].ProductLogo;
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"card-img-top\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=", 864, "", 873, 1);
#nullable restore
#line 30 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Search.cshtml"
WriteAttributeValue("", 869, url, 869, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"175\" />\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td class=\"card-title\">");
#nullable restore
#line 35 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Search.cshtml"
                                              Write(products[i + j].ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td class=\"card-text\"><small>");
#nullable restore
#line 38 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Search.cshtml"
                                                    Write(products[i + j].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td class=\"card-title\">$ ");
#nullable restore
#line 41 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Search.cshtml"
                                                Write(products[i + j].Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n");
#nullable restore
#line 44 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Search.cshtml"
                             if (products[i + j].NumReviews != 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    <!--Code for star rating-->\r\n");
#nullable restore
#line 48 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Search.cshtml"
                                      int k = 1; 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    Rating:");
#nullable restore
#line 49 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Search.cshtml"
                                            for (; k <= Math.Floor(products[i + j].Rating); k++)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            WriteLiteral(" &#10022;\r\n");
#nullable restore
#line 52 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Search.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 54 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Search.cshtml"
                                     for (; k <= 5; k++)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            WriteLiteral(" &#10023;\r\n");
#nullable restore
#line 57 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Search.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
#nullable restore
#line 58 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Search.cshtml"
                               Write(products[i + j].Rating.ToString("0.0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" out of 5\r\n                                    <br />");
#nullable restore
#line 59 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Search.cshtml"
                                     Write(products[i + j].NumReviews);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Customer Reviews\r\n                                </td>\r\n");
#nullable restore
#line 61 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Search.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>No customer reviews</td>\r\n");
#nullable restore
#line 65 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Search.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\r\n");
#nullable restore
#line 67 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Search.cshtml"
                          
                            string recId = products[i + j].ProductID + "rec";
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <tr height=\"20px\">\r\n                            <td>\r\n                                <input type=\"Button\" value=\"Add to Cart\" class=\"cartButton\"");
            BeginWriteAttribute("id", " id=", 2888, "", 2898, 1);
#nullable restore
#line 73 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Search.cshtml"
WriteAttributeValue("", 2892, recId, 2892, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            </td>\r\n                        </tr>\r\n                    </table>\r\n                </td>\r\n");
#nullable restore
#line 78 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Search.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 80 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Search.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
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
