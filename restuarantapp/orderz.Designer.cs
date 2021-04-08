namespace restuarantapp
{
    partial class orderz
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
            this.FinalOrder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FinalOrder
            // 
            this.FinalOrder.AutoSize = true;
            this.FinalOrder.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalOrder.Location = new System.Drawing.Point(333, 26);
            this.FinalOrder.Name = "FinalOrder";
            this.FinalOrder.Size = new System.Drawing.Size(202, 36);
            this.FinalOrder.TabIndex = 0;
            this.FinalOrder.Text = "Final Order";
            // 
            // orderz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.FinalOrder);
            this.Name = "orderz";
            this.Size = new System.Drawing.Size(872, 461);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FinalOrder;
    }
}
