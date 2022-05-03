using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class CategoriaNegocio
    {
            public List<Categoria> listar()
            {
                List<Categoria> lista = new List<Categoria>();
                AccesoDB datos = new AccesoDB();


                try
                {
                    datos.setQuery("select Id, Descripcion from CATEGORIAS");
                    datos.read();

                    while (datos.Reader.Read())
                    {
                        Categoria aux = new Categoria();
                        aux.Id = (int)datos.Reader["Id"];
                        aux.Descripcion = (string)datos.Reader["Descripcion"];

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

    }
}
