using Newtonsoft.Json;
using primaveraWebApi.config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primaveraWebApi
{
    public partial class Propriedade : Form
    {
        public Propriedade()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Config config = new Config();
            config.datasource = txtDatasource.Text;
            config.usuario = txtNome.Text;
            config.senha = txtSenha.Text;
            using ( StreamWriter file = File.CreateText("config/bd.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, config);
            }

        }
    }
}
