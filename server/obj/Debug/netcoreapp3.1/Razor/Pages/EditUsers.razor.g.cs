#pragma checksum "C:\SoccerLeagueTransfer\server\Pages\EditUsers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c22d190e36203cced2cc49480b466caf99016954"
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
#line 5 "C:\SoccerLeagueTransfer\server\Pages\EditUsers.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\SoccerLeagueTransfer\server\Pages\EditUsers.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\SoccerLeagueTransfer\server\Pages\EditUsers.razor"
using SoccerLeagueTransferApp.Models.ConData;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit-users/{UserID}")]
    public partial class EditUsers : SoccerLeagueTransferApp.Pages.EditUsersComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.AddMarkupContent(6, "\n      ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-md-12");
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<SoccerLeagueTransferApp.Models.ConData.User>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<SoccerLeagueTransferApp.Models.ConData.User>(
#line 12 "C:\SoccerLeagueTransfer\server\Pages\EditUsers.razor"
                                   user

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "C:\SoccerLeagueTransfer\server\Pages\EditUsers.razor"
                                                                                                        user != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<SoccerLeagueTransferApp.Models.ConData.User>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<SoccerLeagueTransferApp.Models.ConData.User>(this, 
#line 12 "C:\SoccerLeagueTransfer\server\Pages\EditUsers.razor"
                                                                                                                                Form0Submit

#line default
#line hidden
                )));
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(15, "\n            ");
                    __builder3.OpenElement(16, "div");
                    __builder3.AddAttribute(17, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(18, "class", "row");
                    __builder3.AddMarkupContent(19, "\n              ");
                    __builder3.OpenElement(20, "div");
                    __builder3.AddAttribute(21, "class", "col-md-3");
                    __builder3.AddMarkupContent(22, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(23);
                    __builder3.AddAttribute(24, "Component", "Username");
                    __builder3.AddAttribute(25, "style", "width: 100%");
                    __builder3.AddAttribute(26, "Text", "Username");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\n              ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "col-md-9");
                    __builder3.AddMarkupContent(31, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(32);
                    __builder3.AddAttribute(33, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#line 20 "C:\SoccerLeagueTransfer\server\Pages\EditUsers.razor"
                                          50

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(34, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(35, "Name", "Username");
                    __builder3.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 20 "C:\SoccerLeagueTransfer\server\Pages\EditUsers.razor"
                                                                                                 user.Username

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Username = __value, user.Username))));
                    __builder3.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Username));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(40);
                    __builder3.AddAttribute(41, "Component", "Username");
                    __builder3.AddAttribute(42, "style", "position: absolute");
                    __builder3.AddAttribute(43, "Text", "Username is required");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(44, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(45, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(46, "\n            ");
                    __builder3.OpenElement(47, "div");
                    __builder3.AddAttribute(48, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(49, "class", "row");
                    __builder3.AddMarkupContent(50, "\n              ");
                    __builder3.OpenElement(51, "div");
                    __builder3.AddAttribute(52, "class", "col-md-3");
                    __builder3.AddMarkupContent(53, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(54);
                    __builder3.AddAttribute(55, "Component", "Password");
                    __builder3.AddAttribute(56, "style", "width: 100%");
                    __builder3.AddAttribute(57, "Text", "Password");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(58, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(59, "\n              ");
                    __builder3.OpenElement(60, "div");
                    __builder3.AddAttribute(61, "class", "col-md-9");
                    __builder3.AddMarkupContent(62, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(63);
                    __builder3.AddAttribute(64, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#line 32 "C:\SoccerLeagueTransfer\server\Pages\EditUsers.razor"
                                          50

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(65, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(66, "Name", "Password");
                    __builder3.AddAttribute(67, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 32 "C:\SoccerLeagueTransfer\server\Pages\EditUsers.razor"
                                                                                                 user.Password

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(68, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Password = __value, user.Password))));
                    __builder3.AddAttribute(69, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Password));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(70, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(71);
                    __builder3.AddAttribute(72, "Component", "Password");
                    __builder3.AddAttribute(73, "style", "position: absolute");
                    __builder3.AddAttribute(74, "Text", "Password is required");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(75, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(76, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(77, "\n            ");
                    __builder3.OpenElement(78, "div");
                    __builder3.AddAttribute(79, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(80, "class", "row");
                    __builder3.AddMarkupContent(81, "\n              ");
                    __builder3.OpenElement(82, "div");
                    __builder3.AddAttribute(83, "class", "col-md-3");
                    __builder3.AddMarkupContent(84, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(85);
                    __builder3.AddAttribute(86, "Component", "TeamID");
                    __builder3.AddAttribute(87, "style", "width: 100%");
                    __builder3.AddAttribute(88, "Text", "Club Detail");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(89, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(90, "\n              ");
                    __builder3.OpenElement(91, "div");
                    __builder3.AddAttribute(92, "class", "col-md-9");
                    __builder3.AddMarkupContent(93, "\n                ");
                    __Blazor.SoccerLeagueTransferApp.Pages.EditUsers.TypeInference.CreateRadzenDropDown_0(__builder3, 94, 95, 
#line 44 "C:\SoccerLeagueTransfer\server\Pages\EditUsers.razor"
                                       getClubDetailsResult

#line default
#line hidden
                    , 96, "Choose Club Detail", 97, "width: 100%", 98, "TeamName", 99, "TeamID", 100, "TeamID", 101, 
#line 44 "C:\SoccerLeagueTransfer\server\Pages\EditUsers.razor"
                                                                                                                                                         user.TeamID

#line default
#line hidden
                    , 102, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.TeamID = __value, user.TeamID)), 103, () => user.TeamID);
                    __builder3.AddMarkupContent(104, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(105, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(106, "\n            ");
                    __builder3.OpenElement(107, "div");
                    __builder3.AddAttribute(108, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(109, "class", "row");
                    __builder3.AddMarkupContent(110, "\n              ");
                    __builder3.OpenElement(111, "div");
                    __builder3.AddAttribute(112, "class", "col-md-3");
                    __builder3.AddMarkupContent(113, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(114);
                    __builder3.AddAttribute(115, "Component", "TeamID");
                    __builder3.AddAttribute(116, "style", "width: 100%");
                    __builder3.AddAttribute(117, "Text", "User Role(s)");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(118, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(119, "\n              ");
                    __builder3.OpenElement(120, "div");
                    __builder3.AddAttribute(121, "class", "col-md-9");
                    __builder3.AddMarkupContent(122, "\n                ");
                    __Blazor.SoccerLeagueTransferApp.Pages.EditUsers.TypeInference.CreateRadzenDropDown_1(__builder3, 123, 124, 
#line 54 "C:\SoccerLeagueTransfer\server\Pages\EditUsers.razor"
                                       getRolesResult

#line default
#line hidden
                    , 125, 
#line 54 "C:\SoccerLeagueTransfer\server\Pages\EditUsers.razor"
                                                                 true

#line default
#line hidden
                    , 126, "Please Assign Role To User", 127, "width: 100%", 128, "RoleName", 129, "RoleName", 130, "UserRoles", 131, 
#line 54 "C:\SoccerLeagueTransfer\server\Pages\EditUsers.razor"
                                                                                                                                                                          userRoleNames

#line default
#line hidden
                    , 132, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userRoleNames = __value, userRoleNames)), 133, () => userRoleNames);
                    __builder3.AddMarkupContent(134, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(135, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(136, "\n            ");
                    __builder3.OpenElement(137, "div");
                    __builder3.AddAttribute(138, "class", "row");
                    __builder3.AddMarkupContent(139, "\n              ");
                    __builder3.OpenElement(140, "div");
                    __builder3.AddAttribute(141, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(142, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(143);
                    __builder3.AddAttribute(144, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 60 "C:\SoccerLeagueTransfer\server\Pages\EditUsers.razor"
                                           ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(145, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 60 "C:\SoccerLeagueTransfer\server\Pages\EditUsers.razor"
                                                                            ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(146, "Icon", "save");
                    __builder3.AddAttribute(147, "Text", "Save");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(148, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(149);
                    __builder3.AddAttribute(150, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 62 "C:\SoccerLeagueTransfer\server\Pages\EditUsers.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(151, "Text", "Cancel");
                    __builder3.AddAttribute(152, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 62 "C:\SoccerLeagueTransfer\server\Pages\EditUsers.razor"
                                                                                    Button2Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(153, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(154, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(155, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(156, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(157, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(158, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.SoccerLeagueTransferApp.Pages.EditUsers
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDropDown_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, System.Object __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Placeholder", __arg1);
        __builder.AddAttribute(__seq2, "style", __arg2);
        __builder.AddAttribute(__seq3, "TextProperty", __arg3);
        __builder.AddAttribute(__seq4, "ValueProperty", __arg4);
        __builder.AddAttribute(__seq5, "Name", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDropDown_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.String __arg2, int __seq3, System.Object __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.String __arg6, int __seq7, global::System.Object __arg7, int __seq8, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg8, int __seq9, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg9)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Multiple", __arg1);
        __builder.AddAttribute(__seq2, "Placeholder", __arg2);
        __builder.AddAttribute(__seq3, "style", __arg3);
        __builder.AddAttribute(__seq4, "TextProperty", __arg4);
        __builder.AddAttribute(__seq5, "ValueProperty", __arg5);
        __builder.AddAttribute(__seq6, "Name", __arg6);
        __builder.AddAttribute(__seq7, "Value", __arg7);
        __builder.AddAttribute(__seq8, "ValueChanged", __arg8);
        __builder.AddAttribute(__seq9, "ValueExpression", __arg9);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
