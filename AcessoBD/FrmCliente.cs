﻿using System;
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
        #region Métdo modifica (para DELETE , UPDATE e INSERT)
        private void modifica(string sql)
        {
            MySqlCommand dmc = new MySqlCommand();
            dmc.CommandText = sql;
            dmc.CommandType = CommandType.Text;
            dmc.Connection = Conexao.abreConexao();
            try
            {
                //verifica se o usuario deseja executar a ação
                if (MessageBox.Show("Deseja executar esta ação", "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)==
                    DialogResult.Yes)
                {
                    int result = dmc.ExecuteNonQuery();
                    if (result > 0)
                        MessageBox.Show("Ação realizada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Falha ao realizar esta ação!");

                }
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

        #endregion

        #region botão de Pesquisa
        private void Pesquisa (string consulta)
        {
            MySqlCommand dmc = new MySqlCommand();
            dmc.CommandText = consulta;
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
        #endregion

        private void btnapagarCli_Click(object sender, EventArgs e)
        {
            string apaga = string.Format("DELETE FROM clientes  WHERE codigo = {0}",
                txtcodigoCli.Text);
            modifica(apaga);
        }

        private void btnNovocli_Click(object sender, EventArgs e)
        {
            String novo = String.Format(
               "INSERT INTO clientes VALUES({0} ,'{1}','{2}')",
               txtcodigoCli.Text, txtnomeCli.Text, txtSexo.Text );
            modifica(novo);
        }

        private void btnAtualizaCli_Click(object sender, EventArgs e)
        {
            string atualiza = string.Format(
                "UPDATE clientes SET nome = '{0}',sexo ='{1}' WHERE codigo = {2}", 
                txtnomeCli.Text, txtSexo.Text, txtcodigoCli.Text);
            modifica(atualiza);

            
        }

        private void rbtSexoM_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtSexoM.Checked)
            {
                txtSexo.Text = String.Format("M ", rbtSexoM);
            }
        }

        private void txtSexo_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbtSexoF_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtSexoF.Checked)
            {
                txtSexo.Text = String.Format("F ", rbtSexoF);
            }
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            string primeiro =
                String.Format("SELECT * FROM clientes LIMIT 1 ");
            Pesquisa(primeiro);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            String anterior =
            String.Format("SELECT * FROM clientes WHERE codigo < {0} ORDER BY codigo DESC LIMIT 1", txtcodigoCli.Text);
            Pesquisa(anterior);
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            string proximo = string.Format(
                "SELECT * FROM clientes WHERE codigo > {0} LIMIT 1", txtcodigoCli.Text);
            Pesquisa(proximo);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            string ultimo = String.Format("SELECT * FROM clientes ORDER BY codigo DESC LIMIT 1");
            Pesquisa(ultimo);
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            string primeiro =
                String.Format("SELECT * FROM clientes LIMIT 1");
            Pesquisa(primeiro);
        }
    }
}
