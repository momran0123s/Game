namespace FinalProject
{
    partial class Scores
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
            dgv_scores = new DataGridView();
            btn_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_scores).BeginInit();
            SuspendLayout();
            // 
            // dgv_scores
            // 
            dgv_scores.BackgroundColor = Color.PaleTurquoise;
            dgv_scores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_scores.Location = new Point(0, 0);
            dgv_scores.Name = "dgv_scores";
            dgv_scores.RowHeadersWidth = 51;
            dgv_scores.Size = new Size(800, 362);
            dgv_scores.TabIndex = 0;
            dgv_scores.RowHeaderMouseDoubleClick += dgv_scores_RowHeaderMouseDoubleClick;
            // 
            // btn_delete
            // 
            btn_delete.Font = new Font("Unispace", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_delete.Location = new Point(295, 368);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(194, 73);
            btn_delete.TabIndex = 1;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // Scores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_jpg;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_delete);
            Controls.Add(dgv_scores);
            Name = "Scores";
            Text = "Scores";
            Load += Scores_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_scores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_scores;
        private Button btn_delete;
    }
}