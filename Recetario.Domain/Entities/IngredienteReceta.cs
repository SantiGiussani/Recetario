using Recetario.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recetario.Domain.Entities
{
    public class IngredienteReceta
    {
        public int Id { get; set; }

        public int IdReceta { get; set; }
        public Receta Receta { get; set; }

        public int IdIngrediente { get; set; }
        public Ingrediente Ingrediente { get; set; }

        public short Cantidad { get; set; }

        public byte IdUnidad { get; set; }
        public UnidadMedida Unidad { get; set; }

        public bool Opcional { get; set; }

    }
}
