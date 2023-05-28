
namespace AcessoBD
{
    partial class FrmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodigoCli = new System.Windows.Forms.Label();
            this.lblNomeCli = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtcodigoCli = new System.Windows.Forms.TextBox();
            this.txtnomeCli = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.BtnPesquisaCli = new System.Windows.Forms.Button();
            this.btnAtualizaCli = new System.Windows.Forms.Button();
            this.btnNovocli = new System.Windows.Forms.Button();
            this.btnapagarCli = new System.Windows.Forms.Button();
            this.rbtSexoM = new System.Windows.Forms.RadioButton();
            this.rbtSexoF = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblCodigoCli
            // 
            this.lblCodigoCli.AutoSize = true;
            this.lblCodigoCli.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCli.Location = new System.Drawing.Point(18, 31);
            this.lblCodigoCli.Name = "lblCodigoCli";
            this.lblCodigoCli.Size = new System.Drawing.Size(60, 19);
            this.lblCodigoCli.TabIndex = 0;
            this.lblCodigoCli.Text = "Código:";
            // 
            // lblNomeCli
            // 
            this.lblNomeCli.AutoSize = true;
            this.lblNomeCli.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCli.Location = new System.Drawing.Point(18, 108);
            this.lblNomeCli.Name = "lblNomeCli";
            this.lblNomeCli.Size = new System.Drawing.Size(50, 19);
            this.lblNomeCli.TabIndex = 1;
            this.lblNomeCli.Text = "Nome";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(19, 166);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(41, 19);
            this.lblSexo.TabIndex = 2;
            this.lblSexo.Text = "Sexo";
            // 
            // txtcodigoCli
            // 
            this.txtcodigoCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigoCli.Location = new System.Drawing.Point(12, 53);
            this.txtcodigoCli.Name = "txtcodigoCli";
            this.txtcodigoCli.Size = new System.Drawing.Size(100, 22);
            this.txtcodigoCli.TabIndex = 3;
            // 
            // txtnomeCli
            // 
            this.txtnomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomeCli.Location = new System.Drawing.Point(12, 139);
            this.txtnomeCli.Name = "txtnomeCli";
            this.txtnomeCli.Size = new System.Drawing.Size(132, 24);
            this.txtnomeCli.TabIndex = 4;
            // 
            // txtSexo
            // 
            this.txtSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSexo.Location = new System.Drawing.Point(4, 213);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(129, 22);
            this.txtSexo.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::AcessoBD.Properties.Resources.exit;
            this.btnExit.Location = new System.Drawing.Point(311, -3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(67, 78);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "&Sair";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // BtnPesquisaCli
            // 
            this.BtnPesquisaCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesquisaCli.Image = global::AcessoBD.Properties.Resources.search;
            this.BtnPesquisaCli.Location = new System.Drawing.Point(301, 254);
            this.BtnPesquisaCli.Name = "BtnPesquisaCli";
            this.BtnPesquisaCli.Size = new System.Drawing.Size(89, 79);
            this.BtnPesquisaCli.TabIndex = 7;
            this.BtnPesquisaCli.Text = "&Pesquisar";
            this.BtnPesquisaCli.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPesquisaCli.UseVisualStyleBackColor = true;
            this.BtnPesquisaCli.Click += new System.EventHandler(this.BtnPesquisaCli_Click);
            // 
            // btnAtualizaCli
            // 
            this.btnAtualizaCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizaCli.Image = global::AcessoBD.Properties.Resources.atualizar;
            this.btnAtualizaCli.Location = new System.Drawing.Point(4, 254);
            this.btnAtualizaCli.Name = "btnAtualizaCli";
            this.btnAtualizaCli.Size = new System.Drawing.Size(89, 79);
            this.btnAtualizaCli.TabIndex = 8;
            this.btnAtualizaCli.Text = "At&ualizar";
            this.btnAtualizaCli.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAtualizaCli.UseVisualStyleBackColor = true;
            this.btnAtualizaCli.Click += new System.EventHandler(this.btnAtualizaCli_Click);
            // 
            // btnNovocli
            // 
            this.btnNovocli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovocli.Image = global::AcessoBD.Properties.Resources.adicionar;
            this.btnNovocli.Location = new System.Drawing.Point(95, 254);
            this.btnNovocli.Name = "btnNovocli";
            this.btnNovocli.Size = new System.Drawing.Size(89, 79);
            this.btnNovocli.TabIndex = 9;
            this.btnNovocli.Text = "&Adicionar";
            this.btnNovocli.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovocli.UseVisualStyleBackColor = true;
            this.btnNovocli.Click += new System.EventHandler(this.btnNovocli_Click);
            // 
            // btnapagarCli
            // 
            this.btnapagarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnapagarCli.Image = global::AcessoBD.Properties.Resources.erase;
            this.btnapagarCli.Location = new System.Drawing.Point(206, 254);
            this.btnapagarCli.Name = "btnapagarCli";
            this.btnapagarCli.Size = new System.Drawing.Size(89, 79);
            this.btnapagarCli.TabIndex = 10;
            this.btnapagarCli.Text = "&Apagar";
            this.btnapagarCli.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnapagarCli.UseVisualStyleBackColor = true;
            this.btnapagarCli.Click += new System.EventHandler(this.btnapagarCli_Click);
            // 
            // rbtSexoM
            // 
            this.rbtSexoM.AutoSize = true;
            this.rbtSexoM.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtSexoM.Location = new System.Drawing.Point(12, 188);
            this.rbtSexoM.Name = "rbtSexoM";
            this.rbtSexoM.Size = new System.Drawing.Size(79, 19);
            this.rbtSexoM.TabIndex = 11;
            this.rbtSexoM.TabStop = true;
            this.rbtSexoM.Text = "Masculino";
            this.rbtSexoM.UseVisualStyleBackColor = true;
            this.rbtSexoM.CheckedChanged += new System.EventHandler(this.rbtSexoM_CheckedChanged);
            // 
            // rbtSexoF
            // 
            this.rbtSexoF.AutoSize = true;
            this.rbtSexoF.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtSexoF.Location = new System.Drawing.Point(108, 188);
            this.rbtSexoF.Name = "rbtSexoF";
            this.rbtSexoF.Size = new System.Drawing.Size(76, 19);
            this.rbtSexoF.TabIndex = 12;
            this.rbtSexoF.TabStop = true;
            this.rbtSexoF.Text = "Feminino";
            this.rbtSexoF.UseVisualStyleBackColor = true;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 332);
            this.Controls.Add(this.rbtSexoF);
            this.Controls.Add(this.rbtSexoM);
            this.Controls.Add(this.btnapagarCli);
            this.Controls.Add(this.btnNovocli);
            this.Controls.Add(this.btnAtualizaCli);
            this.Controls.Add(this.BtnPesquisaCli);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtnomeCli);
            this.Controls.Add(this.txtcodigoCli);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblNomeCli);
            this.Controls.Add(this.lblCodigoCli);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoCli;
        private System.Windows.Forms.Label lblNomeCli;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtcodigoCli;
        private System.Windows.Forms.TextBox txtnomeCli;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button BtnPesquisaCli;
        private System.Windows.Forms.Button btnAtualizaCli;
        private System.Windows.Forms.Button btnNovocli;
        private System.Windows.Forms.Button btnapagarCli;
        private System.Windows.Forms.RadioButton rbtSexoM;
        private System.Windows.Forms.RadioButton rbtSexoF;
    }
}