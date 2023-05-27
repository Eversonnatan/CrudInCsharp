using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AcessoBD
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnPesquisaCli_Click(object sender, EventArgs e)
        {
            MySqlCommand dmc = new MySqlCommand();
            dmc.CommandText = String.Format("SELECT * FROM clientes WHERE codigo = {0}",
                txtcodigoCli.Text);
            dmc.CommandType = CommandType.Text;
            dmc.Connection = Conexao.abreConexao();
            MySqlDataReader br;
            try
            {
                br = dmc.ExecuteReader();
                if (br.Read())
                {
                    txtcodigoCli.Text = br["codigo"].ToString();
                    txtnomeCli.Text = br["nome"].ToString();
                    txtSexo.Text = br["sexo"].ToString();
                }
                br.Close();
                dmc.Dispose();
            }
            catch (MySqlException ex)

            {
                MessageBox.Show(ex.Message);
                
            }
            finally
            {
                Conexao.fechaConexao();
            }
        }
    }
}
