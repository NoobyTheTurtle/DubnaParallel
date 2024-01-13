namespace DubnaParallel
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.startButton = new System.Windows.Forms.Button();
            this.initArray = new System.Windows.Forms.ListBox();
            this.sortedArray = new System.Windows.Forms.ListBox();
            this.arraySize = new System.Windows.Forms.TextBox();
            this.startRange = new System.Windows.Forms.TextBox();
            this.endRange = new System.Windows.Forms.TextBox();
            this.labelForArraySize = new System.Windows.Forms.Label();
            this.labelForStartRange = new System.Windows.Forms.Label();
            this.labelForEndRange = new System.Windows.Forms.Label();
            this.labelForInitArray = new System.Windows.Forms.Label();
            this.labelForSortedArray = new System.Windows.Forms.Label();
            this.labelForStatistics = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(676, 404);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(112, 34);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // initArray
            // 
            this.initArray.FormattingEnabled = true;
            this.initArray.ItemHeight = 16;
            this.initArray.Location = new System.Drawing.Point(13, 179);
            this.initArray.Name = "initArray";
            this.initArray.Size = new System.Drawing.Size(96, 196);
            this.initArray.TabIndex = 0;
            // 
            // sortedArray
            // 
            this.sortedArray.FormattingEnabled = true;
            this.sortedArray.ItemHeight = 16;
            this.sortedArray.Location = new System.Drawing.Point(115, 179);
            this.sortedArray.Name = "sortedArray";
            this.sortedArray.Size = new System.Drawing.Size(95, 196);
            this.sortedArray.TabIndex = 1;
            // 
            // arraySize
            // 
            this.arraySize.Location = new System.Drawing.Point(12, 34);
            this.arraySize.Name = "arraySize";
            this.arraySize.Size = new System.Drawing.Size(100, 22);
            this.arraySize.TabIndex = 7;
            // 
            // startRange
            // 
            this.startRange.Location = new System.Drawing.Point(12, 93);
            this.startRange.Name = "startRange";
            this.startRange.Size = new System.Drawing.Size(100, 22);
            this.startRange.TabIndex = 8;
            // 
            // endRange
            // 
            this.endRange.Location = new System.Drawing.Point(131, 93);
            this.endRange.Name = "endRange";
            this.endRange.Size = new System.Drawing.Size(100, 22);
            this.endRange.TabIndex = 9;
            // 
            // labelForArraySize
            // 
            this.labelForArraySize.AutoSize = true;
            this.labelForArraySize.Location = new System.Drawing.Point(12, 9);
            this.labelForArraySize.Name = "labelForArraySize";
            this.labelForArraySize.Size = new System.Drawing.Size(66, 16);
            this.labelForArraySize.TabIndex = 10;
            this.labelForArraySize.Text = "Array size";
            // 
            // labelForStartRange
            // 
            this.labelForStartRange.AutoSize = true;
            this.labelForStartRange.Location = new System.Drawing.Point(10, 74);
            this.labelForStartRange.Name = "labelForStartRange";
            this.labelForStartRange.Size = new System.Drawing.Size(72, 16);
            this.labelForStartRange.TabIndex = 11;
            this.labelForStartRange.Text = "Start range";
            // 
            // labelForEndRange
            // 
            this.labelForEndRange.AutoSize = true;
            this.labelForEndRange.Location = new System.Drawing.Point(128, 74);
            this.labelForEndRange.Name = "labelForEndRange";
            this.labelForEndRange.Size = new System.Drawing.Size(69, 16);
            this.labelForEndRange.TabIndex = 12;
            this.labelForEndRange.Text = "End range";
            // 
            // labelForInitArray
            // 
            this.labelForInitArray.AutoSize = true;
            this.labelForInitArray.Location = new System.Drawing.Point(12, 160);
            this.labelForInitArray.Name = "labelForInitArray";
            this.labelForInitArray.Size = new System.Drawing.Size(57, 16);
            this.labelForInitArray.TabIndex = 13;
            this.labelForInitArray.Text = "Init array";
            // 
            // labelForSortedArray
            // 
            this.labelForSortedArray.AutoSize = true;
            this.labelForSortedArray.Location = new System.Drawing.Point(115, 159);
            this.labelForSortedArray.Name = "labelForSortedArray";
            this.labelForSortedArray.Size = new System.Drawing.Size(81, 16);
            this.labelForSortedArray.TabIndex = 14;
            this.labelForSortedArray.Text = "Sorted array";
            // 
            // labelForStatistics
            // 
            this.labelForStatistics.AutoSize = true;
            this.labelForStatistics.Location = new System.Drawing.Point(233, 179);
            this.labelForStatistics.Name = "labelForStatistics";
            this.labelForStatistics.Size = new System.Drawing.Size(0, 16);
            this.labelForStatistics.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelForStatistics);
            this.Controls.Add(this.labelForSortedArray);
            this.Controls.Add(this.labelForInitArray);
            this.Controls.Add(this.labelForEndRange);
            this.Controls.Add(this.labelForStartRange);
            this.Controls.Add(this.labelForArraySize);
            this.Controls.Add(this.endRange);
            this.Controls.Add(this.startRange);
            this.Controls.Add(this.arraySize);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.sortedArray);
            this.Controls.Add(this.initArray);
            this.Name = "Form1";
            this.Text = "Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ListBox initArray;
        private System.Windows.Forms.ListBox sortedArray;
        private System.Windows.Forms.TextBox arraySize;
        private System.Windows.Forms.TextBox startRange;
        private System.Windows.Forms.TextBox endRange;
        private System.Windows.Forms.Label labelForArraySize;
        private System.Windows.Forms.Label labelForStartRange;
        private System.Windows.Forms.Label labelForEndRange;
        private System.Windows.Forms.Label labelForInitArray;
        private System.Windows.Forms.Label labelForSortedArray;
        private System.Windows.Forms.Label labelForStatistics;
    }
}

