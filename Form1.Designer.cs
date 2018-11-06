namespace AutomationTool
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
            this.label1 = new System.Windows.Forms.Label();
            this.URLBox = new System.Windows.Forms.TextBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Images = new System.Windows.Forms.TextBox();
            this.ImgaeswithLinks = new System.Windows.Forms.TextBox();
            this.Links = new System.Windows.Forms.TextBox();
            this.Select = new System.Windows.Forms.TextBox();
            this.BrokenLinkchecker = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter URL in the box provided : ";
            // 
            // URLBox
            // 
            this.URLBox.Location = new System.Drawing.Point(178, 10);
            this.URLBox.Name = "URLBox";
            this.URLBox.Size = new System.Drawing.Size(494, 20);
            this.URLBox.TabIndex = 1;
            this.URLBox.TextChanged += new System.EventHandler(this.URLBox_TextChanged);
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(16, 49);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 23);
            this.RunButton.TabIndex = 2;
            this.RunButton.Text = "RUN";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Different Web Elements in this Page";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Images : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "TextBoxes :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hyperlinks :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "DropDown :";
            // 
            // Images
            // 
            this.Images.Location = new System.Drawing.Point(166, 121);
            this.Images.Name = "Images";
            this.Images.Size = new System.Drawing.Size(100, 20);
            this.Images.TabIndex = 8;
            this.Images.TextChanged += new System.EventHandler(this.Images_TextChanged);
            // 
            // ImgaeswithLinks
            // 
            this.ImgaeswithLinks.Location = new System.Drawing.Point(166, 152);
            this.ImgaeswithLinks.Name = "ImgaeswithLinks";
            this.ImgaeswithLinks.Size = new System.Drawing.Size(100, 20);
            this.ImgaeswithLinks.TabIndex = 9;
            this.ImgaeswithLinks.TextChanged += new System.EventHandler(this.ImgaeswithLinks_TextChanged);
            // 
            // Links
            // 
            this.Links.Location = new System.Drawing.Point(166, 183);
            this.Links.Name = "Links";
            this.Links.Size = new System.Drawing.Size(100, 20);
            this.Links.TabIndex = 10;
            this.Links.TextChanged += new System.EventHandler(this.Links_TextChanged);
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(166, 211);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(100, 20);
            this.Select.TabIndex = 11;
            this.Select.TextChanged += new System.EventHandler(this.Select_TextChanged);
            // 
            // BrokenLinkchecker
            // 
            this.BrokenLinkchecker.Location = new System.Drawing.Point(22, 277);
            this.BrokenLinkchecker.Name = "BrokenLinkchecker";
            this.BrokenLinkchecker.Size = new System.Drawing.Size(287, 23);
            this.BrokenLinkchecker.TabIndex = 12;
            this.BrokenLinkchecker.Text = "Click here for broken links";
            this.BrokenLinkchecker.UseVisualStyleBackColor = true;
            this.BrokenLinkchecker.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.AutoWordSelection = true;
            this.richTextBox1.Location = new System.Drawing.Point(22, 325);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(872, 279);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            this.richTextBox1.UseWaitCursor = true;
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 635);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BrokenLinkchecker);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.Links);
            this.Controls.Add(this.ImgaeswithLinks);
            this.Controls.Add(this.Images);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.URLBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox URLBox;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Images;
        private System.Windows.Forms.TextBox ImgaeswithLinks;
        private System.Windows.Forms.TextBox Links;
        private System.Windows.Forms.TextBox Select;
        private System.Windows.Forms.Button BrokenLinkchecker;
        public System.Windows.Forms.RichTextBox richTextBox1;
    }
}

