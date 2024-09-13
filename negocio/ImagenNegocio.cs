using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Data.SqlTypes;
using System.Text.RegularExpressions;
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

                

                while (datos.Lector.Read())
                {
                    Imagen aux = new Imagen();
                    if ((int)datos.Lector["IdArticulo"] == idArticulo && !(datos.Lector["ImagenUrl"] is DBNull))
                    {
                        aux.Id = (int)datos.Lector["Id"];
                        aux.Url = (string)datos.Lector["ImagenUrl"];
                        lista.Add(aux);
                    }            
                }
                if (lista.Count == 0)
                {
                    Imagen aux = new Imagen();
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



        public void agregarImagen(Imagen nuevaImagen)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT INTO [CATALOGO_P3_DB].[dbo].[IMAGENES] ([IdArticulo], [ImagenUrl]) VALUES (@idArticulo, @imagenUrl)");
                datos.setearParametro("@idArticulo",nuevaImagen.Id);
                datos.setearParametro("@imagenUrl", nuevaImagen.Url);
                datos.ejecutarAccion();

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


        public void eliminarImagenIdArticulo(int idArticulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
              
                datos.setearConsulta("DELETE FROM IMAGENES WHERE IdArticulo = @idArticulo");
                datos.setearParametro("@idArticulo", idArticulo);
                datos.ejecutarAccion();
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
