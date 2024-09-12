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

        public List<Articulo> listarXcodigo(string num)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion marca, C.Descripcion categoria, A.Precio from ARTICULOS A left join CATEGORIAS C on A.IdCategoria = C.Id left join MARCAS M on A.IdMarca = M.Id where A.Codigo like '%" + num + "%'"); 
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca_ = new Marca();
                    if (!(datos.Lector["Marca"] is DBNull))
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
               datos.setearConsulta("select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion marca, C.Descripcion categoria, A.Precio from ARTICULOS A left join CATEGORIAS C on A.IdCategoria = C.Id left join MARCAS M on A.IdMarca = M.Id where A.Nombre like '%" + nombre + "%'");
               datos.ejecutarLectura();

               while (datos.Lector.Read())
               {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca_ = new Marca();
                    if (!(datos.Lector["Marca"] is DBNull))
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
                datos.setearConsulta("select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion marca, C.Descripcion categoria, A.Precio from ARTICULOS A left join CATEGORIAS C on A.IdCategoria = C.Id left join MARCAS M on A.IdMarca = M.Id where A.Descripcion like '%" + desc + "%'");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca_ = new Marca();
                    if (!(datos.Lector["Marca"] is DBNull))
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
                datos.setearConsulta("select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion marca, C.Descripcion categoria, A.Precio from ARTICULOS A left join CATEGORIAS C on A.IdCategoria = C.Id left join MARCAS M on A.IdMarca = M.Id where M.Descripcion like '%" + Marca + "%'");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca_ = new Marca();
                    if (!(datos.Lector["Marca"] is DBNull))
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
                datos.setearConsulta("select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion marca, C.Descripcion categoria, A.Precio from ARTICULOS A left join CATEGORIAS C on A.IdCategoria = C.Id left join MARCAS M on A.IdMarca = M.Id where C.Descripcion like '%" + cat + "%'");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca_ = new Marca();
                    if (!(datos.Lector["Marca"] is DBNull))
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
            finally
            {
                datos.cerrarConexion();
            }
        }

    }
}
 
