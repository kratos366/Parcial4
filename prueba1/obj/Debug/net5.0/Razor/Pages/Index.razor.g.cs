#pragma checksum "C:\Users\Hawaii36\source\repos\prueba1\prueba1\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9360592bbc334fbe9d31f02be074f6499af3d4cb"
// <auto-generated/>
#pragma warning disable 1591
namespace prueba1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Hawaii36\source\repos\prueba1\prueba1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hawaii36\source\repos\prueba1\prueba1\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Hawaii36\source\repos\prueba1\prueba1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Hawaii36\source\repos\prueba1\prueba1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Hawaii36\source\repos\prueba1\prueba1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Hawaii36\source\repos\prueba1\prueba1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Hawaii36\source\repos\prueba1\prueba1\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Hawaii36\source\repos\prueba1\prueba1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Hawaii36\source\repos\prueba1\prueba1\_Imports.razor"
using prueba1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Hawaii36\source\repos\prueba1\prueba1\_Imports.razor"
using prueba1.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"py-5 text-center\">Panel de Control</h1>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-6 p-5");
            __builder.OpenElement(7, "div");
            __builder.AddMarkupContent(8, "<h4 class=\"p-5\">Administrar Activos</h4>\r\n                \r\n                ");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "class", "btn btn-primary");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Hawaii36\source\repos\prueba1\prueba1\Pages\Index.razor"
                                                          AgregarActivo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(12, "Agregar Activo");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "class", "btn btn-secondary");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\Hawaii36\source\repos\prueba1\prueba1\Pages\Index.razor"
                                                            EditarActivo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "Editar Activo");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "class", "btn btn-danger");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\Hawaii36\source\repos\prueba1\prueba1\Pages\Index.razor"
                                                         EliminarActivo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, "Eliminar Activo");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 16 "C:\Users\Hawaii36\source\repos\prueba1\prueba1\Pages\Index.razor"
             if (mostrarFormulario)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "div");
            __builder.AddMarkupContent(24, "<h4>Formulario para Agregar Activo</h4>\r\n                    ");
            __builder.OpenElement(25, "form");
            __builder.AddAttribute(26, "id", "formregistro");
            __builder.AddMarkupContent(27, "<div class=\"form-group\"><label for=\"nomActi\">Nombre del Activo:</label>\r\n                            <input type=\"text\" name=\"nomActi\" class=\"form-control\" id=\"nomActi\"></div>\r\n                        ");
            __builder.AddMarkupContent(28, "<div class=\"form-group\"><label for=\"tipAct\">Tipo de Activo:</label>\r\n                            <input type=\"text\" name=\"tipAct\" class=\"form-control\" id=\"tipAct\"></div>\r\n                        ");
            __builder.AddMarkupContent(29, "<div class=\"form-group\"><label for=\"ubiActi\">Ubicación del Activo:</label>\r\n                            <input type=\"text\" name=\"ubiActi\" class=\"form-control\" id=\"ubiActi\"></div>\r\n                        ");
            __builder.AddMarkupContent(30, "<div class=\"form-group\"><label for=\"estadoVenta\">Estado de Venta:</label>\r\n                            <input type=\"text\" name=\"estadoVenta\" class=\"form-control\" id=\"estadoVenta\"></div>\r\n                        ");
            __builder.AddMarkupContent(31, "<div class=\"form-group\"><label for=\"fechVenta\">Fecha de Venta:</label>\r\n                            <input type=\"date\" name=\"fechVenta\" class=\"form-control\" id=\"fechVenta\"></div>\r\n                        ");
            __builder.AddMarkupContent(32, "<div class=\"form-group\"><label for=\"valor\">Valor:</label>\r\n                            <input type=\"number\" class=\"form-control\" id=\"valor\" step=\"0.01\"></div>\r\n                        ");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "type", "button");
            __builder.AddAttribute(35, "class", "btn btn-success");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\Hawaii36\source\repos\prueba1\prueba1\Pages\Index.razor"
                                                                                Guardar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, "Guardar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 48 "C:\Users\Hawaii36\source\repos\prueba1\prueba1\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.AddMarkupContent(39, @"<div class=""col-md-6""><div><h4 class id=""listAct"" name=""listAct"">Lista de Activos</h4>
                
                
                <table class=""table table-striped"" id=""tblAct""><thead><tr><th>Nombre</th>
                            <th>Tipo</th>
                            <th>Estado</th></tr></thead>
                    <tbody></tbody></table></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "C:\Users\Hawaii36\source\repos\prueba1\prueba1\Pages\Index.razor"
       
    private bool mostrarFormulario = false;
    private string nomActi;
    private string tipAct;
    private string ubiActi;
    private string estadoVenta;
    private DateTime fechaVenta;
    private decimal valor;





    private void MostrarFormulario()
    {
        mostrarFormulario = !mostrarFormulario;
    }
    // Lógica para agregar un activo

    private void Guardar()
    {
        // Aquí puedes realizar la inserción de los datos en la base de datos o en tu lógica de aplicación
        // Utiliza los valores de las propiedades nomActi, tipAct, ubiActi, estadoVenta, fechaVenta y valor
        // para realizar la inserción

        // Después de realizar la inserción, puedes realizar otras acciones si es necesario

        // Finalmente, oculta el formulario
        mostrarFormulario = false;

        // Limpia los campos del formulario
        nomActi = string.Empty;
        tipAct = string.Empty;
        ubiActi = string.Empty;
        estadoVenta = string.Empty;
        fechaVenta = DateTime.Now;
        valor = 0;
    }
    private void AgregarActivo()
    {
        MostrarFormulario();
    }

    private void EditarActivo()
    {
        // Implementa la lógica para editar un activo aquí
    }

    private void EliminarActivo()
    {
        // Implementa la lógica para eliminar un activo aquí
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
