using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDB datos = new AccesoDB();


            try
            {
                datos.setQuery("select Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, ImagenUrl, Precio from ARTICULOS A, MARCAS M, CATEGORIAS C where M.Id = A.IdMarca And C.Id = A.IdCategoria");
                datos.read();

                while (datos.Reader.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)datos.Reader["Codigo"];
                    aux.Descripcion = (string)datos.Reader["Descripcion"];
                    aux.Nombre = (string)datos.Reader["Nombre"];

                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.Reader["Marca"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Reader["Categoria"];

                    aux.ImagenURL = (string)datos.Reader["ImagenUrl"];
                    aux.Precio = (decimal)datos.Reader["Precio"];

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
                datos.closeConnection();
            }
        }

        public void agregar(Articulo nuevo)
        {
            AccesoDB datos = new AccesoDB();
            try
            {
                datos.setQuery("Insert into ARTICULOS(Codigo, Nombre, IdMarca, IdCategoria, ImagenUrl, Precio, Descripcion)values( @Codigo, @Nombre, @IdMarca, @IdCategoria, @ImagenUrl, @Precio, @Descripcion)");
                datos.setParametros("@Codigo", nuevo.Codigo);
                datos.setParametros("@IdMarca", nuevo.Marca.Id);
                datos.setParametros("@IdCategoria", nuevo.Categoria.Id);
                datos.setParametros("@ImagenUrl", nuevo.ImagenURL);
                datos.setParametros("@Descripcion", nuevo.Descripcion);
                datos.setParametros("@Nombre", nuevo.Nombre);
                datos.setParametros("@Precio", nuevo.Precio);
                datos.run();
            }
            catch ( Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.closeConnection();
            }
        }
        


    }
}
