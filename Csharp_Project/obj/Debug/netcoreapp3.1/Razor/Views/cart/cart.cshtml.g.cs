#pragma checksum "D:\Solfware\C#Project\Doan_Framework\Csharp_Project\Views\cart\cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f372ba286b3c59369e3c671d10a7bb7cd988d965"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_cart_cart), @"mvc.1.0.view", @"/Views/cart/cart.cshtml")]
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
#line 1 "D:\Solfware\C#Project\Doan_Framework\Csharp_Project\Views\_ViewImports.cshtml"
using Csharp_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Solfware\C#Project\Doan_Framework\Csharp_Project\Views\_ViewImports.cshtml"
using Csharp_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Solfware\C#Project\Doan_Framework\Csharp_Project\Views\cart\cart.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f372ba286b3c59369e3c671d10a7bb7cd988d965", @"/Views/cart/cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dfe8b1dba119435608b50da958da69c74a9a936", @"/Views/_ViewImports.cshtml")]
    public class Views_cart_cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/frame_user_info.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/cart.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Solfware\C#Project\Doan_Framework\Csharp_Project\Views\cart\cart.cshtml"
   
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f372ba286b3c59369e3c671d10a7bb7cd988d9655530", async() => {
                WriteLiteral(@"
    <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"">
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Giỏ hàng</title>
    <script src=""https://kit.fontawesome.com/c44ecc908b.js"" crossorigin=""anonymous""></script>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.2/dist/css/bootstrap.min.css"" rel=""stylesheet"">
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.2/dist/js/bootstrap.bundle.min.js""></script>
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f372ba286b3c59369e3c671d10a7bb7cd988d9656485", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <!-- <link rel=\"stylesheet\" type=\"text/css\" href=\"asset/css/cart.css\"/> -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f372ba286b3c59369e3c671d10a7bb7cd988d9657839", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <!-- number spinner -->
    <script>
        $(document).on('click', '.number-spinner button', function () {    
            var btn = $(this),
            oldValue = btn.closest('.number-spinner').find('input').val().trim(),
            newVal = 0;
            
            if (btn.attr('data-dir') == 'up') {
                newVal = parseInt(oldValue) + 1;
            } else {
                if (oldValue > 1) {
                    newVal = parseInt(oldValue) - 1;
                } else {
                    newVal = 1;
                }
            }
            btn.closest('.number-spinner').find('input').val(newVal);
        });
    </script>

");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f372ba286b3c59369e3c671d10a7bb7cd988d96510493", async() => {
                WriteLiteral(@"
    <header>
        <div class=""container"" style=""background: #B4EDFF;"">
            <div class=""row row-mainnav"">
                <nav class=""col-md-9 col-sm-6 col-2 mainnav navbar navbar-expand-lg navbar-light bg-light"">
                    <div style=""width: 100%"">
                        <button class=""navbar-toggler collapsed"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarNavAltMarkup"" aria-controls=""navbarNavAltMarkup"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                            <span class=""navbar-toggler-icon""></span>
                        </button>
                        <div class=""navbar-collapse collapse"" id=""navbarNavAltMarkup""");
                BeginWriteAttribute("style", " style=\"", 2476, "\"", 2484, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            <div class=""navbar-nav"">
                                <a class=""nav-link active"" aria-current=""page"" href=""/Home/Index"">Home</a>
                                <a class=""nav-link"" href=""#"">Features</a>
                                <a class=""nav-link"" href=""#"">Pricing</a>
                                <a class=""nav-link "">Community</a>
                                <a class=""nav-link "">Support</a>
                                <a class=""nav-link "">Track order</a>
                            </div>
                        </div>
                    </div>
                </nav>
    
                <div class=""col-md-3 col-sm-6 col-10 btnnav"">
");
#nullable restore
#line 67 "D:\Solfware\C#Project\Doan_Framework\Csharp_Project\Views\cart\cart.cshtml"
                      
                        if (@HttpContextAccessor.HttpContext.Session.GetInt32("_ID") != null)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"text\">\r\n                                <span>Xin chào ");
#nullable restore
#line 71 "D:\Solfware\C#Project\Doan_Framework\Csharp_Project\Views\cart\cart.cshtml"
                                          Write(HttpContextAccessor.HttpContext.Session.GetString("_Name"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                <a style=\"margin-left: 10px;\" href=\"/tbl_customers/Logout\">Logout</a>\r\n                            </div>\r\n");
#nullable restore
#line 74 "D:\Solfware\C#Project\Doan_Framework\Csharp_Project\Views\cart\cart.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <button onclick=""window.location.href='/tbl_customers/login'"" type=""button"" id=""btnlogin"">Login</button>
                            <button onclick=""window.location.href='/tbl_customers/register'"" type=""button"" id=""btnregister"">Register</button>
");
#nullable restore
#line 79 "D:\Solfware\C#Project\Doan_Framework\Csharp_Project\Views\cart\cart.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n            </div>\r\n    \r\n            <div class=\"row pt-4 pb-3\" style=\"position: relative\">\r\n                <div class=\"searchbar logo col-md-2 col-sm-2\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f372ba286b3c59369e3c671d10a7bb7cd988d96514283", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>
    
                <div class=""searchbar search col-md-8 col-sm-8 col-12""><div class=""input-group"">
                        <input type=""text"" class=""form-control"" placeholder=""Search"">
                        <div class=""input-group-append"">
                            <button class=""btn btn-primary"" type=""button"">
                                <i class=""fas fa-search"" aria-hidden=""true""></i>
                            </button>
                        </div>
                    </div>                           
                </div>
    
                <div class=""searchbar cart col-md-2 col-sm-2"">
                     <button class=""btn"" type=""button"">
                        <i class=""fas fa-shopping-cart"" aria-hidden=""true""></i>
                    </button> 
                </div>
            </div>             
        </div>
    </header>

    <main>
      <div class=""product""></div>
        <div class=""container totalprice"">
    <div class=""cont");
                WriteLiteral(@"ainer row boxbill"">
            <div class=""row voucherline"">
                <div class=""col-8"">
                    <span>
                         <img src=""asset/img/tag-discount.svg"" class=""icon-voucher""> 
                        Mã voucher 
                    </span>
                </div>
                <div class=""col-4"">
                    <span>Chọn mã</span>
                </div>
            </div>
    <div class=""break-line""> </div>
                                <div class=""container row bill"">
                <div class=""col-lg-3"">
           <input type=""checkbox"" value=""Tất cả"">
<label>Tất cả</label>  
    <a class=""allremove"">Xoá</a>
                </div>
                <div class=""col-lg-4 billprice"">
                    <span>Tổng thanh toán: </span>
      <span class=""totalbill"">đ0</span>
                </div>
    <div class=""col-lg-5"">
                    <div class=""row button-buying-product"">
                    <div class=""col-md-6 col-sm-12 btn btn-ret");
                WriteLiteral("urn\">Quay lại</div>\r\n                    <div class=\"col-md-6 col-sm-12 btn btn-buynow\">Mua ngay</div>\r\n                </div>\r\n                </div>\r\n            </div>\r\n    </div>\r\n        </div>\r\n        \r\n    </main>\r\n\r\n");
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
            WriteLiteral("\r\n</html>     \r\n<script>\r\n     const products = ");
#nullable restore
#line 149 "D:\Solfware\C#Project\Doan_Framework\Csharp_Project\Views\cart\cart.cshtml"
                 Write(Html.Raw(Json.Serialize(ViewData["Listc"])));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
    function renderProduct(products) {
        let html = '';
        const content = products.map((item, index) => {

                html += ` <div class=""container product"">

        <div class=""container row boxproduct"">
            <div class=""row"" style=""margin-bottom: 1%;"">
<div class=""col-10 checkprodcut"">
    <input type=""checkbox"">
    <span>Uit shop</span>
</div>
<div class=""col-2 remove""><i id=""${item.id}"" class=""fas fa-times"" aria-hidden=""true""></i></div>
            </div>
    <div class=""row"">
            <div class=""col-lg-5 container imgproduct"">
                <div class=""main-imgproduct"">
                    <img src=""${item.image}"">
                </div>
            </div>

            <div class=""col-lg-7 container detailproduct"">
                <div class=""name-product"">
                    ${item.name}
                </div>

                <div class=""row info-product"">
                    <div class=""col-md-5 info-rating-product"">
                   ");
            WriteLiteral(@"     <div class=""small-ratings"" style=""margin-right: 5px;"">
                            <i class=""fa fa-star rating-color"" aria-hidden=""true""></i>
                            <i class=""fa fa-star rating-color"" aria-hidden=""true""></i>
                            <i class=""fa fa-star rating-color"" aria-hidden=""true""></i>
                            <i class=""fa fa-star-o"" aria-hidden=""true""></i>
                            <i class=""fa fa-star-o"" aria-hidden=""true""></i>
                        </div>
                        <div>
                            <span class=""num-ratings"">3.0</span>
                        </div>
                    </div>
                    <div class=""col-md-4 col-sm-6 col-6 info-review-product"">
                        Đánh giá
                        <span class=""numreview-product"">100</span>
                    </div>
                    <div class=""col-md-3 col-sm-6 col-6"">
                        Đã bán
                        <span class=""numsold-product"">10");
            WriteLiteral(@"0</span>
                    </div>
                </div>

                <div class=""row price-product"">
                    <div class=""row"">
                        <div class=""col-sm-7 discount-price-product"">
                            <span>đ ${item.cost} </span>
                        </div>
                        <div class=""col-sm-5 original-price-product"">
                            đ
                            <span>4.000.000 </span>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""container discount-percent-product"">
                            Giảm
                            <span> 50</span>
                            %
                        </div>
                    </div>
                </div>

                <div class=""row delivery-product"">
                    <b>Vận chuyển: Miễn phí vận chuyển </b>
                    <span>Miễn phí vận chuyển cho đơn hàng trên ₫250.000<");
            WriteLiteral(@"/span>
                </div>

                <div class=""row count-quantity-product"">
                    <div class=""container"">
                        <div class=""row"" style=""width: 110%;"">
                            <div class=""col-md-3 col-sm-6 col-6"">
                                Số lượng
                            </div>
                            <div class=""col-md-4 col-sm-6 col-6"">
                                <div class=""input-group number-spinner"" style=""/* width: 100px; */"">
                                    <!--<span class=""input-group-btn"">
                                        <button class=""btn"" data-dir=""dwn""><span class=""fa fa-minus"" style=""font-size: 10px; position: absolute;"" aria-hidden=""true""></span></button>
                                    </span>-->
                                    <input type=""text"" class=""form-control text-center"" value=""1"" disabled>
                                    <!--<span class=""input-group-btn"">
                         ");
            WriteLiteral(@"               <button class=""btn"" data-dir=""up""><span class=""fa fa-plus"" style=""font-size: 10px; position: absolute;"" aria-hidden=""true""></span></button>
                                    </span> -->
                                </div>
                            </div>
                            <div class=""col-md-5"">
                                <span class=""num-available-product""> ${item.available}</span>
                                sản phẩm có sẵn
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            </div>
        </div>
        </div>`;
                return html;
        });
        document.querySelector('.product').innerHTML = html
    }
    renderProduct(products)
</script>
<script>
    var arrxoa = document.querySelectorAll("".fa-times"")
    for (let btnxoa of arrxoa) {
        btnxoa.addEventListener('click', function () {
            alert(btnxoa.id)
            jQu");
            WriteLiteral(@"ery.ajax({
                url: '/cart/XoaCart',
                dataType: ""json"",
                type: ""POST"",
                data: {
                    id: btnxoa.id,
                },
                success: function (data) {
                    if (data != 0) {
                        alert(""xoa thanh cong"")
                        location.reload()
                    }
                    else {
                        alert(""xoa that bai"")
                    }
                },
            });
        })
    }
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
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