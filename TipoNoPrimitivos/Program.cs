using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoNoPrimitivos
{
    public class Persona
    {
        public string nombre;
        public int edad;
        public int id;
        public string nacionalidad;
        public long telefono;
        public int salario;
        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre: " + nombre);
        }
    }
    public static class Calculadora
    {
        public static int sumar(int a, int b)
        {
            return a + b;
        }

    }
    public class Empleado : Persona
    {
        public string puesto;
        public int horasTrabajadas;
        public void MostrarInformacionEmpleado()
        {
            Console.WriteLine("Puesto: " + puesto);
        }
    }

    public class Cliente : Persona
    {
        public string direccion;
        public int comprasRealizadas;
        public void MostrarInformacionCliente()
        {
            Console.WriteLine("Direccion: " + direccion);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Persona usuario1 = new Persona();
            usuario1.nombre = "Juan";
            usuario1.edad = 30;
            usuario1.id = 30136548;
            usuario1.nacionalidad = "Mexicana";
            usuario1.telefono = 5544332211;
            usuario1.salario = 15000;
            usuario1.MostrarInformacion();
            
            

            Persona usuario2 = new Persona();
            usuario2.nombre = "Maria";
            usuario2.edad = 25;
            usuario2.id = 30136549;
            usuario2.nacionalidad = "Dominicana";
            usuario2.telefono = 5544332212;
            usuario2.salario = 20000;
            usuario2.MostrarInformacion();
            Console.ReadLine();

          
            int resultado = Calculadora.sumar(5, 10);
            Console.WriteLine("Resultado de la suma: " + resultado);
        }
    }

    // al fin voy entendiendo esto



}
