
namespace FrotaEmpresa
{
    partial class ConsultarTdsVeiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarTdsVeiculos));
            this.listView1 = new System.Windows.Forms.ListView();
            this.botaoConsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BotaoLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 142);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(563, 301);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // botaoConsultar
            // 
            this.botaoConsultar.BackColor = System.Drawing.SystemColors.Control;
            this.botaoConsultar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.botaoConsultar.FlatAppearance.BorderSize = 2;
            this.botaoConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoConsultar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.botaoConsultar.Location = new System.Drawing.Point(153, 80);
            this.botaoConsultar.Name = "botaoConsultar";
            this.botaoConsultar.Size = new System.Drawing.Size(109, 41);
            this.botaoConsultar.TabIndex = 12;
            this.botaoConsultar.Text = "Consultar";
            this.botaoConsultar.UseVisualStyleBackColor = false;
            this.botaoConsultar.Click += new System.EventHandler(this.botaoConsultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(71, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "Todos os Veículos Cadastrados";
            // 
            // BotaoLimpar
            // 
            this.BotaoLimpar.BackColor = System.Drawing.SystemColors.Control;
            this.BotaoLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BotaoLimpar.FlatAppearance.BorderSize = 2;
            this.BotaoLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoLimpar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.BotaoLimpar.Location = new System.Drawing.Point(318, 80);
            this.BotaoLimpar.Name = "BotaoLimpar";
            this.BotaoLimpar.Size = new System.Drawing.Size(109, 41);
            this.BotaoLimpar.TabIndex = 14;
            this.BotaoLimpar.Text = "Limpar";
            this.BotaoLimpar.UseVisualStyleBackColor = false;
            this.BotaoLimpar.Click += new System.EventHandler(this.BotaoLimpar_Click);
            // 
            // ConsultarTdsVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(586, 460);
            this.Controls.Add(this.BotaoLimpar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.botaoConsultar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarTdsVeiculos";
            this.Text = "Consultar Todos os Veiculos";
            this.Load += new System.EventHandler(this.ConsultarTdsVeiculos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button botaoConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotaoLimpar;
    }
}