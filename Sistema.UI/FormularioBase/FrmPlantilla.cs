﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.UI.FormularioBase
{
    public partial class FrmPlantilla : Form
    {
        public FrmPlantilla()
        {
            InitializeComponent();
        }

        protected virtual void transferirDatosCajasTexto(DataGridViewCellEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
