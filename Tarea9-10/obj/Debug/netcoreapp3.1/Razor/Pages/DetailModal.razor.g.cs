#pragma checksum "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86815b0bbcc58e4cad56c3aa99bd8e470a825071"
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
#line 3 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
using Tarea9_10.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/detailmodal")]
    public partial class DetailModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "pre-scrollable");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card");
            __builder.AddAttribute(5, "style", "width: 100%");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-body");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, "<h4 class=\"card-title text-center\"><b><u>DATOS PERSONALES</u></b></h4>\r\n            ");
            __builder.OpenElement(11, "p");
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 12 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                 if (persona_service._persona.Foto != null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "                    <br>\r\n                    \r\n                    ");
            __builder.OpenElement(14, "img");
            __builder.AddAttribute(15, "src", 
#nullable restore
#line 17 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                              string.Format("data:image/jpg;base64, {0}", Convert.ToBase64String(getImage(Convert.ToBase64String(persona_service._persona.Foto))))

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "class", "rounded float-right");
            __builder.AddAttribute(17, "width", "125");
            __builder.AddAttribute(18, "height", "130");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    <br>\r\n");
#nullable restore
#line 19 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(20, "                <br>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            <br>\r\n            ");
            __builder.AddMarkupContent(22, "<h5 class=\"card-subtitle mb-2 text-muted\">Sexo:</h5>\r\n            ");
            __builder.OpenElement(23, "p");
            __builder.AddAttribute(24, "class", "card-text");
            __builder.AddContent(25, 
#nullable restore
#line 24 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._persona.Sexo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.AddMarkupContent(27, "<h5 class=\"card-subtitle mb-2 text-muted\">Apellidos:</h5>\r\n            ");
            __builder.OpenElement(28, "p");
            __builder.AddAttribute(29, "class", "card-text");
            __builder.AddContent(30, 
#nullable restore
#line 26 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._persona.Apellidos

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.AddMarkupContent(32, "<h5 class=\"card-subtitle mb-2 text-muted\">Nombres:</h5>\r\n            ");
            __builder.OpenElement(33, "p");
            __builder.AddAttribute(34, "class", "card-text");
            __builder.AddContent(35, 
#nullable restore
#line 28 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._persona.Nombres

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.AddMarkupContent(37, "<h5 class=\"card-subtitle mb-2 text-muted\">Fecha de Nacimiento:</h5>\r\n            ");
            __builder.OpenElement(38, "p");
            __builder.AddAttribute(39, "class", "card-text");
            __builder.AddContent(40, 
#nullable restore
#line 30 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._persona.Fecha_Nacimiento

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.AddMarkupContent(42, "<h5 class=\"card-subtitle mb-2 text-muted\">País de nacimiento:</h5>\r\n            ");
            __builder.OpenElement(43, "p");
            __builder.AddAttribute(44, "class", "card-text");
            __builder.AddContent(45, 
#nullable restore
#line 32 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._persona.Pais_Nacimiento

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.AddMarkupContent(47, "<h5 class=\"card-subtitle mb-2 text-muted\">Ciudad de nacimiento:</h5>\r\n            ");
            __builder.OpenElement(48, "p");
            __builder.AddAttribute(49, "class", "card-text");
            __builder.AddContent(50, 
#nullable restore
#line 34 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._persona.Ciudad_Nacimiento

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.AddMarkupContent(52, "<h5 class=\"card-subtitle mb-2 text-muted\">País de residencia actual:</h5>\r\n            ");
            __builder.OpenElement(53, "p");
            __builder.AddAttribute(54, "class", "card-text");
            __builder.AddContent(55, 
#nullable restore
#line 36 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._persona.Pais_Actual

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.AddMarkupContent(57, "<h5 class=\"card-subtitle mb-2 text-muted\">Ciudad de residencia actual:</h5>\r\n            ");
            __builder.OpenElement(58, "p");
            __builder.AddAttribute(59, "class", "card-text");
            __builder.AddContent(60, 
#nullable restore
#line 38 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._persona.Ciudad_Actual

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n            ");
            __builder.AddMarkupContent(62, "<h5 class=\"card-subtitle mb-2 text-muted\">Dirección (Provincia / sector / calle / No. de vivienda)</h5>\r\n            ");
            __builder.OpenElement(63, "p");
            __builder.AddAttribute(64, "class", "card-text");
            __builder.AddContent(65, 
#nullable restore
#line 40 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._persona.Direccion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n            ");
            __builder.AddMarkupContent(67, "<h5 class=\"card-subtitle mb-2 text-muted\">Teléfono:</h5>\r\n            ");
            __builder.OpenElement(68, "p");
            __builder.AddAttribute(69, "class", "card-text");
            __builder.AddContent(70, 
#nullable restore
#line 42 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._persona.Telefono

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n            ");
            __builder.AddMarkupContent(72, "<h5 class=\"card-subtitle mb-2 text-muted\">Celular:</h5>\r\n            ");
            __builder.OpenElement(73, "p");
            __builder.AddAttribute(74, "class", "card-text");
            __builder.AddContent(75, 
#nullable restore
#line 44 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._persona.Celular

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n            ");
            __builder.AddMarkupContent(77, "<h5 class=\"card-subtitle mb-2 text-muted\">Correo elctrónico:</h5>\r\n            ");
            __builder.OpenElement(78, "p");
            __builder.AddAttribute(79, "class", "card-text");
            __builder.AddContent(80, 
#nullable restore
#line 46 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._persona.Correo_Electronico

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n            ");
            __builder.AddMarkupContent(82, "<h5 class=\"card-subtitle mb-2 text-muted\">Tipo de Documento de identidad:</h5>\r\n            ");
            __builder.OpenElement(83, "p");
            __builder.AddAttribute(84, "class", "card-text");
            __builder.AddContent(85, 
#nullable restore
#line 48 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._persona.Documento_Identidad

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n            ");
            __builder.AddMarkupContent(87, "<h5 class=\"card-subtitle mb-2 text-muted\">Documento de identidad:</h5>\r\n            ");
            __builder.OpenElement(88, "p");
            __builder.AddAttribute(89, "class", "card-text");
            __builder.AddContent(90, 
#nullable restore
#line 50 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._persona.Numero_Identidad

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n\r\n    <br>\r\n\r\n    ");
            __builder.OpenElement(94, "div");
            __builder.AddAttribute(95, "class", "card");
            __builder.AddAttribute(96, "style", "width: 100%");
            __builder.AddMarkupContent(97, "\r\n        ");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "class", "card-body");
            __builder.AddMarkupContent(100, "\r\n            ");
            __builder.AddMarkupContent(101, "<h4 class=\"card-title text-center\"><b><u>DATOS FAMILIARES</u></b></h4>\r\n            ");
            __builder.AddMarkupContent(102, "<h5 class=\"card-subtitle mb-2 text-muted\">Estado civil:</h5>\r\n            ");
            __builder.OpenElement(103, "p");
            __builder.AddAttribute(104, "class", "card-text");
            __builder.AddContent(105, 
#nullable restore
#line 60 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._datosCiviles.Estado_Civil

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n            ");
            __builder.AddMarkupContent(107, "<h5 class=\"card-subtitle mb-2 text-muted\">Nombre esposo(a):</h5>\r\n            ");
            __builder.OpenElement(108, "p");
            __builder.AddAttribute(109, "class", "card-text");
            __builder.AddContent(110, 
#nullable restore
#line 62 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._datosCiviles.Nombre_Pareja

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n            ");
            __builder.AddMarkupContent(112, "<h5 class=\"card-subtitle mb-2 text-muted\">Hijos:</h5>\r\n            ");
            __builder.OpenElement(113, "p");
            __builder.AddAttribute(114, "class", "card-text");
            __builder.AddContent(115, 
#nullable restore
#line 64 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._datosCiviles.Tienes_Hijos

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n            ");
            __builder.AddMarkupContent(117, "<h5 class=\"card-subtitle mb-2 text-muted\">No. Hijos:</h5>\r\n            ");
            __builder.OpenElement(118, "p");
            __builder.AddAttribute(119, "class", "card-text");
            __builder.AddContent(120, 
#nullable restore
#line 66 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._datosCiviles.Cantidad_Hijos

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n\r\n    <br>\r\n\r\n    ");
            __builder.OpenElement(124, "div");
            __builder.AddAttribute(125, "class", "card");
            __builder.AddAttribute(126, "style", "width: 100%");
            __builder.AddMarkupContent(127, "\r\n        ");
            __builder.OpenElement(128, "div");
            __builder.AddAttribute(129, "class", "card-body");
            __builder.AddMarkupContent(130, "\r\n            ");
            __builder.AddMarkupContent(131, "<h4 class=\"card-title text-center\"><b><u>DATOS LABORALES</u></b></h4>\r\n            ");
            __builder.AddMarkupContent(132, "<h5 class=\"card-subtitle mb-2 text-muted\">Profesión:</h5>\r\n            ");
            __builder.OpenElement(133, "p");
            __builder.AddAttribute(134, "class", "card-text");
            __builder.AddContent(135, 
#nullable restore
#line 76 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._datosCiviles.Profesion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n            ");
            __builder.AddMarkupContent(137, "<h5 class=\"card-subtitle mb-2 text-muted\">Nombre de la empresa o negocio:</h5>\r\n            ");
            __builder.OpenElement(138, "p");
            __builder.AddAttribute(139, "class", "card-text");
            __builder.AddContent(140, 
#nullable restore
#line 78 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._datosCiviles.Nombre_Empresa

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n            ");
            __builder.AddMarkupContent(142, "<h5 class=\"card-subtitle mb-2 text-muted\">Ocupación actual:</h5>\r\n            ");
            __builder.OpenElement(143, "p");
            __builder.AddAttribute(144, "class", "card-text");
            __builder.AddContent(145, 
#nullable restore
#line 80 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._datosCiviles.Ocupacion_Actual

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n            ");
            __builder.AddMarkupContent(147, "<h5 class=\"card-subtitle mb-2 text-muted\">Teléfono:</h5>\r\n            ");
            __builder.OpenElement(148, "p");
            __builder.AddAttribute(149, "class", "card-text");
            __builder.AddContent(150, 
#nullable restore
#line 82 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._datosCiviles.Telefono_Trabajo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n\r\n    <br>\r\n\r\n    ");
            __builder.OpenElement(154, "div");
            __builder.AddAttribute(155, "class", "card");
            __builder.AddAttribute(156, "style", "width: 100%");
            __builder.AddMarkupContent(157, "\r\n        ");
            __builder.OpenElement(158, "div");
            __builder.AddAttribute(159, "class", "card-body");
            __builder.AddMarkupContent(160, "\r\n            ");
            __builder.AddMarkupContent(161, "<h4 class=\"card-title text-center\"><b><u>DATOS ECLESIASTICOS</u></b></h4>\r\n            ");
            __builder.AddMarkupContent(162, "<h5 class=\"card-subtitle mb-2 text-muted\">Fecha de conversión:</h5>\r\n            ");
            __builder.OpenElement(163, "p");
            __builder.AddAttribute(164, "class", "card-text");
            __builder.AddContent(165, 
#nullable restore
#line 92 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._datosEclesiasticos.Fecha_Conversion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n            ");
            __builder.AddMarkupContent(167, "<h5 class=\"card-subtitle mb-2 text-muted\">Fecha de bautismo:</h5>\r\n            ");
            __builder.OpenElement(168, "p");
            __builder.AddAttribute(169, "class", "card-text");
            __builder.AddContent(170, 
#nullable restore
#line 94 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._datosEclesiasticos.Fecha_Bautismo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\r\n            ");
            __builder.AddMarkupContent(172, "<h5 class=\"card-subtitle mb-2 text-muted\">Fecha en que fue aceptado(a) formalmente como miembro de la Iglesia:</h5>\r\n            ");
            __builder.OpenElement(173, "p");
            __builder.AddAttribute(174, "class", "card-text");
            __builder.AddContent(175, 
#nullable restore
#line 96 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._datosEclesiasticos.Fecha_Aceptado

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(176, "\r\n            ");
            __builder.AddMarkupContent(177, "<h5 class=\"card-subtitle mb-2 text-muted\">Denominación a la que pertenece:</h5>\r\n            ");
            __builder.OpenElement(178, "p");
            __builder.AddAttribute(179, "class", "card-text");
            __builder.AddContent(180, 
#nullable restore
#line 98 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._datosEclesiasticos.Denominacion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(181, "\r\n            ");
            __builder.AddMarkupContent(182, "<h5 class=\"card-subtitle mb-2 text-muted\">Nombre de la Iglesia a la que asiste actualmente</h5>\r\n            ");
            __builder.OpenElement(183, "p");
            __builder.AddAttribute(184, "class", "card-text");
            __builder.AddContent(185, 
#nullable restore
#line 100 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._datosEclesiasticos.Iglesia_Actual

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(186, "\r\n            ");
            __builder.AddMarkupContent(187, "<h5 class=\"card-subtitle mb-2 text-muted\">Si asiste a esta iglesia por un tiempo menor a un año, ¿dónde se congregaba antes?</h5>\r\n            ");
            __builder.OpenElement(188, "p");
            __builder.AddAttribute(189, "class", "card-text");
            __builder.AddContent(190, 
#nullable restore
#line 102 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._datosEclesiasticos.Iglesia_Antes

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(191, "\r\n            ");
            __builder.AddMarkupContent(192, "<h5 class=\"card-subtitle mb-2 text-muted\">Nombre del pastor de su iglesia actual</h5>\r\n            ");
            __builder.OpenElement(193, "p");
            __builder.AddAttribute(194, "class", "card-text");
            __builder.AddContent(195, 
#nullable restore
#line 104 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._datosEclesiasticos.Nombre_Pastor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(196, "\r\n            ");
            __builder.AddMarkupContent(197, "<h5 class=\"card-subtitle mb-2 text-muted\">¿Ha sido disciplinado alguna vez?</h5>\r\n            ");
            __builder.OpenElement(198, "p");
            __builder.AddAttribute(199, "class", "card-text");
            __builder.AddContent(200, 
#nullable restore
#line 106 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._datosEclesiasticos.Ha_Disiciplinado

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(201, "\r\n            ");
            __builder.AddMarkupContent(202, "<h5 class=\"card-subtitle mb-2 text-muted\">¿cuántas veces?</h5>\r\n            ");
            __builder.OpenElement(203, "p");
            __builder.AddAttribute(204, "class", "card-text");
            __builder.AddContent(205, 
#nullable restore
#line 108 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._datosEclesiasticos.Cantidad_Disciplinado

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(206, "\r\n            ");
            __builder.AddMarkupContent(207, "<h5 class=\"card-subtitle mb-2 text-muted\">Causas:</h5>\r\n            ");
            __builder.OpenElement(208, "p");
            __builder.AddAttribute(209, "class", "card-text");
            __builder.AddContent(210, 
#nullable restore
#line 110 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._datosEclesiasticos.Causas_Disciplinado

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(211, "\r\n            ");
            __builder.AddMarkupContent(212, "<h5 class=\"card-subtitle mb-2 text-muted\">Funciones ocupado en la actualidad:</h5>\r\n            ");
            __builder.OpenElement(213, "p");
            __builder.AddMarkupContent(214, "\r\n                \r\n");
#nullable restore
#line 114 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                 foreach (var i in persona_service._persona._Ocupaciones)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(215, "                    ");
            __builder.OpenElement(216, "li");
            __builder.AddAttribute(217, "class", "card-text");
            __builder.AddContent(218, 
#nullable restore
#line 116 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                           i.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(219, "\r\n");
#nullable restore
#line 117 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(220, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(221, "\r\n            ");
            __builder.AddMarkupContent(222, "<h5 class=\"card-subtitle mb-2 text-muted\">¿Cuáles son los ministerios en los que ha servido?</h5>\r\n            ");
            __builder.OpenElement(223, "p");
            __builder.AddAttribute(224, "class", "card-text");
            __builder.AddContent(225, 
#nullable restore
#line 120 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._datosEclesiasticos.Ministerios_Servido

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(226, "\r\n            ");
            __builder.AddMarkupContent(227, "<h5 class=\"card-subtitle mb-2 text-muted\">¿En cuál de estos ministerios considera que tuvo mayor fruto?</h5>\r\n            ");
            __builder.OpenElement(228, "p");
            __builder.AddAttribute(229, "class", "card-text");
            __builder.AddContent(230, 
#nullable restore
#line 122 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._datosEclesiasticos.Ministerio_Fruto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(231, "\r\n            ");
            __builder.AddMarkupContent(232, "<h5 class=\"card-subtitle mb-2 text-muted\">¿Por qué?</h5>\r\n            ");
            __builder.OpenElement(233, "p");
            __builder.AddAttribute(234, "class", "card-text");
            __builder.AddContent(235, 
#nullable restore
#line 124 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._datosEclesiasticos.Razon_Fruto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(236, "\r\n            ");
            __builder.AddMarkupContent(237, "<h5 class=\"card-subtitle mb-2 text-muted\">Considerando sus dones y talentos, ¿a qué ministerio cree usted que Dios lo(a) está llamando?</h5>\r\n            ");
            __builder.OpenElement(238, "p");
            __builder.AddAttribute(239, "class", "card-text");
            __builder.AddContent(240, 
#nullable restore
#line 126 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._datosEclesiasticos.Ministerio_Llamando

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(241, "\r\n            ");
            __builder.AddMarkupContent(242, "<h5 class=\"card-subtitle mb-2 text-muted\">¿Qué metas tiene para su vida?</h5>\r\n            ");
            __builder.OpenElement(243, "p");
            __builder.AddAttribute(244, "class", "card-text");
            __builder.AddContent(245, 
#nullable restore
#line 128 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._datosEclesiasticos.Meta

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(246, "\r\n            ");
            __builder.AddMarkupContent(247, "<h5 class=\"card-subtitle mb-2 text-muted\">¿Cuenta con el respaldo de sus autoridades eclesiásticas para realizar estos estudios?</h5>\r\n            ");
            __builder.OpenElement(248, "p");
            __builder.AddAttribute(249, "class", "card-text");
            __builder.AddContent(250, 
#nullable restore
#line 130 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._datosEclesiasticos.Estas_Consciente

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(251, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(252, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(253, "\r\n\r\n    <br>\r\n\r\n    ");
            __builder.OpenElement(254, "div");
            __builder.AddAttribute(255, "class", "card");
            __builder.AddAttribute(256, "style", "width: 100%");
            __builder.AddMarkupContent(257, "\r\n        ");
            __builder.OpenElement(258, "div");
            __builder.AddAttribute(259, "class", "card-body");
            __builder.AddMarkupContent(260, "\r\n            ");
            __builder.AddMarkupContent(261, "<h4 class=\"card-title text-center\"><b><u>DATOS\tACADÉMICOS</u></b></h4>\r\n            ");
            __builder.AddMarkupContent(262, "<h5 class=\"card-subtitle mb-2 text-muted\">Nivel de estudio:</h5>\r\n            ");
            __builder.OpenElement(263, "p");
            __builder.AddAttribute(264, "class", "card-text");
            __builder.AddContent(265, 
#nullable restore
#line 140 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._datosCiviles.Nivel_Estudio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(266, "\r\n            ");
            __builder.AddMarkupContent(267, "<h5 class=\"card-subtitle mb-2 text-muted\">¿Alguna vez ha sido expulsado o suspendido de alguna institución?</h5>\r\n            ");
            __builder.OpenElement(268, "p");
            __builder.AddAttribute(269, "class", "card-text");
            __builder.AddContent(270, 
#nullable restore
#line 142 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._datosCiviles.Suspension_institucion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(271, "\r\n            ");
            __builder.AddMarkupContent(272, "<h5 class=\"card-subtitle mb-2 text-muted\">En caso afirmativo, ¿por qué razón?</h5>\r\n            ");
            __builder.OpenElement(273, "p");
            __builder.AddAttribute(274, "class", "card-text");
            __builder.AddContent(275, 
#nullable restore
#line 144 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
                                  persona_service._datosCiviles.Razon_Suspension

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(276, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(277, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(278, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 149 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea9-10\Tarea9-10\Pages\DetailModal.razor"
       

    // el metodo que recibe el string, lo convierte a byte y luego lo retorna.
    public byte[] getImage(string sBase64String)
    {
        byte[] bytes = null;
        if (sBase64String != null)
        {
            bytes = Convert.FromBase64String(sBase64String);
        }

        return bytes;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PersonaServices persona_service { get; set; }
    }
}
#pragma warning restore 1591
