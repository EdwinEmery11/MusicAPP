#pragma checksum "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\Albums\SongsonAlbum.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f72a4423c89b10e9dba68a144239159a06be4b56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Albums_SongsonAlbum), @"mvc.1.0.view", @"/Views/Albums/SongsonAlbum.cshtml")]
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
#line 1 "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\_ViewImports.cshtml"
using MusicApplication;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f72a4423c89b10e9dba68a144239159a06be4b56", @"/Views/Albums/SongsonAlbum.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa4badbd9ea8189b30c7d36e69fabd0e44f7d95b", @"/Views/_ViewImports.cshtml")]
    public class Views_Albums_SongsonAlbum : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MusicApplicationWebLibrary.Models.Song>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SongCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\Albums\SongsonAlbum.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Your playlist:</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f72a4423c89b10e9dba68a144239159a06be4b563587", async() => {
                WriteLiteral("Click here to add to your playlist here!");
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
            WriteLiteral("\r\n    ");
#nullable restore
#line 11 "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\Albums\SongsonAlbum.cshtml"
Write(Html.ActionLink("TestSongCreate", "SongCreate", "song"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\Albums\SongsonAlbum.cshtml"
           Write(Html.DisplayNameFor(model => model.PictureURL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\Albums\SongsonAlbum.cshtml"
           Write(Html.DisplayNameFor(model => model.artistName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\Albums\SongsonAlbum.cshtml"
           Write(Html.DisplayNameFor(model => model.TrackName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\Albums\SongsonAlbum.cshtml"
           Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\Albums\SongsonAlbum.cshtml"
           Write(Html.DisplayNameFor(model => model.Favourite));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 35 "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\Albums\SongsonAlbum.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1013, "\"", 1035, 1);
#nullable restore
#line 39 "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\Albums\SongsonAlbum.cshtml"
WriteAttributeValue("", 1019, item.PictureURL, 1019, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:128px;\" />\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\Albums\SongsonAlbum.cshtml"
               Write(Html.DisplayFor(modelItem => item.artistName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\Albums\SongsonAlbum.cshtml"
               Write(Html.DisplayFor(modelItem => item.TrackName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\Albums\SongsonAlbum.cshtml"
               Write(Html.DisplayFor(modelItem => item.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\Albums\SongsonAlbum.cshtml"
               Write(Html.DisplayFor(modelItem => item.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\Albums\SongsonAlbum.cshtml"
               Write(Html.ActionLink("Edit", "Update", new { id = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 55 "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\Albums\SongsonAlbum.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 56 "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\Albums\SongsonAlbum.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 59 "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\Albums\SongsonAlbum.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MusicApplicationWebLibrary.Models.Song>> Html { get; private set; }
    }
}
#pragma warning restore 1591