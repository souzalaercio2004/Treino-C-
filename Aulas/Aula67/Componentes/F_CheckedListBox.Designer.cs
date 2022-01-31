
namespace Componentes
{
    partial class F_CheckedListBox
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
            this.cb_Carro = new System.Windows.Forms.CheckBox();
            this.cb_Aviao = new System.Windows.Forms.CheckBox();
            this.cb_Navio = new System.Windows.Forms.CheckBox();
            this.cb_Onibus = new System.Windows.Forms.CheckBox();
            this.btn_TransportesMarcados = new System.Windows.Forms.Button();
            this.cbx_Patinete = new System.Windows.Forms.CheckBox();
            this.btn_abrirFormFilho = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Carro
            // 
            this.cb_Carro.AutoSize = true;
            this.cb_Carro.Location = new System.Drawing.Point(102, 44);
            this.cb_Carro.Name = "cb_Carro";
            this.cb_Carro.Size = new System.Drawing.Size(51, 17);
            this.cb_Carro.TabIndex = 0;
            this.cb_Carro.Text = "Carro";
            this.cb_Carro.UseVisualStyleBackColor = true;
            // 
            // cb_Aviao
            // 
            this.cb_Aviao.AutoSize = true;
            this.cb_Aviao.Location = new System.Drawing.Point(102, 67);
            this.cb_Aviao.Name = "cb_Aviao";
            this.cb_Aviao.Size = new System.Drawing.Size(53, 17);
            this.cb_Aviao.TabIndex = 1;
            this.cb_Aviao.Text = "Avião";
            this.cb_Aviao.UseVisualStyleBackColor = true;
            // 
            // cb_Navio
            // 
            this.cb_Navio.AutoSize = true;
            this.cb_Navio.Location = new System.Drawing.Point(102, 90);
            this.cb_Navio.Name = "cb_Navio";
            this.cb_Navio.Size = new System.Drawing.Size(54, 17);
            this.cb_Navio.TabIndex = 2;
            this.cb_Navio.Text = "Navio";
            this.cb_Navio.UseVisualStyleBackColor = true;
            // 
            // cb_Onibus
            // 
            this.cb_Onibus.AutoSize = true;
            this.cb_Onibus.Location = new System.Drawing.Point(102, 113);
            this.cb_Onibus.Name = "cb_Onibus";
            this.cb_Onibus.Size = new System.Drawing.Size(59, 17);
            this.cb_Onibus.TabIndex = 3;
            this.cb_Onibus.Text = "Onibus";
            this.cb_Onibus.UseVisualStyleBackColor = true;
            // 
            // btn_TransportesMarcados
            // 
            this.btn_TransportesMarcados.Location = new System.Drawing.Point(220, 44);
            this.btn_TransportesMarcados.Name = "btn_TransportesMarcados";
            this.btn_TransportesMarcados.Size = new System.Drawing.Size(133, 23);
            this.btn_TransportesMarcados.TabIndex = 4;
            this.btn_TransportesMarcados.Text = "Transportes Marcados";
            this.btn_TransportesMarcados.UseVisualStyleBackColor = true;
            this.btn_TransportesMarcados.Click += new System.EventHandler(this.btn_TransportesMarcados_Click);
            // 
            // cbx_Patinete
            // 
            this.cbx_Patinete.AutoSize = true;
            this.cbx_Patinete.Location = new System.Drawing.Point(102, 195);
            this.cbx_Patinete.Name = "cbx_Patinete";
            this.cbx_Patinete.Size = new System.Drawing.Size(65, 17);
            this.cbx_Patinete.TabIndex = 5;
            this.cbx_Patinete.Text = "Patinete";
            this.cbx_Patinete.UseVisualStyleBackColor = true;
            this.cbx_Patinete.CheckedChanged += new System.EventHandler(this.cbx_Patinete_CheckedChanged);
            // 
            // btn_abrirFormFilho
            // 
            this.btn_abrirFormFilho.Location = new System.Drawing.Point(220, 73);
            this.btn_abrirFormFilho.Name = "btn_abrirFormFilho";
            this.btn_abrirFormFilho.Size = new System.Drawing.Size(133, 23);
            this.btn_abrirFormFilho.TabIndex = 6;
            this.btn_abrirFormFilho.Text = "Abrir Form. Filho";
            this.btn_abrirFormFilho.UseVisualStyleBackColor = true;
            this.btn_abrirFormFilho.Click += new System.EventHandler(this.btn_abrirFormFilho_Click);
            // 
            // F_CheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_abrirFormFilho);
            this.Controls.Add(this.cbx_Patinete);
            this.Controls.Add(this.btn_TransportesMarcados);
            this.Controls.Add(this.cb_Onibus);
            this.Controls.Add(this.cb_Navio);
            this.Controls.Add(this.cb_Aviao);
            this.Controls.Add(this.cb_Carro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_CheckedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checked Lit Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_TransportesMarcados;
        private System.Windows.Forms.CheckBox cbx_Patinete;
        public System.Windows.Forms.CheckBox cb_Carro;
        public System.Windows.Forms.CheckBox cb_Aviao;
        public System.Windows.Forms.CheckBox cb_Navio;
        public System.Windows.Forms.CheckBox cb_Onibus;
        private System.Windows.Forms.Button btn_abrirFormFilho;
    }
}