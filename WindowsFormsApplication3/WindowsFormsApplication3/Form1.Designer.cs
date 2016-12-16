namespace WindowsFormsApplication3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.mistakesCountLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.textViewTextBox = new System.Windows.Forms.TextBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество ошибок:";
            // 
            // mistakesCountLabel
            // 
            this.mistakesCountLabel.AutoSize = true;
            this.mistakesCountLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mistakesCountLabel.Location = new System.Drawing.Point(137, 165);
            this.mistakesCountLabel.Name = "mistakesCountLabel";
            this.mistakesCountLabel.Size = new System.Drawing.Size(13, 13);
            this.mistakesCountLabel.TabIndex = 1;
            this.mistakesCountLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Время теста (в секундах):";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(262, 6);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 5;
            this.startButton.TabStop = false;
            this.startButton.Text = "Старт";
            this.startButton.UseCompatibleTextRendering = true;
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // textViewTextBox
            // 
            this.textViewTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textViewTextBox.Location = new System.Drawing.Point(15, 35);
            this.textViewTextBox.Multiline = true;
            this.textViewTextBox.Name = "textViewTextBox";
            this.textViewTextBox.ReadOnly = true;
            this.textViewTextBox.Size = new System.Drawing.Size(448, 127);
            this.textViewTextBox.TabIndex = 4;
            this.textViewTextBox.Text = "Мама мыла раму";
            this.textViewTextBox.TextChanged += new System.EventHandler(this.textViewTextBox_TextChanged);
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(156, 6);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(100, 20);
            this.timeTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 262);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.textViewTextBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mistakesCountLabel);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Клавиатурный тренажер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mistakesCountLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox textViewTextBox;
        private System.Windows.Forms.TextBox timeTextBox;
    }
}