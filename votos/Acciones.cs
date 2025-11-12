using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace votos
{
    internal class Acciones
    {

        public Dictionary<string, int> estadosiniciales = new Dictionary<string, int> {
         {"AL", 9},{"AK", 3},{"AZ", 11},{"AR", 6},
                {"CA", 55},{"CO", 9},{"CT", 7},{"DE", 3},
                {"FL", 29},{"GA", 16},{"HI", 4},{"ID", 4},
                {"IL", 20},{"IN", 11},{"IA", 6},{"KS", 6},
                {"KY", 8},{"LA", 8},{"ME", 4},{"MD", 10},
                {"MA", 11},{"MI", 16},{"MN", 10},{"MS", 6},
                {"MO", 10},{"MT", 3},{"NE", 5},{"NV", 6},
                {"NH", 4},{"NJ", 14},{"NM", 5},{"NY", 29},
                {"NC", 15},{"ND", 3},{"OH", 18},{"OK", 7},
                {"OR", 7},{"PA", 20},{"RI", 4},{"SC", 9},
                {"SD", 3},{"TN", 11},{"TX", 38},{"UT", 6},
                {"VT", 3},{"VA", 13},{"WA", 12},{"WV", 5},
                {"WI", 10},{"WY", 3}};
        public Dictionary<string, int> estados = new Dictionary<string, int>();

        public Dictionary<string, int> Republicanos = new Dictionary<string, int>();
        public Dictionary<string, int> Democratas = new Dictionary<string, int>();

        public Dictionary<string, int> MostrarRepublicanos()
        {
            return Republicanos;
        }

        public Dictionary<string, int> MostrarDemocratas()
        {
            return Democratas;
        }

        public bool agregarRepublicanos(string estado, int votos)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(estado))
                {
                    return false;
                }

                if (estadosiniciales.ContainsKey(estado) && votos <= estadosiniciales[estado])
                {
                    Republicanos.Add(estado, votos);
                    estadosiniciales.Remove(estado);
                    return true;
                }


                return false;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error en agregarRepublicanos: {ex}");
                return false;
            }
        }

        public bool agregarDemocratas(string estado, int votos)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(estado))
                {
                    return false;
                }

                if (estadosiniciales.ContainsKey(estado) && votos <= estadosiniciales[estado])
                {
                    Democratas.Add(estado, votos);
                    estadosiniciales.Remove(estado);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error en agregarDemocratas : {ex}");
                return false;
            }
        }



        public bool eliminarRepublicanos(string estado, int votos)
        {
            try
            {
                if (Republicanos.ContainsKey(estado))
                {
                    Republicanos.Remove(estado);
                    estadosiniciales.Add(estado, votos); 
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error en eliminarRepublicanos: {ex}");
                return false;
            }
        }

        public bool eliminarDemocratas(string estado, int votos)
        {
            try
            {
                if (Democratas.ContainsKey(estado))
                {
                    Democratas.Remove(estado);
                    estadosiniciales.Add(estado, votos); 
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error en eliminarDemocratas: {ex}");
                return false;
            }
        }
        public int totalVotosRepublicanos()
        {
            return Republicanos.Sum(x => x.Value);
        }

        public int totalVotosDemocratas()
        {
            return Democratas.Sum(x => x.Value);


        }



    }
}


