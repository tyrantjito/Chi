using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChiCuadrada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int NumFilas = 0, NumColum = 0;

        string distro;

        private void abrirCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NumColum = NumFilas = 0;
                OpenFileDialog openFile = new OpenFileDialog();
                dgv1.Rows.Clear();
                openFile.ShowDialog();
                StreamReader leer = new StreamReader(openFile.FileName);
                string leido = "";
                while ((leido = leer.ReadLine()) != null)
                {
                    string[] separados = leido.Split(',');
                    dgv1.ColumnCount = separados.Length;
                    dgv1.Rows.Add(separados);
                    NumColum = separados.Length;
                    NumFilas++;
                }

                openFile.ShowDialog();
                StreamReader leerDistro = new StreamReader(openFile.FileName);
                distro = openFile.FileName;
                while ((leido = leerDistro.ReadLine()) != null)
                {
                    string[] separados = leido.Split(',');
                    DGVDistro.ColumnCount = separados.Length;
                    DGVDistro.Rows.Add(separados);
                }

                lblChiCuadrada.Text = "";
                lblGradoLibertad.Text = "";
                button1.Visible = true;
                //MessageBox.Show("Columnas " + NumColum + "\nFilas: " + NumFilas);
            }
            catch (Exception) { }
        }

        List<double> ft;

        private void verDistribucionChi2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Distribucion dist = new Distribucion(distro);
            dist.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int d = 0;
            //MessageBox.Show("Num colm " + DGVDistro.ColumnCount);
            for (int i = 1; i <DGVDistro.ColumnCount; i++){
                if (DGVDistro.Rows[0].Cells[i].Value.ToString() == comboBox1.Text){
                    d = i;
                    break;
                }
            }
            //MessageBox.Show(DGVDistro.Rows[libertad].Cells[d].Value.ToString());
        }
        int libertad;

        private void button1_Click(object sender, EventArgs e)
        {
            dgv1.Columns.Add(new DataGridViewTextBoxColumn());
            //dgv1.Columns[NumColum].Name = "Total";
            //dgv1.Rows.Add(new DataGridViewRow());
            int suma = 0;
            //dgv1.CurrentRow.Cells[NumColum].Value = "0";
            //dgv1.Rows[0].Cells[NumFilas].Value = "Total";

            for (int i = 1; i < NumColum; i++)
            {
                suma = 0;
                for (int j = 1; j < NumFilas; j++) suma += int.Parse(dgv1.Rows[j].Cells[i].Value.ToString());
                dgv1.Rows[NumFilas].Cells[i].Value = suma;

            }
            int total = 0;
            for (int j = 1; j < NumFilas + 1; j++)
            {
                suma = total = 0;
                for (int i = 1; i < NumColum; i++) suma += int.Parse(dgv1.Rows[j].Cells[i].Value.ToString());
                dgv1.Rows[j].Cells[NumColum].Value = suma;
                total = suma;
            }
            libertad = (NumFilas - 2) * (NumColum - 2);

            //MessageBox.Show("libertad "+libertad+"\ntotal: "+total+"\nFilas: "+NumFilas+"\nColumn: "+NumColum);
            button1.Visible = false;
            double multi = 0.0;
            ft = new List<double>();
            for (int i = 1; i < NumFilas; i++)
            {
                multi = 0.0;
                for (int j = 1; j < NumColum; j++)
                {
                    multi = (int.Parse(dgv1.Rows[i].Cells[NumColum].Value.ToString()) * int.Parse(dgv1.Rows[NumFilas].Cells[j].Value.ToString())) / (double)total;
                    ft.Add(Math.Round(multi, 2));
                    //MessageBox.Show(dgv1.Rows[i].Cells[NumColum].Value.ToString());
                    //MessageBox.Show(dgv1.Rows[NumFilas].Cells[j].Value.ToString());
                    //MessageBox.Show(Math.Round(multi,2).ToString());
                }
            }

            double chi = 0.0;
            int val = 0;
            for (int i = 1; i < NumFilas; i++)
            {
                for (int j = 1; j < NumColum; j++)
                {
                    chi += ((Math.Pow((int.Parse(dgv1.Rows[i].Cells[j].Value.ToString()) - ft[val]), 2)) / ft[val]);
                    val++;

                    //MessageBox.Show(Math.Round(chi,2).ToString());
                    lblChiCuadrada.Text = chi.ToString();
                    lblGradoLibertad.Text = libertad.ToString();
                }
            }
        }
    }
}
