using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED___Programa_23.BusquedaBinaria
{
    public partial class Form1 : Form
    {
        Vector _v;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            _v = new Vector(int.Parse(txtTamaño.Text));
        }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
            _v.llenar(int.Parse(txtLimite.Text));
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            _v.ordenar();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            txtResultado.Text = _v.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int posicion = _v.busquedaBinaria(int.Parse(txtBuscar.Text));
            if (posicion < 0)
            {
                txtResultado.Text = "No se encontró ese número";
                if (posicion == -2)
                    txtResultado.Text += "\r\nEstá fuera del rango de números";
                else
                    txtResultado.Text += "\r\nComparaciones: " + _v.comparaciones.ToString();
            }
            else
                txtResultado.Text = "Encontrado en posición: " + posicion.ToString() + "\r\nComparaciones: " + _v.comparaciones.ToString();
        }
    }
}
