namespace BTLQUANLYQUANAN
{
    partial class Flogin
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
            label1 = new Label();
            label2 = new Label();
            txbDangnhap = new TextBox();
            txbMatkhau = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label3 = new Label();
            btnDangnhap = new Button();
            picExit = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picExit).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(182, 242);
            label1.Name = "label1";
            label1.Size = new Size(112, 24);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(182, 309);
            label2.Name = "label2";
            label2.Size = new Size(100, 24);
            label2.TabIndex = 1;
            label2.Text = "Mật Khẩu";
            // 
            // txbDangnhap
            // 
            txbDangnhap.BorderStyle = BorderStyle.FixedSingle;
            txbDangnhap.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txbDangnhap.Location = new Point(321, 242);
            txbDangnhap.Name = "txbDangnhap";
            txbDangnhap.Size = new Size(189, 30);
            txbDangnhap.TabIndex = 2;
            // 
            // txbMatkhau
            // 
            txbMatkhau.BorderStyle = BorderStyle.FixedSingle;
            txbMatkhau.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txbMatkhau.Location = new Point(321, 306);
            txbMatkhau.Name = "txbMatkhau";
            txbMatkhau.Size = new Size(189, 30);
            txbMatkhau.TabIndex = 3;
            txbMatkhau.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_FastFood;
            pictureBox1.Location = new Point(321, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(166, 553);
            panel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(22, 48);
            label3.Name = "label3";
            label3.Size = new Size(123, 27);
            label3.TabIndex = 0;
            label3.Text = "Xin chào! ";
            // 
            // btnDangnhap
            // 
            btnDangnhap.BackColor = Color.Orange;
            btnDangnhap.FlatAppearance.BorderColor = Color.Lime;
            btnDangnhap.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            btnDangnhap.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            btnDangnhap.FlatStyle = FlatStyle.Flat;
            btnDangnhap.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangnhap.ForeColor = Color.Transparent;
            btnDangnhap.Location = new Point(336, 377);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(143, 54);
            btnDangnhap.TabIndex = 6;
            btnDangnhap.Text = "Đăng nhập";
            btnDangnhap.UseVisualStyleBackColor = false;
            btnDangnhap.Click += btnDangnhap_Click;
            // 
            // picExit
            // 
            picExit.Cursor = Cursors.Hand;
            picExit.Image = Properties.Resources.exit;
            picExit.Location = new Point(626, 0);
            picExit.Name = "picExit";
            picExit.Size = new Size(31, 21);
            picExit.SizeMode = PictureBoxSizeMode.Zoom;
            picExit.TabIndex = 7;
            picExit.TabStop = false;
            picExit.Click += pic_Exit_Click;
            // 
            // Flogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 553);
            Controls.Add(picExit);
            Controls.Add(btnDangnhap);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(txbMatkhau);
            Controls.Add(txbDangnhap);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Flogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picExit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txbDangnhap;
        private TextBox txbMatkhau;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label3;
        private Button btnDangnhap;
        private PictureBox picExit;
    }
}