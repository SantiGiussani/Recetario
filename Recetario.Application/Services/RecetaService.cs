using Recetario.Domain;
using Recetario.Domain.Enums;
using Recetario.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recetario.Application.Services
{
    public class RecetaService : IRecetaService
    {
        private readonly IRecetaRepository _recetaRepository;

        public RecetaService(IRecetaRepository recetaRepository)
        {
            _recetaRepository = recetaRepository;
        }

        public List<Receta> ObtenerTodas()
        {
            return _recetaRepository.ObtenerTodas();
        }

        public Receta ObtenerPorId(int id)
        {
            return _recetaRepository.ObtenerPorId(id);
        }

        public void Agregar(Receta receta)
        {
            _recetaRepository.Agregar(receta);
        }

        public void Modificar(Receta receta)
        {
            _recetaRepository.Modificar(receta);
        }

        public void Eliminar(int id)
        {
            _recetaRepository.Eliminar(id);
        }

        public List<Receta> ObtenerPorCategoriaId(int categoriaId)
        {
            return _recetaRepository.ObtenerTodas()
                .Where(r => r.Categoria.Id == categoriaId)
                .ToList();
        }

        public List<Receta> ObtenerPorDificultad(Dificultad dificultad)
        {
            return _recetaRepository.ObtenerTodas()
                .Where(r => r.Dificultad == dificultad)
                .ToList();
        }

        public List<Receta> ObtenerPorIngrediente(string ingrediente)
        {
            return _recetaRepository.ObtenerTodas()
                .Where(r => r.Ingredientes.Any(i =>
                    i.Nombre.Equals(ingrediente, System.StringComparison.OrdinalIgnoreCase)))
                .ToList();
        }
    }
}
