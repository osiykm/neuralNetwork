namespace IILab2 {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.symbolBox = new System.Windows.Forms.PictureBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.numberImage = new System.Windows.Forms.NumericUpDown();
            this.analyseButton = new System.Windows.Forms.Button();
            this.learnButton = new System.Windows.Forms.Button();
            this.progressLearn = new System.Windows.Forms.ProgressBar();
            this.clearMemoryCheckbox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.symbolBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberImage)).BeginInit();
            this.SuspendLayout();
            // 
            // symbolBox
            // 
            this.symbolBox.Location = new System.Drawing.Point(7, 12);
            this.symbolBox.Name = "symbolBox";
            this.symbolBox.Size = new System.Drawing.Size(280, 280);
            this.symbolBox.TabIndex = 0;
            this.symbolBox.TabStop = false;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(12, 298);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(106, 23);
            this.loadButton.TabIndex = 1;
            this.loadButton.Text = "Load Image";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // numberImage
            // 
            this.numberImage.Location = new System.Drawing.Point(217, 298);
            this.numberImage.Name = "numberImage";
            this.numberImage.Size = new System.Drawing.Size(70, 20);
            this.numberImage.TabIndex = 2;
            // 
            // analyseButton
            // 
            this.analyseButton.Location = new System.Drawing.Point(12, 389);
            this.analyseButton.Name = "analyseButton";
            this.analyseButton.Size = new System.Drawing.Size(275, 23);
            this.analyseButton.TabIndex = 3;
            this.analyseButton.Text = "Test(MNIST)";
            this.analyseButton.UseVisualStyleBackColor = true;
            this.analyseButton.Click += new System.EventHandler(this.analyseButton_Click);
            // 
            // learnButton
            // 
            this.learnButton.Location = new System.Drawing.Point(12, 356);
            this.learnButton.Name = "learnButton";
            this.learnButton.Size = new System.Drawing.Size(129, 23);
            this.learnButton.TabIndex = 4;
            this.learnButton.Text = "Learn";
            this.learnButton.UseVisualStyleBackColor = true;
            this.learnButton.Click += new System.EventHandler(this.learnButton_Click);
            // 
            // progressLearn
            // 
            this.progressLearn.Location = new System.Drawing.Point(12, 418);
            this.progressLearn.Name = "progressLearn";
            this.progressLearn.Size = new System.Drawing.Size(275, 23);
            this.progressLearn.Step = 1;
            this.progressLearn.TabIndex = 6;
            // 
            // clearMemoryCheckbox
            // 
            this.clearMemoryCheckbox.AutoSize = true;
            this.clearMemoryCheckbox.Location = new System.Drawing.Point(162, 360);
            this.clearMemoryCheckbox.Name = "clearMemoryCheckbox";
            this.clearMemoryCheckbox.Size = new System.Drawing.Size(90, 17);
            this.clearMemoryCheckbox.TabIndex = 7;
            this.clearMemoryCheckbox.Text = "Clear Memory";
            this.clearMemoryCheckbox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Analyse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MNIST",
            "File"});
            this.comboBox1.Location = new System.Drawing.Point(124, 298);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(87, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 453);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clearMemoryCheckbox);
            this.Controls.Add(this.progressLearn);
            this.Controls.Add(this.learnButton);
            this.Controls.Add(this.analyseButton);
            this.Controls.Add(this.numberImage);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.symbolBox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Neural Network";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.symbolBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox symbolBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.NumericUpDown numberImage;
        private System.Windows.Forms.Button analyseButton;
        private System.Windows.Forms.Button learnButton;
        private System.Windows.Forms.ProgressBar progressLearn;
        private System.Windows.Forms.CheckBox clearMemoryCheckbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

