using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Colecciones_Botones
{
  public partial class frmBotonesColecciones : Form
  {
    public frmBotonesColecciones()
    {
      InitializeComponent();
    }

    private void frmBotonesColecciones_Load(object sender, EventArgs e)
    {
      lstDatos1.Items.Clear();
      lstDatos2.Items.Clear();

      txtDato.Focus();
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
      if (txtDato.Text == "") MessageBox.Show("Ingrese un dato antes de agregarlo!");
      else
      {
        lstDatos1.Items.Add(txtDato.Text);
        txtDato.Text = "";
        txtDato.Focus();
      }
    }

    private void txtDato_KeyDown(object sender, KeyEventArgs e)
    {
      {
        if (e.KeyCode == Keys.Enter) btnAgregar.PerformClick();
      }
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (lstDatos1.SelectedIndex < 0 && lstDatos2.SelectedIndex < 0) MessageBox.Show("No hay ningun item seleccionado. Seleccione un item para borrar");
      if (lstDatos1.SelectedIndex >= 0) lstDatos1.Items.Remove(lstDatos1.SelectedItem);
      if (lstDatos2.SelectedIndex >= 0) lstDatos2.Items.Remove(lstDatos2.SelectedItem);
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      if (lstDatos1.Items.Count == 0 && lstDatos2.Items.Count == 0) MessageBox.Show("Las listas estan vacias, no hay items para eliminar");
      if (lstDatos1.Items.Count > 0) lstDatos1.Items.Clear();
      if (lstDatos2.Items.Count > 0) lstDatos2.Items.Clear();
    }

    private void btnTodosDerecha_Click(object sender, EventArgs e)
    {
      if (lstDatos1.SelectedIndex >= 0)
      {
        lstDatos2.Items.AddRange(lstDatos1.Items);
        lstDatos1.Items.Clear();
      }
      else
      {
        MessageBox.Show("No hay ningun item seleccionado para mover");
      }
    }

    private void btnTodosIzquierda_Click(object sender, EventArgs e)
    {
      if (lstDatos2.SelectedIndex >= 0)
      {
        lstDatos1.Items.AddRange(lstDatos2.Items);
        lstDatos2.Items.Clear();
      }
      else
      {
        MessageBox.Show("No hay ningun item seleccionado para mover");
      }
    }

    private void btnSelectDerecha_Click(object sender, EventArgs e)
    {
      if (lstDatos1.SelectedIndex >= 0)
      {
        lstDatos2.Items.Add(lstDatos1.SelectedItem);
        lstDatos1.Items.Remove(lstDatos1.SelectedItem);
      }
      else
      {
        MessageBox.Show("No hay ningun item seleccionado para mover");
      }
    }

    private void btnSelectIzquierda_Click(object sender, EventArgs e)
    {
      if (lstDatos2.SelectedIndex >= 0)
      {
        lstDatos1.Items.Add(lstDatos2.SelectedItem);
        lstDatos2.Items.Remove(lstDatos2.SelectedItem);
      }
      else
      {
        MessageBox.Show("No hay ningun item seleccionado para mover");
      }
    }
  }
}