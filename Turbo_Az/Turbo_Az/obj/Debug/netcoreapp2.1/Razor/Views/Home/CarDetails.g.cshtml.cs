#pragma checksum "C:\Users\user\source\repos\Turbo_Az\Turbo_Az\Views\Home\CarDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74b4c8f8d6f351365877185c4ab3a5f8f74a3ce1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CarDetails), @"mvc.1.0.view", @"/Views/Home/CarDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CarDetails.cshtml", typeof(AspNetCore.Views_Home_CarDetails))]
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
#line 1 "C:\Users\user\source\repos\Turbo_Az\Turbo_Az\Views\_ViewImports.cshtml"
using Turbo_Az;

#line default
#line hidden
#line 2 "C:\Users\user\source\repos\Turbo_Az\Turbo_Az\Views\_ViewImports.cshtml"
using Turbo_Az.Models;

#line default
#line hidden
#line 4 "C:\Users\user\source\repos\Turbo_Az\Turbo_Az\Views\_ViewImports.cshtml"
using Turbo_Az.ViewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b4c8f8d6f351365877185c4ab3a5f8f74a3ce1", @"/Views/Home/CarDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbf76361351cab0709fdcaa78e8d4c478d2c92cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CarDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Advertisement>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ElanImg img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/bmw.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\user\source\repos\Turbo_Az\Turbo_Az\Views\Home\CarDetails.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(67, 146, true);
            WriteLiteral("\r\n\r\n<section>\r\n    <div class=\"container\">\r\n        <div class=\"row\" style=\"background:black \">\r\n            <div class=\"col-6\">\r\n                ");
            EndContext();
            BeginContext(213, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f2f7be65d59e47ae8e8cd1c064a9f858", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 223, "~/images/", 223, 9, true);
#line 12 "C:\Users\user\source\repos\Turbo_Az\Turbo_Az\Views\Home\CarDetails.cshtml"
AddHtmlAttributeValue("", 232, Model.PhotoURL, 232, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
            BeginContext(295, 153, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-6\">\r\n                <div class=\"row\">\r\n                    <div class=\"col\">\r\n                        ");
            EndContext();
            BeginContext(448, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b53eeb0e0f2549179c155b052a82eced", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
            BeginContext(522, 93, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col\">\r\n                        ");
            EndContext();
            BeginContext(615, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "da7dcf9654ec46fa8913b02da52c77f2", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
            BeginContext(689, 326, true);
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>

        <div class=""row"">
            <div class=""col-6"">
                <table class=""table"">
                    <tbody>
                        <tr>
                            <td>Şəhər</td>
                            <td>");
            EndContext();
            BeginContext(1016, 15, false);
#line 32 "C:\Users\user\source\repos\Turbo_Az\Turbo_Az\Views\Home\CarDetails.cshtml"
                           Write(Model.City.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1031, 144, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Marka</td>\r\n                            <td>");
            EndContext();
            BeginContext(1176, 22, false);
#line 36 "C:\Users\user\source\repos\Turbo_Az\Turbo_Az\Views\Home\CarDetails.cshtml"
                           Write(Model.Model.Brand.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1198, 152, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Buraxılış ili</td>\r\n                            <td>");
            EndContext();
            BeginContext(1351, 26, false);
#line 40 "C:\Users\user\source\repos\Turbo_Az\Turbo_Az\Views\Home\CarDetails.cshtml"
                           Write(Model.GradiuationYear.Year);

#line default
#line hidden
            EndContext();
            BeginContext(1377, 143, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Rəng</td>\r\n                            <td>");
            EndContext();
            BeginContext(1521, 20, false);
#line 44 "C:\Users\user\source\repos\Turbo_Az\Turbo_Az\Views\Home\CarDetails.cshtml"
                           Write(Model.Color.CarColor);

#line default
#line hidden
            EndContext();
            BeginContext(1541, 155, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Mühərrikin həcmi</td>\r\n                            <td>");
            EndContext();
            BeginContext(1697, 24, false);
#line 48 "C:\Users\user\source\repos\Turbo_Az\Turbo_Az\Views\Home\CarDetails.cshtml"
                           Write(Model.MachinePower.Power);

#line default
#line hidden
            EndContext();
            BeginContext(1721, 151, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Yanacaq növü</td>\r\n                            <td>");
            EndContext();
            BeginContext(1873, 18, false);
#line 52 "C:\Users\user\source\repos\Turbo_Az\Turbo_Az\Views\Home\CarDetails.cshtml"
                           Write(Model.Fuel.CarFuel);

#line default
#line hidden
            EndContext();
            BeginContext(1891, 144, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Yürüş</td>\r\n                            <td>");
            EndContext();
            BeginContext(2036, 12, false);
#line 56 "C:\Users\user\source\repos\Turbo_Az\Turbo_Az\Views\Home\CarDetails.cshtml"
                           Write(Model.Hiking);

#line default
#line hidden
            EndContext();
            BeginContext(2048, 154, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Sürətlər qutusu</td>\r\n                            <td>");
            EndContext();
            BeginContext(2203, 20, false);
#line 60 "C:\Users\user\source\repos\Turbo_Az\Turbo_Az\Views\Home\CarDetails.cshtml"
                           Write(Model.Speed.CarSpeed);

#line default
#line hidden
            EndContext();
            BeginContext(2223, 145, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Qiymət</td>\r\n                            <td>");
            EndContext();
            BeginContext(2369, 11, false);
#line 64 "C:\Users\user\source\repos\Turbo_Az\Turbo_Az\Views\Home\CarDetails.cshtml"
                           Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2380, 200, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n            <div class=\"col-6\">\r\n                <h3>About</h3>\r\n                <p>");
            EndContext();
            BeginContext(2581, 13, false);
#line 72 "C:\Users\user\source\repos\Turbo_Az\Turbo_Az\Views\Home\CarDetails.cshtml"
              Write(Model.CarInfo);

#line default
#line hidden
            EndContext();
            BeginContext(2594, 15209, true);
            WriteLiteral(@"</p>
            </div>
        </div>
    </div>
</section>
<section>
    <div class=""wrapper"">
        <div class=""products"">
            <div class=""productBorder"">
                <div class=""onliCar"">
                    <i class=""far fa-heart likeIcon""></i>
                    <img src=""https://turbo.azstatic.com/uploads/f460x343/2019%2F01%2F30%2F11%2F58%2F34%2Fafcc9d40-7c7d-448f-a7f7-b9f5fc2a5d1e%2F23118_52j_bhYOFSyf5vjlzKv4UQ.jpg""
                         alt="""">
                    <div class=""productPrice"">
                        26 700 <span>AZN</span>
                    </div>
                    <div class=""productsInfo"">
                        <p class=""carName"">Land Rover Discovery</p>
                        <div class=""carInfo"">
                            <p class=""year"">
                                2006 il

                                <span></span>
                            </p>
                            <p class=""engin"">
                             ");
            WriteLiteral(@"   2.7 L
                                <span></span>
                            </p>
                            <p class=""km"">231 000 km </p>
                        </div>
                        <div class=""enterDay"">Baki, 17 fevral 2019 <i class=""fas fa-gem""></i></div>
                    </div>
                </div>
            </div>
            <div class=""productBorder"">
                <div class=""onliCar"">
                    <i class=""far fa-heart likeIcon""></i>
                    <img alt=""Mercedes ML 270""
                         src=""https://turbo.azstatic.com/uploads/f460x343/2019%2F02%2F19%2F17%2F50%2F49%2Fca9af98f-e1a3-4b62-b3ea-c06b32add0dc%2F62509_Zr_a7fPnvNP3lpeaRMa6Ug.jpg"">
                    <div class=""productPrice"">
                        26 700 <span>AZN</span>
                    </div>
                    <div class=""productsInfo"">
                        <p class=""carName"">Mercedes ML 270</p>
                        <div class=""carInfo"">
                 ");
            WriteLiteral(@"           <p class=""year"">
                                2003 il

                                <span></span>
                            </p>
                            <p class=""engin"">
                                2.7 L
                                <span></span>
                            </p>
                            <p class=""km"">331 250 km </p>
                        </div>
                        <div class=""enterDay"">Gence, Bugun 18:00 <i class=""fas fa-gem""></i></div>
                    </div>
                </div>
            </div>
            <div class=""productBorder"">
                <div class=""onliCar"">
                    <i class=""far fa-heart likeIcon""></i>
                    <img alt=""BMW 528""
                         src=""https://turbo.azstatic.com/uploads/f460x343/2019%2F02%2F06%2F01%2F41%2F47%2Fe4e1c946-d637-4647-833c-9fd6b7076a8f%2F71458_r3F2rZ_f1hJa3gRCmxj-og.jpg"">
                    <div class=""productPrice"">
                        34 800 <sp");
            WriteLiteral(@"an>$</span>
                    </div>
                    <div class=""productsInfo"">
                        <p class=""carName"">BMW 528</p>
                        <div class=""carInfo"">
                            <p class=""year"">
                                2006 il

                                <span></span>
                            </p>
                            <p class=""engin"">
                                2.0 L
                                <span></span>
                            </p>
                            <p class=""km"">33 070 km </p>
                        </div>
                        <div class=""enterDay"">Baki, 05 fevral 2019 <i class=""fas fa-gem""></i></div>


                    </div>
                </div>

            </div>
            <div class=""productBorder"">
                <div class=""onliCar"">
                    <i class=""far fa-heart likeIcon""></i>
                    <img alt=""Mercedes Viano""
                         src=""https://tu");
            WriteLiteral(@"rbo.azstatic.com/uploads/f460x343/2018%2F12%2F24%2F15%2F24%2F02%2F26b178f0-2b30-4e0d-9ce0-41626ab80c94%2F64031_dT0G24aevkWFNFhaJ3dz7Q.jpg"">
                    <div class=""productPrice"">
                        60 000 <span>$</span>
                    </div>
                    <div class=""productsInfo"">
                        <p class=""carName"">Mercedes Viano</p>
                        <div class=""carInfo"">
                            <p class=""year"">
                                2013 il

                                <span></span>
                            </p>
                            <p class=""engin"">
                                3.5 L
                                <span></span>
                            </p>
                            <p class=""km"">28 970 km </p>
                        </div>
                        <div class=""enterDay"">Bu gun 15:43 <i class=""fas fa-gem""></i></div>


                    </div>
                </div>

            </div>
    ");
            WriteLiteral(@"        <div class=""productBorder"">
                <div class=""onliCar"">
                    <i class=""far fa-heart likeIcon""></i>
                    <img alt=""Mitsubishi Pajero""
                         src=""https://turbo.azstatic.com/uploads/f460x343/2019%2F01%2F15%2F19%2F02%2F37%2F0da41b28-aeb3-4c6e-8ccb-34708f3ef34a%2F43992_S1kmbdzqiktzzTyotg4hdg.jpg"">
                    <div class=""productPrice"">
                        22 000 <span>AZN</span>
                    </div>
                    <div class=""productsInfo"">
                        <p class=""carName"">Mitsubishi Pajero</p>
                        <div class=""carInfo"">
                            <p class=""year"">
                                2006 il

                                <span></span>
                            </p>
                            <p class=""engin"">
                                3 L
                                <span></span>
                            </p>
                            <p class=");
            WriteLiteral(@"""km"">160 000 km </p>
                        </div>
                        <div class=""enterDay"">Baki, 02 fevral 2019 <i class=""fas fa-gem""></i></div>


                    </div>
                </div>

            </div>
            <div class=""productBorder"">
                <div class=""onliCar"">
                    <i class=""far fa-heart likeIcon""></i>
                    <img src=""https://turbo.azstatic.com/uploads/f460x343/2018%2F10%2F28%2F18%2F35%2F26%2F7be9eb0b-dd3a-41dc-803f-90ef8f5e041b%2F65966_Mjui3okmrzKKDQC1GoPNQg.jpg""
                         alt="""">
                    <div class=""productPrice"">
                        48 900 <span>$</span>
                    </div>
                    <div class=""productsInfo"">
                        <p class=""carName"">Mercedes E 220</p>
                        <div class=""carInfo"">
                            <p class=""year"">
                                2016 il

                                <span></span>
                     ");
            WriteLiteral(@"       </p>
                            <p class=""engin"">
                                2.0 L
                                <span></span>
                            </p>
                            <p class=""km"">46 000 km </p>
                        </div>
                        <div class=""enterDay"">Baki, 15 fevral 2019 <i class=""fas fa-gem""></i></div>


                    </div>
                </div>

            </div>
            <div class=""productBorder"">
                <div class=""onliCar"">
                    <i class=""far fa-heart likeIcon""></i>
                    <img src=""https://turbo.azstatic.com/uploads/f460x343/2019%2F01%2F24%2F12%2F29%2F52%2Ff355c65c-74e4-47fb-b7f1-e12243a478fe%2F12007_BJCJbRaT1TkZjc_9G3S45w.jpg""
                         alt=""Galenvagen"">
                    <div class=""productPrice"">
                        83 200 <span>$</span>
                    </div>
                    <div class=""productsInfo"">
                        <p class=""carName");
            WriteLiteral(@""">Mercedes G 350</p>
                        <div class=""carInfo"">
                            <p class=""year"">
                                2013 il

                                <span></span>
                            </p>
                            <p class=""engin"">
                                3.5 L
                                <span></span>
                            </p>
                            <p class=""km"">61 000 km </p>
                        </div>
                        <div class=""enterDay"">Baki, 13 fevral 2019 <i class=""fas fa-gem""></i></div>


                    </div>
                </div>

            </div>
            <div class=""productBorder"">
                <div class=""onliCar"">
                    <i class=""far fa-heart likeIcon""></i>
                    <img src=""https://turbo.azstatic.com/uploads/f460x343/2019%2F02%2F04%2F15%2F36%2F12%2F1eb7f997-c6c5-46bb-8aaa-5e75740399d9%2F35798_aY7O0CEViPNXYGqqctWDQA.jpg""
                         alt=""");
            WriteLiteral(@""">
                    <div class=""productPrice"">
                        38 900 <span>AZN</span>
                    </div>
                    <div class=""productsInfo"">
                        <p class=""carName"">Hundai Sonata</p>
                        <div class=""carInfo"">
                            <p class=""year"">
                                2019 il

                                <span></span>
                            </p>
                            <p class=""engin"">
                                2.0 L
                                <span></span>
                            </p>
                            <p class=""km"">0 km </p>
                        </div>
                        <div class=""enterDay"">Baki, 10 fevral 2019 <i class=""fas fa-gem""></i></div>


                    </div>
                </div>

            </div>
            <div class=""productBorder"">
                <div class=""onliCar"">
                    <i class=""far fa-heart likeIcon""></i>");
            WriteLiteral(@"
                    <img alt=""Suzuki GSF 250 Bandit""
                         src=""https://turbo.azstatic.com/uploads/f460x343/2019%2F02%2F19%2F18%2F00%2F53%2F071d5a42-d9ba-49db-be38-3bd00faf9242%2F74752_u4Gk0NGe7FVFn-govU1Fiw.jpg"">
                    <div class=""productPrice"">
                        2 000 <span>AZN</span>
                    </div>
                    <div class=""productsInfo"">
                        <p class=""carName"">Suzuki GSF 250 Bandit</p>
                        <div class=""carInfo"">
                            <p class=""year"">
                                2005 il

                                <span></span>
                            </p>
                            <p class=""engin"">
                                0.3 L
                                <span></span>
                            </p>
                            <p class=""km"">20 000 km </p>
                        </div>
                        <div class=""enterDay"">Baki, 08 yanvar 2019 <i c");
            WriteLiteral(@"lass=""fas fa-gem""></i></div>


                    </div>
                </div>

            </div>
            <div class=""productBorder"">
                <div class=""onliCar"">
                    <i class=""far fa-heart likeIcon""></i>
                    <img alt=""Audi A4""
                         src=""https://turbo.azstatic.com/uploads/f460x343/2019%2F02%2F19%2F18%2F04%2F51%2F2ba57138-aa13-469a-ae77-796c8a86dbbc%2F28361_46Wv0kprsQNRYmFnWTuE2Q.jpg"">
                    <div class=""productPrice"">
                        21 900 <span>$</span>
                    </div>
                    <div class=""productsInfo"">
                        <p class=""carName"">Audi A4</p>
                        <div class=""carInfo"">
                            <p class=""year"">
                                2010 il

                                <span></span>
                            </p>
                            <p class=""engin"">
                                2.0 L
                          ");
            WriteLiteral(@"      <span></span>
                            </p>
                            <p class=""km"">165 000 km </p>
                        </div>
                        <div class=""enterDay"">Baki, 14 fevral 2019 <i class=""fas fa-gem""></i></div>


                    </div>
                </div>

            </div>
            <div class=""productBorder"">
                <div class=""onliCar"">
                    <i class=""far fa-heart likeIcon""></i>
                    <img alt=""Mercedes E 240""
                         src=""https://turbo.azstatic.com/uploads/f460x343/2019%2F02%2F19%2F18%2F00%2F34%2F63f24fa6-77d2-403a-aa93-b2b2f6afcf22%2F7353_haDyMi5s6ysV5G97rqf10Q.jpg"">
                    <div class=""productPrice"">
                        15 200 <span>AZN</span>
                    </div>
                    <div class=""productsInfo"">
                        <p class=""carName"">Mercedes E 240</p>
                        <div class=""carInfo"">
                            <p class=""year"">
    ");
            WriteLiteral(@"                            2001 il

                                <span></span>
                            </p>
                            <p class=""engin"">
                                2.6 L
                                <span></span>
                            </p>
                            <p class=""km"">250 000 km </p>
                        </div>
                        <div class=""enterDay"">Baki, 13 fevral 2019 <i class=""fas fa-gem""></i></div>


                    </div>
                </div>

            </div>
            <div class=""productBorder"">
                <div class=""onliCar"">
                    <i class=""far fa-heart likeIcon""></i>
                    <img alt=""Toyota Land Cruiser""
                         src=""https://turbo.azstatic.com/uploads/f460x343/2018%2F10%2F04%2F19%2F22%2F26%2F09c13655-433d-4276-9cc1-46927546c912%2F42149_zsM_ohRMAfnpE_3GKp1w6Q.jpg"">
                    <div class=""productPrice"">
                        11 900 <span>$</span>
");
            WriteLiteral(@"                    </div>
                    <div class=""productsInfo"">
                        <p class=""carName"">Toyota Land Cruiser</p>
                        <div class=""carInfo"">
                            <p class=""year"">
                                2000 il

                                <span></span>
                            </p>
                            <p class=""engin"">
                                4.7 L
                                <span></span>
                            </p>
                            <p class=""km"">248 000 km </p>
                        </div>
                        <div class=""enterDay"">Yevlax, 20 fevral 2019 <i class=""fas fa-gem""></i></div>


                    </div>
                </div>

            </div>
        </div>
        <div class=""clear""></div>
    </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Advertisement> Html { get; private set; }
    }
}
#pragma warning restore 1591