#pragma checksum "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\song\SongIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6031b0d1821af23bebeb1d7859c09df4413d5ba1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_song_SongIndex), @"mvc.1.0.view", @"/Views/song/SongIndex.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6031b0d1821af23bebeb1d7859c09df4413d5ba1", @"/Views/song/SongIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa4badbd9ea8189b30c7d36e69fabd0e44f7d95b", @"/Views/_ViewImports.cshtml")]
    public class Views_song_SongIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MusicApplicationWebLibrary.Models.Song>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\song\SongIndex.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Here are the songs you have saved:</h1>\r\n\r\n<p>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 163, "\"", 223, 1);
#nullable restore
#line 10 "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\song\SongIndex.cshtml"
WriteAttributeValue("", 170, Url.Action("SongCreate", new {id= ViewBag.AlbumID }), 170, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Click here to discover a new song! </a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\song\SongIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.PictureURL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\song\SongIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.artistName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\song\SongIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.TrackName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\song\SongIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\song\SongIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.Favourite));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\song\SongIndex.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1003, "\"", 1025, 1);
#nullable restore
#line 38 "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\song\SongIndex.cshtml"
WriteAttributeValue("", 1009, item.PictureURL, 1009, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:128px;\" />\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\song\SongIndex.cshtml"
               Write(Html.DisplayFor(modelItem => item.artistName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\song\SongIndex.cshtml"
               Write(Html.DisplayFor(modelItem => item.TrackName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\song\SongIndex.cshtml"
               Write(Html.DisplayFor(modelItem => item.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\song\SongIndex.cshtml"
               Write(Html.DisplayFor(modelItem => item.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\song\SongIndex.cshtml"
               Write(Html.ActionLink("Edit", "Update","song", new { id = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |                   \r\n                    ");
#nullable restore
#line 54 "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\song\SongIndex.cshtml"
               Write(Html.ActionLink("Delete", "Delete", "song", new { id = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 57 "C:\MusicAPP\MusicAPP\MusicApp\MusicApplication\MusicApplication\Views\song\SongIndex.cshtml"
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