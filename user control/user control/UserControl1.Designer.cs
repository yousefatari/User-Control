namespace user_control
{
    partial class ucstate
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
            this.lblstate = new System.Windows.Forms.Label();
            this.cbxstate = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblstate
            // 
            this.lblstate.AutoSize = true;
            this.lblstate.Location = new System.Drawing.Point(38, 42);
            this.lblstate.Name = "lblstate";
            this.lblstate.Size = new System.Drawing.Size(37, 15);
            this.lblstate.TabIndex = 0;
            this.lblstate.Text = "states";
            // 
            // cbxstate
            // 
            this.cbxstate.FormattingEnabled = true;
            this.cbxstate.Location = new System.Drawing.Point(115, 39);
            this.cbxstate.Name = "cbxstate";
            this.cbxstate.Size = new System.Drawing.Size(246, 23);
            this.cbxstate.TabIndex = 1;
            // 
            // ucstate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbxstate);
            this.Controls.Add(this.lblstate);
            this.Name = "ucstate";
            this.Size = new System.Drawing.Size(528, 187);
            this.Load += new System.EventHandler(this.ucstate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblstate;
        private ComboBox cbxstate;
    }
}
