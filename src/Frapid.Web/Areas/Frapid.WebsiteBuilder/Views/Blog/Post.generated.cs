﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using DevTrends.MvcDonutCaching;
    using Frapid.Web;
    
    #line 1 "..\..\Views\Blog\Post.cshtml"
    using Frapid.WebsiteBuilder;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Blog\Post.cshtml"
    using Frapid.WebsiteBuilder.Extensions;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Blog/Post.cshtml")]
    public partial class _Views_Blog_Post_cshtml : System.Web.Mvc.WebViewPage<Frapid.WebsiteBuilder.ViewModels.Content>
    {
        public _Views_Blog_Post_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Blog\Post.cshtml"
  
    ViewBag.Description = Model.SeoDescription;
    ViewBag.Title = Model.Title;
    Layout = Model.LayoutPath + Model.Layout;
    ViewBag.LayoutPath = Model.LayoutPath;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"story\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"blog header title\"");

WriteLiteral(">");

            
            #line 13 "..\..\Views\Blog\Post.cshtml"
                              Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n    <div");

WriteLiteral(" class=\"meta\"");

WriteLiteral(">\r\n        <a");

WriteLiteral(" class=\"item\"");

WriteAttribute("title", Tuple.Create(" title=\"", 428), Tuple.Create("\"", 452)
            
            #line 15 "..\..\Views\Blog\Post.cshtml"
, Tuple.Create(Tuple.Create("", 436), Tuple.Create<System.Object, System.Int32>(Model.PublishOn
            
            #line default
            #line hidden
, 436), false)
);

WriteLiteral(">\r\n            <i");

WriteLiteral(" class=\"time icon\"");

WriteLiteral("></i>\r\n");

WriteLiteral("            ");

            
            #line 17 "..\..\Views\Blog\Post.cshtml"
       Write(Model.PublishOn.ToString("D"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </a>\r\n        <a");

WriteLiteral(" class=\"item\"");

WriteLiteral(">\r\n            <i");

WriteLiteral(" class=\"user icon\"");

WriteLiteral("></i>\r\n");

WriteLiteral("            ");

            
            #line 21 "..\..\Views\Blog\Post.cshtml"
       Write(Model.AuthorName);

            
            #line default
            #line hidden
WriteLiteral("\r\n        </a>\r\n        <a");

WriteLiteral(" class=\"item\"");

WriteLiteral(">\r\n            <i");

WriteLiteral(" class=\"folder icon\"");

WriteLiteral("></i>\r\n");

WriteLiteral("            ");

            
            #line 25 "..\..\Views\Blog\Post.cshtml"
       Write(Model.CategoryName);

            
            #line default
            #line hidden
WriteLiteral("\r\n        </a>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"post\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 29 "..\..\Views\Blog\Post.cshtml"
   Write(Html.Raw(Model.Contents));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"ui divider\"");

WriteLiteral("></div>\r\n\r\n    <div");

WriteLiteral(" class=\"social sharing\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"ui grey header\"");

WriteLiteral(">\r\n            Share this blog\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"icons\"");

WriteLiteral(">\r\n            <a");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" href=\"https://www.facebook.com/sharer/sharer.php?u={url}\"");

WriteLiteral(" title=\"Share this on Facebook\"");

WriteLiteral(">\r\n                <i");

WriteLiteral(" class=\"circular inverted blue facebook icon\"");

WriteLiteral("></i>\r\n            </a>\r\n            <a");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" href=\"http://twitter.com/share?text={tweet}&url={url}&hashtags=#mixerp\"");

WriteLiteral(" title=\"Tweet this link\"");

WriteLiteral(">\r\n                <i");

WriteLiteral(" class=\"circular blue twitter icon\"");

WriteLiteral("></i>\r\n            </a>\r\n            <a");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" href=\"http://www.linkedin.com/shareArticle?mini=true&url={url}&title={title}\"");

WriteLiteral(" title=\"Share this on LinkedIn\"");

WriteLiteral(">\r\n                <i");

WriteLiteral(" class=\"circular inverted blue linkedin icon\"");

WriteLiteral("></i>\r\n            </a>\r\n\r\n            <a");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" href=\"https://plus.google.com/share?url={url}\"");

WriteLiteral(" title=\"Share this on Google+\"");

WriteLiteral(">\r\n                <i");

WriteLiteral(" class=\"circular inverted red google plus icon\"");

WriteLiteral("></i>\r\n            </a>\r\n\r\n            <a");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" href=\"http://www.reddit.com/submit?url={url}\"");

WriteLiteral(" title=\"Share this on Reddit\"");

WriteLiteral(">\r\n                <i");

WriteLiteral(" class=\"circular reddit icon\"");

WriteLiteral("></i>\r\n            </a>\r\n\r\n            <a");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" href=\"http://pinterest.com/pin/create/button/?url={url}&description={title}\"");

WriteLiteral(" title=\"Share this on Pinterest\"");

WriteLiteral(">\r\n                <i");

WriteLiteral(" class=\"circular inverted red pinterest icon\"");

WriteLiteral("></i>\r\n            </a>\r\n\r\n            <a");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" href=\"http://www.stumbleupon.com/badge/?url={url}\"");

WriteLiteral(" title=\"Share this on StumbleUpon\"");

WriteLiteral(">\r\n                <i");

WriteLiteral(" class=\"circular inverted red stumbleupon icon\"");

WriteLiteral("></i>\r\n            </a>\r\n\r\n\r\n            <a");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" href=\"mailto:?subject={title}&body={message}\"");

WriteLiteral(" title=\"Send this on email\"");

WriteLiteral(">\r\n                <i");

WriteLiteral(" class=\"circular inverted olive mail icon\"");

WriteLiteral("></i>\r\n            </a>\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <div");

WriteLiteral(" class=\"ui grey header\"");

WriteLiteral(">Leave a Message</div>\r\n    <div");

WriteLiteral(" class=\"ui warning message\"");

WriteLiteral(@">Sorry, discussion closed for posts older than three months.</div>
</div>
<script>
    function processSocialSharing() {
        var url = encodeURIComponent(window.location.href);
        var title = encodeURIComponent($("".blog.header.title:first"").html());
        var tweet = $("".blog.header.title:first"").html();
        var message = 'Hi,' + escape(""\n\n"") + 'Here is a link I think you might like to know about:' + escape(""\n\n"") + url + escape(""\n\n"");

        $("".social.sharing a"").each(function () {
            var el = $(this);
            var href = el.attr(""href"");

            href = href.replace(""{url}"", url);
            href = href.replace(""{title}"", title);
            href = href.replace(""{tweet}"", tweet);
            href = href.replace(""{message}"", message);

            el.attr(""href"", href);
        });
    };
    $(document).ready(function(){
        processSocialSharing();
    });
</script>");

        }
    }
}
#pragma warning restore 1591