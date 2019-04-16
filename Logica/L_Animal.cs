using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace Logica
{
    public class L_Animal
    {
        public List<E_Animal> Obtener_Lista_De_Animales()
        {
            var listaDeAnimales = new List<E_Animal>();

                listaDeAnimales.Add(new E_Animal() {Nombre = "Rana", SonidoId = new int[] {1,2,3,4}, Sonido = new string[] { "brr", "birip", "brrah", "croac" } });
                listaDeAnimales.Add(new E_Animal() {Nombre = "Libelula", SonidoId = new int[] {5, 6, 7}, Sonido = new string[] { "fiu", "plop", "pep" } });
                listaDeAnimales.Add(new E_Animal() {Nombre = "Grillo", SonidoId = new int[] {8, 9, 10}, Sonido = new string[] { "cric-cric", "trri-trri", "bri-bri" } });

            return listaDeAnimales.ToList();
        }

    }
}
