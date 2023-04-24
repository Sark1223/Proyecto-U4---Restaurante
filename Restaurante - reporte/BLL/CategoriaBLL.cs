using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante___reporte.BLL
{
    internal class CategoriaBLL
    {
        /*CREATE TABLE CATEGORIA (
    categoria_id          VARCHAR(3) NOT NULL,
    categoria_nombre      VARCHAr(30) NOT NULL UNIQUE,
    categoria_descripcion VARCHAR(200) NOT NULL,
    categoria_encargado   VARCHAR(50) NOT NULL
);*/
        public int categoria_id;
        public string categoria_nombre;
        public string categoria_descripcion;
        public string categoria_encargado;
    }
}
