namespace ScreenSound.Modelos
{
    // Dentro da chave não se tem um código executável apenas uma assinatura
    //Não se dá new em interfaces
    internal interface IAvaliavel
    {
        //Não abre chaves nos métodos da interface.
        void AdicionarNota(AvaliacaoMusica nota);
        double Media {  get;  }
    }
}
