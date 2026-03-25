namespace InterfaceUtilisateur
{
    partial class FormThermostat
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTemperature = new Label();
            label1 = new Label();
            btnAugmenter = new Button();
            btnDiminuer = new Button();
            SuspendLayout();
            // 
            // lblTemperature
            // 
            lblTemperature.AutoSize = true;
            lblTemperature.Font = new Font("Segoe UI", 24F);
            lblTemperature.Location = new Point(38, 42);
            lblTemperature.Name = "lblTemperature";
            lblTemperature.Size = new Size(37, 45);
            lblTemperature.TabIndex = 0;
            lblTemperature.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(93, 42);
            label1.Name = "label1";
            label1.Size = new Size(212, 45);
            label1.TabIndex = 1;
            label1.Text = "degré Celcius";
            // 
            // btnAugmenter
            // 
            btnAugmenter.Font = new Font("Segoe UI", 20F);
            btnAugmenter.Location = new Point(40, 107);
            btnAugmenter.Name = "btnAugmenter";
            btnAugmenter.Size = new Size(121, 74);
            btnAugmenter.TabIndex = 2;
            btnAugmenter.Text = "+";
            btnAugmenter.UseVisualStyleBackColor = true;
            btnAugmenter.Click += btnAugmenter_Click;
            // 
            // btnDiminuer
            // 
            btnDiminuer.Font = new Font("Segoe UI", 20F);
            btnDiminuer.Location = new Point(184, 107);
            btnDiminuer.Name = "btnDiminuer";
            btnDiminuer.Size = new Size(121, 74);
            btnDiminuer.TabIndex = 3;
            btnDiminuer.Text = "-";
            btnDiminuer.UseVisualStyleBackColor = true;
            btnDiminuer.Click += btnDiminuer_Click;
            // 
            // FormThermostat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 213);
            Controls.Add(btnDiminuer);
            Controls.Add(btnAugmenter);
            Controls.Add(label1);
            Controls.Add(lblTemperature);
            Name = "FormThermostat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thermostat";
            Load += FormThermostat_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTemperature;
        private Label label1;
        private Button btnAugmenter;
        private Button btnDiminuer;
    }
}
