using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea9_10.Data
{
    public class PersonaServices
    {
        private AppDbContext dbContext;
        public PersonaServices(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // objetos utilizados para guardar los datos para agregar en la base de datos, actualizar en la base de datos y eliminar en la base de datos.
        public Persona _persona = new Persona();
        public DatosCiviles _datosCiviles = new DatosCiviles();
        public DatosEclesiasticos _datosEclesiasticos = new DatosEclesiasticos();
        public Usuario _usuario = new Usuario();

        // lista para filtrar personas en la pagina listar.
        public List<Persona> _personas = new List<Persona>();
        // lista para guardar todos los nombres de paises de la api.
        public List<Country> _countries = new List<Country>();

        // booleano para decir la pagina agregar si va a agregar persona o actualizar persona.
        public bool update = false;


        // metodo para llenar la lista _personas.
        //get
        public async Task<List<Persona>> GetPersonasAsync()
        {
            return await dbContext.Personas.ToListAsync();
        }

        // metodo que recibe un objeto de tipo persona (_persona), lo agrega en la base de datos y retorna un string.
        //add
        public async Task<String> AddPersonaAsync (Persona persona)
        {
            try
            {
                dbContext.Personas.Add(persona);
                await dbContext.SaveChangesAsync();
                _persona = new Persona();
                _datosCiviles = new DatosCiviles();
                _datosEclesiasticos = new DatosEclesiasticos();
                _usuario = new Usuario();
                return "Persona Agregado exitosamente";
            }
            catch
            {
                return "Se produjo un error";
            }

        }


        // metodo que recibe un objeto de tipo persona (_persona), lo actualiza en la base de datos y retorna un string.
        public async Task<String> UpdatePersonaAsync (Persona persona)
        {
            try
            {
                var personaExist = dbContext.Personas.FirstOrDefault(p => p.PersonaId == persona.PersonaId);
                if(personaExist!= null)
                {
                    dbContext.Personas.Update(persona);
                    await dbContext.SaveChangesAsync();
                    _persona = new Persona();
                    _datosCiviles = new DatosCiviles();
                    _datosEclesiasticos = new DatosEclesiasticos();
                    _usuario = new Usuario();
                    return "Persona Actualizado exitosamente";
                }
                else
                {
                    return "Persona no existe";
                }

            }
            catch
            {
                return "Se produjo un error";
            }


        }

        // metodo que recibe un objeto de tipo persona (_persona), lo actualiza en la base de datos y retorna un string.
        public async Task<Persona> RemovePersonaAsync (Persona persona)
        {
            try
            {
                dbContext.Personas.Remove(persona);
                await dbContext.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
            return persona;
        }
    }
}
