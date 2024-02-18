﻿

namespace ScreenSound
{
    class Usuario
    {
        public string Nome {  get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public List<Musica> HistoricoDeReproducao = new List<Musica>();
        public List<Playlist> Playlist = new List<Playlist>();
        public List<AvaliacaoMusica> Avaliacoes = new List<AvaliacaoMusica>();
        public List<string> produtosComprados = new List<string>();
        public Usuario(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }
        public void AdicionarPlaylist(Playlist playlist)
        {
            Playlist.Add(playlist);
        }
        public void RemoverPlaylist(Playlist playlist)
        {
            Playlist.Remove(playlist);
        }
        public void AdicionarComentario(AvaliacaoMusica avaliacao)
        {
            //Adicionar Comentario
        }
        public void RemoverComentario(AvaliacaoMusica avaliacao)
        {
            //Remover Comentario
        }
        public void ComprarProduto(string nomeDoProduto)
        {
            produtosComprados.Add(nomeDoProduto);
        }
    }
}
