#pragma checksum "e:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d75a699019f3b19a2efaac9c259796625e7c906e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Tarea9_10.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "e:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "e:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "e:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "e:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "e:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "e:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "e:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "e:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\_Imports.razor"
using Tarea9_10;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "e:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\_Imports.razor"
using Tarea9_10.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "e:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "e:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "e:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "e:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\Login.razor"
using Tarea9_10.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "e:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\Login.razor"
       

    // para bindear el nombre y clave del formulario.
    private Usuario _user = new Usuario();
    // para guardar ocupaciones del usuario.
    private List<Ocupacion> usuario_ocupaciones = new List<Ocupacion>();
    // para los avisos (si ingreso los datos correctos o no).
    private string message;

    // limpiar los datos y llenar la lista ocupacion_service._ocupaciones.
    protected override async Task OnInitializedAsync()
    {
        // limpiar los datos cada vez que entra a esta pagina.
        usuario_service.state = false;
        usuario_service.permiso = false;
        usuario_ocupaciones = new List<Ocupacion>();

        // llenar una lista de tipo ocupacion para filtrar ocupaciones que pertenece al usuario.
        ocupacion_service._ocupaciones = await ocupacion_service.GetOcupacionsAsync();
    }

    // validar y luego llevar el usuario a la pagina inicial.
    private void toContent()
    {
        // pasando el _user a UsuarioServices para validar si existe en la base de datos.
        message = usuario_service.ValidarUsuario(_user);

        //ejecutar si el estado es true.
        if (usuario_service.state)
        {
            // filtrar las ocupaciones del usuario con la lista ocupacion_service._ocupaciones.PersonaId y usuario_service._usuario.PersonaId.
            usuario_ocupaciones = ocupacion_service._ocupaciones.Where(x => x.PersonaId == usuario_service._usuario.PersonaId).ToList();

            // filtrar las ocupaciones del usuario de nuevo para saber si tiene una funcionalidad como pastor o anciano.
            usuario_ocupaciones = usuario_ocupaciones.Where(y => y.Nombre == "Pastor" || y.Nombre == "Anciano").ToList();
            // ejecutar si la lista no esta vacio.
            if(usuario_ocupaciones.Count > 0)
            {
                // cambiar el permiso(cual nos sirve si dejar al usuario utilizar ciertas funcionalidades de la pagina) a true.
                usuario_service.permiso = true;
            }
            // llevar el usuario a la pagina inicial.
            nav.NavigateTo("/");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OcupacionServices ocupacion_service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UsuarioServices usuario_service { get; set; }
    }
}
#pragma warning restore 1591
