using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Grupo> grupos = new List<Grupo>();


            Grupo matematicas =
                new Grupo("Matematicas", "MA12345");
            Grupo historia =
                new Grupo("Historia", "HS12345");



            grupos.Add(matematicas);
            grupos.Add(historia);

            Alumnos juan = new Alumnos("Juan", "78925");
            Alumnos maria = new Alumnos("Maria", "78547");
            Alumnos pedro = new Alumnos("Pedro", "78675");
            Alumnos ana = new Alumnos("Ana", "78115");
            Alumnos pablo = new Alumnos("Pablo", "78035");

            historia.Alumnos.Add(juan);
            historia.Alumnos.Add(ana);
            historia.Alumnos.Add(pedro);

            matematicas.Alumnos.Add(juan);
            matematicas.Alumnos.Add(maria);
            matematicas.Alumnos.Add(pedro);
            matematicas.Alumnos.Add(ana);
            matematicas.Alumnos.Add(pablo);


            foreach (Grupo grupo in grupos)
            {
                Console.WriteLine("Grupo: " +
                    grupo.Codigo);
                Console.WriteLine("Materia: " +
                    grupo.Materia);
                Console.WriteLine("Lista de alumnos: ");
                foreach(Alumnos alumno in grupo.Alumnos)
                {
                    Console.WriteLine("*" +
                        alumno.Nombre);
                }
            }


            Console.Read();
        }
    }
}
