#pragma checksum "E:\源码\AKStreamWebUI\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\Views\VideoChannels\LiveVideo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a27ea961a84871805b7f52126e66f0bfe30e37d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_CameraManage_Views_VideoChannels_LiveVideo), @"mvc.1.0.view", @"/Areas/CameraManage/Views/VideoChannels/LiveVideo.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#nullable restore
#line 3 "E:\源码\AKStreamWebUI\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\源码\AKStreamWebUI\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\_ViewImports.cshtml"
using YiSha.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\源码\AKStreamWebUI\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\_ViewImports.cshtml"
using YiSha.Util.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\源码\AKStreamWebUI\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\_ViewImports.cshtml"
using YiSha.Util.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\源码\AKStreamWebUI\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\_ViewImports.cshtml"
using YiSha.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\源码\AKStreamWebUI\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\_ViewImports.cshtml"
using YiSha.Web.Code;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a27ea961a84871805b7f52126e66f0bfe30e37d", @"/Areas/CameraManage/Views/VideoChannels/LiveVideo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5b622e924f35698514110c8d85c04ddd5a27d39", @"/Areas/CameraManage/_ViewImports.cshtml")]
    public class Areas_CameraManage_Views_VideoChannels_LiveVideo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\源码\AKStreamWebUI\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\Views\VideoChannels\LiveVideo.cshtml"
  
    Layout = "~/Views/Shared/_FormWhite.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script");
            BeginWriteAttribute("src", " src=\"", 66, "\"", 129, 1);
#nullable restore
#line 5 "E:\源码\AKStreamWebUI\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\Views\VideoChannels\LiveVideo.cshtml"
WriteAttributeValue("", 72, Url.Content("~/Extensions/EasyPlayer/EasyWasmPlayer.js"), 72, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></script>\r\n<div id=\"newplay\"></div>\r\n\r\n<script type=\"text/javascript\">\r\n    var mediaId = ys.request(\"MediaServerId\");\r\n    var mainId = ys.request(\"MainId\");\r\n    $(function () {\r\n        ys.ajax({\r\n            url: \'");
#nullable restore
#line 13 "E:\源码\AKStreamWebUI\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\Views\VideoChannels\LiveVideo.cshtml"
             Write(Url.Content("~/CameraManage/VideoChannels/LiveVideoPlay"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?MediaServerId=' + mediaId + '&MainId=' + mainId,
            type: ""get"",
            success: function (obj) {
                console.log(obj)
                var res = JSON.parse(obj);
                if (res.playUrl.length > 0) {
                    // 实例化播放器
                    var Player = new WasmPlayer(null, 'newplay', callbackFun, { cbUserPtr: this, decodeType: ""auto"", BigPlay: false, Height: true });
                    // 调用播放
                    Player.play(res.playUrl[0], 1);
                }
                else {
                    console.log(obj);
                    ys.msgError(obj);
                }
            }
        });
    });

    function callbackFun(e) {
        console.log(e);
    }
</script>

");
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