#pragma checksum "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\Listar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60b87521c485ff89c1e7c74d9f57e3f192d0e494"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea9_10.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\_Imports.razor"
using Tarea9_10;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\_Imports.razor"
using Tarea9_10.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\Listar.razor"
using Tarea9_10.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\Listar.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listar")]
    public partial class Listar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 14 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\Listar.razor"
 if (usuario_service.state)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "    \r\n    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "input-group mb-3");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "class", "form-control");
            __builder.AddAttribute(7, "placeholder", "Buscar persona");
            __builder.AddAttribute(8, "aria-describedby", "basic-addon1");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\Listar.razor"
                                                                                                                    name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => name = __value, name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "input-group-prepend");
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "span");
            __builder.AddAttribute(16, "class", "input-group-text" + " " + (
#nullable restore
#line 20 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\Listar.razor"
                                           Icono

#line default
#line hidden
#nullable disable
            ) + " justify-content-center");
            __builder.AddAttribute(17, "id", "basic-addon1");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\Listar.razor"
                                                                                                     buscar

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    \r\n    ");
            __builder.OpenElement(22, "table");
            __builder.AddAttribute(23, "class", "table");
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.OpenElement(25, "thead");
            __builder.AddAttribute(26, "class", "thead-dark");
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "tr");
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.AddMarkupContent(30, "<th scope=\"col\">Nombres</th>\r\n                ");
            __builder.AddMarkupContent(31, "<th scope=\"col\">Apellidos</th>\r\n                ");
            __builder.AddMarkupContent(32, "<th scope=\"col\">Sexo</th>\r\n                ");
            __builder.AddMarkupContent(33, "<th scope=\"col\">Pais Actual</th>\r\n                ");
            __builder.AddMarkupContent(34, "<th scope=\"col\">Teléfono</th>\r\n                \r\n");
#nullable restore
#line 33 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\Listar.razor"
                 if (usuario_service.permiso)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "                    ");
            __builder.AddMarkupContent(36, "<th scope=\"col\">Ver Detalle</th>\r\n                    ");
            __builder.AddMarkupContent(37, "<th scope=\"col\">Editar</th>\r\n                    ");
            __builder.AddMarkupContent(38, "<th scope=\"col\">Borrar</th>\r\n");
#nullable restore
#line 38 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\Listar.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.OpenElement(42, "tbody");
            __builder.AddMarkupContent(43, "\r\n            \r\n");
#nullable restore
#line 43 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\Listar.razor"
             foreach (var persona in persona_service._personas)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "                ");
            __builder.OpenElement(45, "tr");
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.OpenElement(47, "th");
            __builder.AddAttribute(48, "scope", "row");
            __builder.AddContent(49, 
#nullable restore
#line 46 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\Listar.razor"
                                     persona.Nombres

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.OpenElement(51, "td");
            __builder.AddContent(52, 
#nullable restore
#line 47 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\Listar.razor"
                         persona.Apellidos

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.OpenElement(54, "td");
            __builder.AddContent(55, 
#nullable restore
#line 48 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\Listar.razor"
                         persona.Sexo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.OpenElement(57, "td");
            __builder.AddContent(58, 
#nullable restore
#line 49 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\Listar.razor"
                         persona.Pais_Actual

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                    ");
            __builder.OpenElement(60, "td");
            __builder.AddContent(61, 
#nullable restore
#line 50 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\Listar.razor"
                         persona.Telefono

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                    \r\n");
#nullable restore
#line 52 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\Listar.razor"
                     if (usuario_service.permiso)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(63, "                        ");
            __builder.OpenElement(64, "td");
            __builder.AddAttribute(65, "class", "text-center");
            __builder.OpenElement(66, "span");
            __builder.AddAttribute(67, "class", "oi oi-zoom-in");
            __builder.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\Listar.razor"
                                                                                        ()=> showModal(persona.PersonaId)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                        ");
            __builder.OpenElement(70, "td");
            __builder.AddAttribute(71, "class", "text-center");
            __builder.OpenElement(72, "span");
            __builder.AddAttribute(73, "class", "oi oi-pencil");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\Listar.razor"
                                                                                       ()=> update(persona.PersonaId)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                        ");
            __builder.OpenElement(76, "td");
            __builder.AddAttribute(77, "class", "text-center");
            __builder.OpenElement(78, "span");
            __builder.AddAttribute(79, "class", "oi oi-trash");
            __builder.AddAttribute(80, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\Listar.razor"
                                                                                      ()=> remove(persona)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n");
#nullable restore
#line 57 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\Listar.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(82, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n");
#nullable restore
#line 59 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\Listar.razor"

            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(84, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n    ");
            __builder.OpenElement(87, "center");
            __builder.OpenElement(88, "h3");
            __builder.AddContent(89, 
#nullable restore
#line 63 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\Listar.razor"
                 message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n");
#nullable restore
#line 64 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\Listar.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(91, "    ");
            __builder.AddMarkupContent(92, "<h3>No estas autorizado</h3>\r\n");
#nullable restore
#line 68 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\Listar.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\Listar.razor"
       

    // un string "name" para bindear el input del buscador, un string "Icono" para cambiar el icono del buscador.
    private string name = "", Icono = "oi oi-magnifying-glass", message;

    // para guardar la persona admin cual no quiero presentarlo en la lista.
    private Persona admin = new Persona();

    //llenar todas las listas cual lo necesito para filtrar los datos con el PersonaId y borrar la persona admin.
    protected override async Task OnInitializedAsync()
    {
        persona_service._personas = await persona_service.GetPersonasAsync();
        admin = persona_service._personas.FirstOrDefault(x => x.PersonaId == 5);
        persona_service._personas.Remove(admin);
        datosCiviles_service._datosCiviles = await datosCiviles_service.GetDatosCivilesAsync();
        datosEclesiasticos_service._datosEclesiasticos = await datosEclesiasticos_service.GetDatosEclesiasticosAsync();
        usuario_service._usuarios = await usuario_service.GetUsuariosAsync();
        ocupacion_service._ocupaciones = await ocupacion_service.GetOcupacionsAsync();

        if (persona_service.update)
        {
            persona_service.update = false;
        }
    }

    //metodo para filtrar la lista de la tabla con el string "name".
    private async Task buscar()
    {
        persona_service._personas = await persona_service.GetPersonasAsync();
        persona_service._personas.Remove(admin);

        if (name != "")
        {
            // llenar la lista persona_service._personas con personas que contengan los alfabetos de "name".
            persona_service._personas = persona_service._personas.
            Where(x => 
                x.Nombres.ToLower().Contains(name.ToLower()) || 
                x.Apellidos.ToLower().Contains(name.ToLower()) || 
                x.Sexo.ToLower().Contains(name.ToLower()) ||
                x.Pais_Actual.ToLower().Contains(name.ToLower())).ToList();
            if (persona_service._personas.Count == 0)
            {
                message = "No existe el nombre en la lista";
            }
            else
            {
                message = "";
            }
            Icono = "oi oi-loop-circular";

        }
        else if (name == "")
        {
            Icono = "oi oi-magnifying-glass";
            message = "";
        }

    }

    //metodo que recibe un objeto tipo persona y lo borra de la base de datos llamando PersonaServices.
    private async Task remove(Persona persona)
    {
        await persona_service.RemovePersonaAsync(persona);
        persona_service._personas = await persona_service.GetPersonasAsync();
        persona_service._personas.Remove(admin);
    }


    /*metodo que recibe un entero cual me sirve para llenar los objetos del UsuarioServices,
    cambiar el booleano PersonaServices.update a true y llevar el usuario a la pagina agregar.*/
    private void update(int Id)
    {
        persona_service._persona = persona_service._personas.FirstOrDefault(x => x.PersonaId == Id);
        persona_service._datosCiviles = datosCiviles_service._datosCiviles.FirstOrDefault(x => x.PersonaId == Id);
        persona_service._datosEclesiasticos = datosEclesiasticos_service._datosEclesiasticos.FirstOrDefault(x => x.PersonaId == Id);
        persona_service._usuario = usuario_service._usuarios.FirstOrDefault(x => x.PersonaId == Id);
        persona_service._persona._Ocupaciones = ocupacion_service._ocupaciones.Where(x => x.PersonaId == Id).ToList();
        persona_service.update = true;
        nav.NavigateTo("/agregar");
    }


    /*metodo que recibe un entero cual me sirve para llenar los objetos del UsuarioServices
    y abrir el modal con los datos de la persona.*/
    private void showModal(int Id)
    {
        persona_service._persona = persona_service._personas.FirstOrDefault(x => x.PersonaId == Id);
        persona_service._datosCiviles = datosCiviles_service._datosCiviles.FirstOrDefault(x => x.PersonaId == Id);
        persona_service._datosEclesiasticos = datosEclesiasticos_service._datosEclesiasticos.FirstOrDefault(x => x.PersonaId == Id);
        persona_service._usuario = usuario_service._usuarios.FirstOrDefault(x => x.PersonaId == Id);
        persona_service._persona._Ocupaciones = ocupacion_service._ocupaciones.Where(x => x.PersonaId == Id).ToList();
        modal.Show<DetailModal>("Datos de " + persona_service._persona.Nombres);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService modal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UsuarioServices usuario_service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OcupacionServices ocupacion_service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DatosEclesiasticosServices datosEclesiasticos_service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DatosCivilesServices datosCiviles_service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PersonaServices persona_service { get; set; }
    }
}
#pragma warning restore 1591
