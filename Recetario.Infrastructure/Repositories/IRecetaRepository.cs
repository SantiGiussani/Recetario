using Recetario.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recetario.Infrastructure.Repositories
{
    public interface IRecetaRepository
    {
        List<Receta> ObtenerTodas();
        Receta ObtenerPorId(int id);
        void Agregar(Receta receta);
        void Modificar(Receta receta);
        void Eliminar(int id);
    }
}
