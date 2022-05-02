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
                datos.setQuery("select Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio from ARTICULOS");
                datos.read();

                while (datos.Reader.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)datos.Reader["Codigo"];
                    aux.Descripcion = (string)datos.Reader["Descripcion"];
                    aux.Nombre = (string)datos.Reader["Nombre"];
                    aux.Marca = (int)datos.Reader["IdMarca"];
                    aux.Categoria = (int)datos.Reader["IdCategoria"];
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
                datos.setQuery("Insert into ARTICULOS(Codigo, Nombre, IdMarca, IdCategoria, ImagenUrl, Precio, Descripcion)values('" + nuevo.Codigo + "', '" + nuevo.Nombre + "', '" + nuevo.Marca + "', '" + nuevo.Categoria + "', '" + nuevo.ImagenURL + "', '" + nuevo.Precio + "', '" + nuevo.Descripcion + "')");
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
