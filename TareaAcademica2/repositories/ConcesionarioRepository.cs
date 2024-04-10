using TareaAcademica2.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaAcademica2.repositories
{
    class ConcesionarioRepository
    {
        private static List<Concesionario> concesionarios = new List<Concesionario>();

        public bool Existe(String codigo)
        {
            return concesionarios.Exists(con => con.Codigo.Equals(codigo));
        }

        public void Registrar(Concesionario con)
        {
            concesionarios.Add(con);
        }

        public static List<Concesionario> ListarTodo()
        {
            return concesionarios;
        }

        public void Eliminar(String codigo)
        {
            concesionarios.RemoveAll(con => con.Codigo.Equals(codigo));
        }

        public List<Concesionario> BuscarPorMarca(String marca)
        {
            return concesionarios.Where(con => con.Marca.Contains(marca)).ToList();
        }


    }
}
