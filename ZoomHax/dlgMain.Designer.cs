namespace ZoomHax
{
    partial class dlgMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dlgMain));
            this.btn_Activate = new System.Windows.Forms.Button();
            this.btn_Deactivate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Activate
            // 
            this.btn_Activate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Activate.Location = new System.Drawing.Point(12, 12);
            this.btn_Activate.Name = "btn_Activate";
            this.btn_Activate.Size = new System.Drawing.Size(221, 46);
            this.btn_Activate.TabIndex = 0;
            this.btn_Activate.Text = "Activate";
            this.btn_Activate.UseVisualStyleBackColor = true;
            this.btn_Activate.Click += new System.EventHandler(this.btn_Activate_Click);
            // 
            // btn_Deactivate
            // 
            this.btn_Deactivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Deactivate.Location = new System.Drawing.Point(12, 64);
            this.btn_Deactivate.Name = "btn_Deactivate";
            this.btn_Deactivate.Size = new System.Drawing.Size(221, 46);
            this.btn_Deactivate.TabIndex = 1;
            this.btn_Deactivate.Text = "De-Activate";
            this.btn_Deactivate.UseVisualStyleBackColor = true;
            this.btn_Deactivate.Click += new System.EventHandler(this.btn_Deactivate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Created by: M_IsHaxin";
            // 
            // dlgMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 148);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Deactivate);
            this.Controls.Add(this.btn_Activate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "dlgMain";
            this.Text = "Leviathan Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Activate;
        private System.Windows.Forms.Button btn_Deactivate;
        private System.Windows.Forms.Label label1;
    }
}

