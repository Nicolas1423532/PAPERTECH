using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace VISTA
{
    public partial class Menu_principal : Form
    {
        BLL_Producto bll_producto;
        public Menu_principal()
        {
            InitializeComponent();
        }

        private void Menu_principal_Load(object sender, EventArgs e)
        {
            foreach (var pD in this.Controls)
            {
                if (pD is DataGridView)
                {
                    (pD as DataGridView).MultiSelect = false;
                    (pD as DataGridView).SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }

            }
            bll_producto = new BLL_Producto();
            //Mostrar(dataGridView1, bll_producto.ConsultarTodosLosProductos());
        }
        private void Mostrar(DataGridView grilla, object dato)
        {
            grilla.DataSource = null;
            grilla.DataSource = dato;
        }

    }
}
