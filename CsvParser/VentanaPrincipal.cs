using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsvParser
{
    public partial class VentanaPrincipal : Form
    {
        DataTable dt = new DataTable();
        
        public VentanaPrincipal()
        {
            InitializeComponent();
            this.listaCampos.MouseDoubleClick += new MouseEventHandler(listaCampos_MouseDoubleClick);
        }

        private void listaCampos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listaCampos.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                PasardeListadeCamposaColumna();
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            var path = GetPathofFileAndOpenDialog();
            if (!CheckIfItIsaValidPath(path)) return;
            var allRegisters = GetWholeRegistersFromFile(path);
            var listaDataCampos = GetListDataFromNormalCsvRegister(allRegisters);

            var lista = new List<string>();
            foreach (var dataCampo in listaDataCampos)
            {
                lista.Add(dataCampo);
                if (lista.Count != dt.Columns.Count) continue;
                dt.Rows.Add(lista.ToArray());
                lista.Clear();
            }
            
            tablaGrid.DataSource = dt;
            //foreach (var registro in listaRegistros)
            //{
            //    var listaDataPorRegistro = GetListDataFromNormalCsvRegister(registro);
            //    for (var i = 0; i < tablaGrid.ColumnCount; i++)
            //    {
            //        var row = (DataGridViewRow)tablaGrid.Rows[i];
            //        row.Cells[i].Value = listaDataPorRegistro.ElementAt(i);
            //        tablaGrid.Rows.Add(row);
            //    }
            //}
        }

        protected List<string> GetListDataFromNormalCsvRegister(string register)
        {
            return register.Split(',').ToList();
        }
        protected List<string> GetRegistersFromFile(string path)
        {
            return System.IO.File.ReadAllLines(path).ToList();
        }

        protected string GetWholeRegistersFromFile(string path)
        {
           return System.IO.File.ReadAllText(path);
        }
        protected string GetPathofFileAndOpenDialog()
        {
            var path ="";
            if (openFileWindow.ShowDialog() == DialogResult.OK)
            {
                path = openFileWindow.FileName;
            }
            return path;
        }

        private static bool CheckIfItIsaValidPath(string path)
        {
            return !string.IsNullOrEmpty(path);
        }

        private void btnAgregarCampo_Click(object sender, EventArgs e)
        {
            if (txtBoxAgregarCampo.Text == "") return;
            listaCampos.Items.Add(txtBoxAgregarCampo.Text);
            btnImportar.Enabled = true;
            txtBoxAgregarCampo.Clear();
        }

        private void btnPasarColumna_Click(object sender, EventArgs e)
        {
           PasardeListadeCamposaColumna();
        }

        private void tablaGrid_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var columnIndex = tablaGrid.CurrentCellAddress.X;
            listaCampos.Items.Add(tablaGrid.Columns[columnIndex].Name);
            dt.Columns.RemoveAt(columnIndex);
            tablaGrid.DataSource = dt;
        }

        protected void PasardeListadeCamposaColumna()
        {
            var item = listaCampos.SelectedItem;
            dt.Columns.Add(new DataColumn(item as string, typeof(string)));
            tablaGrid.DataSource = dt;
            listaCampos.Items.Remove(item);
        }

    }
}
