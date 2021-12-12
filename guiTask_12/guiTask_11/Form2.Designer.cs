
namespace guiTask_11
{
    partial class Form2
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
            this.labPP = new System.Windows.Forms.Label();
            this.labUp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbS = new System.Windows.Forms.TextBox();
            this.labArr = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labPP
            // 
            this.labPP.AutoSize = true;
            this.labPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labPP.Location = new System.Drawing.Point(24, 29);
            this.labPP.Name = "labPP";
            this.labPP.Size = new System.Drawing.Size(341, 44);
            this.labPP.TabIndex = 0;
            this.labPP.Text = "Массив после ++: ";
            // 
            // labUp
            // 
            this.labUp.AutoSize = true;
            this.labUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labUp.Location = new System.Drawing.Point(24, 103);
            this.labUp.Name = "labUp";
            this.labUp.Size = new System.Drawing.Size(381, 44);
            this.labUp.TabIndex = 1;
            this.labUp.Text = "Массив упорядочен!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(314, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите скаляр:";
            // 
            // tbS
            // 
            this.tbS.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbS.Location = new System.Drawing.Point(405, 243);
            this.tbS.Name = "tbS";
            this.tbS.Size = new System.Drawing.Size(100, 49);
            this.tbS.TabIndex = 4;
            // 
            // labArr
            // 
            this.labArr.AutoSize = true;
            this.labArr.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labArr.Location = new System.Drawing.Point(202, 353);
            this.labArr.Name = "labArr";
            this.labArr.Size = new System.Drawing.Size(163, 44);
            this.labArr.TabIndex = 5;
            this.labArr.Text = "Массив:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(239, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(415, 106);
            this.button1.TabIndex = 6;
            this.button1.Text = "Показать результат";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 675);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labArr);
            this.Controls.Add(this.tbS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labUp);
            this.Controls.Add(this.labPP);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labPP;
        private System.Windows.Forms.Label labUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbS;
        private System.Windows.Forms.Label labArr;
        private System.Windows.Forms.Button button1;
    }
}