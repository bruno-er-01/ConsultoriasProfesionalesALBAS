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
    public partial class FormEspecialistaBuscarCita : Form
    {
        private NCita nCita = new NCita();
        private int nroCaso;
        private Usuario usuarioActual;

        public FormEspecialistaBuscarCita(Usuario usuarioActual, int nroCaso)
        {
            InitializeComponent();
            this.nroCaso = nroCaso;
            this.usuarioActual = usuarioActual;
            MostrarData(nCita.ListarPorCaso(nroCaso));
        }

        private void MostrarData(List<Cita> citas)
        {
            dgCitas.DataSource = null;

            if (citas.Count > 0)
            {
                dgCitas.DataSource = citas;
            }
            else
            {
                return;
            }

            dgCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgCitas.Columns["idCita"].Visible = false;
            dgCitas.Columns["nroCaso"].Visible = false;
            dgCitas.Columns["Caso"].Visible = false;
            dgCitas.Columns["activo"].Visible = false;
            dgCitas.Columns["tiempoAnticipacion"].Visible = false;
            dgCitas.Columns["createdBy"].Visible = false;
            dgCitas.Columns["createdAt"].Visible = false;
            dgCitas.Columns["modifiedBy"].Visible = false;
            dgCitas.Columns["modifiedAt"].Visible = false;
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            List<Cita> lista = nCita.ListarPorCaso(nroCaso);

            if ((cbEstado.Text == "" || cbEstado.Text == "Todos") &&
                (cbAsistencia.Text == "" || cbAsistencia.Text == "Todos"))
            {
                MostrarData(lista);
                return;
            }

            if (cbEstado.Text != "" && cbEstado.Text != "Todos")
            {
                lista = lista.Where(c => c.estado == cbEstado.Text).ToList();
            }

            if (cbAsistencia.Text != "" && cbAsistencia.Text != "Todos")
            {
                bool asistencia = false;

                if (cbAsistencia.Text == "Si")
                {
                    asistencia = true;
                }
                else if (cbAsistencia.Text == "No")
                {
                    asistencia = false;
                }

                lista = lista.Where(c => c.confirmacionAsistencia == asistencia).ToList();
            }

            MostrarData(lista);
        }

        private void btnBorrarFiltro_Click(object sender, EventArgs e)
        {
            cbEstado.SelectedIndex = -1;
            cbAsistencia.SelectedIndex = -1;
            cbEstadoActualizado.SelectedIndex = -1;
            cbAreaActualizada.SelectedIndex = -1;
            rtxtObservacion.Text = "";
            dgCitas.ClearSelection();

            MostrarData(nCita.ListarPorCaso(nroCaso));
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgCitas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una cita.");
                return;
            }

            if (cbEstadoActualizado.Text == "" || cbAreaActualizada.Text == "")
            {
                MessageBox.Show("Complete el estado y la asistencia.");
                return;
            }

            if (cbEstadoActualizado.Text == "Cancelado" && cbAreaActualizada.Text == "Si")
            {
                MessageBox.Show("Una cita cancelada no puede figurar como asistida.");
                return;
            }

            if (cbEstadoActualizado.Text == "Atendido" && cbAreaActualizada.Text == "No")
            {
                MessageBox.Show("Una cita atendida debe figurar como asistida.");
                return;
            }

            DataGridViewRow fila = dgCitas.SelectedRows[0];

            Cita cita = new Cita()
            {
                idCita = Convert.ToInt32(fila.Cells["idCita"].Value),
                estado = cbEstadoActualizado.Text,
                observacion = rtxtObservacion.Text,
                confirmacionAsistencia = cbAreaActualizada.Text == "Si",
                modifiedBy = usuarioActual.idUsuario
            };

            string mensaje = nCita.ModificarAtencionEspecialista(cita);
            MessageBox.Show(mensaje);

            MostrarData(nCita.ListarPorCaso(nroCaso));
            dgCitas.ClearSelection();
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            if (dgCitas.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar");
                return;
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Archivo CSV (.csv)|.csv";
            save.FileName = "Citas.csv";

            if (save.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();

                foreach (DataGridViewColumn columna in dgCitas.Columns)
                {
                    if (columna.Visible)
                    {
                        sb.Append(columna.HeaderText + ";");
                    }
                }

                sb.AppendLine();

                foreach (DataGridViewRow fila in dgCitas.Rows)
                {
                    if (!fila.IsNewRow)
                    {
                        foreach (DataGridViewCell celda in fila.Cells)
                        {
                            if (dgCitas.Columns[celda.ColumnIndex].Visible)
                            {
                                sb.Append((celda.Value != null ? celda.Value.ToString() : "") + ";");
                            }
                        }

                        sb.AppendLine();
                    }
                }

                File.WriteAllText(save.FileName, sb.ToString(), Encoding.UTF8);
                MessageBox.Show("Citas exportadas correctamente");
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgCitas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgCitas.SelectedRows.Count > 0)
            {
                var fila = dgCitas.SelectedRows[0];

                if (fila.Cells["estado"].Value != null)
                {
                    cbEstadoActualizado.Text = fila.Cells["estado"].Value.ToString();
                }

                if (fila.Cells["confirmacionAsistencia"].Value != null)
                {
                    bool asistencia = Convert.ToBoolean(fila.Cells["confirmacionAsistencia"].Value);

                    if (asistencia == true)
                    {
                        cbAreaActualizada.Text = "Si";
                    }
                    else
                    {
                        cbAreaActualizada.Text = "No";
                    }
                }

                if (fila.Cells["observacion"].Value != null)
                {
                    rtxtObservacion.Text = fila.Cells["observacion"].Value.ToString();
                }
                else
                {
                    rtxtObservacion.Text = "";
                }
            }
        }

        private void cbEstadoActualizado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEstadoActualizado.Text == "Cancelado")
            {
                cbAreaActualizada.Text = "No";
                cbAreaActualizada.Enabled = false;
            }
            else if (cbEstadoActualizado.Text == "Atendido")
            {
                cbAreaActualizada.Text = "Si";
                cbAreaActualizada.Enabled = false;
            }
            else
            {
                cbAreaActualizada.Enabled = true;
            }
        }
    }
}