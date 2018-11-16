using HHBotLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HHBot42
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        HHModel m = new HHModel();
        

        private void button1_Click(object sender, EventArgs e)
        {
            string r = m.WEbClientGet("http://api.hh.ru/vacancies?text=Программист");
            
            ResBox.Text = "" + r;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string r = m.WEbClientGet("http://api.hh.ru/vacancies?text=Программист");
            string rp = m.JsonParseStringMany(r);
            ResBox.Text = "" + rp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string r = m.WEbClientGet("http://api.hh.ru/vacancies?text=Программист");

            List<Work> work = m.JsonParseList(r);
            GridView.Rows.Clear();
            int nr;

            foreach (Work w in work)
            {
                DataGridViewRow row = (DataGridViewRow)GridView.Rows[0].Clone();
                /*row.Cells["ColID"].Value = w.id;
                row.Cells["CName"].Value = w.Name;
                row.Cells["Empl"].Value = w.employer;
                row.Cells["s_from"].Value = w.salary_from;
                row.Cells["s_to"].Value = w.salary_to;
                */
                row.Cells[0].Value = w.id;
                row.Cells[1].Value = w.Name;
                row.Cells[2].Value = w.employer;
                row.Cells[3].Value = w.salary_from;
                row.Cells[4].Value = w.salary_to;
                row.Cells[5].Value = w.info;

                GridView.Rows.Add(row);
                
            }

        }
    }
}
