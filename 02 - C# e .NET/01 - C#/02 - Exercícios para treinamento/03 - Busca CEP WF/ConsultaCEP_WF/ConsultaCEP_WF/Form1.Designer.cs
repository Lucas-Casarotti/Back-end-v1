
namespace ConsultaCEP_WF
{
    partial class BuscaCEP
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbConsulta = new System.Windows.Forms.GroupBox();
            this.grbResultado = new System.Windows.Forms.GroupBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblInformacoes = new System.Windows.Forms.Label();
            this.grbConsulta.SuspendLayout();
            this.grbResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbConsulta
            // 
            this.grbConsulta.Controls.Add(this.lblInformacoes);
            this.grbConsulta.Controls.Add(this.btnConsultar);
            this.grbConsulta.Controls.Add(this.txtCep);
            this.grbConsulta.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbConsulta.Location = new System.Drawing.Point(12, 12);
            this.grbConsulta.Name = "grbConsulta";
            this.grbConsulta.Size = new System.Drawing.Size(354, 112);
            this.grbConsulta.TabIndex = 0;
            this.grbConsulta.TabStop = false;
            this.grbConsulta.Text = "Consulta";
            // 
            // grbResultado
            // 
            this.grbResultado.Controls.Add(this.txtEstado);
            this.grbResultado.Controls.Add(this.txtCidade);
            this.grbResultado.Controls.Add(this.txtBairro);
            this.grbResultado.Controls.Add(this.txtComplemento);
            this.grbResultado.Controls.Add(this.txtEndereco);
            this.grbResultado.Controls.Add(this.lblEstado);
            this.grbResultado.Controls.Add(this.lblCidade);
            this.grbResultado.Controls.Add(this.lblBairro);
            this.grbResultado.Controls.Add(this.lblComplemento);
            this.grbResultado.Controls.Add(this.lblEndereco);
            this.grbResultado.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbResultado.Location = new System.Drawing.Point(12, 130);
            this.grbResultado.Name = "grbResultado";
            this.grbResultado.Size = new System.Drawing.Size(354, 203);
            this.grbResultado.TabIndex = 1;
            this.grbResultado.TabStop = false;
            this.grbResultado.Text = "Resultado";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(36, 44);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(92, 26);
            this.txtCep.TabIndex = 0;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(197, 44);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(92, 26);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(32, 33);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(83, 22);
            this.lblEndereco.TabIndex = 0;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(32, 64);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(115, 22);
            this.lblComplemento.TabIndex = 1;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(32, 97);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(59, 22);
            this.lblBairro.TabIndex = 2;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(32, 128);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(66, 22);
            this.lblCidade.TabIndex = 3;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(32, 164);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(63, 22);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(146, 25);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(192, 26);
            this.txtEndereco.TabIndex = 5;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Enabled = false;
            this.txtComplemento.Location = new System.Drawing.Point(146, 57);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(192, 26);
            this.txtComplemento.TabIndex = 6;
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(146, 93);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(192, 26);
            this.txtBairro.TabIndex = 7;
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(146, 124);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(192, 26);
            this.txtCidade.TabIndex = 8;
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(146, 156);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(192, 26);
            this.txtEstado.TabIndex = 9;
            // 
            // lblInformacoes
            // 
            this.lblInformacoes.AutoSize = true;
            this.lblInformacoes.ForeColor = System.Drawing.Color.Red;
            this.lblInformacoes.Location = new System.Drawing.Point(32, 73);
            this.lblInformacoes.Name = "lblInformacoes";
            this.lblInformacoes.Size = new System.Drawing.Size(112, 22);
            this.lblInformacoes.TabIndex = 2;
            this.lblInformacoes.Text = "Digite um CEP";
            // 
            // BuscaCEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 345);
            this.Controls.Add(this.grbResultado);
            this.Controls.Add(this.grbConsulta);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Name = "BuscaCEP";
            this.Text = "Consulta CEP";
            this.grbConsulta.ResumeLayout(false);
            this.grbConsulta.PerformLayout();
            this.grbResultado.ResumeLayout(false);
            this.grbResultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbConsulta;
        private System.Windows.Forms.GroupBox grbResultado;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblInformacoes;
    }
}

