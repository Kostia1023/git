
namespace labs15_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NElArith = new System.Windows.Forms.Button();
            this.SumArith = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Res = new System.Windows.Forms.Label();
            this.FirstArith = new System.Windows.Forms.TextBox();
            this.ArithD = new System.Windows.Forms.TextBox();
            this.ArithN = new System.Windows.Forms.TextBox();
            this.FirstGoem = new System.Windows.Forms.TextBox();
            this.GeomQ = new System.Windows.Forms.TextBox();
            this.GeomN = new System.Windows.Forms.TextBox();
            this.NElGeom = new System.Windows.Forms.Button();
            this.SumGeom = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Перший елемент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Різниця";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Номер елемента";
            // 
            // NElArith
            // 
            this.NElArith.Location = new System.Drawing.Point(165, 255);
            this.NElArith.Name = "NElArith";
            this.NElArith.Size = new System.Drawing.Size(75, 23);
            this.NElArith.TabIndex = 3;
            this.NElArith.Text = "N елемент";
            this.NElArith.UseVisualStyleBackColor = true;
            this.NElArith.Click += new System.EventHandler(this.NElArith_Click);
            // 
            // SumArith
            // 
            this.SumArith.Location = new System.Drawing.Point(165, 306);
            this.SumArith.Name = "SumArith";
            this.SumArith.Size = new System.Drawing.Size(75, 23);
            this.SumArith.TabIndex = 4;
            this.SumArith.Text = "Сума";
            this.SumArith.UseVisualStyleBackColor = true;
            this.SumArith.Click += new System.EventHandler(this.SumArith_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Перший елмент";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(468, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Знаменик ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Номер елемента";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Результат:";
            // 
            // Res
            // 
            this.Res.AutoSize = true;
            this.Res.Location = new System.Drawing.Point(342, 295);
            this.Res.Name = "Res";
            this.Res.Size = new System.Drawing.Size(0, 13);
            this.Res.TabIndex = 9;
            // 
            // FirstArith
            // 
            this.FirstArith.Location = new System.Drawing.Point(165, 122);
            this.FirstArith.Name = "FirstArith";
            this.FirstArith.Size = new System.Drawing.Size(100, 20);
            this.FirstArith.TabIndex = 10;
            this.FirstArith.Text = "0";
            // 
            // ArithD
            // 
            this.ArithD.Location = new System.Drawing.Point(165, 165);
            this.ArithD.Name = "ArithD";
            this.ArithD.Size = new System.Drawing.Size(100, 20);
            this.ArithD.TabIndex = 11;
            this.ArithD.Text = "0";
            // 
            // ArithN
            // 
            this.ArithN.Location = new System.Drawing.Point(165, 215);
            this.ArithN.Name = "ArithN";
            this.ArithN.Size = new System.Drawing.Size(100, 20);
            this.ArithN.TabIndex = 12;
            this.ArithN.Text = "0";
            // 
            // FirstGoem
            // 
            this.FirstGoem.Location = new System.Drawing.Point(468, 121);
            this.FirstGoem.Name = "FirstGoem";
            this.FirstGoem.Size = new System.Drawing.Size(100, 20);
            this.FirstGoem.TabIndex = 13;
            this.FirstGoem.Text = "0";
            // 
            // GeomQ
            // 
            this.GeomQ.Location = new System.Drawing.Point(468, 164);
            this.GeomQ.Name = "GeomQ";
            this.GeomQ.Size = new System.Drawing.Size(100, 20);
            this.GeomQ.TabIndex = 14;
            this.GeomQ.Text = "0";
            // 
            // GeomN
            // 
            this.GeomN.Location = new System.Drawing.Point(468, 214);
            this.GeomN.Name = "GeomN";
            this.GeomN.Size = new System.Drawing.Size(100, 20);
            this.GeomN.TabIndex = 15;
            this.GeomN.Text = "0";
            // 
            // NElGeom
            // 
            this.NElGeom.Location = new System.Drawing.Point(468, 255);
            this.NElGeom.Name = "NElGeom";
            this.NElGeom.Size = new System.Drawing.Size(75, 23);
            this.NElGeom.TabIndex = 16;
            this.NElGeom.Text = "N елемент";
            this.NElGeom.UseVisualStyleBackColor = true;
            this.NElGeom.Click += new System.EventHandler(this.NElGeom_Click);
            // 
            // SumGeom
            // 
            this.SumGeom.Location = new System.Drawing.Point(468, 306);
            this.SumGeom.Name = "SumGeom";
            this.SumGeom.Size = new System.Drawing.Size(75, 23);
            this.SumGeom.TabIndex = 17;
            this.SumGeom.Text = "Сума";
            this.SumGeom.UseVisualStyleBackColor = true;
            this.SumGeom.Click += new System.EventHandler(this.SumGeom_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(162, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Арифметична прогресія";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(465, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Геометрична прогресія";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SumGeom);
            this.Controls.Add(this.NElGeom);
            this.Controls.Add(this.GeomN);
            this.Controls.Add(this.GeomQ);
            this.Controls.Add(this.FirstGoem);
            this.Controls.Add(this.ArithN);
            this.Controls.Add(this.ArithD);
            this.Controls.Add(this.FirstArith);
            this.Controls.Add(this.Res);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SumArith);
            this.Controls.Add(this.NElArith);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button NElArith;
        private System.Windows.Forms.Button SumArith;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Res;
        private System.Windows.Forms.TextBox FirstArith;
        private System.Windows.Forms.TextBox ArithD;
        private System.Windows.Forms.TextBox ArithN;
        private System.Windows.Forms.TextBox FirstGoem;
        private System.Windows.Forms.TextBox GeomQ;
        private System.Windows.Forms.TextBox GeomN;
        private System.Windows.Forms.Button NElGeom;
        private System.Windows.Forms.Button SumGeom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

