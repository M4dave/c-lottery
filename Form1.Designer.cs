namespace MidTerm287
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
            this.showNumbersButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.About = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Lottery = new System.Windows.Forms.Label();
            this.slot1 = new System.Windows.Forms.Panel();
            this.num1 = new System.Windows.Forms.Label();
            this.slot2 = new System.Windows.Forms.Panel();
            this.num2 = new System.Windows.Forms.Label();
            this.slot3 = new System.Windows.Forms.Panel();
            this.num3 = new System.Windows.Forms.Label();
            this.slot4 = new System.Windows.Forms.Panel();
            this.num4 = new System.Windows.Forms.Label();
            this.slot5 = new System.Windows.Forms.Panel();
            this.num5 = new System.Windows.Forms.Label();
            this.slot6 = new System.Windows.Forms.Panel();
            this.num6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.About.SuspendLayout();
            this.slot1.SuspendLayout();
            this.slot2.SuspendLayout();
            this.slot3.SuspendLayout();
            this.slot4.SuspendLayout();
            this.slot5.SuspendLayout();
            this.slot6.SuspendLayout();
            this.SuspendLayout();
            // 
            // showNumbersButton
            // 
            this.showNumbersButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showNumbersButton.Location = new System.Drawing.Point(60, 269);
            this.showNumbersButton.Name = "showNumbersButton";
            this.showNumbersButton.Size = new System.Drawing.Size(170, 42);
            this.showNumbersButton.TabIndex = 0;
            this.showNumbersButton.Text = "&Show Numbers";
            this.showNumbersButton.UseVisualStyleBackColor = true;
            this.showNumbersButton.Click += new System.EventHandler(this.showNumbersButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(289, 269);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(87, 42);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "&Exit";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // About
            // 
            this.About.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.About.Location = new System.Drawing.Point(0, 0);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(460, 24);
            this.About.TabIndex = 6;
            this.About.Text = "&About";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // creditToolStripMenuItem
            // 
            this.creditToolStripMenuItem.Name = "creditToolStripMenuItem";
            this.creditToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.creditToolStripMenuItem.Text = "Credit";
            this.creditToolStripMenuItem.Click += new System.EventHandler(this.creditToolStripMenuItem_Click);
            // 
            // Lottery
            // 
            this.Lottery.AutoSize = true;
            this.Lottery.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lottery.Location = new System.Drawing.Point(53, 69);
            this.Lottery.Name = "Lottery";
            this.Lottery.Size = new System.Drawing.Size(339, 40);
            this.Lottery.TabIndex = 7;
            this.Lottery.Text = "Welcome to my Lottery";
            // 
            // slot1
            // 
            this.slot1.BackColor = System.Drawing.Color.White;
            this.slot1.Controls.Add(this.num1);
            this.slot1.ForeColor = System.Drawing.Color.White;
            this.slot1.Location = new System.Drawing.Point(12, 142);
            this.slot1.Name = "slot1";
            this.slot1.Size = new System.Drawing.Size(68, 68);
            this.slot1.TabIndex = 4;
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.num1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(0, 0);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(68, 68);
            this.num1.TabIndex = 0;
            this.num1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // slot2
            // 
            this.slot2.BackColor = System.Drawing.Color.White;
            this.slot2.Controls.Add(this.num2);
            this.slot2.ForeColor = System.Drawing.Color.White;
            this.slot2.Location = new System.Drawing.Point(86, 142);
            this.slot2.Name = "slot2";
            this.slot2.Size = new System.Drawing.Size(68, 68);
            this.slot2.TabIndex = 5;
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.num2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num2.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(0, 0);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(68, 68);
            this.num2.TabIndex = 1;
            this.num2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // slot3
            // 
            this.slot3.BackColor = System.Drawing.Color.White;
            this.slot3.Controls.Add(this.num3);
            this.slot3.ForeColor = System.Drawing.Color.White;
            this.slot3.Location = new System.Drawing.Point(160, 142);
            this.slot3.Name = "slot3";
            this.slot3.Size = new System.Drawing.Size(68, 68);
            this.slot3.TabIndex = 5;
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.num3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num3.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.Location = new System.Drawing.Point(0, 0);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(68, 68);
            this.num3.TabIndex = 1;
            this.num3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // slot4
            // 
            this.slot4.BackColor = System.Drawing.Color.White;
            this.slot4.Controls.Add(this.num4);
            this.slot4.ForeColor = System.Drawing.Color.White;
            this.slot4.Location = new System.Drawing.Point(234, 142);
            this.slot4.Name = "slot4";
            this.slot4.Size = new System.Drawing.Size(68, 68);
            this.slot4.TabIndex = 5;
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.num4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num4.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.Location = new System.Drawing.Point(0, 0);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(68, 68);
            this.num4.TabIndex = 1;
            this.num4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // slot5
            // 
            this.slot5.BackColor = System.Drawing.Color.White;
            this.slot5.Controls.Add(this.num5);
            this.slot5.ForeColor = System.Drawing.Color.White;
            this.slot5.Location = new System.Drawing.Point(308, 142);
            this.slot5.Name = "slot5";
            this.slot5.Size = new System.Drawing.Size(68, 68);
            this.slot5.TabIndex = 5;
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.num5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num5.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.Location = new System.Drawing.Point(0, 0);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(68, 68);
            this.num5.TabIndex = 1;
            this.num5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // slot6
            // 
            this.slot6.BackColor = System.Drawing.Color.Red;
            this.slot6.Controls.Add(this.num6);
            this.slot6.ForeColor = System.Drawing.Color.White;
            this.slot6.Location = new System.Drawing.Point(382, 142);
            this.slot6.Name = "slot6";
            this.slot6.Size = new System.Drawing.Size(68, 68);
            this.slot6.TabIndex = 5;
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.num6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num6.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.Location = new System.Drawing.Point(0, 0);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(68, 68);
            this.num6.TabIndex = 1;
            this.num6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(460, 382);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.slot6);
            this.Controls.Add(this.slot5);
            this.Controls.Add(this.slot4);
            this.Controls.Add(this.slot3);
            this.Controls.Add(this.slot2);
            this.Controls.Add(this.Lottery);
            this.Controls.Add(this.slot1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.showNumbersButton);
            this.Controls.Add(this.About);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.About;
            this.Name = "Form1";
            this.Text = "Lottery";
            this.About.ResumeLayout(false);
            this.About.PerformLayout();
            this.slot1.ResumeLayout(false);
            this.slot2.ResumeLayout(false);
            this.slot3.ResumeLayout(false);
            this.slot4.ResumeLayout(false);
            this.slot5.ResumeLayout(false);
            this.slot6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showNumbersButton;
        private System.Windows.Forms.Button closeButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip About;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditToolStripMenuItem;
        private System.Windows.Forms.Label Lottery;
        private System.Windows.Forms.Panel slot1;
        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Panel slot2;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.Panel slot3;
        private System.Windows.Forms.Label num3;
        private System.Windows.Forms.Panel slot4;
        private System.Windows.Forms.Label num4;
        private System.Windows.Forms.Panel slot5;
        private System.Windows.Forms.Label num5;
        private System.Windows.Forms.Panel slot6;
        private System.Windows.Forms.Label num6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}

