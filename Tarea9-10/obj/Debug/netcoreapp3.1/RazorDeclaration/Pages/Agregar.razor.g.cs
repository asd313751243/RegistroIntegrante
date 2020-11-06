#pragma checksum "e:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\Agregar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fada3212f4e4c5e17326a5e127d922f67db083a9"
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
#line 2 "e:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\Agregar.razor"
using Tarea9_10.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "e:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\Agregar.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "e:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\Agregar.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/agregar")]
    public partial class Agregar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 534 "e:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\Agregar.razor"
       
    IFileListEntry file;

    // son checks para mantener las ocupaciones que pertenece a la seleccionado al editar una persona
    private bool Pastor_check, Anciano_check, Diacono_check, Misionero_check, Escuela_Dominical_check,
                 Jovenes_check, Caballeros_check, Damas_check, Ninnos_check, Matrimonios_check, Grupo_check,
                 changepassword = false;
    private string message, confirmpassword, password_Now, password_New;
    private Ocupacion _ocupacion = new Ocupacion();

    // ejecutar primero al entrar a la pagina.
    protected override async Task OnInitializedAsync()
    {
        // ejecutar dependiendo persona_service.update cual cambia a true al darle editar en la pagina listar.
        if (persona_service.update)
        {
            if (persona_service._persona._Ocupaciones != null)
            {
                // un foreach para saber cuales son las ocupaciones de la persona para mantenerlo seleccionado.
                foreach (var i in persona_service._persona._Ocupaciones)
                {
                    if (i.Nombre == "Pastor")
                    {
                        Pastor_check = true;
                    }
                    else if (i.Nombre == "Anciano")
                    {
                        Anciano_check = true;
                    }
                    else if (i.Nombre == "Diacono")
                    {
                        Diacono_check = true;
                    }
                    else if (i.Nombre == "Misionero")
                    {
                        Misionero_check = true;
                    }
                    else if (i.Nombre == "Lider Escuela Dominical")
                    {
                        Escuela_Dominical_check = true;
                    }
                    else if (i.Nombre == "Lider Minist. de Jóvenes")
                    {
                        Jovenes_check = true;
                    }
                    else if (i.Nombre == "Lider Minist. de Caballeros")
                    {
                        Caballeros_check = true;
                    }
                    else if (i.Nombre == "Lider Minist. de Damas")
                    {
                        Damas_check = true;
                    }
                    else if (i.Nombre == "Lider Minist. de Níños")
                    {
                        Ninnos_check = true;
                    }
                    else if (i.Nombre == "Lider Minist. de Matrimonios")
                    {
                        Matrimonios_check = true;
                    }
                    else if (i.Nombre == "Lider de grupo pequeño (Célula)")
                    {
                        Grupo_check = true;
                    }
                }
            }
        }
        else if (!persona_service.update)
        {
            //limpiar todos los campos.
            persona_service._persona = new Persona();
            persona_service._datosCiviles = new DatosCiviles();
            persona_service._datosEclesiasticos = new DatosEclesiasticos();
            persona_service._usuario = new Usuario();
        }
        // consumir la api para llenar la lista persona_service.countries cual me sirve para llenar el dropdown list de los paises.
        persona_service._countries = await Http.GetJsonAsync<List<Country>>("https://restcountries.eu/rest/v2/all");

    }

    // metodo que recibe un array tipo IFileListEntry para poder guardarlo en la base de datos en tipo byte[] 
    private async Task HandleFileSelection(IFileListEntry[] files)
    {
        if (files.Count() > 0)
        {
            file = files.FirstOrDefault();
            using (var ms = new MemoryStream())
            {
                await file.Data.CopyToAsync(ms);
                persona_service._persona.Foto = ms.ToArray();
            }
        }
    }

    // metodo que recibe el string, lo convierte a byte y luego lo retorna.
    public byte[] getImage(string sBase64String)
    {
        byte[] bytes = null;
        if (sBase64String != null)
        {
            bytes = Convert.FromBase64String(sBase64String);
        }

        return bytes;
    }

    // metodo para cambiar el changepassword de false a true.
    private void CambiarClave()
    {
        changepassword = true;
    }

    // el metodo que se ejecuta al darle cualquiera de los botones del formulario (AgregarPersona o ActualizarPersona).
    private async Task Ejecutar()
    {
        // ejecuta dependiendo el booleano de persona_service.update cual cambia a true al darle editar en la pagina listar.
        if (persona_service.update)
        {
            // si changepassword es igual a true me valida los campos de contraseña actual para ver si el usaurio conoce la contraseña actual de la persona.
            if (changepassword)
            {
                if (password_Now != persona_service._usuario.Clave)
                {
                    message = "Contraseña actual incorrecta";
                }
                else if (password_New != confirmpassword)
                {
                    message = "Favor de revisar la confirmacion de contraseña";
                }
                else
                {
                    // juntar todos los datos y actualizarlo en la base de datos.
                    persona_service._persona.DatosCiviles = persona_service._datosCiviles;
                    persona_service._persona.DatosEclesiasticos = persona_service._datosEclesiasticos;
                    persona_service._persona.Usuarios = persona_service._usuario;
                    message = await persona_service.UpdatePersonaAsync(persona_service._persona);
                    confirmpassword = "";
                    persona_service.update = false;
                }
            }
            else
            {
                // juntar todos los datos y actualizarlo en la base de datos.
                persona_service._persona.DatosCiviles = persona_service._datosCiviles;
                persona_service._persona.DatosEclesiasticos = persona_service._datosEclesiasticos;
                persona_service._persona.Usuarios = persona_service._usuario;
                message = await persona_service.UpdatePersonaAsync(persona_service._persona);
                persona_service.update = false;
            }
        }
        else if (!persona_service.update)
        {
            // llenar la lista usuario_service.usuarios.
            usuario_service._usuarios = await usuario_service.GetUsuariosAsync();

            // filtrar un usuario con el nombre de persona_service.usuario.Nombre_Usuario.
            Usuario usuarioExist = usuario_service._usuarios.FirstOrDefault(x => x.Nombre_Usuario == persona_service._usuario.Nombre_Usuario);
            
            // validar si el usuario seleccionó todos los grupos de input tipo radio y selects.
            if (persona_service._datosCiviles.Tienes_Hijos == "No")
            {
                persona_service._datosCiviles.Cantidad_Hijos = 0;
            }
            if (persona_service._datosEclesiasticos.Ha_Disiciplinado == "No")
            {
                persona_service._datosEclesiasticos.Cantidad_Disciplinado = 0;
            }
            if (persona_service._persona.Sexo == null)
            {
                message = "Favor de seleccionar un sexo";
            }
            else if (persona_service._persona.Documento_Identidad == null)
            {
                message = "Favor de seleccionar un tipo de documento";
            }
            else if (persona_service._datosCiviles.Tienes_Hijos == null)
            {
                message = "Favor de seleccionar si tienes hijos o no";
            }
            else if (persona_service._datosCiviles.Suspension_institucion == null)
            {
                message = "Favor de seleccionar si ha sido expulsado o no";
            }
            else if (persona_service._datosEclesiasticos.Denominacion == null)
            {
                message = "Favor de seleccionar la denominacion que perteneces";
            }
            else if (persona_service._datosEclesiasticos.Ha_Disiciplinado == null)
            {
                message = "Favor de seleccionar si ha sido disciplinado o no";
            }
            else if (persona_service._datosEclesiasticos.Estas_Consciente == null)
            {
                message = "Favor de seleccionar si cuenta con el respaldo de sus autoridades eclesiásticas para realizar estos estudios";
            }
            else if (persona_service._persona.Pais_Actual == null)
            {
                message = "Favor de seleccionar el País de residencia actual";
            }
            else if (persona_service._persona.Pais_Nacimiento == null)
            {
                message = "Favor de seleccionar el País de nacimiento";
            }
            else if (persona_service._datosCiviles.Nivel_Estudio == null)
            {
                message = "Favor de seleccionar el Nivel de estudio";
            }
            else if (persona_service._datosEclesiasticos.Estas_Consciente == "No")
            {
                message = "No puedes terminar si no cuenta con el respaldo de sus autoridades eclesiásticas para realizar estos estudios";
            }
            else if (persona_service._usuario.Clave != confirmpassword)
            {
                message = "Favor de revisar la confirmacion de contraseña";
            }
            else if (usuarioExist != null)
            {
                // validar si el nombre de usuario esta en uso (si el usuarioExist no es igual a nulo significa que ya existe uno en la base de datos).
                message = "Nombre de usuario ya esta en uso";
            }
            else
            {
                // juntar todos y agregarlo en la base de datos
                persona_service._persona.DatosCiviles = persona_service._datosCiviles;
                persona_service._persona.DatosEclesiasticos = persona_service._datosEclesiasticos;
                persona_service._persona.Usuarios = persona_service._usuario;
                message = await persona_service.AddPersonaAsync(persona_service._persona);
                datosEclesiasticos_service._datosEclesiasticos = await datosEclesiasticos_service.GetDatosEclesiasticosAsync();
                confirmpassword = "";
            }
        }

    }

    // un metodo que recibe un string (la ocupacion), y validar el check, si el check es true remueve la ocupacion, si es false agrega la ocupacion.
    private void CheckChange(string ocupacion)
    {
        _ocupacion = new Ocupacion();
        switch (ocupacion)
        {
            case "Pastor":
                if (Pastor_check)
                {
                    // filtrar ocupacion con el string recibido y luego removerlo de la lista y cambiar el check a false.
                    _ocupacion = persona_service._persona._Ocupaciones.FirstOrDefault(x => x.Nombre == ocupacion);
                    persona_service._persona._Ocupaciones.Remove(_ocupacion);
                    Pastor_check = false;
                }
                else if (!Pastor_check)
                {
                    // agregar la ocupacion a la lista y cambiar el check a true.
                    _ocupacion.Nombre = ocupacion;
                    persona_service._persona._Ocupaciones.Add(_ocupacion);
                    Pastor_check = true;
                }
                break;
            case "Anciano":
                if (Anciano_check)
                {
                    _ocupacion = persona_service._persona._Ocupaciones.FirstOrDefault(x => x.Nombre == ocupacion);
                    persona_service._persona._Ocupaciones.Remove(_ocupacion);
                    Anciano_check = false;
                }
                else if (!Anciano_check)
                {
                    _ocupacion.Nombre = ocupacion;
                    persona_service._persona._Ocupaciones.Add(_ocupacion);
                    Anciano_check = true;
                }
                break;
            case "Diacono":
                if (Diacono_check)
                {
                    _ocupacion = persona_service._persona._Ocupaciones.FirstOrDefault(x => x.Nombre == ocupacion);
                    persona_service._persona._Ocupaciones.Remove(_ocupacion);
                    Diacono_check = false;
                }
                else if (!Diacono_check)
                {
                    _ocupacion.Nombre = ocupacion;
                    persona_service._persona._Ocupaciones.Add(_ocupacion);
                    Diacono_check = true;
                }
                break;
            case "Misionero":
                if (Misionero_check)
                {
                    _ocupacion = persona_service._persona._Ocupaciones.FirstOrDefault(x => x.Nombre == ocupacion);
                    persona_service._persona._Ocupaciones.Remove(_ocupacion);
                    Misionero_check = false;
                }
                else if (!Misionero_check)
                {
                    _ocupacion.Nombre = ocupacion;
                    persona_service._persona._Ocupaciones.Add(_ocupacion);
                    Misionero_check = true;
                }
                break;
            case "Lider Escuela Dominical":
                if (Escuela_Dominical_check)
                {
                    _ocupacion = persona_service._persona._Ocupaciones.FirstOrDefault(x => x.Nombre == ocupacion);
                    persona_service._persona._Ocupaciones.Remove(_ocupacion);
                    Escuela_Dominical_check = false;
                }
                else if (!Escuela_Dominical_check)
                {
                    _ocupacion.Nombre = ocupacion;
                    persona_service._persona._Ocupaciones.Add(_ocupacion);
                    Escuela_Dominical_check = true;
                }
                break;
            case "Lider Minist. de Jóvenes":
                if (Jovenes_check)
                {
                    _ocupacion = persona_service._persona._Ocupaciones.FirstOrDefault(x => x.Nombre == ocupacion);
                    persona_service._persona._Ocupaciones.Remove(_ocupacion);
                    Jovenes_check = false;
                }
                else if (!Jovenes_check)
                {
                    _ocupacion.Nombre = ocupacion;
                    persona_service._persona._Ocupaciones.Add(_ocupacion);
                    Jovenes_check = true;
                }
                break;
            case "Lider Minist. de Caballeros":
                if (Caballeros_check)
                {
                    _ocupacion = persona_service._persona._Ocupaciones.FirstOrDefault(x => x.Nombre == ocupacion);
                    persona_service._persona._Ocupaciones.Remove(_ocupacion);
                    Caballeros_check = false;
                }
                else if (!Caballeros_check)
                {
                    _ocupacion.Nombre = ocupacion;
                    persona_service._persona._Ocupaciones.Add(_ocupacion);
                    Caballeros_check = true;
                }
                break;
            case "Lider Minist. de Damas":
                if (Damas_check)
                {
                    _ocupacion = persona_service._persona._Ocupaciones.FirstOrDefault(x => x.Nombre == ocupacion);
                    persona_service._persona._Ocupaciones.Remove(_ocupacion);
                    Damas_check = false;
                }
                else if (!Damas_check)
                {
                    _ocupacion.Nombre = ocupacion;
                    persona_service._persona._Ocupaciones.Add(_ocupacion);
                    Damas_check = true;
                }
                break;
            case "Lider Minist. de Níños":
                if (Ninnos_check)
                {
                    _ocupacion = persona_service._persona._Ocupaciones.FirstOrDefault(x => x.Nombre == ocupacion);
                    persona_service._persona._Ocupaciones.Remove(_ocupacion);
                    Ninnos_check = false;
                }
                else if (!Ninnos_check)
                {
                    _ocupacion.Nombre = ocupacion;
                    persona_service._persona._Ocupaciones.Add(_ocupacion);
                    Ninnos_check = true;
                }
                break;
            case "Lider Minist. de Matrimonios":
                if (Matrimonios_check)
                {
                    _ocupacion = persona_service._persona._Ocupaciones.FirstOrDefault(x => x.Nombre == ocupacion);
                    persona_service._persona._Ocupaciones.Remove(_ocupacion);
                    Matrimonios_check = false;
                }
                else if (!Matrimonios_check)
                {
                    _ocupacion.Nombre = ocupacion;
                    persona_service._persona._Ocupaciones.Add(_ocupacion);
                    Matrimonios_check = true;
                }
                break;
            case "Lider de grupo pequeño (Célula)":
                if (Grupo_check)
                {
                    _ocupacion = persona_service._persona._Ocupaciones.FirstOrDefault(x => x.Nombre == ocupacion);
                    persona_service._persona._Ocupaciones.Remove(_ocupacion);
                    Grupo_check = false;
                }
                else if (!Grupo_check)
                {
                    _ocupacion.Nombre = ocupacion;
                    persona_service._persona._Ocupaciones.Add(_ocupacion);
                    Grupo_check = true;
                }
                break;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UsuarioServices usuario_service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DatosEclesiasticosServices datosEclesiasticos_service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PersonaServices persona_service { get; set; }
    }
}
#pragma warning restore 1591
