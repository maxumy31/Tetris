namespace tetris_questionMark_
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.InfoLabel = new System.Windows.Forms.Label();
            this.GridPictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.score_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.preview_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.Image = ((System.Drawing.Image)(resources.GetObject("InfoLabel.Image")));
            this.InfoLabel.Location = new System.Drawing.Point(425, 0);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(256, 857);
            this.InfoLabel.TabIndex = 1;
            this.InfoLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // GridPictureBox
            // 
            this.GridPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GridPictureBox.BackgroundImage")));
            this.GridPictureBox.Location = new System.Drawing.Point(2, 0);
            this.GridPictureBox.Name = "GridPictureBox";
            this.GridPictureBox.Size = new System.Drawing.Size(430, 854);
            this.GridPictureBox.TabIndex = 3;
            this.GridPictureBox.TabStop = false;
            this.GridPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(451, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 62);
            this.label1.TabIndex = 4;
            // 
            // score_label
            // 
            this.score_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(166)))));
            this.score_label.Font = new System.Drawing.Font("Tw Cen MT Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.score_label.ForeColor = System.Drawing.Color.White;
            this.score_label.Location = new System.Drawing.Point(451, 225);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(211, 82);
            this.score_label.TabIndex = 5;
            this.score_label.Text = "-------";
            this.score_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(451, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 76);
            this.label2.TabIndex = 6;
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(166)))));
            this.timeLabel.Font = new System.Drawing.Font("Tw Cen MT Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(451, 433);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(211, 70);
            this.timeLabel.TabIndex = 7;
            this.timeLabel.Text = "-------";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.TimerUpdate);
            // 
            // preview_label
            // 
            this.preview_label.Image = ((System.Drawing.Image)(resources.GetObject("preview_label.Image")));
            this.preview_label.Location = new System.Drawing.Point(438, 547);
            this.preview_label.Name = "preview_label";
            this.preview_label.Size = new System.Drawing.Size(230, 230);
            this.preview_label.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(438, 785);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 60);
            this.label4.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 854);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.preview_label);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.score_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridPictureBox);
            this.Controls.Add(this.InfoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Tetris";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.GridPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label UpperHalfGrid;
        private Label InfoLabel;
        private Label LowerUpperGrid;
        private PictureBox GridPictureBox;
        private Label label1;
        private Label score_label;
        public System.Windows.Forms.Timer timer1;
        private Label label2;
        private Label timeLabel;
        private System.Windows.Forms.Timer timer2;
        private Label preview_label;
        private Label label4;
    }
}