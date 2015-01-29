namespace ValProject
{
    partial class ValForm
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
            this.buildButton = new System.Windows.Forms.Button();
            this.numTeethValParameterControl = new ValProject.ValParameterControl();
            this.fifthRValParameterControl = new ValProject.ValParameterControl();
            this.fourthRValParameterControl = new ValProject.ValParameterControl();
            this.thirdRValParameterControl = new ValProject.ValParameterControl();
            this.secondRValParameterControl = new ValProject.ValParameterControl();
            this.firstRValParameterControl = new ValProject.ValParameterControl();
            this.fifthLValParameterControl = new ValProject.ValParameterControl();
            this.fourthLValParameterControl = new ValProject.ValParameterControl();
            this.thirdLvalParameterControl = new ValProject.ValParameterControl();
            this.secondLvalParameterControl = new ValProject.ValParameterControl();
            this.firstLValParameterControl = new ValProject.ValParameterControl();
            this.SuspendLayout();
            // 
            // buildButton
            // 
            this.buildButton.Location = new System.Drawing.Point(393, 12);
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(172, 112);
            this.buildButton.TabIndex = 11;
            this.buildButton.Text = "Вперёд!";
            this.buildButton.UseVisualStyleBackColor = true;
            this.buildButton.Click += new System.EventHandler(this.buildButton_Click);
            // 
            // numTeethValParameterControl
            // 
            this.numTeethValParameterControl.Location = new System.Drawing.Point(12, 472);
            this.numTeethValParameterControl.Name = "numTeethValParameterControl";
            this.numTeethValParameterControl.ParameterDescription = "label5";
            this.numTeethValParameterControl.ParameterName = "Число зубьев";
            this.numTeethValParameterControl.Size = new System.Drawing.Size(343, 39);
            this.numTeethValParameterControl.TabIndex = 10;
            // 
            // fifthRValParameterControl
            // 
            this.fifthRValParameterControl.Location = new System.Drawing.Point(12, 426);
            this.fifthRValParameterControl.Name = "fifthRValParameterControl";
            this.fifthRValParameterControl.ParameterDescription = "label5";
            this.fifthRValParameterControl.ParameterName = "Радиус  пятой ступени";
            this.fifthRValParameterControl.Size = new System.Drawing.Size(343, 39);
            this.fifthRValParameterControl.TabIndex = 9;
            // 
            // fourthRValParameterControl
            // 
            this.fourthRValParameterControl.Location = new System.Drawing.Point(12, 380);
            this.fourthRValParameterControl.Name = "fourthRValParameterControl";
            this.fourthRValParameterControl.ParameterDescription = "label5";
            this.fourthRValParameterControl.ParameterName = "Радиус четвертой ступени";
            this.fourthRValParameterControl.Size = new System.Drawing.Size(343, 39);
            this.fourthRValParameterControl.TabIndex = 8;
            // 
            // thirdRValParameterControl
            // 
            this.thirdRValParameterControl.Location = new System.Drawing.Point(12, 334);
            this.thirdRValParameterControl.Name = "thirdRValParameterControl";
            this.thirdRValParameterControl.ParameterDescription = "label5";
            this.thirdRValParameterControl.ParameterName = "Радиус третьей ступени";
            this.thirdRValParameterControl.Size = new System.Drawing.Size(343, 39);
            this.thirdRValParameterControl.TabIndex = 7;
            // 
            // secondRValParameterControl
            // 
            this.secondRValParameterControl.Location = new System.Drawing.Point(12, 288);
            this.secondRValParameterControl.Name = "secondRValParameterControl";
            this.secondRValParameterControl.ParameterDescription = "label5";
            this.secondRValParameterControl.ParameterName = "Радиус второй ступени";
            this.secondRValParameterControl.Size = new System.Drawing.Size(343, 39);
            this.secondRValParameterControl.TabIndex = 6;
            // 
            // firstRValParameterControl
            // 
            this.firstRValParameterControl.Location = new System.Drawing.Point(13, 242);
            this.firstRValParameterControl.Name = "firstRValParameterControl";
            this.firstRValParameterControl.ParameterDescription = "label5";
            this.firstRValParameterControl.ParameterName = "Радиус первой ступени";
            this.firstRValParameterControl.Size = new System.Drawing.Size(343, 39);
            this.firstRValParameterControl.TabIndex = 5;
            // 
            // fifthLValParameterControl
            // 
            this.fifthLValParameterControl.Location = new System.Drawing.Point(13, 196);
            this.fifthLValParameterControl.Name = "fifthLValParameterControl";
            this.fifthLValParameterControl.ParameterDescription = "label5";
            this.fifthLValParameterControl.ParameterName = "Длина пятой ступени";
            this.fifthLValParameterControl.Size = new System.Drawing.Size(343, 39);
            this.fifthLValParameterControl.TabIndex = 4;
            // 
            // fourthLValParameterControl
            // 
            this.fourthLValParameterControl.Location = new System.Drawing.Point(13, 150);
            this.fourthLValParameterControl.Name = "fourthLValParameterControl";
            this.fourthLValParameterControl.ParameterDescription = "label5";
            this.fourthLValParameterControl.ParameterName = "Длина четвертой ступени";
            this.fourthLValParameterControl.Size = new System.Drawing.Size(343, 39);
            this.fourthLValParameterControl.TabIndex = 3;
            // 
            // thirdLvalParameterControl
            // 
            this.thirdLvalParameterControl.Location = new System.Drawing.Point(12, 104);
            this.thirdLvalParameterControl.Name = "thirdLvalParameterControl";
            this.thirdLvalParameterControl.ParameterDescription = "label5";
            this.thirdLvalParameterControl.ParameterName = "Длина третьей ступени";
            this.thirdLvalParameterControl.Size = new System.Drawing.Size(343, 39);
            this.thirdLvalParameterControl.TabIndex = 2;
            // 
            // secondLvalParameterControl
            // 
            this.secondLvalParameterControl.Location = new System.Drawing.Point(12, 58);
            this.secondLvalParameterControl.Name = "secondLvalParameterControl";
            this.secondLvalParameterControl.ParameterDescription = "label5";
            this.secondLvalParameterControl.ParameterName = "Длина второй ступени";
            this.secondLvalParameterControl.Size = new System.Drawing.Size(343, 39);
            this.secondLvalParameterControl.TabIndex = 1;
            // 
            // firstLValParameterControl
            // 
            this.firstLValParameterControl.Location = new System.Drawing.Point(12, 12);
            this.firstLValParameterControl.Name = "firstLValParameterControl";
            this.firstLValParameterControl.ParameterDescription = "label5";
            this.firstLValParameterControl.ParameterName = "Длина первой ступени";
            this.firstLValParameterControl.Size = new System.Drawing.Size(343, 39);
            this.firstLValParameterControl.TabIndex = 0;
            // 
            // ValForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 527);
            this.Controls.Add(this.buildButton);
            this.Controls.Add(this.numTeethValParameterControl);
            this.Controls.Add(this.fifthRValParameterControl);
            this.Controls.Add(this.fourthRValParameterControl);
            this.Controls.Add(this.thirdRValParameterControl);
            this.Controls.Add(this.secondRValParameterControl);
            this.Controls.Add(this.firstRValParameterControl);
            this.Controls.Add(this.fifthLValParameterControl);
            this.Controls.Add(this.fourthLValParameterControl);
            this.Controls.Add(this.thirdLvalParameterControl);
            this.Controls.Add(this.secondLvalParameterControl);
            this.Controls.Add(this.firstLValParameterControl);
            this.Name = "ValForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ValParameterControl firstLValParameterControl;
        private ValParameterControl secondLvalParameterControl;
        private ValParameterControl thirdLvalParameterControl;
        private ValParameterControl fourthLValParameterControl;
        private ValParameterControl fifthLValParameterControl;
        private ValParameterControl firstRValParameterControl;
        private ValParameterControl secondRValParameterControl;
        private ValParameterControl thirdRValParameterControl;
        private ValParameterControl fourthRValParameterControl;
        private ValParameterControl fifthRValParameterControl;
        private ValParameterControl numTeethValParameterControl;
        private System.Windows.Forms.Button buildButton;
    }
}

