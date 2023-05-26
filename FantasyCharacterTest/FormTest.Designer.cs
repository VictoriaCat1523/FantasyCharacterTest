
namespace FantasyCharacterTest
{
    partial class FormTest
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.rbtnAnswer1 = new System.Windows.Forms.RadioButton();
            this.rbtnAnswer2 = new System.Windows.Forms.RadioButton();
            this.rbtnAnswer3 = new System.Windows.Forms.RadioButton();
            this.rbtnAnswer4 = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(148, 49);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(56, 17);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Вопрос";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.rbtnAnswer4);
            this.groupBox.Controls.Add(this.rbtnAnswer3);
            this.groupBox.Controls.Add(this.rbtnAnswer2);
            this.groupBox.Controls.Add(this.rbtnAnswer1);
            this.groupBox.Location = new System.Drawing.Point(151, 107);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(267, 170);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            // 
            // rbtnAnswer1
            // 
            this.rbtnAnswer1.AutoSize = true;
            this.rbtnAnswer1.Location = new System.Drawing.Point(7, 22);
            this.rbtnAnswer1.Name = "rbtnAnswer1";
            this.rbtnAnswer1.Size = new System.Drawing.Size(93, 21);
            this.rbtnAnswer1.TabIndex = 0;
            this.rbtnAnswer1.TabStop = true;
            this.rbtnAnswer1.Text = "Вариант1";
            this.rbtnAnswer1.UseVisualStyleBackColor = true;
            // 
            // rbtnAnswer2
            // 
            this.rbtnAnswer2.AutoSize = true;
            this.rbtnAnswer2.Location = new System.Drawing.Point(7, 58);
            this.rbtnAnswer2.Name = "rbtnAnswer2";
            this.rbtnAnswer2.Size = new System.Drawing.Size(93, 21);
            this.rbtnAnswer2.TabIndex = 1;
            this.rbtnAnswer2.TabStop = true;
            this.rbtnAnswer2.Text = "Вариант2";
            this.rbtnAnswer2.UseVisualStyleBackColor = true;
            // 
            // rbtnAnswer3
            // 
            this.rbtnAnswer3.AutoSize = true;
            this.rbtnAnswer3.Location = new System.Drawing.Point(7, 95);
            this.rbtnAnswer3.Name = "rbtnAnswer3";
            this.rbtnAnswer3.Size = new System.Drawing.Size(93, 21);
            this.rbtnAnswer3.TabIndex = 2;
            this.rbtnAnswer3.TabStop = true;
            this.rbtnAnswer3.Text = "Вариант3";
            this.rbtnAnswer3.UseVisualStyleBackColor = true;
            // 
            // rbtnAnswer4
            // 
            this.rbtnAnswer4.AutoSize = true;
            this.rbtnAnswer4.Location = new System.Drawing.Point(7, 129);
            this.rbtnAnswer4.Name = "rbtnAnswer4";
            this.rbtnAnswer4.Size = new System.Drawing.Size(93, 21);
            this.rbtnAnswer4.TabIndex = 3;
            this.rbtnAnswer4.TabStop = true;
            this.rbtnAnswer4.Text = "Вариант4";
            this.rbtnAnswer4.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(293, 325);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(165, 50);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Дальше";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.SystemColors.Control;
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblError.Location = new System.Drawing.Point(151, 294);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(135, 17);
            this.lblError.TabIndex = 3;
            this.lblError.Text = "Выберите вариант!";
            this.lblError.Visible = false;
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.lblQuestion);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton rbtnAnswer4;
        private System.Windows.Forms.RadioButton rbtnAnswer3;
        private System.Windows.Forms.RadioButton rbtnAnswer2;
        private System.Windows.Forms.RadioButton rbtnAnswer1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblError;
    }
}