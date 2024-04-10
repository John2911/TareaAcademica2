using TareaAcademica2.entities;
using TareaAcademica2.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaAcademica2.services
{
    class ConcesionarioService
    {
        private ConcesionarioRepository concesionarioRepository = new ConcesionarioRepository();

        public bool Registrar(Concesionario con)
        {
            if(concesionarioRepository.Existe(con.Codigo))
            {
                return false;
            }
            else
            {
                concesionarioRepository.Registrar(con);
                return true;
            }
        }

        public List<Concesionario> ListarTodo()
        {
            return ConcesionarioRepository.ListarTodo();
        }

        public void Eliminar (String codigo)
        {
            concesionarioRepository.Eliminar(codigo);
        }

        public List<Concesionario> BuscarPorMarca(String marca)
        {
            return concesionarioRepository.BuscarPorMarca(marca);
        }
    }
}
