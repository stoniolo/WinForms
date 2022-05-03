using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDB datos = new AccesoDB();


            try
            {
                datos.setQuery("select Id, Descripcion from MARCAS");
                datos.read();

                while (datos.Reader.Read())
                {
                    Marca aux = new Marca();
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
