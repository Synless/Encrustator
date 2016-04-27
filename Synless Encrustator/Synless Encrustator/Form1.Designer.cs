namespace Synless_Encrustor
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loadBtn = new System.Windows.Forms.Button();
            this.tittleTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.opacityUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.whiteRbt = new System.Windows.Forms.RadioButton();
            this.blackRbt = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.leftArrowCheck = new System.Windows.Forms.CheckBox();
            this.rightArrowCheck = new System.Windows.Forms.CheckBox();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.redLbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.demoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(200, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 128);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Original :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modified :";
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(30, 217);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 23);
            this.loadBtn.TabIndex = 4;
            this.loadBtn.Text = "Load ...";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // tittleTxtBox
            // 
            this.tittleTxtBox.Enabled = false;
            this.tittleTxtBox.Location = new System.Drawing.Point(228, 207);
            this.tittleTxtBox.Name = "tittleTxtBox";
            this.tittleTxtBox.Size = new System.Drawing.Size(100, 20);
            this.tittleTxtBox.TabIndex = 5;
            this.tittleTxtBox.Text = "- Test -";
            this.tittleTxtBox.TextChanged += new System.EventHandler(this.tittleTxtBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tittle :";
            // 
            // opacityUpDown
            // 
            this.opacityUpDown.Enabled = false;
            this.opacityUpDown.Location = new System.Drawing.Point(229, 339);
            this.opacityUpDown.Name = "opacityUpDown";
            this.opacityUpDown.Size = new System.Drawing.Size(100, 20);
            this.opacityUpDown.TabIndex = 7;
            this.opacityUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.opacityUpDown.ValueChanged += new System.EventHandler(this.opacityUpDown_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Opacity :";
            // 
            // saveBtn
            // 
            this.saveBtn.Enabled = false;
            this.saveBtn.Location = new System.Drawing.Point(30, 257);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.Text = "Save ...";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // whiteRbt
            // 
            this.whiteRbt.AutoSize = true;
            this.whiteRbt.Enabled = false;
            this.whiteRbt.Location = new System.Drawing.Point(283, 241);
            this.whiteRbt.Name = "whiteRbt";
            this.whiteRbt.Size = new System.Drawing.Size(53, 17);
            this.whiteRbt.TabIndex = 12;
            this.whiteRbt.Text = "White";
            this.whiteRbt.UseVisualStyleBackColor = true;
            this.whiteRbt.CheckedChanged += new System.EventHandler(this.whiteRbt_CheckedChanged);
            // 
            // blackRbt
            // 
            this.blackRbt.AutoSize = true;
            this.blackRbt.Checked = true;
            this.blackRbt.Enabled = false;
            this.blackRbt.Location = new System.Drawing.Point(221, 241);
            this.blackRbt.Name = "blackRbt";
            this.blackRbt.Size = new System.Drawing.Size(52, 17);
            this.blackRbt.TabIndex = 13;
            this.blackRbt.TabStop = true;
            this.blackRbt.Text = "Black";
            this.blackRbt.UseVisualStyleBackColor = true;
            this.blackRbt.CheckedChanged += new System.EventHandler(this.blackRbt_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Arrow :";
            // 
            // leftArrowCheck
            // 
            this.leftArrowCheck.AutoSize = true;
            this.leftArrowCheck.Checked = true;
            this.leftArrowCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.leftArrowCheck.Enabled = false;
            this.leftArrowCheck.Location = new System.Drawing.Point(229, 280);
            this.leftArrowCheck.Name = "leftArrowCheck";
            this.leftArrowCheck.Size = new System.Drawing.Size(44, 17);
            this.leftArrowCheck.TabIndex = 15;
            this.leftArrowCheck.Text = "Left";
            this.leftArrowCheck.UseVisualStyleBackColor = true;
            this.leftArrowCheck.CheckedChanged += new System.EventHandler(this.leftArrowCheck_CheckedChanged);
            // 
            // rightArrowCheck
            // 
            this.rightArrowCheck.AutoSize = true;
            this.rightArrowCheck.Checked = true;
            this.rightArrowCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rightArrowCheck.Enabled = false;
            this.rightArrowCheck.Location = new System.Drawing.Point(229, 299);
            this.rightArrowCheck.Name = "rightArrowCheck";
            this.rightArrowCheck.Size = new System.Drawing.Size(51, 17);
            this.rightArrowCheck.TabIndex = 16;
            this.rightArrowCheck.Text = "Rigth";
            this.rightArrowCheck.UseVisualStyleBackColor = true;
            this.rightArrowCheck.CheckedChanged += new System.EventHandler(this.rightArrowCheck_CheckedChanged);
            // 
            // trackBarRed
            // 
            this.trackBarRed.Enabled = false;
            this.trackBarRed.LargeChange = 10;
            this.trackBarRed.Location = new System.Drawing.Point(106, 390);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(179, 45);
            this.trackBarRed.TabIndex = 254;
            this.trackBarRed.Value = 254;
            this.trackBarRed.ValueChanged += new System.EventHandler(this.trackBar_Scroll);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Enabled = false;
            this.trackBarGreen.Location = new System.Drawing.Point(106, 425);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(179, 45);
            this.trackBarGreen.TabIndex = 18;
            this.trackBarGreen.Value = 254;
            this.trackBarGreen.ValueChanged += new System.EventHandler(this.trackBar_Scroll);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Enabled = false;
            this.trackBarBlue.Location = new System.Drawing.Point(106, 460);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(179, 45);
            this.trackBarBlue.TabIndex = 19;
            this.trackBarBlue.Value = 254;
            this.trackBarBlue.ValueChanged += new System.EventHandler(this.trackBar_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Red :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 429);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Green :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 464);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Blue :";
            // 
            // redLbl
            // 
            this.redLbl.AutoSize = true;
            this.redLbl.Location = new System.Drawing.Point(70, 394);
            this.redLbl.Name = "redLbl";
            this.redLbl.Size = new System.Drawing.Size(25, 13);
            this.redLbl.TabIndex = 23;
            this.redLbl.Text = "255";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(70, 429);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "255";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(70, 464);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "255";
            // 
            // demoPictureBox
            // 
            this.demoPictureBox.Location = new System.Drawing.Point(307, 425);
            this.demoPictureBox.Name = "demoPictureBox";
            this.demoPictureBox.Size = new System.Drawing.Size(32, 32);
            this.demoPictureBox.TabIndex = 26;
            this.demoPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 514);
            this.Controls.Add(this.demoPictureBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.redLbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.trackBarRed);
            this.Controls.Add(this.rightArrowCheck);
            this.Controls.Add(this.leftArrowCheck);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.blackRbt);
            this.Controls.Add(this.whiteRbt);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.opacityUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tittleTxtBox);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Synless Encrustator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.TextBox tittleTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown opacityUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.RadioButton whiteRbt;
        private System.Windows.Forms.RadioButton blackRbt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox leftArrowCheck;
        private System.Windows.Forms.CheckBox rightArrowCheck;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label redLbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox demoPictureBox;
    }
}

