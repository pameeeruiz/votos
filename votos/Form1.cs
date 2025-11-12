using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace votos
{
    public partial class Form1 : Form
    {
        Acciones acci = new Acciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = new BindingSource(acci.estadosiniciales, null);
            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";

            dgvRepublicanos.Columns.Add("Estado", "Estado");
            dgvRepublicanos.Columns.Add("Puntos", "Puntos");
            dgvDemocratas.Columns.Add("Estado", "Estado");
            dgvDemocratas.Columns.Add("Puntos", "Puntos");
        }

        private void btnAgregarR_Click(object sender, EventArgs e)
        {
            try
            {
                int totalR = acci.totalVotosRepublicanos();

                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Selecciona un estado");
                    return;
                }

                if (totalR >= 270)
                {
                    MessageBox.Show("🎉 ¡Los Republicanos han ganado con " + totalR + " votos!");
                    bloquearbotones();
                    return;
                }

                string estado = ((KeyValuePair<string, int>)comboBox1.SelectedItem).Key;
                int puntos = ((KeyValuePair<string, int>)comboBox1.SelectedItem).Value;

                bool agregado = acci.agregarRepublicanos(estado, puntos);

                if (agregado)
                {
                    comboBox1.DataSource = new BindingSource(acci.estadosiniciales, null);
                    ActualizarGridRepublicanos();
                }
                else
                {
                    MessageBox.Show("Error al agregar estado.");
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error : " + ex.Message);
            }
        }

        private void ActualizarGridDemocratas()
        {
            dgvDemocratas.Rows.Clear();
            foreach (var item in acci.MostrarDemocratas())
            {
                dgvDemocratas.Rows.Add(item.Key, item.Value);
            }
        }
        private void ActualizarGridRepublicanos()
        {
            dgvRepublicanos.Rows.Clear();
            foreach (var item in acci.MostrarRepublicanos())
            {
                dgvRepublicanos.Rows.Add(item.Key, item.Value);
            }
        }

        private void bloquearbotones()
        {
            btnAgregarR.Enabled = false;
            btnEliminar.Enabled = false;
            btnAgregard.Enabled = false;
            btnEliminard.Enabled = false;
            btnCalcular.Enabled = false;
            comboBox1.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRepublicanos.CurrentRow == null)
                {
                    MessageBox.Show("Selecciona un estado de la tabla Republicanos.");
                    return;
                }

                string estado = dgvRepublicanos.CurrentRow.Cells[0].Value?.ToString();
                int puntos = 0;

                
                if (!int.TryParse(dgvRepublicanos.CurrentRow.Cells[1].Value?.ToString(), out puntos))
                {
                    MessageBox.Show("Error: el valor de puntos no es válido.");
                    return;
                }

                bool eliminado = acci.eliminarRepublicanos(estado, puntos);

                if (eliminado)
                {
                    comboBox1.DataSource = new BindingSource(acci.estadosiniciales, null);
                    ActualizarGridRepublicanos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar estado.");
                }
            }
           
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error .\n" + ex.Message);
            }

        }

        private void btnAgregard_Click(object sender, EventArgs e)
        {
            try
            {
                int totalD = acci.totalVotosDemocratas();

                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Selecciona un estado");
                    return;
                }
                else if (totalD >= 270)
                {
                    MessageBox.Show("🎉 ¡Los Demócratas han ganado con " + totalD + " votos!");
                    bloquearbotones();
                    return;
                }

                string estado = ((KeyValuePair<string, int>)comboBox1.SelectedItem).Key;
                int puntos = ((KeyValuePair<string, int>)comboBox1.SelectedItem).Value;

                

                if (acci.agregarDemocratas(estado, puntos))
                {
                    comboBox1.DataSource = new BindingSource(acci.estadosiniciales, null);
                    ActualizarGridDemocratas();
                }
                else
                {
                    MessageBox.Show("Error al agregar estado.");
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error .\n" + ex.Message);
            }

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int totalRep = acci.MostrarRepublicanos().Sum(x => x.Value);
                int totalDem = acci.MostrarDemocratas().Sum(x => x.Value);

                string resultado;

                if (totalRep >= 270)
                {
                    resultado = $"🏆 ¡Republicanos ganan con {totalRep} votos!";
                    btnAgregarR.Enabled = false;
                    btnAgregard.Enabled = false;
                    btnCalcular.Enabled = false;
                }
                else if (totalDem >= 270)
                {
                    resultado = $"🏆 ¡Demócratas ganan con {totalDem} votos!";
                    btnAgregarR.Enabled = false;
                    btnAgregard.Enabled = false;
                    btnCalcular.Enabled = false;
                }
                else
                {
                    resultado = $"Republicanos: {totalRep} | Demócratas: {totalDem}";
                }

                MessageBox.Show(resultado);
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error .\n" + ex.Message);
            }

        }

        private void btnEliminard_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDemocratas.CurrentRow == null)
                {
                    MessageBox.Show("Selecciona un estado de la tabla Demócratas.");
                    return;
                }

                string estado = dgvDemocratas.CurrentRow.Cells[0].Value?.ToString();
                int puntos = int.Parse(dgvDemocratas.CurrentRow.Cells[1].Value.ToString()); 

                // Validar que el valor pueda convertirse correctamente a entero
                if (!int.TryParse(dgvDemocratas.CurrentRow.Cells[1].Value?.ToString(), out puntos))
                {
                    MessageBox.Show("Error: el valor de puntos no es válido.");
                    return;
                }

            

                if (acci.eliminarDemocratas(estado, puntos))
                {
                    comboBox1.DataSource = new BindingSource(acci.estadosiniciales, null);
                    ActualizarGridDemocratas();
                }
                else
                {
                    MessageBox.Show("Error al eliminar estado.");
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error .\n" + ex.Message);
            }

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            acci = new Acciones();
            dgvRepublicanos.Rows.Clear();
            dgvDemocratas.Rows.Clear();


            btnAgregarR.Enabled = true;
            btnAgregard.Enabled = true;
            btnEliminar.Enabled = true;
            btnEliminard.Enabled = true;
            btnCalcular.Enabled = true;
            comboBox1.Enabled = true;
        }
    }
}
