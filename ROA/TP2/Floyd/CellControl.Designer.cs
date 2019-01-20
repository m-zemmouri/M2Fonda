namespace ROA.TP2.Floyd
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
            this.textBoxTop = new System.Windows.Forms.TextBox();
            this.textBoxBottom = new System.Windows.Forms.TextBox();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxTop
            // 
            this.textBoxTop.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxTop.ForeColor = System.Drawing.Color.Green;
            this.textBoxTop.Location = new System.Drawing.Point(0, 0);
            this.textBoxTop.Name = "textBoxTop";
            this.textBoxTop.ReadOnly = true;
            this.textBoxTop.Size = new System.Drawing.Size(150, 13);
            this.textBoxTop.TabIndex = 0;
            this.textBoxTop.TabStop = false;
            this.textBoxTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxBottom
            // 
            this.textBoxBottom.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxBottom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxBottom.ForeColor = System.Drawing.Color.Red;
            this.textBoxBottom.Location = new System.Drawing.Point(0, 137);
            this.textBoxBottom.Name = "textBoxBottom";
            this.textBoxBottom.ReadOnly = true;
            this.textBoxBottom.Size = new System.Drawing.Size(150, 13);
            this.textBoxBottom.TabIndex = 1;
            this.textBoxBottom.TabStop = false;
            // 
            // textBoxValue
            // 
            this.textBoxValue.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValue.Location = new System.Drawing.Point(0, 13);
            this.textBoxValue.Multiline = true;
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.ReadOnly = true;
            this.textBoxValue.Size = new System.Drawing.Size(150, 124);
            this.textBoxValue.TabIndex = 2;
            this.textBoxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CellControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.textBoxBottom);
            this.Controls.Add(this.textBoxTop);
            this.Name = "CellControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTop;
        private System.Windows.Forms.TextBox textBoxBottom;
        private System.Windows.Forms.TextBox textBoxValue;
    }
}
