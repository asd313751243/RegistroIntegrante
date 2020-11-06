using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea9_10.Data
{
    public class UsuarioServices
    {
        private AppDbContext dbContext;
        public UsuarioServices(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // lista para guardar todos los datos de la tabla Usuarios.
        public List<Usuario> _usuarios = new List<Usuario>();
        // modelo para guardar un objeto persona cual hizo el login o objeto persona cual el usuario quiere editar. 
        public Usuario _usuario = new Usuario();
        // booleano para no dejar acceder a las otras paginas los usuarios que no hicieron el login.
        public bool state = false;
        // booleano para no dejar acceder los usuarios que no tienen una ocupacion como pastor o anciano.
        public bool permiso = false;


        // metodo para llenar la lista _usuarios.
        //get
        public async Task<List<Usuario>> GetUsuariosAsync()
        {
            return await dbContext.Usuarios.ToListAsync();
        }


        // metodo que recibe un objeto persona (_usuario), y hace el update en la base de datos, retorna un string.
        public async Task<string> UpdateUsuarioAsync(Usuario usuario)
        {
            try
            {
                dbContext.Usuarios.Update(usuario);
                await dbContext.SaveChangesAsync();
                return "Contraseña cambiado exitosamente";
            }
            catch
            {
                return "No pudo cambiar la contraseña";
            }
        }

        // metodo recibe un objeto persona (_usuario), filtra los datos con la lista _usuarios con el nombre usuario y la clave.
        public string ValidarUsuario(Usuario _user)
        {
            _usuario = dbContext.Usuarios.FirstOrDefault(p => p.Nombre_Usuario + p.Clave == _user.Nombre_Usuario + _user.Clave);
            // si _usuario no es nulo quiere decir que pudo encontrar una persona en la base de datos, si es nulo quiere decir que los datos son incorrectos.
            if (_usuario != null)
            {
                state = true;
                return "Datos Correcto";
            }
            else
            {
                state = false;
                return "Datos Incorreto";
            }

        }
    }
}
