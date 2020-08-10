#pragma checksum "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c44bc4890eb9306343c06c88d5eba48c879ea73"
// <auto-generated/>
#pragma warning disable 1591
namespace SoccerLeagueTransferApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using SoccerLeagueTransferApp.Shared;

#line default
#line hidden
#line 5 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
using SoccerLeagueTransferApp.Models.ConData;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/club-detail")]
    public partial class ClubDetail : SoccerLeagueTransferApp.Pages.ClubDetailComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(4);
                __builder2.AddAttribute(5, "Size", "H1");
                __builder2.AddAttribute(6, "Text", "Club Detail");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row");
                __builder2.AddMarkupContent(10, "\n      ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-md-12");
                __builder2.AddMarkupContent(13, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(14);
                __builder2.AddAttribute(15, "Icon", "add_circle_outline");
                __builder2.AddAttribute(16, "style", "margin-bottom: 10px");
                __builder2.AddAttribute(17, "Text", "Add");
                __builder2.AddAttribute(18, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 14 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
                                                                                               Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<SoccerLeagueTransferApp.Models.ConData.ClubDetail>>(20);
                __builder2.AddAttribute(21, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<SoccerLeagueTransferApp.Models.ConData.ClubDetail>>(
#line 16 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
                                                                                                     getClubDetailsResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<SoccerLeagueTransferApp.Models.ConData.ClubDetail>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<SoccerLeagueTransferApp.Models.ConData.ClubDetail>(this, 
#line 16 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
                                                                                                                                                                                                 Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(26, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.ClubDetail>>(28);
                    __builder3.AddAttribute(29, "Property", "TeamID");
                    __builder3.AddAttribute(30, "Title", "Team ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.ClubDetail>>(32);
                    __builder3.AddAttribute(33, "Property", "TeamName");
                    __builder3.AddAttribute(34, "Title", "Team Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(35, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.ClubDetail>>(36);
                    __builder3.AddAttribute(37, "Property", "HomeGround");
                    __builder3.AddAttribute(38, "Title", "Home Ground");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.ClubDetail>>(40);
                    __builder3.AddAttribute(41, "Property", "RegisteredOfficeAddress");
                    __builder3.AddAttribute(42, "Title", "Registered Office Address");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.ClubDetail>>(44);
                    __builder3.AddAttribute(45, "Property", "ContactEmail");
                    __builder3.AddAttribute(46, "Title", "Contact Email");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(47, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.ClubDetail>>(48);
                    __builder3.AddAttribute(49, "Property", "ContactTelephone");
                    __builder3.AddAttribute(50, "Title", "Contact Telephone");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(51, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.ClubDetail>>(52);
                    __builder3.AddAttribute(53, "Property", "ClubLogo");
                    __builder3.AddAttribute(54, "Title", "Club Logo");
                    __builder3.AddAttribute(55, "Template", (Microsoft.AspNetCore.Components.RenderFragment<SoccerLeagueTransferApp.Models.ConData.ClubDetail>)((soccerLeagueTransferAppModelsConDataClubDetail) => (__builder4) => {
                        __builder4.AddMarkupContent(56, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenImage>(57);
                        __builder4.AddAttribute(58, "Path", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 32 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
                                     soccerLeagueTransferAppModelsConDataClubDetail.ClubLogo

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(59, "style", "height: 50px; width: 50px");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(60, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(61, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SoccerLeagueTransferApp.Models.ConData.ClubDetail>>(62);
                    __builder3.AddAttribute(63, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 36 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
                                                                                                    false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(64, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 36 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
                                                                                                                     false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(65, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 36 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
                                                                                                                                       TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(66, "Width", "70px");
                    __builder3.AddAttribute(67, "Template", (Microsoft.AspNetCore.Components.RenderFragment<SoccerLeagueTransferApp.Models.ConData.ClubDetail>)((soccerLeagueTransferAppModelsConDataClubDetail) => (__builder4) => {
                        __builder4.AddMarkupContent(68, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(69);
                        __builder4.AddAttribute(70, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 38 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(71, "Icon", "close");
                        __builder4.AddAttribute(72, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 38 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(73, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 38 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, soccerLeagueTransferAppModelsConDataClubDetail)

#line default
#line hidden
                        )));
                        __builder4.AddEventStopPropagationAttribute(74, "onclick", 
#line 38 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
                                                                                                                                                                                                                              true

#line default
#line hidden
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(75, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(76, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(77, (__value) => {
#line 16 "C:\SoccerLeagueTransfer\server\Pages\ClubDetail.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<SoccerLeagueTransferApp.Models.ConData.ClubDetail>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(78, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
