namespace Relogio
{
    partial class Relogio
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
            this.components = new System.ComponentModel.Container();
            this.lblHora = new System.Windows.Forms.Label();
            this.tmrTempo = new System.Windows.Forms.Timer(this.components);
            this.btnSair = new System.Windows.Forms.Button();
            this.dtpCalendario = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(51, 20);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(40, 13);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "lblHora";
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // tmrTempo
            // 
            this.tmrTempo.Enabled = true;
            this.tmrTempo.Interval = 1;
            this.tmrTempo.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(342, 352);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dtpCalendario
            // 
            this.dtpCalendario.CustomFormat = "dd-MM-yyyy";
            this.dtpCalendario.Location = new System.Drawing.Point(97, 116);
            this.dtpCalendario.Name = "dtpCalendario";
            this.dtpCalendario.Size = new System.Drawing.Size(200, 20);
            this.dtpCalendario.TabIndex = 2;
            this.dtpCalendario.ValueChanged += new System.EventHandler(this.dtpCalendario_ValueChanged);
            // 
            // Relogio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(638, 387);
            this.Controls.Add(this.dtpCalendario);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblHora);
            this.Name = "Relogio";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer tmrTempo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DateTimePicker dtpCalendario;
    }
}

