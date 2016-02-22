namespace WindowsForms_Diploma_NevskiiProekt
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.toInformationButton = new System.Windows.Forms.Button();
            this.toEditFormButton = new System.Windows.Forms.Button();
            this.toAddFormButton = new System.Windows.Forms.Button();
            this.toFireFormButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toInformationButton
            // 
            this.toInformationButton.BackColor = System.Drawing.SystemColors.Control;
            this.toInformationButton.Location = new System.Drawing.Point(84, 77);
            this.toInformationButton.Name = "toInformationButton";
            this.toInformationButton.Size = new System.Drawing.Size(217, 48);
            this.toInformationButton.TabIndex = 0;
            this.toInformationButton.Text = "ИНФОРМАЦИЯ ОБ ОРГАНИЗАЦИИ";
            this.toInformationButton.UseVisualStyleBackColor = false;
            this.toInformationButton.MouseLeave += new System.EventHandler(this.toInformationButton_MouseLeave);
            this.toInformationButton.MouseHover += new System.EventHandler(this.toInformationButton_MouseHover);
            // 
            // toEditFormButton
            // 
            this.toEditFormButton.Location = new System.Drawing.Point(84, 131);
            this.toEditFormButton.Name = "toEditFormButton";
            this.toEditFormButton.Size = new System.Drawing.Size(217, 48);
            this.toEditFormButton.TabIndex = 1;
            this.toEditFormButton.Text = "ИНФОРМАЦИЯ О СОТРУДНИКАХ";
            this.toEditFormButton.UseVisualStyleBackColor = true;
            this.toEditFormButton.Click += new System.EventHandler(this.button2_Click);
            this.toEditFormButton.MouseLeave += new System.EventHandler(this.toEditFormButton_MouseLeave);
            this.toEditFormButton.MouseHover += new System.EventHandler(this.toEditFormButton_MouseHover);
            // 
            // toAddFormButton
            // 
            this.toAddFormButton.Location = new System.Drawing.Point(84, 185);
            this.toAddFormButton.Name = "toAddFormButton";
            this.toAddFormButton.Size = new System.Drawing.Size(217, 48);
            this.toAddFormButton.TabIndex = 2;
            this.toAddFormButton.Text = "ПРИЕМ НА РАБОТУ";
            this.toAddFormButton.UseVisualStyleBackColor = true;
            this.toAddFormButton.Click += new System.EventHandler(this.button3_Click);
            this.toAddFormButton.MouseLeave += new System.EventHandler(this.toAddFormButton_MouseLeave);
            this.toAddFormButton.MouseHover += new System.EventHandler(this.toAddFormButton_MouseHover);
            // 
            // toFireFormButton
            // 
            this.toFireFormButton.Location = new System.Drawing.Point(84, 239);
            this.toFireFormButton.Name = "toFireFormButton";
            this.toFireFormButton.Size = new System.Drawing.Size(217, 48);
            this.toFireFormButton.TabIndex = 3;
            this.toFireFormButton.Text = "УВОЛЬНЕНИЕ";
            this.toFireFormButton.UseVisualStyleBackColor = true;
            this.toFireFormButton.Click += new System.EventHandler(this.button4_Click);
            this.toFireFormButton.MouseLeave += new System.EventHandler(this.toFireFormButton_MouseLeave);
            this.toFireFormButton.MouseHover += new System.EventHandler(this.toFireFormButton_MouseHover);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(84, 361);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(217, 41);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "ВЫХОД";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button5_Click);
            this.exitButton.MouseLeave += new System.EventHandler(this.exitButton_MouseLeave);
            this.exitButton.MouseHover += new System.EventHandler(this.exitButton_MouseHover);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 498);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.toFireFormButton);
            this.Controls.Add(this.toAddFormButton);
            this.Controls.Add(this.toEditFormButton);
            this.Controls.Add(this.toInformationButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button toInformationButton;
        private System.Windows.Forms.Button toEditFormButton;
        private System.Windows.Forms.Button toAddFormButton;
        private System.Windows.Forms.Button toFireFormButton;
        private System.Windows.Forms.Button exitButton;
    }
}

