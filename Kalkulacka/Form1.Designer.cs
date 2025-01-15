namespace Kalkulacka
{
    partial class CalculatorWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            entry = new TextBox();
            button1 = new RoundedButton();
            button2 = new RoundedButton();
            button3 = new RoundedButton();
            button4 = new RoundedButton();
            button5 = new RoundedButton();
            button6 = new RoundedButton();
            button7 = new RoundedButton();
            button8 = new RoundedButton();
            button9 = new RoundedButton();
            button0 = new RoundedButton();
            btnEqual = new RoundedButton();
            btnPlus = new RoundedButton();
            btnMinus = new RoundedButton();
            btnMultiply = new RoundedButton();
            btnDivide = new RoundedButton();
            trackInputsLabel = new Label();
            decimalPoint = new RoundedButton();
            AC = new RoundedButton();
            del = new RoundedButton();
            SuspendLayout();
            // 
            // entry
            // 
            entry.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entry.Location = new Point(35, 109);
            entry.Margin = new Padding(4, 2, 4, 2);
            entry.Name = "entry";
            entry.Size = new Size(849, 57);
            entry.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(167, 309);
            button1.Margin = new Padding(4, 2, 4, 2);
            button1.Name = "button1";
            button1.Size = new Size(186, 94);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += numberClick;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(368, 309);
            button2.Margin = new Padding(4, 2, 4, 2);
            button2.Name = "button2";
            button2.Size = new Size(186, 94);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += numberClick;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(570, 309);
            button3.Margin = new Padding(4, 2, 4, 2);
            button3.Name = "button3";
            button3.Size = new Size(186, 94);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += numberClick;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(167, 435);
            button4.Margin = new Padding(4, 2, 4, 2);
            button4.Name = "button4";
            button4.Size = new Size(186, 94);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += numberClick;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(368, 435);
            button5.Margin = new Padding(4, 2, 4, 2);
            button5.Name = "button5";
            button5.Size = new Size(186, 94);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += numberClick;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(570, 435);
            button6.Margin = new Padding(4, 2, 4, 2);
            button6.Name = "button6";
            button6.Size = new Size(186, 94);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += numberClick;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(167, 561);
            button7.Margin = new Padding(4, 2, 4, 2);
            button7.Name = "button7";
            button7.Size = new Size(186, 94);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += numberClick;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(368, 561);
            button8.Margin = new Padding(4, 2, 4, 2);
            button8.Name = "button8";
            button8.Size = new Size(186, 94);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += numberClick;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Location = new Point(570, 561);
            button9.Margin = new Padding(4, 2, 4, 2);
            button9.Name = "button9";
            button9.Size = new Size(186, 94);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += numberClick;
            // 
            // button0
            // 
            button0.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button0.Location = new Point(368, 685);
            button0.Margin = new Padding(4, 2, 4, 2);
            button0.Name = "button0";
            button0.Size = new Size(186, 96);
            button0.TabIndex = 10;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += numberClick;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEqual.Location = new Point(604, 196);
            btnEqual.Margin = new Padding(4, 2, 4, 2);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(152, 87);
            btnEqual.TabIndex = 11;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(167, 196);
            btnPlus.Margin = new Padding(4, 2, 4, 2);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(85, 87);
            btnPlus.TabIndex = 12;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += operandClick;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(275, 196);
            btnMinus.Margin = new Padding(4, 2, 4, 2);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(87, 87);
            btnMinus.TabIndex = 13;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += operandClick;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiply.Location = new Point(384, 196);
            btnMultiply.Margin = new Padding(4, 2, 4, 2);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(85, 87);
            btnMultiply.TabIndex = 14;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += operandClick;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivide.Location = new Point(490, 196);
            btnDivide.Margin = new Padding(4, 2, 4, 2);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(87, 87);
            btnDivide.TabIndex = 15;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += operandClick;
            // 
            // trackInputsLabel
            // 
            trackInputsLabel.AutoSize = true;
            trackInputsLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            trackInputsLabel.Location = new Point(35, 19);
            trackInputsLabel.Margin = new Padding(6, 0, 6, 0);
            trackInputsLabel.Name = "trackInputsLabel";
            trackInputsLabel.Size = new Size(0, 51);
            trackInputsLabel.TabIndex = 16;
            // 
            // decimalPoint
            // 
            decimalPoint.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            decimalPoint.Location = new Point(275, 685);
            decimalPoint.Margin = new Padding(6, 6, 6, 6);
            decimalPoint.Name = "decimalPoint";
            decimalPoint.Size = new Size(78, 96);
            decimalPoint.TabIndex = 17;
            decimalPoint.Text = ".";
            decimalPoint.UseVisualStyleBackColor = true;
            decimalPoint.Click += decimalPoint_Click;
            // 
            // AC
            // 
            AC.Location = new Point(570, 685);
            AC.Margin = new Padding(6, 6, 6, 6);
            AC.Name = "AC";
            AC.Size = new Size(87, 96);
            AC.TabIndex = 18;
            AC.Text = "AC";
            AC.UseVisualStyleBackColor = true;
            AC.Click += AC_Click;
            // 
            // del
            // 
            del.Location = new Point(669, 685);
            del.Margin = new Padding(6, 6, 6, 6);
            del.Name = "del";
            del.Size = new Size(87, 96);
            del.TabIndex = 19;
            del.Text = "del";
            del.UseVisualStyleBackColor = true;
            del.Click += del_Click;
            // 
            // CalculatorWindow
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 868);
            Controls.Add(del);
            Controls.Add(AC);
            Controls.Add(decimalPoint);
            Controls.Add(trackInputsLabel);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(btnEqual);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(entry);
            Margin = new Padding(4, 2, 4, 2);
            Name = "CalculatorWindow";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox entry;
        private RoundedButton button1;
        private RoundedButton button2;
        private RoundedButton button3;
        private RoundedButton button4;
        private RoundedButton button5;
        private RoundedButton button6;
        private RoundedButton button7;
        private RoundedButton button8;
        private RoundedButton button9;
        private RoundedButton button0;
        private RoundedButton btnEqual;
        private RoundedButton btnPlus;
        private RoundedButton btnMinus;
        private RoundedButton btnMultiply;
        private RoundedButton btnDivide;
        private Label trackInputsLabel;
        private RoundedButton decimalPoint;
        private RoundedButton AC;
        private RoundedButton del;
    }
}
