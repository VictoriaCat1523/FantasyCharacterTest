
namespace FantasyCharacterTest
{
    partial class Result
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
            this.result_text = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // result_res
            // 
            this.result_res.AutoSize = true;
            this.result_res.Location = new System.Drawing.Point(142, 104);
            this.result_res.Name = "result_res";
            this.result_res.Size = new System.Drawing.Size(80, 17);
            this.result_res.TabIndex = 0;
            this.result_res.Text = "Результат:";
            // 
            // result_text
            // 
            this.result_text.AutoSize = true;
            this.result_text.Location = new System.Drawing.Point(229, 104);
            this.result_text.Name = "result_text";
            this.result_text.Size = new System.Drawing.Size(0, 17);
            this.result_text.TabIndex = 1;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(302, 308);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(188, 68);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Завершить";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.result_text);
            this.Controls.Add(this.result_res);
            this.Name = "Result";
            this.Text = "Result";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label result_res;
        private System.Windows.Forms.Label result_text;
        private System.Windows.Forms.Button BtnClose;
    }
}