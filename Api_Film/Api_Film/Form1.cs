using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Api_Film
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ClientREST.SetClient();
            scelta.SelectedIndex = 0;
            domainUpDownType.SelectedIndex = 0;
            anno.Enabled = false;
        }

        private void checkBoxAnno_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAnno.Checked)
            {
                anno.Enabled = true;
            }
            else
            {
                anno.Enabled = false;
            }
        }

        private async void invio_Click(object sender, EventArgs e)
        {
            Movie movie = null;
            bool imdbId = false;
            if (scelta.SelectedIndex != 0)
            {
                imdbId = true;
            }
            if (!checkBoxAnno.Checked)
            {
                anno.Text = "";
            }
            if (titolo.Text != null)
            {
                movie = await ClientREST.GetMovieAsync(titolo.Text, imdbId, anno.Text, domainUpDownType.SelectedItem.ToString(), checkBoxPlot.Checked);
                if (movie.Response == "True")
                {
                    FormMovie fM = new FormMovie(movie);
                    fM.Show();
                    this.Visible = false;
                }
                else
                    MessageBox.Show("Film non trovato");
            }
        }
    }
}
