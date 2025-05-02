using System;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryLunaMConexionBDv4
{
    internal class clsProductos
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Desc { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int CategoriaID { get; set; }

        public clsProductos() { }

        public clsProductos(int codigo, string nombre, string desc, decimal precio, int stock, int categoriaID)
        {
            Codigo = codigo;
            Nombre = nombre;
            Desc = desc;
            Precio = precio;
            Stock = stock;
            CategoriaID = categoriaID;
        }
    }
}
