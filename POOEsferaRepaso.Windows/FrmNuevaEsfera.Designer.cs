
namespace POOEsferaRepaso.Windows
{
    partial class FrmNuevaEsfera
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
            this.components = new System.ComponentModel.Container();
            this.TrazosComboBox2 = new System.Windows.Forms.ComboBox();
            this.ColorcomboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RadiotextBox1 = new System.Windows.Forms.TextBox();
            this.Cancelbutton1 = new System.Windows.Forms.Button();
            this.Okbutton2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TrazosComboBox2
            // 
            this.TrazosComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TrazosComboBox2.FormattingEnabled = true;
            this.TrazosComboBox2.Location = new System.Drawing.Point(188, 132);
            this.TrazosComboBox2.Name = "TrazosComboBox2";
            this.TrazosComboBox2.Size = new System.Drawing.Size(121, 21);
            this.TrazosComboBox2.TabIndex = 0;
            // 
            // ColorcomboBox1
            // 
            this.ColorcomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorcomboBox1.FormattingEnabled = true;
            this.ColorcomboBox1.Location = new System.Drawing.Point(188, 90);
            this.ColorcomboBox1.Name = "ColorcomboBox1";
            this.ColorcomboBox1.Size = new System.Drawing.Size(121, 21);
            this.ColorcomboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trazos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Radio";
            // 
            // RadiotextBox1
            // 
            this.RadiotextBox1.Location = new System.Drawing.Point(188, 37);
            this.RadiotextBox1.Name = "RadiotextBox1";
            this.RadiotextBox1.Size = new System.Drawing.Size(100, 20);
            this.RadiotextBox1.TabIndex = 2;
            // 
            // Cancelbutton1
            // 
            this.Cancelbutton1.Location = new System.Drawing.Point(277, 253);
            this.Cancelbutton1.Name = "Cancelbutton1";
            this.Cancelbutton1.Size = new System.Drawing.Size(144, 68);
            this.Cancelbutton1.TabIndex = 3;
            this.Cancelbutton1.Text = "CANCEL";
            this.Cancelbutton1.UseVisualStyleBackColor = true;
            // 
            // Okbutton2
            // 
            this.Okbutton2.Location = new System.Drawing.Point(87, 253);
            this.Okbutton2.Name = "Okbutton2";
            this.Okbutton2.Size = new System.Drawing.Size(144, 68);
            this.Okbutton2.TabIndex = 3;
            this.Okbutton2.Text = "OK";
            this.Okbutton2.UseVisualStyleBackColor = true;
            this.Okbutton2.Click += new System.EventHandler(this.Okbutton2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmNuevaEsfera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Okbutton2);
            this.Controls.Add(this.Cancelbutton1);
            this.Controls.Add(this.RadiotextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColorcomboBox1);
            this.Controls.Add(this.TrazosComboBox2);
            this.Name = "FrmNuevaEsfera";
            this.Text = "FrmNuevaEsfera";
            this.Load += new System.EventHandler(this.FrmNuevaEsfera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TrazosComboBox2;
        private System.Windows.Forms.ComboBox ColorcomboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RadiotextBox1;
        private System.Windows.Forms.Button Cancelbutton1;
        private System.Windows.Forms.Button Okbutton2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}