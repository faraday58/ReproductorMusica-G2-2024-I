﻿using System;
using System.Collections;
using System.Windows.Forms;

namespace ReproductorMusica_G2_2024_I
{
    public partial class FormReproductor : Form
    {
        private Form formPadre;
        private ArrayList canciones;
        private int tiempo;
        private Musica musica;
        public FormReproductor(Form formPadre)
        {
            InitializeComponent();
            this.formPadre = formPadre;
            canciones = new ArrayList();
        }

        private void FormReproductor_FormClosing(object sender, FormClosingEventArgs e)
        {
            formPadre.Show();
            
        }

        private void CargarCanciones()
        {
            canciones.Add(new Musica("Peso Pluma","Lady Gaga","Génesis",210));
            canciones.Add(new Musica("Michael Jackson","Thriller","Thriller",300));

        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarCanciones();
            foreach (object cancion in canciones    )
            {
                Musica musica = (Musica)cancion;
                lstbCanciones.Items.Add(musica.Titulo);

            }

        }

        private void lstbCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
             this.musica = (Musica)canciones[lstbCanciones.SelectedIndex];


            lbTitulo.Text = musica.Titulo;
            lbArtista.Text = musica.Artista;
            lbAlbum.Text = musica.Album;
            lbFinal.Text = String.Format("{0}:{1}", musica.Duracion/60,  (musica.Duracion/60.0 - musica.Duracion/60)*60);
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregar formAgregar = new FormAgregar();
            formAgregar.EnviarMusica += AgregarCancion;
            formAgregar.ShowDialog();
        }

        public void AgregarCancion(Musica musica)
        {
            canciones.Add(musica);
            
            lstbCanciones.Items.Add(musica.Titulo);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbDuracion.Value +=  1;
            lbInicio.Text =String.Format(" {0} [s] ",   pbDuracion.Value);

            if ( pbDuracion.Value == 100)
            {
                timer1.Stop();
            }

        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
