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

namespace CapaPresentacion.Forms
{
    public partial class FormEspecialistaInicio : Form
    {
        private Usuario usuarioActual;
        private NEspecialista nEspecialista = new NEspecialista();
        private NCaso nCaso = new NCaso();
        private NCita nCita = new NCita();
        public FormEspecialistaInicio(Usuario usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
            lblAreaAsignada.Text = nEspecialista.BuscarAreaEspecialista(usuarioActual.idUsuario);
            lblEspecialista.Text = $"{usuarioActual.nombre} {usuarioActual.apellido}";
            lblNumCasosHoy.Text = nCita.ContarCitasHoy(usuarioActual.idUsuario).ToString();
            lblNumClientesAsignados.Text = nEspecialista.ContarClientesAsignados(usuarioActual.idUsuario).ToString();
            lblCasosActivos.Text = nCaso.ContarCasosActivos(usuarioActual.idUsuario).ToString();
            lblNumCasosCerrados.Text =  nCaso.ContarCasosCerrados(usuarioActual.idUsuario).ToString();
            MostrarData(nCita.ListarCitasPendientesPorEspecialista(usuarioActual.idUsuario));
        }
        private void MostrarData<t>(List<t> lista)
        {
            dgProxCitas.DataSource = null;
            if(lista.Count > 0)
            {
                dgProxCitas.DataSource = lista;
            }
        }

        
    }
}
