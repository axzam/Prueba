using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Logica;

namespace Lago_Musical
{
    public class LagoMusical
    {
        
        static void Main(string[] args)
        {
            bool seguir = true;

            while (seguir)
            {
                L_Animal lista = new L_Animal();
                var animales = lista.Obtener_Lista_De_Animales();

                Presentar_Informacion();
                int sonido = Obtener_Datos_Del_Usuario();
                Procesar_Sonido(sonido, animales);
                Devolver_Sonidos_Restantes(sonido, animales);


                Console.WriteLine(" \n Presiona Enter para volver a iniciar o ESC para salir");
                if (Console.ReadKey().Key != ConsoleKey.Enter) { seguir = false; }
                Console.Clear();
            } 
        }

       
        private static void Presentar_Informacion()
        {
            try
            {
                Console.Title = "Lago Musical";
                Console.Write(" Explorador, ¿Que sonido recibes...?\n\n");
                Console.Write(" 1=brr, 2=birip, 3=brrah, 4=corac\n");
                Console.Write(" 5=fiu, 6=plop, 7=pep\n");
                Console.Write(" 8=cri-cri, 9=trri-trri, 10=bri-bri\n\n");
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private static int Obtener_Datos_Del_Usuario()
        {
            try
            {
                int valor;
                string numeroDelSonido;
                bool esNumero;

                do
                {
                    Console.Write(" Sonido:");
                    numeroDelSonido = Console.ReadLine();
                    esNumero = int.TryParse(numeroDelSonido, out valor);
                } while (!esNumero);
                return int.Parse(numeroDelSonido);

            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public static int Procesar_Sonido(int sonidoEscuchado, List<E_Animal> animales)
        {
            try
            {
                bool breakForeach = false;

                foreach (var animal in animales)
                {
                    for (int contador = 0; contador <= animal.Sonido.Length - 1; contador++)
                    {
                        if (animal.SonidoId[contador] == sonidoEscuchado)
                        {
                            Console.WriteLine($" El sonido es de {animal.Nombre}\n\n");
                            
                            breakForeach = true;
                            return sonidoEscuchado;
                            
                        }
                    }

                    if (breakForeach) break;

                }
                return 0;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private static void Devolver_Sonidos_Restantes(int sonidoEscuchado, List<E_Animal> animales)
        {
            try
            {
                if (sonidoEscuchado == 6) sonidoEscuchado = 3;
                switch (sonidoEscuchado)
                {
                    case 1:
                        Console.WriteLine($" {animales[0].Nombre}: {animales[0].Sonido[0]}");
                        Console.WriteLine($" {animales[1].Nombre}: {animales[1].Sonido[0]}");
                        Console.WriteLine($" {animales[2].Nombre}: {animales[2].Sonido[0]}");
                        Console.WriteLine($" {animales[0].Nombre}: {animales[0].Sonido[2]}");
                        break;
                    case 2:
                        Console.WriteLine($" {animales[0].Nombre}: {animales[0].Sonido[1]}");
                        Console.WriteLine($" {animales[2].Nombre}: {animales[2].Sonido[1]}");
                        Console.WriteLine($" {animales[0].Nombre}: {animales[0].Sonido[3]}");
                        break;
                    case 3:
                        Console.WriteLine($" {animales[1].Nombre}: {animales[1].Sonido[1]}");
                        Console.WriteLine($" {animales[2].Nombre}: {animales[2].Sonido[0]}");
                        Console.WriteLine($" {animales[0].Nombre}: {animales[0].Sonido[2]}");
                        break;
                    default:
                        Console.WriteLine(" Silencio ambiental...");
                        break;
                }
            }
            catch (Exception)
            {

                throw;
            }
                
        }

    }
}
