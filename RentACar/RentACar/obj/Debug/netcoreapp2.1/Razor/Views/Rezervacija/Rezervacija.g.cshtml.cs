#pragma checksum "/Users/amilalakovic/Projects/ooad-2018-2019/Grupa4-A.N.A.git/RentACar/RentACar/Views/Rezervacija/Rezervacija.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf227d81d0954d2a57e9b064030038ba665640ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rezervacija_Rezervacija), @"mvc.1.0.view", @"/Views/Rezervacija/Rezervacija.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Rezervacija/Rezervacija.cshtml", typeof(AspNetCore.Views_Rezervacija_Rezervacija))]
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
#line 1 "/Users/amilalakovic/Projects/ooad-2018-2019/Grupa4-A.N.A.git/RentACar/RentACar/Views/_ViewImports.cshtml"
using RentACar;

#line default
#line hidden
#line 2 "/Users/amilalakovic/Projects/ooad-2018-2019/Grupa4-A.N.A.git/RentACar/RentACar/Views/_ViewImports.cshtml"
using RentACar.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf227d81d0954d2a57e9b064030038ba665640ff", @"/Views/Rezervacija/Rezervacija.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0eb15c43ca34d0757bf544ad01cf9e6fac7aec62", @"/Views/_ViewImports.cshtml")]
    public class Views_Rezervacija_Rezervacija : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/fonts/material-icon/css/material-design-iconic-font.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/amilalakovic/Projects/ooad-2018-2019/Grupa4-A.N.A.git/RentACar/RentACar/Views/Rezervacija/Rezervacija.cshtml"
  
    ViewData["Title"] = "Rezervacija";

#line default
#line hidden
            BeginContext(44, 33, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(77, 456, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20f360d676244be8b2ae2b56fee08310", async() => {
                BeginContext(83, 276, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <script type=""text/javascript"" src=""js/zaPocetnu.js""></script>
    <title></title>

    <!-- Font Icon -->
    ");
                EndContext();
                BeginContext(359, 92, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d83ec0289a6948e8a7581c24fd459837", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(451, 28, true);
                WriteLiteral("\n\n    <!-- Main css -->\n    ");
                EndContext();
                BeginContext(479, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d0009b3caef04e54a494a2aa15cca209", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(525, 1, true);
                WriteLiteral("\n");
                EndContext();
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
            EndContext();
            BeginContext(533, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(534, 4364, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d79758341440465a8e03a8fce7830fed", async() => {
                BeginContext(540, 28, true);
                WriteLiteral("\n\n    <div class=\"main\">\n\n\n\n");
                EndContext();
#line 25 "/Users/amilalakovic/Projects/ooad-2018-2019/Grupa4-A.N.A.git/RentACar/RentACar/Views/Rezervacija/Rezervacija.cshtml"
         using (Html.BeginForm("Validacija", "Rezervacija"))
        {

#line default
#line hidden
                BeginContext(639, 4118, true);
                WriteLiteral(@"        <!-- Sing in  Form -->
        <section class=""sign-in"">
            <div class=""container"">
                <div class=""signin-content"">
                    <div class=""signin-image"">
                        <figure><img src=""../slike/car2.png"" alt=""sing up image""></figure>
                    </div>

                    <div class=""signin-form"">
                        <h2 class=""form-title"">Rezervacija</h2>

                        <div class=""form-group"">
                            <label for=""your_name""><i class=""zmdi zmdi-account material-icons-name""></i></label>
                            <input type=""text"" name=""lokacijaPreuzimanja"" id=""your_name"" placeholder=""Lokacija preuzimanja"" />
                        </div>

                        <div class=""form-group"">
                            <label for=""your_name""><i class=""zmdi zmdi-account material-icons-name""></i></label>
                            <input type=""text"" name=""lokacijaVracanja"" id=""your_name"" placeholder=""Lokacija vraćanja"" ");
                WriteLiteral(@"/>
                        </div>

                        <div class=""form-group"">
                            <label for=""your_name""><i class=""zmdi zmdi-account material-icons-name""></i></label>
                            <input type=""text"" name=""datumOD"" id=""your_name"" placeholder=""Datum od"" />
                        </div>


                        <div class=""form-group"">
                            <label for=""your_name""><i class=""zmdi zmdi-account material-icons-name""></i></label>
                            <input type=""text"" name=""datumDO"" id=""your_name"" placeholder=""Datum do"" />
                        </div>

                        <p>Način plaćanja</p>
                        <div class=""form-group"">
                            <input type=""checkbox"" name=""remember-me"" id=""navigacija"" class=""agree-term"" />
                            <label for=""navigacija"" class=""label-agree-term""><span><span></span></span>Sada</label>
                            <div class=""form-group"">
                      ");
                WriteLiteral(@"          <label for=""your_pass""><i class=""zmdi zmdi-account material-icons-name""></i></label>
                                <input type=""password"" name=""your_pass"" id=""your_pass"" placeholder=""Broj katrice"" />
                            </div>

                            <div class=""form-group"">
                                <label for=""your_pass""><i class=""zmdi zmdi-account material-icons-name""></i></label>
                                <input type=""password"" name=""your_pass"" id=""your_pass"" placeholder=""Banka"" />
                            </div>


                            <input type=""checkbox"" name=""remember-me"" id=""priPreuzimanju"" class=""agree-term"" />
                            <label for=""priPreuzimanju"" class=""label-agree-term""><span><span></span></span>Pri preuzimanju</label>

                        </div>


                        <div class=""form-group"">
                            <label for=""your_name""><i class=""zmdi zmdi-account material-icons-name""></i></label>
                    ");
                WriteLiteral(@"        <input type=""text"" name=""imeIPrezime"" id=""your_name"" placeholder=""Ime i prezime"" />
                        </div>

                        <div class=""form-group"">
                            <label for=""your_name""><i class=""zmdi zmdi-account material-icons-name""></i></label>
                            <input type=""text"" name=""datumRodjenja"" id=""your_name"" placeholder=""Datum rođenja"" />
                        </div>

                        <div class=""form-group"">
                            <label for=""your_name""><i class=""zmdi zmdi-account material-icons-name""></i></label>
                            <input type=""text"" name=""brojTelefona"" id=""your_name"" placeholder=""Broj telefona"" />
                        </div>


                        <div class=""form-group form-button"">
                            <button type = ""submit"" name = ""signin"" id = ""signin"" class = ""form-submit"" > Rezerviši</button>
                        </div>

                    </div>
                </div>
            </di");
                WriteLiteral("v>\n        </section>\n");
                EndContext();
#line 104 "/Users/amilalakovic/Projects/ooad-2018-2019/Grupa4-A.N.A.git/RentACar/RentACar/Views/Rezervacija/Rezervacija.cshtml"
        }

#line default
#line hidden
                BeginContext(4767, 124, true);
                WriteLiteral("\n    </div>\n\n    <!-- JS -->\n    <script src=\"vendor/jquery/jquery.min.js\"></script>\n    <script src=\"js/main.js\"></script>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4898, 76, true);
            WriteLiteral("<!-- This templates was made by Colorlib (https://colorlib.com) -->\n</html>\n");
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
