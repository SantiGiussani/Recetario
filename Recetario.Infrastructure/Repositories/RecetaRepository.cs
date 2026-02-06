using Recetario.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recetario.Infrastructure.Repositories
{
    public class RecetaRepository : IRecetaRepository
    {
        private static List<Receta> _recetas = new List<Receta>();

        public List<Receta> ObtenerTodas()
        {
            return _recetas;
        }

        public Receta ObtenerPorId(int id)
        {
            return _recetas.FirstOrDefault(r => r.Id == id);
        }

        public void Agregar(Receta receta)
        {
            _recetas.Add(receta);
        }

        public void Modificar(Receta receta)
        {
            var existente = ObtenerPorId(receta.Id);
            if (existente != null)
            {
                existente.Nombre = receta.Nombre;
                existente.Categoria = receta.Categoria;
                existente.Ingredientes = receta.Ingredientes;
                existente.Preparacion = receta.Preparacion;
                existente.TiempoPreparacion = receta.TiempoPreparacion;
                existente.Dificultad = receta.Dificultad;
                existente.CantidadPorciones = receta.CantidadPorciones;
                existente.Comentarios = receta.Comentarios;
                existente.Puntuacion = receta.Puntuacion;
            }
        }

        public void Eliminar(int id)
        {
            var receta = ObtenerPorId(id);
            if (receta != null)
                _recetas.Remove(receta);
        }
    }
}
