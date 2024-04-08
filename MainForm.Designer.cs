namespace MyFirstWindFormProject
{
    partial class MainForm
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
            this.btnShowPart1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMessageBoxForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowPart1
            // 
            this.btnShowPart1.Location = new System.Drawing.Point(21, 101);
            this.btnShowPart1.Name = "btnShowPart1";
            this.btnShowPart1.Size = new System.Drawing.Size(211, 73);
            this.btnShowPart1.TabIndex = 0;
            this.btnShowPart1.Text = "Show Form";
            this.btnShowPart1.UseVisualStyleBackColor = true;
            this.btnShowPart1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 73);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show Form as dialogu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnMessageBoxForm
            // 
            this.btnMessageBoxForm.Location = new System.Drawing.Point(577, 101);
            this.btnMessageBoxForm.Name = "btnMessageBoxForm";
            this.btnMessageBoxForm.Size = new System.Drawing.Size(211, 73);
            this.btnMessageBoxForm.TabIndex = 2;
            this.btnMessageBoxForm.Text = "ShowMessage Box Form";
            this.btnMessageBoxForm.UseVisualStyleBackColor = true;
            this.btnMessageBoxForm.Click += new System.EventHandler(this.btnMessageBoxForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMessageBoxForm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnShowPart1);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowPart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMessageBoxForm;
    }
}