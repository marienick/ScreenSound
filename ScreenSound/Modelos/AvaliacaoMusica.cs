
namespace ScreenSound.Modelos
{
    //Apenas o projeto vai conseguir acessá-la
    internal class AvaliacaoMusica
    {
        public double Nota { get; set; }
        public AvaliacaoMusica(int nota)
        {
            if (nota <= 0) nota = 0;
            if (nota >= 10) nota = 10;
            Nota = nota;
            
        }
        
        public static  AvaliacaoMusica Parse(string texto)
        {
            int nota = int.Parse(texto);
            return new AvaliacaoMusica(nota);
        }


    }
}
