using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante___reporte.BLL
{
    internal class PlatilloBLL
    {

        /*CREATE TABLE PLATILLO (
    plato_id               VARCHAR(3) NOT NULL,
    plato_nombre           VARCHAR(50) NOT NULL,
    plato_descripcion      VARCHAR(200) NOT NULL,
    plato_dificultad       VARCHAR(8) NOT NULL,
    plato_foto             IMAGE NOT NULL,
    plato_preciof          DECIMAL(6, 2),
    categoria_id VARCHAR(3) NOT NULL
);*/
        public int plato_id;
        public string plato_nombre;
        public string plato_descripcion;
        public string plato_dificultad;
        public byte[] plato_foto;
        public float plato_preciof;
        public int categoria_id;
    }
}
