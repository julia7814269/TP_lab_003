namespace WindowsFormsApp1
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
            this.buttonRoad = new System.Windows.Forms.Button();
            this.buttonTemp = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRoad
            // 
            this.buttonRoad.Location = new System.Drawing.Point(175, 110);
            this.buttonRoad.Name = "buttonRoad";
            this.buttonRoad.Size = new System.Drawing.Size(456, 50);
            this.buttonRoad.TabIndex = 0;
            this.buttonRoad.Text = "Показать данные о доли плохих дорог";
            this.buttonRoad.UseVisualStyleBackColor = true;
            this.buttonRoad.Click += new System.EventHandler(this.button_ShowRoadData);
            // 
            // buttonTemp
            // 
            this.buttonTemp.Location = new System.Drawing.Point(175, 194);
            this.buttonTemp.Name = "buttonTemp";
            this.buttonTemp.Size = new System.Drawing.Size(456, 50);
            this.buttonTemp.TabIndex = 1;
            this.buttonTemp.Text = "Показать данные о температуре в городе";
            this.buttonTemp.UseVisualStyleBackColor = true;
            this.buttonTemp.Click += new System.EventHandler(this.button_ShowTempData);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(202, 44);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(408, 25);
            this.label.TabIndex = 2;
            this.label.Text = "Вывести данные по следующим темам:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 318);
            this.Controls.Add(this.label);
            this.Controls.Add(this.buttonTemp);
            this.Controls.Add(this.buttonRoad);
            this.Name = "MainForm";
            this.Text = "Получение данных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRoad;
        private System.Windows.Forms.Button buttonTemp;
        private System.Windows.Forms.Label label;
    }
}