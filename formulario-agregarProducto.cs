using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocios;

namespace CapaPresentacion
{ 
    public partial class addProduct : Form
    {
        Entidad objEntidad = new Entidad();
        Negocios objNegocios = new Negocios();
        adminForm admin = new adminForm();
        public addProduct()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            admin.Show();
        }
        
        private void saveBtn_Click(object sender, EventArgs e)
        {
            objEntidad.categoria = categoriaTxt.Text;
            objEntidad.marca = marcaTxt.Text;
            objEntidad.descripcion = descripcionTxt.Text;
            objEntidad.serie = serieTxt.Text;
            objEntidad.stock = (int)stockTxt.Value;
            objEntidad.costo = (int)costoTxt.Value;
            objEntidad.ventas = (int)ventasTxt.Value;

            string categoria = objEntidad.categoria;
            string marca = objEntidad.marca;
            string descripcion = objEntidad.descripcion;
            string serie = objEntidad.serie;
            int stock = objEntidad.stock;
            int costo = objEntidad.costo;
            int ventas = objEntidad.ventas;

            objNegocios.N_agregar(categoria, marca, descripcion, serie, stock, costo, ventas);

            this.Close();
            admin.Show();

        }
        
    }
}
