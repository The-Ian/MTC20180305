namespace WindowsFormsApp1
{
    partial class smplCalc
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
            this.operatorBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.valOneTextBox = new System.Windows.Forms.TextBox();
            this.valTwoTextBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.rbSubtract = new System.Windows.Forms.RadioButton();
            this.rbMultiply = new System.Windows.Forms.RadioButton();
            this.rbDivide = new System.Windows.Forms.RadioButton();
            this.operatorBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // operatorBox
            // 
            this.operatorBox.AccessibleName = "";
            this.operatorBox.Controls.Add(this.rbDivide);
            this.operatorBox.Controls.Add(this.rbMultiply);
            this.operatorBox.Controls.Add(this.rbSubtract);
            this.operatorBox.Controls.Add(this.rbAdd);
            this.operatorBox.Location = new System.Drawing.Point(173, 36);
            this.operatorBox.Name = "operatorBox";
            this.operatorBox.Size = new System.Drawing.Size(88, 120);
            this.operatorBox.TabIndex = 0;
            this.operatorBox.TabStop = false;
            this.operatorBox.Text = "Operator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Second Value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Result:";
            // 
            // valOneTextBox
            // 
            this.valOneTextBox.Location = new System.Drawing.Point(26, 53);
            this.valOneTextBox.Name = "valOneTextBox";
            this.valOneTextBox.Size = new System.Drawing.Size(100, 20);
            this.valOneTextBox.TabIndex = 4;
            // 
            // valTwoTextBox
            // 
            this.valTwoTextBox.Location = new System.Drawing.Point(26, 102);
            this.valTwoTextBox.Name = "valTwoTextBox";
            this.valTwoTextBox.Size = new System.Drawing.Size(100, 20);
            this.valTwoTextBox.TabIndex = 5;
            // 
            // calcButton
            // 
            this.calcButton.BackColor = System.Drawing.Color.MistyRose;
            this.calcButton.Location = new System.Drawing.Point(51, 146);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 6;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = false;
            this.calcButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(26, 200);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(100, 20);
            this.resultTextBox.TabIndex = 7;
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Location = new System.Drawing.Point(7, 20);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(44, 17);
            this.rbAdd.TabIndex = 0;
            this.rbAdd.TabStop = true;
            this.rbAdd.Text = "Add";
            this.rbAdd.UseVisualStyleBackColor = true;
            // 
            // rbSubtract
            // 
            this.rbSubtract.AutoSize = true;
            this.rbSubtract.Location = new System.Drawing.Point(7, 44);
            this.rbSubtract.Name = "rbSubtract";
            this.rbSubtract.Size = new System.Drawing.Size(65, 17);
            this.rbSubtract.TabIndex = 1;
            this.rbSubtract.TabStop = true;
            this.rbSubtract.Text = "Subtract";
            this.rbSubtract.UseVisualStyleBackColor = true;
            // 
            // rbMultiply
            // 
            this.rbMultiply.AutoSize = true;
            this.rbMultiply.Location = new System.Drawing.Point(7, 66);
            this.rbMultiply.Name = "rbMultiply";
            this.rbMultiply.Size = new System.Drawing.Size(60, 17);
            this.rbMultiply.TabIndex = 2;
            this.rbMultiply.TabStop = true;
            this.rbMultiply.Text = "Multiply";
            this.rbMultiply.UseVisualStyleBackColor = true;
            // 
            // rbDivide
            // 
            this.rbDivide.AutoSize = true;
            this.rbDivide.Location = new System.Drawing.Point(7, 90);
            this.rbDivide.Name = "rbDivide";
            this.rbDivide.Size = new System.Drawing.Size(55, 17);
            this.rbDivide.TabIndex = 3;
            this.rbDivide.TabStop = true;
            this.rbDivide.Text = "Divide";
            this.rbDivide.UseVisualStyleBackColor = true;
            // 
            // smplCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.valTwoTextBox);
            this.Controls.Add(this.valOneTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.operatorBox);
            this.Name = "smplCalc";
            this.Text = "Simple Calculator";
            this.operatorBox.ResumeLayout(false);
            this.operatorBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox operatorBox;
        private System.Windows.Forms.RadioButton rbDivide;
        private System.Windows.Forms.RadioButton rbMultiply;
        private System.Windows.Forms.RadioButton rbSubtract;
        private System.Windows.Forms.RadioButton rbAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox valOneTextBox;
        private System.Windows.Forms.TextBox valTwoTextBox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

