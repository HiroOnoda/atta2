namespace WindowsFormsApp5
{
    partial class Back
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
            this.inputX = new System.Windows.Forms.TextBox();
            this.inputN = new System.Windows.Forms.TextBox();
            this.inputE = new System.Windows.Forms.TextBox();
            this.printer = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Label();
            this.sumE = new System.Windows.Forms.Label();
            this.sumE10 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelE = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.labelSUM = new System.Windows.Forms.Label();
            this.labelSUME = new System.Windows.Forms.Label();
            this.labelSUME10 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputX
            // 
            this.inputX.Location = new System.Drawing.Point(18, 24);
            this.inputX.Name = "inputX";
            this.inputX.Size = new System.Drawing.Size(42, 20);
            this.inputX.TabIndex = 1;
            // 
            // inputN
            // 
            this.inputN.Location = new System.Drawing.Point(163, 24);
            this.inputN.Name = "inputN";
            this.inputN.Size = new System.Drawing.Size(46, 20);
            this.inputN.TabIndex = 1;
            // 
            // inputE
            // 
            this.inputE.Location = new System.Drawing.Point(88, 24);
            this.inputE.Name = "inputE";
            this.inputE.Size = new System.Drawing.Size(46, 20);
            this.inputE.TabIndex = 2;
            // 
            // printer
            // 
            this.printer.Location = new System.Drawing.Point(74, 69);
            this.printer.Name = "printer";
            this.printer.Size = new System.Drawing.Size(76, 23);
            this.printer.TabIndex = 3;
            this.printer.Text = "Вычислить";
            this.printer.UseVisualStyleBackColor = true;
            this.printer.Click += new System.EventHandler(this.printer_Click);
            // 
            // sum
            // 
            this.sum.AutoSize = true;
            this.sum.Location = new System.Drawing.Point(19, 108);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(35, 13);
            this.sum.TabIndex = 7;
            this.sum.Text = "label1";
            // 
            // sumE
            // 
            this.sumE.AutoSize = true;
            this.sumE.Location = new System.Drawing.Point(63, 108);
            this.sumE.Name = "sumE";
            this.sumE.Size = new System.Drawing.Size(35, 13);
            this.sumE.TabIndex = 8;
            this.sumE.Text = "label2";
            // 
            // sumE10
            // 
            this.sumE10.AutoSize = true;
            this.sumE10.Location = new System.Drawing.Point(115, 108);
            this.sumE10.Name = "sumE10";
            this.sumE10.Size = new System.Drawing.Size(35, 13);
            this.sumE10.TabIndex = 9;
            this.sumE10.Text = "label3";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(169, 108);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(35, 13);
            this.result.TabIndex = 10;
            this.result.Text = "label4";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(15, 8);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(57, 13);
            this.labelX.TabIndex = 11;
            this.labelX.Text = "Введите х";
            // 
            // labelE
            // 
            this.labelE.AutoSize = true;
            this.labelE.Location = new System.Drawing.Point(85, 8);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(59, 13);
            this.labelE.TabIndex = 12;
            this.labelE.Text = "Введите E";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(160, 8);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(60, 13);
            this.labelN.TabIndex = 13;
            this.labelN.Text = "Введите N";
            // 
            // labelSUM
            // 
            this.labelSUM.AutoSize = true;
            this.labelSUM.Location = new System.Drawing.Point(19, 95);
            this.labelSUM.Name = "labelSUM";
            this.labelSUM.Size = new System.Drawing.Size(29, 13);
            this.labelSUM.TabIndex = 14;
            this.labelSUM.Text = "sum:";
            // 
            // labelSUME
            // 
            this.labelSUME.AutoSize = true;
            this.labelSUME.Location = new System.Drawing.Point(63, 95);
            this.labelSUME.Name = "labelSUME";
            this.labelSUME.Size = new System.Drawing.Size(36, 13);
            this.labelSUME.TabIndex = 15;
            this.labelSUME.Text = "sumE:";
            // 
            // labelSUME10
            // 
            this.labelSUME10.AutoSize = true;
            this.labelSUME10.Location = new System.Drawing.Point(115, 95);
            this.labelSUME10.Name = "labelSUME10";
            this.labelSUME10.Size = new System.Drawing.Size(48, 13);
            this.labelSUME10.TabIndex = 16;
            this.labelSUME10.Text = "sumE10:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(169, 95);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(35, 13);
            this.labelResult.TabIndex = 17;
            this.labelResult.Text = "result:";
            // 
            // Back
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelSUME10);
            this.Controls.Add(this.labelSUME);
            this.Controls.Add(this.labelSUM);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.labelE);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.result);
            this.Controls.Add(this.sumE10);
            this.Controls.Add(this.sumE);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.printer);
            this.Controls.Add(this.inputE);
            this.Controls.Add(this.inputN);
            this.Controls.Add(this.inputX);
            this.Name = "Back";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Back_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputX;
        private System.Windows.Forms.TextBox inputN;
        private System.Windows.Forms.TextBox inputE;
        private System.Windows.Forms.Button printer;
        private System.Windows.Forms.Label sum;
        private System.Windows.Forms.Label sumE;
        private System.Windows.Forms.Label sumE10;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelE;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelSUM;
        private System.Windows.Forms.Label labelSUME;
        private System.Windows.Forms.Label labelSUME10;
        private System.Windows.Forms.Label labelResult;
    }
}

