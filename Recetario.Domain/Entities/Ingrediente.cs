using Recetario.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recetario.Domain
{
    public class Ingrediente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Categoria Categoria { get; set; }
        public decimal Cantidad { get; set; }
        public UnidadMedida UnidadMedida { get; set; }
        public bool Opcional { get; set; }

        //LUGAR COMPRA
    }
}
