using System.Collections.Generic;
using RegistroComunitario.Models;

namespace RegistroComunitario.Data
{
    public static class RepositorioVecinos
    {
        private static List<Vecino> listaVecinos = new List<Vecino>();

        public static void Agregar(Vecino v)
        {
            listaVecinos.Add(v);
        }

        public static List<Vecino> ObtenerTodos()
        {
            return listaVecinos;
        }
    }
}
