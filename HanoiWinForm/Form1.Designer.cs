namespace HanoiWinForm
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
            this.components = new System.ComponentModel.Container();
            this.labelBackGround = new System.Windows.Forms.Label();
            this.panelDisksButtons = new System.Windows.Forms.Panel();
            this.buttonPegA4 = new System.Windows.Forms.Button();
            this.buttonPegC1 = new System.Windows.Forms.Button();
            this.buttonPegC2 = new System.Windows.Forms.Button();
            this.buttonPegC3 = new System.Windows.Forms.Button();
            this.buttonPegC4 = new System.Windows.Forms.Button();
            this.buttonPegB1 = new System.Windows.Forms.Button();
            this.buttonPegB2 = new System.Windows.Forms.Button();
            this.buttonPegB3 = new System.Windows.Forms.Button();
            this.buttonPegB4 = new System.Windows.Forms.Button();
            this.buttonPegA1 = new System.Windows.Forms.Button();
            this.buttonPegA2 = new System.Windows.Forms.Button();
            this.buttonPegA3 = new System.Windows.Forms.Button();
            this.labelMoves = new System.Windows.Forms.Label();
            this.buttonTimer = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.timePlayed = new System.Windows.Forms.Timer(this.components);
            this.panelDisksButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBackGround
            // 
            this.labelBackGround.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.labelBackGround.Image = global::HanoiWinForm.Properties.Resources._base;
            this.labelBackGround.Location = new System.Drawing.Point(-1, 0);
            this.labelBackGround.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBackGround.Name = "labelBackGround";
            this.labelBackGround.Size = new System.Drawing.Size(595, 237);
            this.labelBackGround.TabIndex = 0;
            // 
            // panelDisksButtons
            // 
            this.panelDisksButtons.BackColor = System.Drawing.Color.Transparent;
            this.panelDisksButtons.Controls.Add(this.buttonPegA4);
            this.panelDisksButtons.Controls.Add(this.buttonPegC1);
            this.panelDisksButtons.Controls.Add(this.buttonPegC2);
            this.panelDisksButtons.Controls.Add(this.buttonPegC3);
            this.panelDisksButtons.Controls.Add(this.buttonPegC4);
            this.panelDisksButtons.Controls.Add(this.buttonPegB1);
            this.panelDisksButtons.Controls.Add(this.buttonPegB2);
            this.panelDisksButtons.Controls.Add(this.buttonPegB3);
            this.panelDisksButtons.Controls.Add(this.buttonPegB4);
            this.panelDisksButtons.Controls.Add(this.buttonPegA1);
            this.panelDisksButtons.Controls.Add(this.buttonPegA2);
            this.panelDisksButtons.Controls.Add(this.buttonPegA3);
            this.panelDisksButtons.Controls.Add(this.labelBackGround);
            this.panelDisksButtons.Location = new System.Drawing.Point(12, 13);
            this.panelDisksButtons.Name = "panelDisksButtons";
            this.panelDisksButtons.Size = new System.Drawing.Size(595, 249);
            this.panelDisksButtons.TabIndex = 13;
            // 
            // buttonPegA4
            // 
            this.buttonPegA4.Location = new System.Drawing.Point(43, 189);
            this.buttonPegA4.Name = "buttonPegA4";
            this.buttonPegA4.Size = new System.Drawing.Size(110, 30);
            this.buttonPegA4.TabIndex = 13;
            this.buttonPegA4.UseVisualStyleBackColor = true;
            // 
            // buttonPegC1
            // 
            this.buttonPegC1.Location = new System.Drawing.Point(456, 108);
            this.buttonPegC1.Name = "buttonPegC1";
            this.buttonPegC1.Size = new System.Drawing.Size(80, 30);
            this.buttonPegC1.TabIndex = 12;
            this.buttonPegC1.UseVisualStyleBackColor = true;
            // 
            // buttonPegC2
            // 
            this.buttonPegC2.Location = new System.Drawing.Point(451, 135);
            this.buttonPegC2.Name = "buttonPegC2";
            this.buttonPegC2.Size = new System.Drawing.Size(90, 30);
            this.buttonPegC2.TabIndex = 11;
            this.buttonPegC2.UseVisualStyleBackColor = true;
            // 
            // buttonPegC3
            // 
            this.buttonPegC3.Location = new System.Drawing.Point(446, 162);
            this.buttonPegC3.Name = "buttonPegC3";
            this.buttonPegC3.Size = new System.Drawing.Size(100, 30);
            this.buttonPegC3.TabIndex = 10;
            this.buttonPegC3.UseVisualStyleBackColor = true;
            // 
            // buttonPegC4
            // 
            this.buttonPegC4.Location = new System.Drawing.Point(441, 189);
            this.buttonPegC4.Name = "buttonPegC4";
            this.buttonPegC4.Size = new System.Drawing.Size(110, 30);
            this.buttonPegC4.TabIndex = 9;
            this.buttonPegC4.UseVisualStyleBackColor = true;
            // 
            // buttonPegB1
            // 
            this.buttonPegB1.ForeColor = System.Drawing.Color.Transparent;
            this.buttonPegB1.Location = new System.Drawing.Point(258, 108);
            this.buttonPegB1.Name = "buttonPegB1";
            this.buttonPegB1.Size = new System.Drawing.Size(80, 30);
            this.buttonPegB1.TabIndex = 8;
            this.buttonPegB1.UseVisualStyleBackColor = true;
            // 
            // buttonPegB2
            // 
            this.buttonPegB2.Location = new System.Drawing.Point(253, 135);
            this.buttonPegB2.Name = "buttonPegB2";
            this.buttonPegB2.Size = new System.Drawing.Size(90, 30);
            this.buttonPegB2.TabIndex = 7;
            this.buttonPegB2.UseVisualStyleBackColor = true;
            // 
            // buttonPegB3
            // 
            this.buttonPegB3.Location = new System.Drawing.Point(248, 162);
            this.buttonPegB3.Name = "buttonPegB3";
            this.buttonPegB3.Size = new System.Drawing.Size(100, 30);
            this.buttonPegB3.TabIndex = 6;
            this.buttonPegB3.UseVisualStyleBackColor = true;
            // 
            // buttonPegB4
            // 
            this.buttonPegB4.Location = new System.Drawing.Point(243, 189);
            this.buttonPegB4.Name = "buttonPegB4";
            this.buttonPegB4.Size = new System.Drawing.Size(110, 30);
            this.buttonPegB4.TabIndex = 5;
            this.buttonPegB4.UseVisualStyleBackColor = true;
            // 
            // buttonPegA1
            // 
            this.buttonPegA1.Location = new System.Drawing.Point(58, 109);
            this.buttonPegA1.Name = "buttonPegA1";
            this.buttonPegA1.Size = new System.Drawing.Size(80, 30);
            this.buttonPegA1.TabIndex = 4;
            this.buttonPegA1.UseVisualStyleBackColor = true;
            // 
            // buttonPegA2
            // 
            this.buttonPegA2.Location = new System.Drawing.Point(53, 136);
            this.buttonPegA2.Name = "buttonPegA2";
            this.buttonPegA2.Size = new System.Drawing.Size(90, 30);
            this.buttonPegA2.TabIndex = 3;
            this.buttonPegA2.UseVisualStyleBackColor = true;
            // 
            // buttonPegA3
            // 
            this.buttonPegA3.Location = new System.Drawing.Point(48, 163);
            this.buttonPegA3.Name = "buttonPegA3";
            this.buttonPegA3.Size = new System.Drawing.Size(100, 30);
            this.buttonPegA3.TabIndex = 2;
            this.buttonPegA3.UseVisualStyleBackColor = true;
            // 
            // labelMoves
            // 
            this.labelMoves.AutoSize = true;
            this.labelMoves.Location = new System.Drawing.Point(12, 265);
            this.labelMoves.Name = "labelMoves";
            this.labelMoves.Size = new System.Drawing.Size(51, 13);
            this.labelMoves.TabIndex = 14;
            this.labelMoves.Text = "Moves: 0";
            // 
            // buttonTimer
            // 
            this.buttonTimer.Location = new System.Drawing.Point(14, 304);
            this.buttonTimer.Name = "buttonTimer";
            this.buttonTimer.Size = new System.Drawing.Size(75, 23);
            this.buttonTimer.TabIndex = 15;
            this.buttonTimer.Text = "Start Timer";
            this.buttonTimer.UseVisualStyleBackColor = true;
            this.buttonTimer.Click += new System.EventHandler(this.ButtonTimer_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(95, 309);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(74, 13);
            this.labelTime.TabIndex = 16;
            this.labelTime.Text = "Time Elapsed:";
            // 
            // timePlayed
            // 
            this.timePlayed.Tick += new System.EventHandler(this.TimePlayed_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 366);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonTimer);
            this.Controls.Add(this.labelMoves);
            this.Controls.Add(this.panelDisksButtons);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Towers of Hanoi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelDisksButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBackGround;
        private System.Windows.Forms.Panel panelDisksButtons;
        private System.Windows.Forms.Button buttonPegC1;
        private System.Windows.Forms.Button buttonPegC2;
        private System.Windows.Forms.Button buttonPegC3;
        private System.Windows.Forms.Button buttonPegC4;
        private System.Windows.Forms.Button buttonPegB1;
        private System.Windows.Forms.Button buttonPegB2;
        private System.Windows.Forms.Button buttonPegB3;
        private System.Windows.Forms.Button buttonPegB4;
        private System.Windows.Forms.Button buttonPegA1;
        private System.Windows.Forms.Button buttonPegA2;
        private System.Windows.Forms.Button buttonPegA3;
        private System.Windows.Forms.Button buttonPegA4;
        private System.Windows.Forms.Label labelMoves;
        private System.Windows.Forms.Button buttonTimer;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timePlayed;
    }
}

