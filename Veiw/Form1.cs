using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace call_woter
{
    public partial class Form1 : Form
    {
        private RadioButton rb_m;
        private RadioButton rb_w;
        private Label txt_v;
        private NumericUpDown weight;
        private Label txt_live;
        private ComboBox comboBox1;
        private Button go;
        public Form1()
        {
            InitializeComponent();
            rb_m.Checked = true;
            rb_m.Tag = "Мужской";
            rb_w.Tag = "Женский";
            weight.Value = 30;
            weight.Maximum = 200;
            weight.Minimum = 30;
            go.Click += Go_Click;
            comboBox1.Items.AddRange(new string[] { "Спотсмен", "Домосед", "Леньтяюга" });
            comboBox1.SelectedIndex = 0;
        }

        private void Go_Click(object sender, EventArgs e)
        {
            
        }
    }
}
