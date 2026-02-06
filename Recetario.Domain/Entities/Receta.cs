using Recetario.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recetario.Domain
{
    public class Receta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Categoria Categoria { get; set; }
        public List<Ingrediente> Ingredientes { get; set; }
        public List<PasoPreparacion> Preparacion { get; set; }
        public int TiempoPreparacion { get; set; }
        public Dificultad Dificultad { get; set; }
        public int CantidadPorciones { get; set; }
        public string Comentarios { get; set; }
        public decimal Puntuacion { get; set; }

        //ETIQUETAS
        //IMAGEN RECETA
    }
}
