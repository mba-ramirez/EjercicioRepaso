using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Controlador
    {
        public string[] Nombres = new string[1000];
        public int Contador = 0;
        public int[] DNIs = new int[1000];
        public double[] Notas = new double[1000];


        public void AgregarAlumno(string nombre, int dni, double nota)
        {
            Nombres[Contador] = nombre;
            DNIs[Contador] = dni;
            Notas[Contador] = nota;
            Contador++;
        }

        public double CalcularPromedio()
        {
            double Acumulador = 0;
            double Promedio = 0;
            for (int i = 0; i < Contador; i++)
            {
                Acumulador += Notas[i];
            }
            if (Contador > 0)
            {
                Promedio = Acumulador / Contador;
            }
            return Promedio;
        }
    }
}
