namespace POSDesingnPatternsFCV.Facade
{
    public class SistemasFacade
    {
        public SistemaDeAudio Audio { get; set; }
        public SistemaDeInput Input { get; set; }
        public SistemaDeVideo Video { get; set; }
        public SistemaDeFisica Fisica { get; set; }

        public SistemasFacade()
        {
            Audio = new SistemaDeAudio();
            Input = new SistemaDeInput();
            Video = new SistemaDeVideo();
            Fisica = new SistemaDeFisica();
        }

        public void InicializarSubSistemas()
        {            
            Audio.ConfigurarCanais();
            Audio.ConfigurarFrequencia();
            Audio.ConfigurarVolume();
            
            Input.ConfigurarTeclado();
            Input.ConfigurarJoystick();
            
            Video.ConfigurarImagem();

            Fisica.AjustarDensidade();
        }

        public void ReproduzirAudio(string arquivo)
        {
            Audio.ReproduzirAudio(arquivo);
        }
    }
}
