using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using dominio;

namespace negocio
{
    public class ImagenNegocio
    {
        public List<Imagen> listar(int idArticulo)
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Id, IdArticulo, ImagenUrl From IMAGENES");
                datos.ejecutarLectura();

                Imagen aux = new Imagen();

                while (datos.Lector.Read())
                {
                    if ((int)datos.Lector["IdArticulo"] == idArticulo && !(datos.Lector["ImagenUrl"] is DBNull))
                    {
                        aux.Id = (int)datos.Lector["Id"];
                        aux.Url = (string)datos.Lector["ImagenUrl"];
                        lista.Add(aux);
                    }            
                }
                if (lista.Count == 0)
                {
                    aux.Id = idArticulo;
                    aux.Url = "";
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
