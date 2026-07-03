using CapaDatos;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormEspecialistaBuscarCaso : Form
    {
        private NCaso nCaso = new NCaso();

        public FormEspecialistaBuscarCaso()
        {
            InitializeComponent();
            CargarTabla();
        }

        private void CargarTabla()
        {
            dgCaso.DataSource = null;
            var lista = nCaso.ListarTodo();
            if (lista != null && lista.Count > 0)
            {
                dgCaso.DataSource = lista;
            }
        }

        private void dgCaso_SelectionChanged(object sender, EventArgs e)
        {
            if (dgCaso.SelectedRows.Count > 0)
            {
                var fila = dgCaso.SelectedRows[0];

                tbId.Text = (fila.Cells["nroCaso"].Value ?? fila.Cells["NroCaso"].Value ?? fila.Cells[0].Value)?.ToString();
                cbEstado.Text = (fila.Cells["estado"].Value ?? fila.Cells["Estado"].Value ?? fila.Cells[3].Value)?.ToString();

                if (dgCaso.Columns.Contains("areaAtencion"))
                    cbAreaAtención.Text = fila.Cells["areaAtencion"].Value?.ToString();
                else if (dgCaso.Columns.Contains("AreaAtencion"))
                    cbAreaAtención.Text = fila.Cells["AreaAtencion"].Value?.ToString();
            }
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var listaCompleta = nCaso.ListarTodo();
            if (listaCompleta != null && listaCompleta.Count > 0)
            {
                var filtrado = listaCompleta.AsEnumerable();

                if (!string.IsNullOrWhiteSpace(tbId.Text) && int.TryParse(tbId.Text.Trim(), out int idBuscado))
                { 
                filtrado = filtrado.Where(c => c.nroCaso == idBuscado);
                }

                if (cbEstado.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(cbEstado.Text))
                {
                    filtrado = filtrado.Where(c => c.estado != null && c.estado.Equals(cbEstado.Text, StringComparison.OrdinalIgnoreCase));
                }

                if (cbAreaAtención.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(cbAreaAtención.Text))
                {
                    string areaBuscada = cbAreaAtención.Text;
                    filtrado = filtrado.Where(c => c.estado != null);
                }

                dgCaso.DataSource = null;
                dgCaso.DataSource = filtrado.ToList();
            }
        }

        private void btnListarTodo_Click(object sender, EventArgs e)
        {
            tbId.Clear();
            cbEstado.SelectedIndex = -1;
            cbAreaAtención.SelectedIndex = -1;
            CargarTabla();
        }
    }
}
