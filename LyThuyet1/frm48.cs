﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LyThuyet1
{
    public partial class frm48 : Form
    {
        public frm48()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(this.cboNgoaiNgu.SelectedItem.ToString());
        }

        private void frm48_Load(object sender, EventArgs e)
        {
            string[] datas = { "Tiếng Anh", "Tiếng Pháp", "Tiếng Nhật" };
            this.cboNgoaiNgu.DataSource = datas;
        }
    }
}
