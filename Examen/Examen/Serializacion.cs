using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Examen
{
    [Serializable]
    static class Serializacion
    {
        public static void Cargar(Partida partida)
        {
            using (Stream stream = File.Open(@"..\..\data\DataPartida.bin", FileMode.Open))
            {
                BinaryFormatter bin = new BinaryFormatter();
                List<string> partidaActual = (List<string>)bin.Deserialize(stream);

                foreach (string s in partida.GetDatosPartida())
                {
                    partidaActual.Add(s);
                }
            }                
        }
        
        public static void Guardar(Partida partida)
        {
            using (Stream stream = File.Open(@"..\..\data\DataPartida.bin", FileMode.Create))
            {
                List<string> partidas = partida.GetDatosPartida();

                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, partidas);
                stream.Close();
            }
        }
    }
}
