#pragma checksum "/Users/Bthom/Desktop/FriendLetter.Solution/FriendLetter/Views/Home/Postcard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "604c6acb455cd6aac705ba0e4fb38773cca392d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Postcard), @"mvc.1.0.view", @"/Views/Home/Postcard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Postcard.cshtml", typeof(AspNetCore.Views_Home_Postcard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"604c6acb455cd6aac705ba0e4fb38773cca392d7", @"/Views/Home/Postcard.cshtml")]
    public class Views_Home_Postcard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 33, true);
            WriteLiteral("<h1>Hello From Afar</h1>\n<p>Dear ");
            EndContext();
            BeginContext(34, 15, false);
#line 2 "/Users/Bthom/Desktop/FriendLetter.Solution/FriendLetter/Views/Home/Postcard.cshtml"
   Write(Model.Recipient);

#line default
#line hidden
            EndContext();
            BeginContext(49, 131, true);
            WriteLiteral(",</p>\n<p>How are you? I hope that you are having a nice weekend. I\'m vacationing in the Iceland while I learn programming! </p>\n<p>");
            EndContext();
            BeginContext(181, 15, false);
#line 4 "/Users/Bthom/Desktop/FriendLetter.Solution/FriendLetter/Views/Home/Postcard.cshtml"
Write(Model.Recipient);

#line default
#line hidden
            EndContext();
            BeginContext(196, 268, true);
            WriteLiteral(@", you would not believe how cold it is here. I should have gone to Hawaii instead.</p>
<p>But I like programming a lot, so I've got that going for me. </p>
<p>Looking forward to seeing you soon. I'll bring you back a souvenir. </p>
<p>Cheers,</p>
<p>Travel Enthusiast ");
            EndContext();
            BeginContext(465, 12, false);
#line 8 "/Users/Bthom/Desktop/FriendLetter.Solution/FriendLetter/Views/Home/Postcard.cshtml"
                Write(Model.Sender);

#line default
#line hidden
            EndContext();
            BeginContext(477, 4, true);
            WriteLiteral("</p>");
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
