using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class editForm : Form
    {
        public editForm()
        {
            InitializeComponent();
        }

        adminForm admin = new adminForm();
        Negocios objNegocios = new Negocios();
        private void saveBtn_Click(object sender, EventArgs e)
        {
            int id = (int)idTxt.Value;
            string categoria = categoriaTxt.Text;
            string marca = marcaTxt.Text;
            string descripcion = descripcionTxt.Text;
            string serie = serieTxt.Text;
            int stock = (int) stockTxt.Value;
            int costo = (int) costoTxt.Value;
            int ventas = (int) ventasTxt.Value;

            objNegocios.N_editar(id, categoria, marca, descripcion, serie, stock, costo, ventas);
            DataTable dt = objNegocios.N_listar();
            admin.adminTable.DataSource = dt;
            this.Close();
            admin.Show();   
        }



        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            admin.Show();
        }
    }
}
