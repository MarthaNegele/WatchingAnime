namespace Animes_mit_David_2
{
    partial class AddAnime
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.btAbbr = new System.Windows.Forms.Button();
            this.nudFolge = new System.Windows.Forms.NumericUpDown();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbLink = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudEpAnz = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudFolge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEpAnz)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Folge";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Link";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Episodennummer im Link durch ü ersetzen!";
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(79, 280);
            this.btOK.Margin = new System.Windows.Forms.Padding(4);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(112, 34);
            this.btOK.TabIndex = 1;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btAbbr
            // 
            this.btAbbr.Location = new System.Drawing.Point(356, 280);
            this.btAbbr.Margin = new System.Windows.Forms.Padding(4);
            this.btAbbr.Name = "btAbbr";
            this.btAbbr.Size = new System.Drawing.Size(112, 34);
            this.btAbbr.TabIndex = 2;
            this.btAbbr.Text = "Abbrechen";
            this.btAbbr.UseVisualStyleBackColor = true;
            this.btAbbr.Click += new System.EventHandler(this.btAbbr_Click);
            // 
            // nudFolge
            // 
            this.nudFolge.Location = new System.Drawing.Point(142, 128);
            this.nudFolge.Margin = new System.Windows.Forms.Padding(4);
            this.nudFolge.Name = "nudFolge";
            this.nudFolge.Size = new System.Drawing.Size(60, 26);
            this.nudFolge.TabIndex = 3;
            this.nudFolge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFolge.ValueChanged += new System.EventHandler(this.nudFolge_ValueChanged);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(142, 74);
            this.tbxName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(326, 26);
            this.tbxName.TabIndex = 4;
            // 
            // tbLink
            // 
            this.tbLink.Location = new System.Drawing.Point(142, 183);
            this.tbLink.Margin = new System.Windows.Forms.Padding(4);
            this.tbLink.Name = "tbLink";
            this.tbLink.Size = new System.Drawing.Size(326, 26);
            this.tbLink.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "von";
            // 
            // nudEpAnz
            // 
            this.nudEpAnz.Location = new System.Drawing.Point(272, 128);
            this.nudEpAnz.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudEpAnz.Name = "nudEpAnz";
            this.nudEpAnz.Size = new System.Drawing.Size(55, 26);
            this.nudEpAnz.TabIndex = 7;
            // 
            // AddAnime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(597, 393);
            this.Controls.Add(this.nudEpAnz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbLink);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.nudFolge);
            this.Controls.Add(this.btAbbr);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddAnime";
            this.Text = "AddAnime";
            ((System.ComponentModel.ISupportInitialize)(this.nudFolge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEpAnz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btAbbr;
        private System.Windows.Forms.NumericUpDown nudFolge;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbLink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudEpAnz;
    }
}