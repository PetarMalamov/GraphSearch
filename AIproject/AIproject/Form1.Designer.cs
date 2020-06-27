namespace AIproject
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
            this.AddNodePanel = new System.Windows.Forms.Button();
            this.AddLink = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.AddNode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NodeWeightTf = new System.Windows.Forms.TextBox();
            this.NodeNameTf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchMethod = new System.Windows.Forms.ComboBox();
            this.SearchFromCB = new System.Windows.Forms.ComboBox();
            this.SearchToCB = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AddLinkPanel = new System.Windows.Forms.Panel();
            this.AddLinkButton = new System.Windows.Forms.Button();
            this.ToNodeCB = new System.Windows.Forms.ComboBox();
            this.FromNodeCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.AddLinkPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddNodePanel
            // 
            this.AddNodePanel.Location = new System.Drawing.Point(12, 184);
            this.AddNodePanel.Name = "AddNodePanel";
            this.AddNodePanel.Size = new System.Drawing.Size(75, 23);
            this.AddNodePanel.TabIndex = 1;
            this.AddNodePanel.Text = "Add Nodes";
            this.AddNodePanel.UseVisualStyleBackColor = true;
            this.AddNodePanel.Click += new System.EventHandler(this.AddNodePanel_Click);
            // 
            // AddLink
            // 
            this.AddLink.Location = new System.Drawing.Point(120, 184);
            this.AddLink.Name = "AddLink";
            this.AddLink.Size = new System.Drawing.Size(75, 23);
            this.AddLink.TabIndex = 2;
            this.AddLink.Text = "Add Links";
            this.AddLink.UseVisualStyleBackColor = true;
            this.AddLink.Click += new System.EventHandler(this.AddLink_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(221, 184);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(82, 23);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search Panel";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.AddNode);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.NodeWeightTf);
            this.MainPanel.Controls.Add(this.NodeNameTf);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Location = new System.Drawing.Point(12, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(291, 162);
            this.MainPanel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Add Node";
            // 
            // AddNode
            // 
            this.AddNode.Location = new System.Drawing.Point(174, 119);
            this.AddNode.Name = "AddNode";
            this.AddNode.Size = new System.Drawing.Size(75, 23);
            this.AddNode.TabIndex = 4;
            this.AddNode.Text = "Add";
            this.AddNode.UseVisualStyleBackColor = true;
            this.AddNode.Click += new System.EventHandler(this.AddNode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Node weigth:";
            // 
            // NodeWeightTf
            // 
            this.NodeWeightTf.Location = new System.Drawing.Point(108, 83);
            this.NodeWeightTf.Name = "NodeWeightTf";
            this.NodeWeightTf.Size = new System.Drawing.Size(141, 20);
            this.NodeWeightTf.TabIndex = 2;
            // 
            // NodeNameTf
            // 
            this.NodeNameTf.Location = new System.Drawing.Point(108, 43);
            this.NodeNameTf.Name = "NodeNameTf";
            this.NodeNameTf.Size = new System.Drawing.Size(141, 20);
            this.NodeNameTf.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Node name:";
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.SearchButton);
            this.SearchPanel.Controls.Add(this.SearchMethod);
            this.SearchPanel.Controls.Add(this.SearchFromCB);
            this.SearchPanel.Controls.Add(this.SearchToCB);
            this.SearchPanel.Controls.Add(this.label10);
            this.SearchPanel.Controls.Add(this.label9);
            this.SearchPanel.Controls.Add(this.label8);
            this.SearchPanel.Controls.Add(this.label7);
            this.SearchPanel.Location = new System.Drawing.Point(12, 12);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(291, 162);
            this.SearchPanel.TabIndex = 5;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(174, 120);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchMethod
            // 
            this.SearchMethod.FormattingEnabled = true;
            this.SearchMethod.Location = new System.Drawing.Point(108, 29);
            this.SearchMethod.Name = "SearchMethod";
            this.SearchMethod.Size = new System.Drawing.Size(141, 21);
            this.SearchMethod.TabIndex = 6;
            // 
            // SearchFromCB
            // 
            this.SearchFromCB.FormattingEnabled = true;
            this.SearchFromCB.Location = new System.Drawing.Point(108, 62);
            this.SearchFromCB.Name = "SearchFromCB";
            this.SearchFromCB.Size = new System.Drawing.Size(141, 21);
            this.SearchFromCB.TabIndex = 5;
            // 
            // SearchToCB
            // 
            this.SearchToCB.FormattingEnabled = true;
            this.SearchToCB.Location = new System.Drawing.Point(108, 93);
            this.SearchToCB.Name = "SearchToCB";
            this.SearchToCB.Size = new System.Drawing.Size(141, 21);
            this.SearchToCB.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "To:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "From:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Search method:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Search";
            // 
            // AddLinkPanel
            // 
            this.AddLinkPanel.Controls.Add(this.AddLinkButton);
            this.AddLinkPanel.Controls.Add(this.ToNodeCB);
            this.AddLinkPanel.Controls.Add(this.FromNodeCB);
            this.AddLinkPanel.Controls.Add(this.label6);
            this.AddLinkPanel.Controls.Add(this.label5);
            this.AddLinkPanel.Controls.Add(this.label4);
            this.AddLinkPanel.Location = new System.Drawing.Point(12, 12);
            this.AddLinkPanel.Name = "AddLinkPanel";
            this.AddLinkPanel.Size = new System.Drawing.Size(291, 162);
            this.AddLinkPanel.TabIndex = 6;
            // 
            // AddLinkButton
            // 
            this.AddLinkButton.Location = new System.Drawing.Point(174, 120);
            this.AddLinkButton.Name = "AddLinkButton";
            this.AddLinkButton.Size = new System.Drawing.Size(75, 23);
            this.AddLinkButton.TabIndex = 5;
            this.AddLinkButton.Text = "Add";
            this.AddLinkButton.UseVisualStyleBackColor = true;
            this.AddLinkButton.Click += new System.EventHandler(this.AddLinkButton_Click);
            // 
            // ToNodeCB
            // 
            this.ToNodeCB.FormattingEnabled = true;
            this.ToNodeCB.Location = new System.Drawing.Point(108, 78);
            this.ToNodeCB.Name = "ToNodeCB";
            this.ToNodeCB.Size = new System.Drawing.Size(141, 21);
            this.ToNodeCB.TabIndex = 4;
            // 
            // FromNodeCB
            // 
            this.FromNodeCB.FormattingEnabled = true;
            this.FromNodeCB.Location = new System.Drawing.Point(108, 43);
            this.FromNodeCB.Name = "FromNodeCB";
            this.FromNodeCB.Size = new System.Drawing.Size(141, 21);
            this.FromNodeCB.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "To:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "From:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Add link";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 224);
            this.Controls.Add(this.AddLinkPanel);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.AddLink);
            this.Controls.Add(this.AddNodePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.AddLinkPanel.ResumeLayout(false);
            this.AddLinkPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddNodePanel;
        private System.Windows.Forms.Button AddLink;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Panel AddLinkPanel;
        private System.Windows.Forms.Button AddNode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NodeWeightTf;
        private System.Windows.Forms.TextBox NodeNameTf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddLinkButton;
        private System.Windows.Forms.ComboBox ToNodeCB;
        private System.Windows.Forms.ComboBox FromNodeCB;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ComboBox SearchMethod;
        private System.Windows.Forms.ComboBox SearchFromCB;
        private System.Windows.Forms.ComboBox SearchToCB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

