namespace LNuevoAño
{
    partial class FormNuevoAño
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuevoAño));
            this.m_strAño = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btAlta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_strAño
            // 
            this.m_strAño.Location = new System.Drawing.Point(133, 56);
            this.m_strAño.Name = "m_strAño";
            this.m_strAño.Size = new System.Drawing.Size(251, 22);
            this.m_strAño.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de Año :";
            // 
            // button1
            // 
            this.button1.Image = global::LNuevoAño.Properties.Resources.WinXPSetV4_Icon_17;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(254, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btAlta
            // 
            this.btAlta.Image = global::LNuevoAño.Properties.Resources.Apptl;
            this.btAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAlta.Location = new System.Drawing.Point(26, 125);
            this.btAlta.Name = "btAlta";
            this.btAlta.Size = new System.Drawing.Size(132, 40);
            this.btAlta.TabIndex = 2;
            this.btAlta.Text = "Alta";
            this.btAlta.UseVisualStyleBackColor = true;
            this.btAlta.Click += new System.EventHandler(this.btAlta_Click);
            // 
            // FormNuevoAño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 177);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btAlta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_strAño);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNuevoAño";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Nuevo Año";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_strAño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAlta;
        private System.Windows.Forms.Button button1;
    }
}