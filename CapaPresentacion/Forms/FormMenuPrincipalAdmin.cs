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
    public partial class FormMenuPrincipalAdmin : Form
    {
        private Usuario usuarioActual;
        private NCita nCita = new NCita();
        private List<int> citasNotificadas = new List<int>();

        public FormMenuPrincipalAdmin(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioActual = usuario;
        }

        private void AbrirFormEnPanel(Form formHijo)
        {
            pnlFormularios.Controls.Clear();

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            pnlFormularios.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void pnlInicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormInicio(usuarioActual));
        }

        private void pnlUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormMenuRegistroUsuarios(usuarioActual));
        }

        private void pnlClientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormRegistrarBuscarClientes(usuarioActual));
        }

        private void pnlRegistrarCasosCitas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormRegistrarCaso(1, usuarioActual.idUsuario));
        }

        private void pnlReportes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormReportes());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerRecordatorio_Tick(object sender, EventArgs e)
        {
            List<Cita> citas = nCita.ListarCitasConRecordatorio();

            foreach (Cita cita in citas)
            {
                DateTime fechaHoraCita = cita.fecha.Date.Add(cita.horaInicio);

                DateTime fechaHoraRecordatorio = fechaHoraCita.AddMinutes(-Convert.ToInt32(cita.tiempoAnticipacion));

                if (DateTime.Now >= fechaHoraRecordatorio
                    && DateTime.Now < fechaHoraCita
                    && !citasNotificadas.Contains(cita.idCita))
                {
                    MessageBox.Show(
                        "Tiene una cita próxima.\n\n" +
                        "Fecha: " + cita.fecha.ToString("dd/MM/yyyy") + "\n" +
                        "Hora: " + cita.horaInicio.ToString() + "\n" +
                        "Modalidad: " + cita.modalidad + "\n" +
                        "Anticipación: " + cita.tiempoAnticipacion.ToString() + " minutos",
                        "Recordatorio de cita",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    citasNotificadas.Add(cita.idCita);
                }
            }
        }
    }
}
