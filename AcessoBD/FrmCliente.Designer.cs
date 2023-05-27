
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
            this.SuspendLayout();
            // 
            // lblCodigoCli
            // 
            this.lblCodigoCli.AutoSize = true;
            this.lblCodigoCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCli.Location = new System.Drawing.Point(-4, 59);
            this.lblCodigoCli.Name = "lblCodigoCli";
            this.lblCodigoCli.Size = new System.Drawing.Size(62, 16);
            this.lblCodigoCli.TabIndex = 0;
            this.lblCodigoCli.Text = "Código:";
            // 
            // lblNomeCli
            // 
            this.lblNomeCli.AutoSize = true;
            this.lblNomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCli.Location = new System.Drawing.Point(0, 159);
            this.lblNomeCli.Name = "lblNomeCli";
            this.lblNomeCli.Size = new System.Drawing.Size(49, 16);
            this.lblNomeCli.TabIndex = 1;
            this.lblNomeCli.Text = "Nome";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(-4, 288);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(43, 16);
            this.lblSexo.TabIndex = 2;
            this.lblSexo.Text = "Sexo";
            // 
            // txtcodigoCli
            // 
            this.txtcodigoCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigoCli.Location = new System.Drawing.Point(3, 87);
            this.txtcodigoCli.Name = "txtcodigoCli";
            this.txtcodigoCli.Size = new System.Drawing.Size(100, 22);
            this.txtcodigoCli.TabIndex = 3;
            // 
            // txtnomeCli
            // 
            this.txtnomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomeCli.Location = new System.Drawing.Point(3, 196);
            this.txtnomeCli.Name = "txtnomeCli";
            this.txtnomeCli.Size = new System.Drawing.Size(132, 24);
            this.txtnomeCli.TabIndex = 4;
            // 
            // txtSexo
            // 
            this.txtSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSexo.Location = new System.Drawing.Point(3, 307);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(100, 22);
            this.txtSexo.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::AcessoBD.Properties.Resources.exit;
            this.btnExit.Location = new System.Drawing.Point(342, -3);
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
            this.BtnPesquisaCli.Location = new System.Drawing.Point(320, 339);
            this.BtnPesquisaCli.Name = "BtnPesquisaCli";
            this.BtnPesquisaCli.Size = new System.Drawing.Size(89, 79);
            this.BtnPesquisaCli.TabIndex = 7;
            this.BtnPesquisaCli.Text = "&Pesquisar";
            this.BtnPesquisaCli.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPesquisaCli.UseVisualStyleBackColor = true;
            this.BtnPesquisaCli.Click += new System.EventHandler(this.BtnPesquisaCli_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 417);
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
    }
}