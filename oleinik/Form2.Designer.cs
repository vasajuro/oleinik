namespace oleinik
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.полToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.семейноеПоложениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.воинскаяОбязанностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покупкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заработнаяПлатаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.полToolStripMenuItem,
            this.семейноеПоложениеToolStripMenuItem,
            this.воинскаяОбязанностьToolStripMenuItem,
            this.должностьToolStripMenuItem,
            this.покупкиToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.заработнаяПлатаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(948, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // полToolStripMenuItem
            // 
            this.полToolStripMenuItem.Name = "полToolStripMenuItem";
            this.полToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.полToolStripMenuItem.Text = "Пол";
            // 
            // семейноеПоложениеToolStripMenuItem
            // 
            this.семейноеПоложениеToolStripMenuItem.Name = "семейноеПоложениеToolStripMenuItem";
            this.семейноеПоложениеToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.семейноеПоложениеToolStripMenuItem.Text = "Семейное положение";
            // 
            // воинскаяОбязанностьToolStripMenuItem
            // 
            this.воинскаяОбязанностьToolStripMenuItem.Name = "воинскаяОбязанностьToolStripMenuItem";
            this.воинскаяОбязанностьToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.воинскаяОбязанностьToolStripMenuItem.Text = "Воинская обязанность";
            // 
            // должностьToolStripMenuItem
            // 
            this.должностьToolStripMenuItem.Name = "должностьToolStripMenuItem";
            this.должностьToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.должностьToolStripMenuItem.Text = "Должность";
            // 
            // покупкиToolStripMenuItem
            // 
            this.покупкиToolStripMenuItem.Name = "покупкиToolStripMenuItem";
            this.покупкиToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.покупкиToolStripMenuItem.Text = "Покупки";
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // заработнаяПлатаToolStripMenuItem
            // 
            this.заработнаяПлатаToolStripMenuItem.Name = "заработнаяПлатаToolStripMenuItem";
            this.заработнаяПлатаToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.заработнаяПлатаToolStripMenuItem.Text = "Заработная плата";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 517);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem полToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem семейноеПоложениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem воинскаяОбязанностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem покупкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заработнаяПлатаToolStripMenuItem;
    }
}