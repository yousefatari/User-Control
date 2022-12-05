namespace user_control
{
    partial class Form1
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
            this.ucstate1 = new user_control.ucstate();
            this.btngetstate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucstate1
            // 
            this.ucstate1.Location = new System.Drawing.Point(12, 12);
            this.ucstate1.Name = "ucstate1";
            this.ucstate1.Size = new System.Drawing.Size(528, 110);
            this.ucstate1.TabIndex = 0;
            // 
            // btngetstate
            // 
            this.btngetstate.Location = new System.Drawing.Point(143, 158);
            this.btngetstate.Name = "btngetstate";
            this.btngetstate.Size = new System.Drawing.Size(90, 33);
            this.btngetstate.TabIndex = 1;
            this.btngetstate.Text = "state";
            this.btngetstate.UseVisualStyleBackColor = true;
            this.btngetstate.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 282);
            this.Controls.Add(this.btngetstate);
            this.Controls.Add(this.ucstate1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ucstate ucstate1;
        private Button btngetstate;
    }
}