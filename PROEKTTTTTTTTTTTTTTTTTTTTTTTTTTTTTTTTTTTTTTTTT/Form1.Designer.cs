
namespace PROEKTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT
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
            menuStrip1 = new MenuStrip();
            началоToolStripMenuItem = new ToolStripMenuItem();
            adminToolStripMenuItem = new ToolStripMenuItem();
            adminToolStripMenuItem1 = new ToolStripMenuItem();
            приверкаToolStripMenuItem = new ToolStripMenuItem();
            списъкToolStripMenuItem = new ToolStripMenuItem();
            галерияToolStripMenuItem = new ToolStripMenuItem();
            контактиToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { началоToolStripMenuItem, adminToolStripMenuItem, галерияToolStripMenuItem, контактиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(614, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // началоToolStripMenuItem
            // 
            началоToolStripMenuItem.Name = "началоToolStripMenuItem";
            началоToolStripMenuItem.Size = new Size(61, 20);
            началоToolStripMenuItem.Text = "Начало";
            началоToolStripMenuItem.Click += началоToolStripMenuItem_Click;
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adminToolStripMenuItem1, приверкаToolStripMenuItem, списъкToolStripMenuItem });
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(45, 20);
            adminToolStripMenuItem.Text = "Вход";
            // 
            // adminToolStripMenuItem1
            // 
            adminToolStripMenuItem1.Name = "adminToolStripMenuItem1";
            adminToolStripMenuItem1.Size = new Size(180, 22);
            adminToolStripMenuItem1.Text = "Admin";
            adminToolStripMenuItem1.Click += adminToolStripMenuItem1_Click;
            // 
            // приверкаToolStripMenuItem
            // 
            приверкаToolStripMenuItem.Name = "приверкаToolStripMenuItem";
            приверкаToolStripMenuItem.Size = new Size(180, 22);
            приверкаToolStripMenuItem.Text = "Проверка";
            приверкаToolStripMenuItem.Click += приверкаToolStripMenuItem_Click;
            // 
            // списъкToolStripMenuItem
            // 
            списъкToolStripMenuItem.Name = "списъкToolStripMenuItem";
            списъкToolStripMenuItem.Size = new Size(180, 22);
            списъкToolStripMenuItem.Text = "Списък";
            списъкToolStripMenuItem.Click += списъкToolStripMenuItem_Click;
            // 
            // галерияToolStripMenuItem
            // 
            галерияToolStripMenuItem.Name = "галерияToolStripMenuItem";
            галерияToolStripMenuItem.Size = new Size(64, 20);
            галерияToolStripMenuItem.Text = "Галерия";
            галерияToolStripMenuItem.Click += галерияToolStripMenuItem_Click;
            // 
            // контактиToolStripMenuItem
            // 
            контактиToolStripMenuItem.Name = "контактиToolStripMenuItem";
            контактиToolStripMenuItem.Size = new Size(69, 20);
            контактиToolStripMenuItem.Text = "Контакти";
            контактиToolStripMenuItem.Click += контактиToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._586d61191500009206e9e7b2;
            pictureBox1.Location = new Point(0, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(614, 282);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 311);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void приверкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            proverka1.Show();
            proverka1.BringToFront();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem началоToolStripMenuItem;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem adminToolStripMenuItem1;
        private ToolStripMenuItem приверкаToolStripMenuItem;
        private ToolStripMenuItem галерияToolStripMenuItem;
        private ToolStripMenuItem контактиToolStripMenuItem;
        private PictureBox pictureBox1;
        private VHOD vhod1;
        private PROVERKA proverka1;
        private ToolStripMenuItem списъкToolStripMenuItem;
    }
}
