using LabFinalCurso.Data.DataAccess;
using LabFinalCurso.Data.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LabFinalCurso
{
    public partial class Form1 : Form
    {
        JuegosC Clscone = new JuegosC();
        Consolas consol = new Consolas();
        
        private JuegosC juegoconsola;
        public Form1()
        {
            InitializeComponent();
            juegoconsola= new JuegosC();
        }

        private void btprobarconexion_Click(object sender, EventArgs e)
        {
            if (juegoconsola.PruebaConexion())
            {
                MessageBox.Show("Simona la mona");

            }
            else
            {
                MessageBox.Show("Nelson");
            }
        }

        private void btmodeloinsertar_Click(object sender, EventArgs e)
        {
            consol.id_consola = int.Parse(tbidconsola.Text);
            consol.nombre_consola = tbnombrecon.Text;
            consol.compania = comboBoxcompania.Text;
            consol.anio_lanzamiento = int.Parse(tbaniolan.Text);
            consol.generacion = int.Parse(tbgeneracion.Text);
            Clscone.Insertar(consol);
            MessageBox.Show("Insertado con exito, cargue de nuevo la lista para poder verlo.");
        }

        private void btcargar_Click(object sender, EventArgs e)
        {
            DataTable dt = juegoconsola.LeerCatalogo();
            dataGridViewcatalogo.DataSource = dt;
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            consol.id_consola = int.Parse(tbidconsola.Text);
            consol.nombre_consola = tbnombrecon.Text;
            consol.compania = comboBoxcompania.Text;
            consol.anio_lanzamiento = int.Parse(tbaniolan.Text);
            consol.generacion = int.Parse(tbgeneracion.Text);
            Clscone.Actualizar(consol);
            MessageBox.Show("Actualizado con exito, cargue de nuevo la lista para poder verlo.");
        }

        private void btelim_Click(object sender, EventArgs e)
        {
            consol.id_consola = int.Parse(tbidconsola.Text);
            consol.nombre_consola = tbnombrecon.Text;
            consol.compania = comboBoxcompania.Text;
            consol.anio_lanzamiento = int.Parse(tbaniolan.Text);
            consol.generacion = int.Parse(tbgeneracion.Text);
            Clscone.Eliminar(consol);
            MessageBox.Show("Eliminado con exito, cargue de nuevo la lista para poder verlo.");
        }

    }
}

