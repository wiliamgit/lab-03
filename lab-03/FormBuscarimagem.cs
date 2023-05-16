using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_03
{
    public partial class FormBuscarimagem : Form
    {
        public FormBuscarimagem()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            openFileDialogBuscar.Filter =
                "Arquivos bmp | *. bmp | Arquivos jpg | *.jpg";
            if (openFileDialogBuscar.ShowDialog() == DialogResult.OK)
           {
                pictureBoxScreen.ImageLocation = openFileDialogBuscar.FileName;
            }
        }
    }
}
