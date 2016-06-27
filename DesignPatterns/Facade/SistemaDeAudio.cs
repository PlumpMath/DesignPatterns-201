using System;

namespace POSDesingnPatternsFCV.Facade
{
    public class SistemaDeAudio
    {
        public void ConfigurarCanais() { }
        public void ConfigurarFrequencia() { }
        public void ConfigurarVolume() { }
        public void ReproduzirAudio(string arquivo)
        {
            Console.WriteLine("Reproduzindo: " + arquivo);
        }
    }
}