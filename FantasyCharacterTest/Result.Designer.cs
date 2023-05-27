
namespace FantasyCharacterTest
{
    partial class FormResult
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
            this.result_res = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.result_text = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // result_res
            // 
            this.result_res.AutoSize = true;
            this.result_res.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result_res.ForeColor = System.Drawing.SystemColors.Desktop;
            this.result_res.Location = new System.Drawing.Point(290, 488);
            this.result_res.Name = "result_res";
            this.result_res.Size = new System.Drawing.Size(147, 34);
            this.result_res.TabIndex = 0;
            this.result_res.Text = "Результат:";
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(296, 656);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(188, 68);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Завершить";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // result_text
            // 
            this.result_text.BackColor = System.Drawing.SystemColors.Control;
            this.result_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result_text.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result_text.ForeColor = System.Drawing.Color.Blue;
            this.result_text.Location = new System.Drawing.Point(35, 556);
            this.result_text.Multiline = true;
            this.result_text.Name = "result_text";
            this.result_text.ReadOnly = true;
            this.result_text.Size = new System.Drawing.Size(779, 94);
            this.result_text.TabIndex = 4;
            this.result_text.Text = "dszcdsvd dfvdf fdg fdcsf dsg dsgf sdg dsgdsxgdsgdsgdgs gsg sdg rsg r gs";
            this.result_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(35, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(779, 444);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 753);
            this.Controls.Add(this.result_text);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.result_res);
            this.Name = "FormResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label result_res;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox result_text;
    }
}