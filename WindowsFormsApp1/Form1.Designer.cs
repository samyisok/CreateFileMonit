namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxEx = new System.Windows.Forms.ListBox();
            this.textBoxEx = new System.Windows.Forms.TextBox();
            this.addExButton = new System.Windows.Forms.Button();
            this.DeleteExButton = new System.Windows.Forms.Button();
            this.listBoxFolders = new System.Windows.Forms.ListBox();
            this.addFolderButton = new System.Windows.Forms.Button();
            this.DeleteFolderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(600, 595);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.AccessibleName = "";
            this.button1.Location = new System.Drawing.Point(12, 627);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "To tray!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // listBoxEx
            // 
            this.listBoxEx.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.listBoxEx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxEx.FormattingEnabled = true;
            this.listBoxEx.Location = new System.Drawing.Point(638, 12);
            this.listBoxEx.Name = "listBoxEx";
            this.listBoxEx.Size = new System.Drawing.Size(321, 366);
            this.listBoxEx.TabIndex = 3;
            this.listBoxEx.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBoxEx
            // 
            this.textBoxEx.Location = new System.Drawing.Point(638, 404);
            this.textBoxEx.Name = "textBoxEx";
            this.textBoxEx.Size = new System.Drawing.Size(321, 20);
            this.textBoxEx.TabIndex = 4;
            // 
            // addExButton
            // 
            this.addExButton.Location = new System.Drawing.Point(638, 448);
            this.addExButton.Name = "addExButton";
            this.addExButton.Size = new System.Drawing.Size(145, 23);
            this.addExButton.TabIndex = 5;
            this.addExButton.Text = "ADD EX";
            this.addExButton.UseVisualStyleBackColor = true;
            this.addExButton.Click += new System.EventHandler(this.addExButton_Click);
            // 
            // DeleteExButton
            // 
            this.DeleteExButton.Location = new System.Drawing.Point(804, 448);
            this.DeleteExButton.Name = "DeleteExButton";
            this.DeleteExButton.Size = new System.Drawing.Size(155, 23);
            this.DeleteExButton.TabIndex = 6;
            this.DeleteExButton.Text = "DELETE EX";
            this.DeleteExButton.UseVisualStyleBackColor = true;
            this.DeleteExButton.Click += new System.EventHandler(this.DeleteExButton_Click);
            // 
            // listBoxFolders
            // 
            this.listBoxFolders.FormattingEnabled = true;
            this.listBoxFolders.Location = new System.Drawing.Point(989, 13);
            this.listBoxFolders.Name = "listBoxFolders";
            this.listBoxFolders.Size = new System.Drawing.Size(326, 368);
            this.listBoxFolders.TabIndex = 7;
            // 
            // addFolderButton
            // 
            this.addFolderButton.Location = new System.Drawing.Point(989, 400);
            this.addFolderButton.Name = "addFolderButton";
            this.addFolderButton.Size = new System.Drawing.Size(147, 23);
            this.addFolderButton.TabIndex = 8;
            this.addFolderButton.Text = "Add Folder";
            this.addFolderButton.UseVisualStyleBackColor = true;
            this.addFolderButton.Click += new System.EventHandler(this.addFolderButton_Click);
            // 
            // DeleteFolderButton
            // 
            this.DeleteFolderButton.Location = new System.Drawing.Point(1155, 400);
            this.DeleteFolderButton.Name = "DeleteFolderButton";
            this.DeleteFolderButton.Size = new System.Drawing.Size(160, 23);
            this.DeleteFolderButton.TabIndex = 9;
            this.DeleteFolderButton.Text = "Delete Folder";
            this.DeleteFolderButton.UseVisualStyleBackColor = true;
            this.DeleteFolderButton.Click += new System.EventHandler(this.DeleteFolderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 671);
            this.Controls.Add(this.DeleteFolderButton);
            this.Controls.Add(this.addFolderButton);
            this.Controls.Add(this.listBoxFolders);
            this.Controls.Add(this.DeleteExButton);
            this.Controls.Add(this.addExButton);
            this.Controls.Add(this.textBoxEx);
            this.Controls.Add(this.listBoxEx);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ListBox listBoxEx;
        private System.Windows.Forms.TextBox textBoxEx;
        private System.Windows.Forms.Button addExButton;
        private System.Windows.Forms.Button DeleteExButton;
        private System.Windows.Forms.ListBox listBoxFolders;
        private System.Windows.Forms.Button addFolderButton;
        private System.Windows.Forms.Button DeleteFolderButton;
    }
}

