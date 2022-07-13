
namespace FrotaEmpresa
{
    partial class AtuCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtuCadastro));
            this.TextoAtualizarCadastro = new System.Windows.Forms.Label();
            this.BotaoAtuMotorista = new System.Windows.Forms.Button();
            this.BotaoAtuVeiculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextoAtualizarCadastro
            // 
            this.TextoAtualizarCadastro.AutoSize = true;
            this.TextoAtualizarCadastro.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold);
            this.TextoAtualizarCadastro.ForeColor = System.Drawing.Color.Navy;
            this.TextoAtualizarCadastro.Location = new System.Drawing.Point(172, 22);
            this.TextoAtualizarCadastro.Name = "TextoAtualizarCadastro";
            this.TextoAtualizarCadastro.Size = new System.Drawing.Size(274, 36);
            this.TextoAtualizarCadastro.TabIndex = 0;
            this.TextoAtualizarCadastro.Text = "Atualizar Cadastro";
            // 
            // BotaoAtuMotorista
            // 
            this.BotaoAtuMotorista.BackColor = System.Drawing.SystemColors.Control;
            this.BotaoAtuMotorista.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BotaoAtuMotorista.FlatAppearance.BorderSize = 2;
            this.BotaoAtuMotorista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoAtuMotorista.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.BotaoAtuMotorista.Location = new System.Drawing.Point(47, 147);
            this.BotaoAtuMotorista.Name = "BotaoAtuMotorista";
            this.BotaoAtuMotorista.Size = new System.Drawing.Size(215, 100);
            this.BotaoAtuMotorista.TabIndex = 1;
            this.BotaoAtuMotorista.Text = "Atualizar Cadastro do Motorista";
            this.BotaoAtuMotorista.UseVisualStyleBackColor = false;
            this.BotaoAtuMotorista.Click += new System.EventHandler(this.BotaoAtuMotorista_Click);
            // 
            // BotaoAtuVeiculo
            // 
            this.BotaoAtuVeiculo.BackColor = System.Drawing.SystemColors.Control;
            this.BotaoAtuVeiculo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BotaoAtuVeiculo.FlatAppearance.BorderSize = 2;
            this.BotaoAtuVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoAtuVeiculo.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.BotaoAtuVeiculo.Location = new System.Drawing.Point(348, 147);
            this.BotaoAtuVeiculo.Name = "BotaoAtuVeiculo";
            this.BotaoAtuVeiculo.Size = new System.Drawing.Size(215, 100);
            this.BotaoAtuVeiculo.TabIndex = 2;
            this.BotaoAtuVeiculo.Text = "Atualizar Cadastro do Veículo";
            this.BotaoAtuVeiculo.UseVisualStyleBackColor = false;
            this.BotaoAtuVeiculo.Click += new System.EventHandler(this.BotaoAtuVeiculo_Click);
            // 
            // AtuCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(611, 309);
            this.Controls.Add(this.BotaoAtuVeiculo);
            this.Controls.Add(this.BotaoAtuMotorista);
            this.Controls.Add(this.TextoAtualizarCadastro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AtuCadastro";
            this.Text = "Atualizar Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextoAtualizarCadastro;
        private System.Windows.Forms.Button BotaoAtuMotorista;
        private System.Windows.Forms.Button BotaoAtuVeiculo;
    }
}