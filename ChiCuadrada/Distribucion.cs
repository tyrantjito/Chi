using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChiCuadrada
{
    public partial class Distribucion : Form
    {
        public Distribucion(string distribucion)
        {
            InitializeComponent();
            string leer = "";
            StreamReader distri = new StreamReader(distribucion);
            while ((leer = distri.ReadLine()) != null){
                string[] sepa = leer.Split(',');
                dgvDistribucion.ColumnCount = sepa.Length;
                dgvDistribucion.Rows.Add(sepa);
            }
        }
    }
}
