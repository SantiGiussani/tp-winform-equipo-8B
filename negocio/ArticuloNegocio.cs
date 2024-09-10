using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using System.Xml.Linq;
using System.Data.SqlTypes;
using System.Text.RegularExpressions;

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
                datos.setearConsulta("select A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion marca, C.Descripcion Categoria ,Precio from ARTICULOS A, MARCAS M, CATEGORIAS C where M.Id = A.IdMarca and C.Id = A.IdCategoria ");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Clasificacion(); 
                    aux.Marca.descripcion = (string)datos.Lector["Marca"];
                    aux.categoria = new Clasificacion();
                    aux.categoria.descripcion = (string)datos.Lector["Categoria"];
                    aux.precio = (decimal)datos.Lector["precio"];
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

        public List<Articulo> listarXcodigo(string num)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion marca, C.Descripcion Categoria, Precio from ARTICULOS A, MARCAS M, CATEGORIAS C where M.Id = A.IdMarca and C.Id = A.IdCategoria and Codigo like '%" + num + "%'"); 
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Clasificacion();
                    aux.Marca.descripcion = (string)datos.Lector["Marca"];
                    aux.categoria = new Clasificacion();
                    aux.categoria.descripcion = (string)datos.Lector["Categoria"];
                    aux.precio = (decimal)datos.Lector["Precio"];
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
            finally
            {
                datos.cerrarConexion();
            }

        }

       public List<Articulo> listarXnombre(string nombre)
       {
           List<Articulo> lista = new List<Articulo>();
           AccesoDatos datos = new AccesoDatos();

           try
           {
               datos.setearConsulta("select A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion marca, C.Descripcion Categoria ,Precio from ARTICULOS A, MARCAS M, CATEGORIAS C where M.Id = A.IdMarca and C.Id = A.IdCategoria and Nombre like '%" + nombre + "%'");
               datos.ejecutarLectura();

               while (datos.Lector.Read())
               {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Clasificacion();
                    aux.Marca.descripcion = (string)datos.Lector["Marca"];
                    aux.categoria = new Clasificacion();
                    aux.categoria.descripcion = (string)datos.Lector["Categoria"];
                    aux.precio = (decimal)datos.Lector["Precio"];
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
           finally
           {
               datos.cerrarConexion();
           }
       }

        public List<Articulo> listarXdesc(string desc)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select A.ID, Codigo, Nombre, A.Descripcion, M.Descripcion marca, C.Descripcion Categoria ,Precio from ARTICULOS A, MARCAS M, CATEGORIAS C where M.Id = A.IdMarca and C.Id = A.IdCategoria and A.Descripcion like '%" + desc + "%'");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Clasificacion();
                    aux.Marca.descripcion = (string)datos.Lector["Marca"];
                    aux.categoria = new Clasificacion();
                    aux.categoria.descripcion = (string)datos.Lector["Categoria"];
                    aux.precio = (decimal)datos.Lector["Precio"];
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
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Articulo> listarXmarca(string Marca)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion marca, C.Descripcion Categoria ,Precio from ARTICULOS A, MARCAS M, CATEGORIAS C where M.Id = A.IdMarca and C.Id = A.IdCategoria and M.Descripcion like '%" + Marca + "%'");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Clasificacion();
                    aux.Marca.descripcion = (string)datos.Lector["Marca"];
                    aux.categoria = new Clasificacion();
                    aux.categoria.descripcion = (string)datos.Lector["Categoria"];
                    aux.precio = (decimal)datos.Lector["Precio"];
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
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Articulo> listarXcat(string cat)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion marca, C.Descripcion Categoria ,Precio from ARTICULOS A, MARCAS M, CATEGORIAS C where M.Id = A.IdMarca and C.Id = A.IdCategoria and C.Descripcion like '%" + cat + "%'");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Clasificacion();
                    aux.Marca.descripcion = (string)datos.Lector["Marca"];
                    aux.categoria = new Clasificacion();
                    aux.categoria.descripcion = (string)datos.Lector["Categoria"];
                    aux.precio = (decimal)datos.Lector["Precio"];
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
            finally
            {
                datos.cerrarConexion();
            }
        }

    }
}
 
