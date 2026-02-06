using Recetario.Domain;
using Recetario.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recetario.Application.Services
{
    public interface IRecetaService
    {
        List<Receta> ObtenerTodas();
        Receta ObtenerPorId(int id);
        void Agregar(Receta receta);
        void Modificar(Receta receta);
        void Eliminar(int id);

        List<Receta> ObtenerPorCategoriaId(int categoriaId);
        List<Receta> ObtenerPorDificultad(Dificultad dificultad);
        List<Receta> ObtenerPorIngrediente(string ingrediente);
    }
}
