using CSharpSTO.Controllers;
using CSharpSTO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpSTO
{
    public partial class Form1 : Form
    {
        private BindingList<Master> masters;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (DatabaseController dbc = new DatabaseController())
            {
                masters = new BindingList<Master>(dbc.GetMasters());
                BindingSource bs = new BindingSource();
                bs.DataSource = masters;
                bs.AddingNew += Bs_AddingNew;
                bs.AllowNew = true;

                dataGridViewMasters.DataSource = bs;
            }

            dataGridViewMasters.Columns["Id"].ReadOnly = true;
        }

        private void Bs_AddingNew(object sender, AddingNewEventArgs e)
        {
            int id = masters.Max(x => x.Id);
            e.NewObject = new Master(++id, "", "", "", "", "");
        }

        private void ButtonSaveChangesMaster_Click(object sender, EventArgs e)
        {
            bool flag = false;
            for (int i = 0; i < dataGridViewMasters.Rows.Count-1; i++)
            {
                for (int j = 1; j < dataGridViewMasters.Columns.Count; j++)
                {
                    if (string.IsNullOrWhiteSpace((string)dataGridViewMasters.Rows[i].Cells[j].Value))
                    {
                        flag = true;
                    }
                }
            }

            if (flag)
            {
                MessageBox.Show("Все ячейки должны быть заполнены!");
            }
            else
            {

            }
        }
    }
}
