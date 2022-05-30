namespace _3005
{
    partial class Team
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
            this.btnFirst = new System.Windows.Forms.Button();
            this.BtnPrev = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnLast = new System.Windows.Forms.Button();
            this.lbNamaTeam = new System.Windows.Forms.Label();
            this.lbManager = new System.Windows.Forms.Label();
            this.lbSatidum = new System.Windows.Forms.Label();
            this.lbTopScorer = new System.Windows.Forms.Label();
            this.lbWorst = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtgvMatch = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMatch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(78, 58);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // BtnPrev
            // 
            this.BtnPrev.Location = new System.Drawing.Point(159, 58);
            this.BtnPrev.Name = "BtnPrev";
            this.BtnPrev.Size = new System.Drawing.Size(75, 23);
            this.BtnPrev.TabIndex = 1;
            this.BtnPrev.Text = "<";
            this.BtnPrev.UseVisualStyleBackColor = true;
            this.BtnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(240, 58);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(75, 23);
            this.BtnNext.TabIndex = 2;
            this.BtnNext.Text = ">";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnLast
            // 
            this.BtnLast.Location = new System.Drawing.Point(321, 58);
            this.BtnLast.Name = "BtnLast";
            this.BtnLast.Size = new System.Drawing.Size(75, 23);
            this.BtnLast.TabIndex = 3;
            this.BtnLast.Text = ">>";
            this.BtnLast.UseVisualStyleBackColor = true;
            this.BtnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // lbNamaTeam
            // 
            this.lbNamaTeam.AutoSize = true;
            this.lbNamaTeam.Location = new System.Drawing.Point(187, 111);
            this.lbNamaTeam.Name = "lbNamaTeam";
            this.lbNamaTeam.Size = new System.Drawing.Size(35, 13);
            this.lbNamaTeam.TabIndex = 4;
            this.lbNamaTeam.Text = "label1";
            // 
            // lbManager
            // 
            this.lbManager.AutoSize = true;
            this.lbManager.Location = new System.Drawing.Point(187, 138);
            this.lbManager.Name = "lbManager";
            this.lbManager.Size = new System.Drawing.Size(35, 13);
            this.lbManager.TabIndex = 5;
            this.lbManager.Text = "label2";
            // 
            // lbSatidum
            // 
            this.lbSatidum.AutoSize = true;
            this.lbSatidum.Location = new System.Drawing.Point(187, 163);
            this.lbSatidum.Name = "lbSatidum";
            this.lbSatidum.Size = new System.Drawing.Size(35, 13);
            this.lbSatidum.TabIndex = 6;
            this.lbSatidum.Text = "label3";
            // 
            // lbTopScorer
            // 
            this.lbTopScorer.AutoSize = true;
            this.lbTopScorer.Location = new System.Drawing.Point(187, 185);
            this.lbTopScorer.Name = "lbTopScorer";
            this.lbTopScorer.Size = new System.Drawing.Size(35, 13);
            this.lbTopScorer.TabIndex = 7;
            this.lbTopScorer.Text = "label4";
            // 
            // lbWorst
            // 
            this.lbWorst.AutoSize = true;
            this.lbWorst.Location = new System.Drawing.Point(187, 207);
            this.lbWorst.Name = "lbWorst";
            this.lbWorst.Size = new System.Drawing.Size(35, 13);
            this.lbWorst.TabIndex = 8;
            this.lbWorst.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Team Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Manager :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Stadium :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Top Scorer";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(78, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Worst Discipline :";
            // 
            // dtgvMatch
            // 
            this.dtgvMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMatch.Location = new System.Drawing.Point(78, 251);
            this.dtgvMatch.Name = "dtgvMatch";
            this.dtgvMatch.Size = new System.Drawing.Size(672, 150);
            this.dtgvMatch.TabIndex = 14;
            // 
            // Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgvMatch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbWorst);
            this.Controls.Add(this.lbTopScorer);
            this.Controls.Add(this.lbSatidum);
            this.Controls.Add(this.lbManager);
            this.Controls.Add(this.lbNamaTeam);
            this.Controls.Add(this.BtnLast);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnPrev);
            this.Controls.Add(this.btnFirst);
            this.Name = "Team";
            this.Text = "Team";
            this.Load += new System.EventHandler(this.Team_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button BtnPrev;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnLast;
        private System.Windows.Forms.Label lbNamaTeam;
        private System.Windows.Forms.Label lbManager;
        private System.Windows.Forms.Label lbSatidum;
        private System.Windows.Forms.Label lbTopScorer;
        private System.Windows.Forms.Label lbWorst;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtgvMatch;
    }
}

