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
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, A.Precio from ARTICULOS A Left Join CATEGORIAS C on A.IdCategoria = C.Id Left Join MARCAS M on A.IdMarca = M.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca_ = new Marca(); 
                    if(!(datos.Lector["Marca"] is DBNull))
                    {
                        aux.Marca_.Descripcion = (string)datos.Lector["Marca"];
                    }
                    else
                    {
                        aux.Marca_.Descripcion = "";
                    }
                    aux.Categoria_ = new Categoria();
                    if (!(datos.Lector["Categoria"] is DBNull))
                    {
                        aux.Categoria_.Descripcion = (string)datos.Lector["Categoria"];
                    }
                    else
                    {
                        aux.Categoria_.Descripcion = "";
                    }
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    ImagenNegocio imagenNegocio = new ImagenNegocio();
                    aux.ListaImagenes = imagenNegocio.listar(aux.Id);

                    lista.Add(aux);
                }

                return lista;
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally {
                datos.cerrarConexion();
            }
            
        }

        public void agregar(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, Precio, IdMarca, IdCategoria) VALUES (@Codigo, @Nombre, @Descripcion, @Precio, @IdMarca, @IdCategoria)");
                datos.setearParametro("@Codigo", art.Codigo);
                datos.setearParametro("@Nombre", art.Nombre);
                datos.setearParametro("@Descripcion", art.Descripcion);
                datos.setearParametro("@Precio", art.Precio);
                datos.setearParametro("@IdMarca", art.Marca_.Id);
                datos.setearParametro("@IdCategoria", art.Categoria_.Id);
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


        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("Delete from ARTICULOS Where Id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




    }
}
 
