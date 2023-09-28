namespace bai3._2
{
    partial class Form1
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
            text1 = new TextBox();
            text2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbresult = new Label();
            radmultiplication = new RadioButton();
            radsubtraction = new RadioButton();
            radaddition = new RadioButton();
            raddivision = new RadioButton();
            groupBox1 = new GroupBox();
            textresult = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // text1
            // 
            text1.Location = new Point(97, 22);
            text1.Name = "text1";
            text1.Size = new Size(235, 27);
            text1.TabIndex = 0;
            // 
            // text2
            // 
            text2.Location = new Point(97, 67);
            text2.Name = "text2";
            text2.Size = new Size(235, 27);
            text2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 25);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 4;
            label1.Text = "Số 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 74);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 5;
            label2.Text = "Số 2:";
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            // 
            // lbresult
            // 
            lbresult.AutoSize = true;
            lbresult.Location = new Point(32, 232);
            lbresult.MaximumSize = new Size(100, 100);
            lbresult.MinimumSize = new Size(300, 10);
            lbresult.Name = "lbresult";
            lbresult.Size = new Size(300, 20);
            lbresult.TabIndex = 6;
            lbresult.Text = "Kết quả:";
            lbresult.Click += label4_Click;
            // 
            // radmultiplication
            // 
            radmultiplication.AutoSize = true;
            radmultiplication.Location = new Point(160, 36);
            radmultiplication.Name = "radmultiplication";
            radmultiplication.Size = new Size(65, 24);
            radmultiplication.TabIndex = 7;
            radmultiplication.TabStop = true;
            radmultiplication.Text = "Nhân";
            radmultiplication.UseVisualStyleBackColor = true;
            radmultiplication.CheckedChanged += radmultiplication_CheckedChanged;
            // 
            // radsubtraction
            // 
            radsubtraction.Location = new Point(90, 36);
            radsubtraction.Name = "radsubtraction";
            radsubtraction.Size = new Size(73, 24);
            radsubtraction.TabIndex = 11;
            radsubtraction.Text = "Trừ";
            radsubtraction.CheckedChanged += radsubtraction_CheckedChanged;
            // 
            // radaddition
            // 
            radaddition.AutoSize = true;
            radaddition.Location = new Point(10, 36);
            radaddition.Name = "radaddition";
            radaddition.Size = new Size(65, 24);
            radaddition.TabIndex = 9;
            radaddition.TabStop = true;
            radaddition.Text = "Cộng";
            radaddition.UseVisualStyleBackColor = true;
            radaddition.CheckedChanged += radaddition_CheckedChanged;
            // 
            // raddivision
            // 
            raddivision.AutoSize = true;
            raddivision.Location = new Point(249, 36);
            raddivision.Name = "raddivision";
            raddivision.Size = new Size(59, 24);
            raddivision.TabIndex = 10;
            raddivision.TabStop = true;
            raddivision.Text = "Chia";
            raddivision.UseVisualStyleBackColor = true;
            raddivision.CheckedChanged += raddivision_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radaddition);
            groupBox1.Controls.Add(radmultiplication);
            groupBox1.Controls.Add(raddivision);
            groupBox1.Controls.Add(radsubtraction);
            groupBox1.Location = new Point(40, 121);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 77);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "phép tinh";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textresult
            // 
            textresult.Location = new Point(97, 229);
            textresult.Name = "textresult";
            textresult.Size = new Size(235, 27);
            textresult.TabIndex = 12;
            textresult.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 273);
            Controls.Add(textresult);
            Controls.Add(lbresult);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(text2);
            Controls.Add(text1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox text1;
        private TextBox text2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbresult;
        private RadioButton radmultiplication;
        private RadioButton radsubtraction;
        private RadioButton radaddition;
        private RadioButton raddivision;
        private GroupBox groupBox1;
        private TextBox textresult;
    }
}