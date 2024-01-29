namespace Form2
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
            gb_player1 = new GroupBox();
            tb_player1 = new TextBox();
            lbl_name_player1 = new Label();
            rb_player1_o = new RadioButton();
            rb_player1_x = new RadioButton();
            gb_player2 = new GroupBox();
            tb_player2 = new TextBox();
            lbl_name_player2 = new Label();
            rb_player2_o = new RadioButton();
            rb_player2_x = new RadioButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btn_start = new Button();
            gb_player1.SuspendLayout();
            gb_player2.SuspendLayout();
            SuspendLayout();
            // 
            // gb_player1
            // 
            gb_player1.Controls.Add(tb_player1);
            gb_player1.Controls.Add(lbl_name_player1);
            gb_player1.Controls.Add(rb_player1_o);
            gb_player1.Controls.Add(rb_player1_x);
            gb_player1.Location = new Point(12, 68);
            gb_player1.Name = "gb_player1";
            gb_player1.Size = new Size(332, 188);
            gb_player1.TabIndex = 0;
            gb_player1.TabStop = false;
            gb_player1.Text = "Player 1";
            // 
            // tb_player1
            // 
            tb_player1.Location = new Point(186, 140);
            tb_player1.Name = "tb_player1";
            tb_player1.Size = new Size(125, 27);
            tb_player1.TabIndex = 5;
            // 
            // lbl_name_player1
            // 
            lbl_name_player1.AutoSize = true;
            lbl_name_player1.Location = new Point(21, 147);
            lbl_name_player1.Name = "lbl_name_player1";
            lbl_name_player1.Size = new Size(49, 20);
            lbl_name_player1.TabIndex = 4;
            lbl_name_player1.Text = "Name";
            // 
            // rb_player1_o
            // 
            rb_player1_o.AutoSize = true;
            rb_player1_o.Location = new Point(194, 72);
            rb_player1_o.Name = "rb_player1_o";
            rb_player1_o.Size = new Size(41, 24);
            rb_player1_o.TabIndex = 1;
            rb_player1_o.TabStop = true;
            rb_player1_o.Text = "O";
            rb_player1_o.UseVisualStyleBackColor = true;
            rb_player1_o.CheckedChanged += rb_player1_o_CheckedChanged;
            // 
            // rb_player1_x
            // 
            rb_player1_x.AutoSize = true;
            rb_player1_x.Location = new Point(21, 72);
            rb_player1_x.Name = "rb_player1_x";
            rb_player1_x.Size = new Size(39, 24);
            rb_player1_x.TabIndex = 0;
            rb_player1_x.TabStop = true;
            rb_player1_x.Text = "X";
            rb_player1_x.UseVisualStyleBackColor = true;
            rb_player1_x.CheckedChanged += rb_player1_x_CheckedChanged;
            // 
            // gb_player2
            // 
            gb_player2.Controls.Add(tb_player2);
            gb_player2.Controls.Add(lbl_name_player2);
            gb_player2.Controls.Add(rb_player2_o);
            gb_player2.Controls.Add(rb_player2_x);
            gb_player2.Location = new Point(441, 68);
            gb_player2.Name = "gb_player2";
            gb_player2.Size = new Size(332, 188);
            gb_player2.TabIndex = 1;
            gb_player2.TabStop = false;
            gb_player2.Text = "Player 2";
            // 
            // tb_player2
            // 
            tb_player2.Location = new Point(179, 144);
            tb_player2.Name = "tb_player2";
            tb_player2.Size = new Size(125, 27);
            tb_player2.TabIndex = 4;
            // 
            // lbl_name_player2
            // 
            lbl_name_player2.AutoSize = true;
            lbl_name_player2.Location = new Point(38, 144);
            lbl_name_player2.Name = "lbl_name_player2";
            lbl_name_player2.Size = new Size(49, 20);
            lbl_name_player2.TabIndex = 3;
            lbl_name_player2.Text = "Name";
            // 
            // rb_player2_o
            // 
            rb_player2_o.AutoSize = true;
            rb_player2_o.Location = new Point(179, 72);
            rb_player2_o.Name = "rb_player2_o";
            rb_player2_o.Size = new Size(41, 24);
            rb_player2_o.TabIndex = 2;
            rb_player2_o.TabStop = true;
            rb_player2_o.Text = "O";
            rb_player2_o.UseVisualStyleBackColor = true;
            rb_player2_o.CheckedChanged += rb_player2_o_CheckedChanged;
            // 
            // rb_player2_x
            // 
            rb_player2_x.AutoSize = true;
            rb_player2_x.Location = new Point(25, 72);
            rb_player2_x.Name = "rb_player2_x";
            rb_player2_x.Size = new Size(39, 24);
            rb_player2_x.TabIndex = 1;
            rb_player2_x.TabStop = true;
            rb_player2_x.Text = "X";
            rb_player2_x.UseVisualStyleBackColor = true;
            rb_player2_x.CheckedChanged += rb_player2_x_CheckedChanged;
            // 
            // btn_start
            // 
            btn_start.Location = new Point(296, 340);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(209, 71);
            btn_start.TabIndex = 2;
            btn_start.Text = "Start";
            btn_start.UseVisualStyleBackColor = true;
            btn_start.Click += btn_start_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_start);
            Controls.Add(gb_player2);
            Controls.Add(gb_player1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gb_player1.ResumeLayout(false);
            gb_player1.PerformLayout();
            gb_player2.ResumeLayout(false);
            gb_player2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_player1;
        private GroupBox gb_player2;
        private RadioButton rb_player1_o;
        private RadioButton rb_player1_x;
        private RadioButton rb_player2_o;
        private RadioButton rb_player2_x;
        private Label lbl_name_player1;
        private Label lbl_name_player2;
        private TextBox tb_player1;
        private TextBox tb_player2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btn_start;
    }
}
