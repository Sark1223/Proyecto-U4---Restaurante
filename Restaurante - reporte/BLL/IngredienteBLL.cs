using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante___reporte.BLL
{
    internal class IngredienteBLL
    {
        public int ingrediente_id;//llave primaria, varchar(4), not null
        public string ingrediente_nombre;//varchar(30), null
        public string ingrediente_unidad_medida;//varchar(20), not null
        public int ingrediente_cantidad_almacen;//varchar(4), not null
    }
}
