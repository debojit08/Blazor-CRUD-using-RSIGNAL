#pragma checksum "E:\Asp_Project\Blazor_Server_Crud\Blazor_Server_Crud\Pages\AddEmp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f7502dadb604533d1277511af959c0537b1b545"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor_Server_Crud.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Asp_Project\Blazor_Server_Crud\Blazor_Server_Crud\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Asp_Project\Blazor_Server_Crud\Blazor_Server_Crud\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Asp_Project\Blazor_Server_Crud\Blazor_Server_Crud\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Asp_Project\Blazor_Server_Crud\Blazor_Server_Crud\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Asp_Project\Blazor_Server_Crud\Blazor_Server_Crud\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Asp_Project\Blazor_Server_Crud\Blazor_Server_Crud\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Asp_Project\Blazor_Server_Crud\Blazor_Server_Crud\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Asp_Project\Blazor_Server_Crud\Blazor_Server_Crud\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Asp_Project\Blazor_Server_Crud\Blazor_Server_Crud\_Imports.razor"
using Blazor_Server_Crud;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Asp_Project\Blazor_Server_Crud\Blazor_Server_Crud\_Imports.razor"
using Blazor_Server_Crud.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Asp_Project\Blazor_Server_Crud\Blazor_Server_Crud\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Asp_Project\Blazor_Server_Crud\Blazor_Server_Crud\_Imports.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Asp_Project\Blazor_Server_Crud\Blazor_Server_Crud\Pages\AddEmp.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Asp_Project\Blazor_Server_Crud\Blazor_Server_Crud\Pages\AddEmp.razor"
using Blazor_Server_Crud.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addEmp")]
    public partial class AddEmp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>AddEmp</h3>\r\n\r\n");
            __builder.OpenElement(1, "form");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-8");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group");
            __builder.AddMarkupContent(8, "<label for=\"empName\" class=\"control-label\">Name</label>\r\n                ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "for", "empName");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "id", "t1");
            __builder.AddAttribute(13, "required");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "E:\Asp_Project\Blazor_Server_Crud\Blazor_Server_Crud\Pages\AddEmp.razor"
                                                                          emp.empName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => emp.empName = __value, emp.empName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n            ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "form-group");
            __builder.AddMarkupContent(19, "<label for=\"designation\" class=\"control-label\">Designation</label>\r\n                ");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "for", "designation");
            __builder.AddAttribute(22, "class", "form-control");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "E:\Asp_Project\Blazor_Server_Crud\Blazor_Server_Crud\Pages\AddEmp.razor"
                                                                      emp.designation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => emp.designation = __value, emp.designation));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n\r\n            ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "form-group");
            __builder.AddMarkupContent(28, "<label for=\"department\" class=\"control-label\">Department</label>\r\n                ");
            __builder.OpenElement(29, "input");
            __builder.AddAttribute(30, "for", "department");
            __builder.AddAttribute(31, "class", "form-control");
            __builder.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "E:\Asp_Project\Blazor_Server_Crud\Blazor_Server_Crud\Pages\AddEmp.razor"
                                                                     emp.department

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => emp.department = __value, emp.department));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "row");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "col-md-4");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "form-group");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "type", "button");
            __builder.AddAttribute(43, "class", "btn btn-primary");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "E:\Asp_Project\Blazor_Server_Crud\Blazor_Server_Crud\Pages\AddEmp.razor"
                                                                        CreateEmp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "value", "save");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "input");
            __builder.AddAttribute(48, "type", "button");
            __builder.AddAttribute(49, "class", "btn");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "E:\Asp_Project\Blazor_Server_Crud\Blazor_Server_Crud\Pages\AddEmp.razor"
                                                            Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "E:\Asp_Project\Blazor_Server_Crud\Blazor_Server_Crud\Pages\AddEmp.razor"
       

    empInfo emp = new empInfo();
    private HubConnection hubConnection;
    protected override async Task OnInitializedAsync()
    {
        hubConnection = new HubConnectionBuilder()
           .WithUrl(NavigationManager.ToAbsoluteUri("/EmpHub"))
           .Build();

        await hubConnection.StartAsync();
    }

    public bool IsConnected =>
        hubConnection.State == HubConnectionState.Connected;

    public async Task CreateEmp()
        {
        await Http.PostJsonAsync("http://localhost:55449/api/empInfoes", emp);
        if (IsConnected) await SendMessage();
        NavigationManager.NavigateTo("employeeList");

        }

        

        Task SendMessage() => hubConnection.SendAsync("SendMessage");

        void Cancel()
        {
            NavigationManager.NavigateTo("employeeList");
        }


        public void Dispose()
        {
            _ = hubConnection.DisposeAsync();
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
