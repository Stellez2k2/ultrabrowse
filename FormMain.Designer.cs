
namespace UltraBrowse
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.webBrowserDisplay = new System.Windows.Forms.WebBrowser();
            this.richTextBoxNotes = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.webBrowserDisplay2 = new System.Windows.Forms.WebBrowser();
            this.textBoxSearch2 = new System.Windows.Forms.TextBox();
            this.buttonSearch2 = new System.Windows.Forms.Button();
            this.buttonMusic1 = new System.Windows.Forms.Button();
            this.buttonMusic2 = new System.Windows.Forms.Button();
            this.buttonMusic3 = new System.Windows.Forms.Button();
            this.buttonMusic4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(1108, 16);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(96, 56);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(50, 25);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(1016, 22);
            this.textBoxSearch.TabIndex = 1;
            // 
            // webBrowserDisplay
            // 
            this.webBrowserDisplay.Location = new System.Drawing.Point(7, 103);
            this.webBrowserDisplay.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserDisplay.Name = "webBrowserDisplay";
            this.webBrowserDisplay.Size = new System.Drawing.Size(1197, 703);
            this.webBrowserDisplay.TabIndex = 2;
            // 
            // richTextBoxNotes
            // 
            this.richTextBoxNotes.Location = new System.Drawing.Point(1221, 103);
            this.richTextBoxNotes.Name = "richTextBoxNotes";
            this.richTextBoxNotes.Size = new System.Drawing.Size(307, 703);
            this.richTextBoxNotes.TabIndex = 3;
            this.richTextBoxNotes.Text = "Type Your Notes Here!\n";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 76);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1889, 880);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.webBrowserDisplay);
            this.tabPage1.Controls.Add(this.buttonSearch);
            this.tabPage1.Controls.Add(this.richTextBoxNotes);
            this.tabPage1.Controls.Add(this.textBoxSearch);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1881, 851);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Notes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.buttonSearch2);
            this.tabPage2.Controls.Add(this.webBrowserDisplay2);
            this.tabPage2.Controls.Add(this.textBoxSearch2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1881, 851);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Web";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // webBrowserDisplay2
            // 
            this.webBrowserDisplay2.Location = new System.Drawing.Point(51, 122);
            this.webBrowserDisplay2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserDisplay2.Name = "webBrowserDisplay2";
            this.webBrowserDisplay2.Size = new System.Drawing.Size(1368, 726);
            this.webBrowserDisplay2.TabIndex = 4;
            // 
            // textBoxSearch2
            // 
            this.textBoxSearch2.Location = new System.Drawing.Point(161, 47);
            this.textBoxSearch2.Name = "textBoxSearch2";
            this.textBoxSearch2.Size = new System.Drawing.Size(1016, 22);
            this.textBoxSearch2.TabIndex = 3;
            // 
            // buttonSearch2
            // 
            this.buttonSearch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch2.Location = new System.Drawing.Point(1336, 29);
            this.buttonSearch2.Name = "buttonSearch2";
            this.buttonSearch2.Size = new System.Drawing.Size(96, 56);
            this.buttonSearch2.TabIndex = 5;
            this.buttonSearch2.Text = "Search";
            this.buttonSearch2.UseVisualStyleBackColor = true;
            this.buttonSearch2.Click += new System.EventHandler(this.buttonSearch2_Click);
            // 
            // buttonMusic1
            // 
            this.buttonMusic1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMusic1.Location = new System.Drawing.Point(78, 12);
            this.buttonMusic1.Name = "buttonMusic1";
            this.buttonMusic1.Size = new System.Drawing.Size(103, 45);
            this.buttonMusic1.TabIndex = 5;
            this.buttonMusic1.Text = "Relaxing";
            this.buttonMusic1.UseVisualStyleBackColor = true;
            this.buttonMusic1.Click += new System.EventHandler(this.buttonMusic1_Click);
            // 
            // buttonMusic2
            // 
            this.buttonMusic2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMusic2.Location = new System.Drawing.Point(231, 12);
            this.buttonMusic2.Name = "buttonMusic2";
            this.buttonMusic2.Size = new System.Drawing.Size(103, 45);
            this.buttonMusic2.TabIndex = 6;
            this.buttonMusic2.Text = "Rock";
            this.buttonMusic2.UseVisualStyleBackColor = true;
            this.buttonMusic2.Click += new System.EventHandler(this.buttonMusic2_Click);
            // 
            // buttonMusic3
            // 
            this.buttonMusic3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMusic3.Location = new System.Drawing.Point(394, 12);
            this.buttonMusic3.Name = "buttonMusic3";
            this.buttonMusic3.Size = new System.Drawing.Size(103, 45);
            this.buttonMusic3.TabIndex = 7;
            this.buttonMusic3.Text = "Jazz";
            this.buttonMusic3.UseVisualStyleBackColor = true;
            this.buttonMusic3.Click += new System.EventHandler(this.buttonMusic3_Click);
            // 
            // buttonMusic4
            // 
            this.buttonMusic4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMusic4.Location = new System.Drawing.Point(541, 12);
            this.buttonMusic4.Name = "buttonMusic4";
            this.buttonMusic4.Size = new System.Drawing.Size(103, 45);
            this.buttonMusic4.TabIndex = 8;
            this.buttonMusic4.Text = "Pop";
            this.buttonMusic4.UseVisualStyleBackColor = true;
            this.buttonMusic4.Click += new System.EventHandler(this.buttonMusic4_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.buttonMusic4);
            this.Controls.Add(this.buttonMusic3);
            this.Controls.Add(this.buttonMusic2);
            this.Controls.Add(this.buttonMusic1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.WebBrowser webBrowserDisplay;
        private System.Windows.Forms.RichTextBox richTextBoxNotes;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonSearch2;
        private System.Windows.Forms.WebBrowser webBrowserDisplay2;
        private System.Windows.Forms.TextBox textBoxSearch2;
        private System.Windows.Forms.Button buttonMusic1;
        private System.Windows.Forms.Button buttonMusic2;
        private System.Windows.Forms.Button buttonMusic3;
        private System.Windows.Forms.Button buttonMusic4;
    }
}

