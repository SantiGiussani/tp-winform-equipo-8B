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

        public List<Articulo> Listar(string campo, string criterio, string buscar)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                string consulta = "Select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, A.Precio from ARTICULOS A Left Join CATEGORIAS C on A.IdCategoria = C.Id Left Join MARCAS M on A.IdMarca = M.Id";

                if(campo == "Precio")
                {
                    if(criterio == "Menor a")
                    {
                        consulta += " where A.Precio < "+ buscar +" ";
                    }
                    else
                    {
                        consulta += " where A.Precio > " + buscar + " ";
                    }
                }
                if(campo == "Marca")
                {
                    if(criterio == "Contiene")
                    {
                        consulta += " where M.Descripcion like '%" + buscar + "%'";
                    }
                    else
                    {
                        consulta += " where M.Descripcion like '" + buscar + "%'";
                    }
                }
                if(campo == "Categoria")
                {
                    if (criterio == "Contiene")
                    {
                        consulta += " where C.Descripcion like '%" + buscar + "%'";
                    }
                    else
                    {
                        consulta += " where C.Descripcion like '" + buscar + "%'";
                    }
                }

                accesoDatos.setearConsulta(consulta);
                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)accesoDatos.Lector["Id"];
                    aux.Codigo = (string)accesoDatos.Lector["Codigo"];
                    aux.Nombre = (string)accesoDatos.Lector["Nombre"];
                    aux.Descripcion = (string)accesoDatos.Lector["Descripcion"];
                    aux.Marca_ = new Marca();
                    if (!(accesoDatos.Lector["Marca"] is DBNull))
                    {
                        aux.Marca_.Descripcion = (string)accesoDatos.Lector["Marca"];
                    }
                    else
                    {
                        aux.Marca_.Descripcion = "";
                    }
                    aux.Categoria_ = new Categoria();
                    if (!(accesoDatos.Lector["Categoria"] is DBNull))
                    {
                        aux.Categoria_.Descripcion = (string)accesoDatos.Lector["Categoria"];
                    }
                    else
                    {
                        aux.Categoria_.Descripcion = "";
                    }
                    aux.Precio = (decimal)accesoDatos.Lector["Precio"];
                    ImagenNegocio imagenNegocio = new ImagenNegocio();
                    aux.ListaImagenes = imagenNegocio.listar(aux.Id);

                    lista.Add(aux);
                }


                return lista;
            }
            catch (Exception)
            {

                throw;
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







        public void modificar(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE ARTICULOS SET Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idMarca, IdCategoria = @idCategoria, Precio = @precio WHERE Id = @id");
                datos.setearParametro("@id", art.Id);
                datos.setearParametro("@codigo", art.Codigo);
                datos.setearParametro("@nombre", art.Nombre);
                datos.setearParametro("@descripcion", art.Descripcion);
                datos.setearParametro("@idMarca", art.Marca_.Id);
                datos.setearParametro("@idCategoria", art.Categoria_.Id);
                datos.setearParametro("@precio", art.Precio);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el artículo", ex);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }







        public void actualizarImagenes(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                // Primero, eliminar todas las imágenes asociadas con el artículo
                datos.setearConsulta("DELETE FROM IMAGENES WHERE IdArticulo = @idArticulo");
                datos.setearParametro("@idArticulo", art.Id);
                datos.ejecutarAccion();
                datos.cerrarConexion();  // Cierra la conexión después de ejecutar la primera acción

                // Luego, insertar las nuevas imágenes
                foreach (var img in art.ListaImagenes)
                {
                    if (!string.IsNullOrEmpty(img.Url)) // Verificar que la URL no sea nula o vacía
                    {
                        datos = new AccesoDatos(); // Crear una nueva instancia para cada inserción
                        datos.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@idArticulo, @imagenUrl)");
                        datos.setearParametro("@idArticulo", art.Id);
                        datos.setearParametro("@imagenUrl", img.Url);
                        datos.ejecutarAccion();
                        datos.cerrarConexion();  // Cerrar la conexión después de cada inserción
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Error SQL al actualizar imágenes: " + sqlEx.Message, sqlEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar imágenes", ex);
            }
            finally
            {
                datos.cerrarConexion();  // Asegurar que la conexión se cierra al final
            }
        }



        public bool existeCodigo(string codigo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT Id FROM ARTICULOS WHERE Codigo = @codigo");
                datos.setearParametro("@codigo", codigo);

                // Ejecutar la consulta y leer los resultados
                SqlDataReader lector = datos.ejecutarLectura();

                // Verificar si se devolvió algún registro
                return lector.HasRows;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar el código de artículo.", ex);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }




    }
}
 
