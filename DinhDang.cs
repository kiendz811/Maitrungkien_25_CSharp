﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maitrungkien_25_CSharp
{
    public partial class DinhDang : Form
    {
        public DinhDang()
        {
            InitializeComponent();
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            txtLapTrinh.ForeColor = Color.Red;
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            txtLapTrinh.Text = txtNhapTen.Text;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            txtLapTrinh.ForeColor = Color.LimeGreen;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            txtLapTrinh.ForeColor = Color.Blue;
        }

        private void lblLapTrinh_CheckedChanged(object sender, EventArgs e)
        {
            txtLapTrinh.ForeColor = Color.Black;
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            txtLapTrinh.Font = new Font(txtLapTrinh.Font.Name, txtLapTrinh.Font.Size, txtLapTrinh.Font.Style ^ FontStyle.Bold);
        }

        private void chkitalic_CheckedChanged(object sender, EventArgs e)
        {
            txtLapTrinh.Font = new Font(txtLapTrinh.Font.Name, txtLapTrinh.Font.Size, txtLapTrinh.Font.Style ^ FontStyle.Italic);
        }

        private void chkunderline_CheckedChanged(object sender, EventArgs e)
        {
            txtLapTrinh.Font = new Font(txtLapTrinh.Font.Name, txtLapTrinh.Font.Size, txtLapTrinh.Font.Style ^ FontStyle.Underline);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    
    

