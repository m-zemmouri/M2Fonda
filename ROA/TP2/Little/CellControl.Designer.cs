namespace ROA.TP2.Little
{
    partial class CellControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxReduction = new System.Windows.Forms.Label();
            this.textBoxRegret = new System.Windows.Forms.Label();
            this.textBoxValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxReduction
            // 
            this.textBoxReduction.BackColor = System.Drawing.Color.Transparent;
            this.textBoxReduction.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxReduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReduction.ForeColor = System.Drawing.Color.Green;
            this.textBoxReduction.Location = new System.Drawing.Point(0, 0);
            this.textBoxReduction.Name = "textBoxReduction";
            this.textBoxReduction.Size = new System.Drawing.Size(77, 18);
            this.textBoxReduction.TabIndex = 0;
            this.textBoxReduction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxRegret
            // 
            this.textBoxRegret.BackColor = System.Drawing.Color.Transparent;
            this.textBoxRegret.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxRegret.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegret.ForeColor = System.Drawing.Color.Red;
            this.textBoxRegret.Location = new System.Drawing.Point(0, 62);
            this.textBoxRegret.Name = "textBoxRegret";
            this.textBoxRegret.Size = new System.Drawing.Size(77, 15);
            this.textBoxRegret.TabIndex = 1;
            this.textBoxRegret.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxValue
            // 
            this.textBoxValue.BackColor = System.Drawing.Color.Transparent;
            this.textBoxValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValue.Location = new System.Drawing.Point(0, 18);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(77, 44);
            this.textBoxValue.TabIndex = 2;
            this.textBoxValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CellControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.textBoxRegret);
            this.Controls.Add(this.textBoxReduction);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CellControl";
            this.Size = new System.Drawing.Size(77, 77);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label textBoxReduction;
        public System.Windows.Forms.Label textBoxRegret;
        public System.Windows.Forms.Label textBoxValue;
    }
}
