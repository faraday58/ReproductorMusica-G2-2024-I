
namespace ReproductorMusica_G2_2024_I
{
    public class Musica
    {
        #region Atributos
        private string artista;
        private string titulo;
        private string album;
        private short duracion;
        #endregion

        #region Constructor
        public Musica(string artista, string titulo, string album)
        {
            Artista = artista;
            Titulo = titulo;
            Album = album;
        }

        public Musica(string artista, string titulo, string album, short duracion)
        {
            Artista = artista;
            Titulo = titulo;
            Album = album;
            Duracion = duracion;
        }
        #endregion

        #region Propiedades
        public string Artista { get => artista; set => artista = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Album { get => album; set => album = value; }
        public short Duracion { get => duracion; set => duracion = value; }
        #endregion


    }
}
