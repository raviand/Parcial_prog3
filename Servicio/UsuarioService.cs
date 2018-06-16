using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
namespace Servicio
{
    public class UsuarioService
    {
        //validar login
        SqlDataReader lector;
        List<Usuario> usuarios;
        AccesoDatos ad = new AccesoDatos();

        public List<Usuario> traerUsuarios()
        {
            String query = "SELECT IDUSUARIO, USUARIO, PALABRACLAVE FROM USUARIOS ";
            try
            {
                usuarios = new List<Usuario>();
                ad.setearConsulta(query);
                lector = ad.leerConsulta();
                Usuario user;
                while (lector.Read())
                {
                    user = new Usuario();
                    user.IdUsuario = lector.GetInt32(0);
                    user.Nombre = lector.GetString(1);
                    user.Clave = lector.GetString(2);
                    usuarios.Add(user);
                }
                return usuarios;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}
