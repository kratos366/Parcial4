// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
