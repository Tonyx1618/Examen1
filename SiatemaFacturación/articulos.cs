using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturación
{
     public class articulo:menu
    {
        public int codigo;
        public string nombre;
        public double precio;

        public articulo(){}
        public articulo(int codigo, string nombre, double precio)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;

            Console.WriteLine($" Codigo: {codigo} \n Nombre: {nombre} \n Precio: {precio}");

        }

        

        

        public void agregar(int codigo)
        {
 
        }

        public void borra()
        {
            Console.WriteLine("Borrar articulo");
        }

        public void consultar()
        {
            Console.WriteLine($" Codigo: {codigo} \n Nombre: {nombre} \n Precio: {precio}");

        }




    }
}
