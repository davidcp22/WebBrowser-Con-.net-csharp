using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace navegador_web
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> favoritos = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com.co");
            txtDirrecion.Text = "www.google.com.co";
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtDirrecion.Text);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
            txtDirrecion.Text = (webBrowser1.Url.ToString());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            favoritos.Add(webBrowser1.Url.ToString());
            comboxFavorito();
        }

        private void comboxFavorito()
        {
            cmbFavoritos.Items.Clear();
            foreach (string dirrecion in favoritos)
            {
                cmbFavoritos.Items.Add(dirrecion);

            }
        }

        private void cmbFavoritos_SelectedIndexChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate(cmbFavoritos.SelectedItem.ToString());
            txtDirrecion.Text = (cmbFavoritos.SelectedItem.ToString());


        }
    }
}
