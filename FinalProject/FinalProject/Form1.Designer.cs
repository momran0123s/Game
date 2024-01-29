namespace FinalProject
{
    partial class Form1
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
            btn_start = new Button();
            gb_player2 = new GroupBox();
            tb_player2 = new TextBox();
            lbl_name_player2 = new Label();
            rb_player2_o = new RadioButton();
            rb_player2_x = new RadioButton();
            gb_player1 = new GroupBox();
            tb_player1 = new TextBox();
            lbl_name_player1 = new Label();
            rb_player1_o = new RadioButton();
            rb_player1_x = new RadioButton();
            gb_player2.SuspendLayout();
            gb_player1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_start
            // 
            btn_start.Font = new Font("Unispace", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_start.Location = new Point(304, 326);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(209, 71);
            btn_start.TabIndex = 5;
            btn_start.Text = "Start";
            btn_start.UseVisualStyleBackColor = true;
            btn_start.Click += btn_start_Click;
            // 
            // gb_player2
            // 
            gb_player2.BackColor = Color.Transparent;
            gb_player2.Controls.Add(tb_player2);
            gb_player2.Controls.Add(lbl_name_player2);
            gb_player2.Controls.Add(rb_player2_o);
            gb_player2.Controls.Add(rb_player2_x);
            gb_player2.Font = new Font("Unispace", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            gb_player2.Location = new Point(449, 54);
            gb_player2.Name = "gb_player2";
            gb_player2.Size = new Size(332, 211);
            gb_player2.TabIndex = 4;
            gb_player2.TabStop = false;
            gb_player2.Text = "Player 2";
            // 
            // tb_player2
            // 
            tb_player2.Location = new Point(118, 141);
            tb_player2.Name = "tb_player2";
            tb_player2.Size = new Size(197, 43);
            tb_player2.TabIndex = 4;
            // 
            // lbl_name_player2
            // 
            lbl_name_player2.AutoSize = true;
            lbl_name_player2.Location = new Point(25, 148);
            lbl_name_player2.Name = "lbl_name_player2";
            lbl_name_player2.Size = new Size(87, 36);
            lbl_name_player2.TabIndex = 3;
            lbl_name_player2.Text = "Name";
            // 
            // rb_player2_o
            // 
            rb_player2_o.AutoSize = true;
            rb_player2_o.Location = new Point(179, 72);
            rb_player2_o.Name = "rb_player2_o";
            rb_player2_o.Size = new Size(54, 40);
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
            rb_player2_x.Size = new Size(54, 40);
            rb_player2_x.TabIndex = 1;
            rb_player2_x.TabStop = true;
            rb_player2_x.Text = "X";
            rb_player2_x.UseVisualStyleBackColor = true;
            rb_player2_x.CheckedChanged += rb_player2_x_CheckedChanged;
            // 
            // gb_player1
            // 
            gb_player1.BackColor = Color.Transparent;
            gb_player1.Controls.Add(tb_player1);
            gb_player1.Controls.Add(lbl_name_player1);
            gb_player1.Controls.Add(rb_player1_o);
            gb_player1.Controls.Add(rb_player1_x);
            gb_player1.Font = new Font("Unispace", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            gb_player1.Location = new Point(20, 54);
            gb_player1.Name = "gb_player1";
            gb_player1.Size = new Size(332, 211);
            gb_player1.TabIndex = 3;
            gb_player1.TabStop = false;
            gb_player1.Text = "Player 1";
            // 
            // tb_player1
            // 
            tb_player1.Location = new Point(114, 140);
            tb_player1.Name = "tb_player1";
            tb_player1.Size = new Size(197, 43);
            tb_player1.TabIndex = 5;
            // 
            // lbl_name_player1
            // 
            lbl_name_player1.AutoSize = true;
            lbl_name_player1.Location = new Point(21, 147);
            lbl_name_player1.Name = "lbl_name_player1";
            lbl_name_player1.Size = new Size(87, 36);
            lbl_name_player1.TabIndex = 4;
            lbl_name_player1.Text = "Name";
            // 
            // rb_player1_o
            // 
            rb_player1_o.AutoSize = true;
            rb_player1_o.Location = new Point(194, 72);
            rb_player1_o.Name = "rb_player1_o";
            rb_player1_o.Size = new Size(54, 40);
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
            rb_player1_x.Size = new Size(54, 40);
            rb_player1_x.TabIndex = 0;
            rb_player1_x.TabStop = true;
            rb_player1_x.Text = "X";
            rb_player1_x.UseVisualStyleBackColor = true;
            rb_player1_x.CheckedChanged += rb_player1_x_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_jpg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_start);
            Controls.Add(gb_player2);
            Controls.Add(gb_player1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gb_player2.ResumeLayout(false);
            gb_player2.PerformLayout();
            gb_player1.ResumeLayout(false);
            gb_player1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_start;
        private GroupBox gb_player2;
        private TextBox tb_player2;
        private Label lbl_name_player2;
        private RadioButton rb_player2_o;
        private RadioButton rb_player2_x;
        private GroupBox gb_player1;
        private TextBox tb_player1;
        private Label lbl_name_player1;
        private RadioButton rb_player1_o;
        private RadioButton rb_player1_x;
    }
}