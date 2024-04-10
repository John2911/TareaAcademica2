using TareaAcademica2.entities;
using TareaAcademica2.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaAcademica2
{
    public partial class FormConcesionario : Form
    {
        private ConcesionarioService concesionarioService = new ConcesionarioService();

        public FormConcesionario()
        {
            InitializeComponent();
        }

        private void MostrarConcesionario(List<Concesionario> concesionarios)
        {
            dgConcesionario.DataSource = null;

            if(concesionarios.Count == 0)
            {
                return;
            }
            else
            {
                dgConcesionario.DataSource = concesionarios;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text == "" || tbCliente.Text == "" || tbDireccion.Text == "" || tbMarca.Text == "" || tbPrecio.Text == "" || tbDuracion.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Concesionario con = new Concesionario()
            {
                Codigo = tbCodigo.Text,
                Persona = tbCliente.Text,
                Direccion = tbDireccion.Text,
                Marca = tbMarca.Text,
                Precio = double.Parse(tbPrecio.Text),
                Duracion = int.Parse(tbDuracion.Text)
            };

            bool registrado = concesionarioService.Registrar(con);
            if(!registrado)
            {
                MessageBox.Show("El codigo ya existe");
                return;
            }

            MostrarConcesionario(concesionarioService.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgConcesionario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione registro a eliminar");
                return;
            }

            String codigo = dgConcesionario.SelectedRows[0].Cells[0].Value.ToString();

            concesionarioService.Eliminar(codigo);

            MostrarConcesionario(concesionarioService.ListarTodo());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(tbBuscarMarca.Text == "")
            {
                MessageBox.Show("Ingrese la marca");
                return;
            }

            String marca = tbBuscarMarca.Text;

            MostrarConcesionario(concesionarioService.BuscarPorMarca(marca));
        }
    }
}
