namespace console
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">true, если управляемые ресурсы должны быть удалены; иначе — false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbQ = new System.Windows.Forms.TextBox();
            this.tbP = new System.Windows.Forms.TextBox();
            this.tbH = new System.Windows.Forms.TextBox();
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSource = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.odOpen = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbQ
            // 
            this.tbQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbQ.Location = new System.Drawing.Point(82, 65);
            this.tbQ.Name = "tbQ";
            this.tbQ.Size = new System.Drawing.Size(199, 50);
            this.tbQ.TabIndex = 0;
            // 
            // tbP
            // 
            this.tbP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbP.Location = new System.Drawing.Point(82, 114);
            this.tbP.Name = "tbP";
            this.tbP.Size = new System.Drawing.Size(199, 50);
            this.tbP.TabIndex = 1;
            // 
            // tbH
            // 
            this.tbH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbH.Location = new System.Drawing.Point(82, 170);
            this.tbH.Name = "tbH";
            this.tbH.Size = new System.Drawing.Size(199, 50);
            this.tbH.TabIndex = 2;
            // 
            // tbX
            // 
            this.tbX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbX.Location = new System.Drawing.Point(82, 225);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(199, 50);
            this.tbX.TabIndex = 3;
            // 
            // tbK
            // 
            this.tbK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbK.Location = new System.Drawing.Point(82, 276);
            this.tbK.Name = "tbK";
            this.tbK.Size = new System.Drawing.Size(199, 50);
            this.tbK.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(31, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "q";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(31, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "p";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(31, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "h";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(29, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "x";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(31, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "k";
            // 
            // tbSource
            // 
            this.tbSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbSource.Location = new System.Drawing.Point(323, 62);
            this.tbSource.Multiline = true;
            this.tbSource.Name = "tbSource";
            this.tbSource.Size = new System.Drawing.Size(305, 448);
            this.tbSource.TabIndex = 13;
            // 
            // tbResult
            // 
            this.tbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbResult.Location = new System.Drawing.Point(670, 62);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(286, 448);
            this.tbResult.TabIndex = 14;
            // 
            // btnSign
            // 
            this.btnSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSign.Location = new System.Drawing.Point(31, 390);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(250, 55);
            this.btnSign.TabIndex = 11;
            this.btnSign.Text = "Подписать";
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCheck.Location = new System.Drawing.Point(31, 455);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(250, 55);
            this.btnCheck.TabIndex = 12;
            this.btnCheck.Text = "Проверить";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnOpen.Location = new System.Drawing.Point(31, 325);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(250, 55);
            this.btnOpen.TabIndex = 10;
            this.btnOpen.Text = "Выбрать файл";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label6.Location = new System.Drawing.Point(31, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(329, 45);
            this.label6.TabIndex = 15;
            this.label6.Text = "Введите параметры";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(970, 541);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbSource);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbK);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.tbH);
            this.Controls.Add(this.tbP);
            this.Controls.Add(this.tbQ);
            this.Name = "MainForm";
            this.Text = "Цифровая подпись";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tbQ;
        private System.Windows.Forms.TextBox tbP;
        private System.Windows.Forms.TextBox tbH;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSource;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog odOpen;
        private System.Windows.Forms.Label label6;
    }
}
