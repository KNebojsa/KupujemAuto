#pragma checksum "C:\Users\Nebojsa\Desktop\Git Uploads\KupujemAuto\WebAssigmentAutoKP-VER2\WebAssigmentAutoKP\Views\Automobil\_PretragaCena.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1958d8963c06eb306c5ce846e05711d53aafec3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Automobil__PretragaCena), @"mvc.1.0.view", @"/Views/Automobil/_PretragaCena.cshtml")]
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
#line 1 "C:\Users\Nebojsa\Desktop\Git Uploads\KupujemAuto\WebAssigmentAutoKP-VER2\WebAssigmentAutoKP\Views\_ViewImports.cshtml"
using WebAssigmentAutoKP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nebojsa\Desktop\Git Uploads\KupujemAuto\WebAssigmentAutoKP-VER2\WebAssigmentAutoKP\Views\_ViewImports.cshtml"
using WebAssigmentAutoKP.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nebojsa\Desktop\Git Uploads\KupujemAuto\WebAssigmentAutoKP-VER2\WebAssigmentAutoKP\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nebojsa\Desktop\Git Uploads\KupujemAuto\WebAssigmentAutoKP-VER2\WebAssigmentAutoKP\Views\_ViewImports.cshtml"
using WebAssigmentAutoKP.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nebojsa\Desktop\Git Uploads\KupujemAuto\WebAssigmentAutoKP-VER2\WebAssigmentAutoKP\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1958d8963c06eb306c5ce846e05711d53aafec3", @"/Views/Automobil/_PretragaCena.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de67d469034da606454de768ae3a51082e242379", @"/Views/_ViewImports.cshtml")]
    public class Views_Automobil__PretragaCena : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebAssigmentAutoKP.Models.Automobil>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1958d8963c06eb306c5ce846e05711d53aafec35217", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n");
#nullable restore
#line 6 "C:\Users\Nebojsa\Desktop\Git Uploads\KupujemAuto\WebAssigmentAutoKP-VER2\WebAssigmentAutoKP\Views\Automobil\_PretragaCena.cshtml"
 if (ViewBag.Automobil != "")
{



#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n\r\n");
#nullable restore
#line 13 "C:\Users\Nebojsa\Desktop\Git Uploads\KupujemAuto\WebAssigmentAutoKP-VER2\WebAssigmentAutoKP\Views\Automobil\_PretragaCena.cshtml"
             foreach (Automobil auto in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"slika\">\r\n                    <h4>");
#nullable restore
#line 16 "C:\Users\Nebojsa\Desktop\Git Uploads\KupujemAuto\WebAssigmentAutoKP-VER2\WebAssigmentAutoKP\Views\Automobil\_PretragaCena.cshtml"
                   Write(auto.Marka);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 16 "C:\Users\Nebojsa\Desktop\Git Uploads\KupujemAuto\WebAssigmentAutoKP-VER2\WebAssigmentAutoKP\Views\Automobil\_PretragaCena.cshtml"
                               Write(auto.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 16 "C:\Users\Nebojsa\Desktop\Git Uploads\KupujemAuto\WebAssigmentAutoKP-VER2\WebAssigmentAutoKP\Views\Automobil\_PretragaCena.cshtml"
                                           Write(auto.Godiste);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1958d8963c06eb306c5ce846e05711d53aafec38008", async() => {
                WriteLiteral("<img");
                BeginWriteAttribute("src", " src=\"", 458, "\"", 510, 1);
#nullable restore
#line 17 "C:\Users\Nebojsa\Desktop\Git Uploads\KupujemAuto\WebAssigmentAutoKP-VER2\WebAssigmentAutoKP\Views\Automobil\_PretragaCena.cshtml"
WriteAttributeValue("", 464, $"/Automobil/CitajSliku/{auto.AutomobilId}", 464, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 511, "\"", 517, 0);
                EndWriteAttribute();
                WriteLiteral(" />");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "C:\Users\Nebojsa\Desktop\Git Uploads\KupujemAuto\WebAssigmentAutoKP-VER2\WebAssigmentAutoKP\Views\Automobil\_PretragaCena.cshtml"
                                              WriteLiteral(auto.AutomobilId);

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
            WriteLiteral("\r\n\r\n                    <p>");
#nullable restore
#line 19 "C:\Users\Nebojsa\Desktop\Git Uploads\KupujemAuto\WebAssigmentAutoKP-VER2\WebAssigmentAutoKP\Views\Automobil\_PretragaCena.cshtml"
                  Write(localizer["Korisnik"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 19 "C:\Users\Nebojsa\Desktop\Git Uploads\KupujemAuto\WebAssigmentAutoKP-VER2\WebAssigmentAutoKP\Views\Automobil\_PretragaCena.cshtml"
                                          Write(auto.KorisnickoIme);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <br />\r\n                    <p>");
#nullable restore
#line 21 "C:\Users\Nebojsa\Desktop\Git Uploads\KupujemAuto\WebAssigmentAutoKP-VER2\WebAssigmentAutoKP\Views\Automobil\_PretragaCena.cshtml"
                  Write(localizer["Cena"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":<a class=\"text-primary\"> ");
#nullable restore
#line 21 "C:\Users\Nebojsa\Desktop\Git Uploads\KupujemAuto\WebAssigmentAutoKP-VER2\WebAssigmentAutoKP\Views\Automobil\_PretragaCena.cshtml"
                                                              Write(auto.Cena);

#line default
#line hidden
#nullable disable
            WriteLiteral(" €</a></p>\r\n                    <p>\r\n\r\n");
#nullable restore
#line 24 "C:\Users\Nebojsa\Desktop\Git Uploads\KupujemAuto\WebAssigmentAutoKP-VER2\WebAssigmentAutoKP\Views\Automobil\_PretragaCena.cshtml"
                         if (UserManager.GetUserName(User) == auto.KorisnickoIme || UserManager.GetUserName(User) == "admin")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1958d8963c06eb306c5ce846e05711d53aafec312612", async() => {
#nullable restore
#line 27 "C:\Users\Nebojsa\Desktop\Git Uploads\KupujemAuto\WebAssigmentAutoKP-VER2\WebAssigmentAutoKP\Views\Automobil\_PretragaCena.cshtml"
                                                                               Write(localizer["Obrisi"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "C:\Users\Nebojsa\Desktop\Git Uploads\KupujemAuto\WebAssigmentAutoKP-VER2\WebAssigmentAutoKP\Views\Automobil\_PretragaCena.cshtml"
                                                     WriteLiteral(auto.AutomobilId);

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
            WriteLiteral(" |\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1958d8963c06eb306c5ce846e05711d53aafec315141", async() => {
#nullable restore
#line 28 "C:\Users\Nebojsa\Desktop\Git Uploads\KupujemAuto\WebAssigmentAutoKP-VER2\WebAssigmentAutoKP\Views\Automobil\_PretragaCena.cshtml"
                                                                             Write(localizer["Promjeni"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\Nebojsa\Desktop\Git Uploads\KupujemAuto\WebAssigmentAutoKP-VER2\WebAssigmentAutoKP\Views\Automobil\_PretragaCena.cshtml"
                                                   WriteLiteral(auto.AutomobilId);

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
            WriteLiteral(" |\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1958d8963c06eb306c5ce846e05711d53aafec317668", async() => {
#nullable restore
#line 29 "C:\Users\Nebojsa\Desktop\Git Uploads\KupujemAuto\WebAssigmentAutoKP-VER2\WebAssigmentAutoKP\Views\Automobil\_PretragaCena.cshtml"
                                                                                Write(localizer["Detalji"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\Nebojsa\Desktop\Git Uploads\KupujemAuto\WebAssigmentAutoKP-VER2\WebAssigmentAutoKP\Views\Automobil\_PretragaCena.cshtml"
                                                      WriteLiteral(auto.AutomobilId);

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
            WriteLiteral("\r\n                        </p>\r\n");
#nullable restore
#line 31 "C:\Users\Nebojsa\Desktop\Git Uploads\KupujemAuto\WebAssigmentAutoKP-VER2\WebAssigmentAutoKP\Views\Automobil\_PretragaCena.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1958d8963c06eb306c5ce846e05711d53aafec320539", async() => {
#nullable restore
#line 34 "C:\Users\Nebojsa\Desktop\Git Uploads\KupujemAuto\WebAssigmentAutoKP-VER2\WebAssigmentAutoKP\Views\Automobil\_PretragaCena.cshtml"
                                                                            Write(localizer["Detalji"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\Nebojsa\Desktop\Git Uploads\KupujemAuto\WebAssigmentAutoKP-VER2\WebAssigmentAutoKP\Views\Automobil\_PretragaCena.cshtml"
                                                  WriteLiteral(auto.AutomobilId);

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
            WriteLiteral("\r\n");
#nullable restore
#line 35 "C:\Users\Nebojsa\Desktop\Git Uploads\KupujemAuto\WebAssigmentAutoKP-VER2\WebAssigmentAutoKP\Views\Automobil\_PretragaCena.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 38 "C:\Users\Nebojsa\Desktop\Git Uploads\KupujemAuto\WebAssigmentAutoKP-VER2\WebAssigmentAutoKP\Views\Automobil\_PretragaCena.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 42 "C:\Users\Nebojsa\Desktop\Git Uploads\KupujemAuto\WebAssigmentAutoKP-VER2\WebAssigmentAutoKP\Views\Automobil\_PretragaCena.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Ne postoji trazeni automobil</h3>\r\n");
#nullable restore
#line 46 "C:\Users\Nebojsa\Desktop\Git Uploads\KupujemAuto\WebAssigmentAutoKP-VER2\WebAssigmentAutoKP\Views\Automobil\_PretragaCena.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral(@"
    <style>
        div.slika {
            width: 300px;
            border-radius: 5px;
            border: 1px solid black;
            padding: 10px;
            float: left;
            margin: 10px;
        }

            div.slika img {
                width: 280px;
                height: 210px;
                align-content: center;
                margin-bottom: 10px;
            }
    </style>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<Resource> localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebAssigmentAutoKP.Models.Automobil>> Html { get; private set; }
    }
}
#pragma warning restore 1591
