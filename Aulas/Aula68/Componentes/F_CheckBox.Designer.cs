
namespace Componentes
{
    partial class F_CheckBox
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
            this.btn_OpenCheckedListBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_OpenCheckedListBox
            // 
            this.btn_OpenCheckedListBox.Location = new System.Drawing.Point(169, 90);
            this.btn_OpenCheckedListBox.Name = "btn_OpenCheckedListBox";
            this.btn_OpenCheckedListBox.Size = new System.Drawing.Size(165, 38);
            this.btn_OpenCheckedListBox.TabIndex = 0;
            this.btn_OpenCheckedListBox.Text = "Abrir Formulário";
            this.btn_OpenCheckedListBox.UseVisualStyleBackColor = true;
            this.btn_OpenCheckedListBox.Click += new System.EventHandler(this.btn_OpenCheckedListBox_Click);
            // 
            // F_CheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_OpenCheckedListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_CheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormulárioCheck Box";
            this.Load += new System.EventHandler(this.F_CheckBox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_OpenCheckedListBox;
    }
}