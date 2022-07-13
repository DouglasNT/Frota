
namespace FrotaEmpresa
{
    partial class ConsultarCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarCadastro));
            this.TextoConsultarCadastro = new System.Windows.Forms.Label();
            this.BotaoConsultarMotorista = new System.Windows.Forms.Button();
            this.BotaoConsultarVeiculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextoConsultarCadastro
            // 
            this.TextoConsultarCadastro.AutoSize = true;
            this.TextoConsultarCadastro.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold);
            this.TextoConsultarCadastro.ForeColor = System.Drawing.Color.Navy;
            this.TextoConsultarCadastro.Location = new System.Drawing.Point(163, 22);
            this.TextoConsultarCadastro.Name = "TextoConsultarCadastro";
            this.TextoConsultarCadastro.Size = new System.Drawing.Size(286, 36);
            this.TextoConsultarCadastro.TabIndex = 0;
            this.TextoConsultarCadastro.Text = "Consultar Cadastro";
            // 
            // BotaoConsultarMotorista
            // 
            this.BotaoConsultarMotorista.BackColor = System.Drawing.SystemColors.Control;
            this.BotaoConsultarMotorista.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BotaoConsultarMotorista.FlatAppearance.BorderSize = 2;
            this.BotaoConsultarMotorista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoConsultarMotorista.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.BotaoConsultarMotorista.Location = new System.Drawing.Point(37, 138);
            this.BotaoConsultarMotorista.Name = "BotaoConsultarMotorista";
            this.BotaoConsultarMotorista.Size = new System.Drawing.Size(215, 100);
            this.BotaoConsultarMotorista.TabIndex = 1;
            this.BotaoConsultarMotorista.Text = "Consultar Dados do Motorista";
            this.BotaoConsultarMotorista.UseVisualStyleBackColor = false;
            this.BotaoConsultarMotorista.Click += new System.EventHandler(this.BotaoConsultarMotorista_Click);
            // 
            // BotaoConsultarVeiculo
            // 
            this.BotaoConsultarVeiculo.BackColor = System.Drawing.SystemColors.Control;
            this.BotaoConsultarVeiculo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BotaoConsultarVeiculo.FlatAppearance.BorderSize = 2;
            this.BotaoConsultarVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoConsultarVeiculo.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.BotaoConsultarVeiculo.Location = new System.Drawing.Point(354, 138);
            this.BotaoConsultarVeiculo.Name = "BotaoConsultarVeiculo";
            this.BotaoConsultarVeiculo.Size = new System.Drawing.Size(215, 100);
            this.BotaoConsultarVeiculo.TabIndex = 2;
            this.BotaoConsultarVeiculo.Text = "Consultar Dados do Veículo";
            this.BotaoConsultarVeiculo.UseVisualStyleBackColor = false;
            this.BotaoConsultarVeiculo.Click += new System.EventHandler(this.BotaoConsultarVeiculo_Click);
            // 
            // ConsultarCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(611, 309);
            this.Controls.Add(this.BotaoConsultarVeiculo);
            this.Controls.Add(this.BotaoConsultarMotorista);
            this.Controls.Add(this.TextoConsultarCadastro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarCadastro";
            this.Text = "Consultar Cadastro";
            this.Load += new System.EventHandler(this.ConsultarCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextoConsultarCadastro;
        private System.Windows.Forms.Button BotaoConsultarMotorista;
        private System.Windows.Forms.Button BotaoConsultarVeiculo;
    }
}