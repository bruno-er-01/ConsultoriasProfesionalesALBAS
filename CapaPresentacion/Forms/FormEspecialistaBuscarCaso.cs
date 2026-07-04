using CapaDatos;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormEspecialistaBuscarCaso : Form
    {
        private NCaso nCaso = new NCaso();
        private Usuario usuarioActual;
        public FormEspecialistaBuscarCaso(Usuario usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
            MostrarData(nCaso.ListarCasosPorEspecialista(usuarioActual.idUsuario, "", ""));
        }
        private void MostrarData<t>(List<t> lista)
        {
            dgCasos.DataSource = null;
            if (lista.Count > 0)
            {
                dgCasos.DataSource = lista;
            }
            dgCasos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgCasos.Columns["IdCliente"] != null)
            {
                dgCasos.Columns["IdCliente"].Visible = false;
            }

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            MostrarData(nCaso.ListarCasosPorEspecialista(usuarioActual.idUsuario, cbEstadoCaso.Text, ""));
        }

        private void btnCitasCaso_Click(object sender, EventArgs e)
        {
            if(dgCasos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciones un caso");
                return;
            }
            FormEspecialistaBuscarCita form = new FormEspecialistaBuscarCita();
            form.ShowDialog();
        }
        // si quiero excel debo instalar nuggets
        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            if (dgCasos.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Archivo CSV|*.csv";
            save.Title = "Exportar casos";
            save.FileName = "Mis_Casos.csv";

            if (save.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < dgCasos.Columns.Count; i++)
                {
                    if (dgCasos.Columns[i].Visible == true)
                    {
                        sb.Append(dgCasos.Columns[i].HeaderText + ";");
                    }
                }

                sb.AppendLine();

                foreach (DataGridViewRow fila in dgCasos.Rows)
                {
                    if (fila.IsNewRow == false)
                    {
                        for (int i = 0; i < dgCasos.Columns.Count; i++)
                        {
                            if (dgCasos.Columns[i].Visible == true)
                            {
                                if (fila.Cells[i].Value != null)
                                {
                                    sb.Append(fila.Cells[i].Value.ToString() + ";");
                                }
                                else
                                {
                                    sb.Append(";");
                                }
                            }
                        }

                        sb.AppendLine();
                    }
                }

                File.WriteAllText(save.FileName, sb.ToString(), Encoding.UTF8);

                MessageBox.Show("Archivo exportado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar: " + ex.Message);
            }
        }
        

        private void btnBorrarFiltro_Click(object sender, EventArgs e)
        {
            cbEstadoCaso.SelectedIndex = 0;
            txtDataCliente.Text = "";
            MostrarData(nCaso.ListarCasosPorEspecialista(usuarioActual.idUsuario, "", ""));
        }

        private void txtDataCliente_TextChanged(object sender, EventArgs e)
        {
            MostrarData(nCaso.ListarCasosPorEspecialista(usuarioActual.idUsuario, "", txtDataCliente.Text));
        }
    }
}
