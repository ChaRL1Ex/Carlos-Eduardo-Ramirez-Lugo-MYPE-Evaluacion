namespace Evaluacion
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbnames = new System.Windows.Forms.TextBox();
            this.lbnames = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registre su nombre completo: ";
            // 
            // tbnames
            // 
            this.tbnames.Location = new System.Drawing.Point(168, 9);
            this.tbnames.Name = "tbnames";
            this.tbnames.Size = new System.Drawing.Size(323, 20);
            this.tbnames.TabIndex = 1;
            this.tbnames.TextChanged += new System.EventHandler(this.tbnames_TextChanged);
            this.tbnames.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbnames_KeyPress);
            // 
            // lbnames
            // 
            this.lbnames.FormattingEnabled = true;
            this.lbnames.Location = new System.Drawing.Point(47, 83);
            this.lbnames.Name = "lbnames";
            this.lbnames.Size = new System.Drawing.Size(483, 251);
            this.lbnames.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombres Registrados:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 419);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbnames);
            this.Controls.Add(this.tbnames);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Registro de estudiantes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbnames;
        private System.Windows.Forms.ListBox lbnames;
        private System.Windows.Forms.Label label2;
    }
}

