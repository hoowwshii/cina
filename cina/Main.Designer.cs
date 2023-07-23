namespace cina {
    partial class Main {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            button1 = new Button();
            cinaWords = new TextBox();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            repeat = new Button();
            label2 = new Label();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            hideToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(52, 377);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "&Lanjut";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cinaWords
            // 
            cinaWords.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cinaWords.Location = new Point(508, 60);
            cinaWords.Multiline = true;
            cinaWords.Name = "cinaWords";
            cinaWords.ScrollBars = ScrollBars.Vertical;
            cinaWords.Size = new Size(250, 261);
            cinaWords.TabIndex = 1;
            cinaWords.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(664, 336);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "&Import";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(508, 30);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 3;
            label1.Text = "Import";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(508, 336);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "&Random";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // repeat
            // 
            repeat.Location = new Point(178, 377);
            repeat.Name = "repeat";
            repeat.Size = new Size(94, 29);
            repeat.TabIndex = 6;
            repeat.Text = "&Ulang";
            repeat.UseVisualStyleBackColor = true;
            repeat.Click += repeat_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(46, 85);
            label2.Name = "label2";
            label2.Size = new Size(183, 50);
            label2.TabIndex = 7;
            label2.Text = "Your 听写";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(46, 135);
            label3.Name = "label3";
            label3.Size = new Size(100, 38);
            label3.TabIndex = 8;
            label3.Text = "Helper";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hideToolStripMenuItem, closeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // hideToolStripMenuItem
            // 
            hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            hideToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            hideToolStripMenuItem.Size = new Size(55, 24);
            hideToolStripMenuItem.Text = "Hide";
            hideToolStripMenuItem.Click += hideToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(59, 24);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(repeat);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(cinaWords);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "我爱听写<3";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox cinaWords;
        private Button button2;
        private Label label1;
        private Button button3;
        private Button repeat;
        private Label label2;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hideToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
    }
}