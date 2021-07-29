namespace QuizApp
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.answerBox = new System.Windows.Forms.TextBox();
            this.question = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stoicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.survivalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.makeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.hintComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.shuffleComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sub = new System.Windows.Forms.Label();
            this.answerButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.modeLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // answerBox
            // 
            this.answerBox.Enabled = false;
            this.answerBox.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.answerBox.Location = new System.Drawing.Point(68, 316);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(659, 29);
            this.answerBox.TabIndex = 0;
            // 
            // question
            // 
            this.question.Font = new System.Drawing.Font("MS UI Gothic", 50F);
            this.question.Location = new System.Drawing.Point(68, 49);
            this.question.Name = "question";
            this.question.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.question.Size = new System.Drawing.Size(659, 199);
            this.question.TabIndex = 1;
            this.question.Text = "QuizApp";
            this.question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label1.Location = new System.Drawing.Point(64, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "\r\n";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.stoicToolStripMenuItem,
            this.survivalToolStripMenuItem,
            this.toolStripSeparator1,
            this.makeToolStripMenuItem,
            this.toolStripSeparator2,
            this.hintComboBox1,
            this.shuffleComboBox1,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.fileToolStripMenuItem.Text = "ファイル";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.normalToolStripMenuItem.Text = "ノーマルモード";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.StartNormal);
            // 
            // stoicToolStripMenuItem
            // 
            this.stoicToolStripMenuItem.Name = "stoicToolStripMenuItem";
            this.stoicToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.stoicToolStripMenuItem.Text = "ストイックモード";
            this.stoicToolStripMenuItem.Click += new System.EventHandler(this.StartStoic);
            // 
            // survivalToolStripMenuItem
            // 
            this.survivalToolStripMenuItem.Name = "survivalToolStripMenuItem";
            this.survivalToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.survivalToolStripMenuItem.Text = "サバイバルモード";
            this.survivalToolStripMenuItem.Click += new System.EventHandler(this.StartSurvival);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // makeToolStripMenuItem
            // 
            this.makeToolStripMenuItem.Name = "makeToolStripMenuItem";
            this.makeToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.makeToolStripMenuItem.Text = "問題の作り方";
            this.makeToolStripMenuItem.Click += new System.EventHandler(this.HowToMake);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // hintComboBox1
            // 
            this.hintComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hintComboBox1.Items.AddRange(new object[] {
            "ヒント：ON",
            "ヒント：OFF"});
            this.hintComboBox1.Name = "hintComboBox1";
            this.hintComboBox1.Size = new System.Drawing.Size(121, 23);
            this.hintComboBox1.SelectedIndexChanged += new System.EventHandler(this.HintComboBox1_SelectedIndexChanged);
            // 
            // shuffleComboBox1
            // 
            this.shuffleComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shuffleComboBox1.Items.AddRange(new object[] {
            "シャッフル：ON",
            "シャッフル：OFF"});
            this.shuffleComboBox1.Name = "shuffleComboBox1";
            this.shuffleComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(178, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.exitToolStripMenuItem.Text = "終了";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitMenuClicked);
            // 
            // sub
            // 
            this.sub.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.sub.Location = new System.Drawing.Point(68, 248);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(659, 65);
            this.sub.TabIndex = 5;
            this.sub.Text = "ファイルから、いろんなジャンルに挑戦!";
            this.sub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerButton
            // 
            this.answerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answerButton.Enabled = false;
            this.answerButton.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.answerButton.Location = new System.Drawing.Point(627, 351);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(100, 30);
            this.answerButton.TabIndex = 3;
            this.answerButton.Text = "OK";
            this.answerButton.UseVisualStyleBackColor = true;
            this.answerButton.Click += new System.EventHandler(this.Answered);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "\r\n";
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.modeLabel.Location = new System.Drawing.Point(12, 24);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(0, 24);
            this.modeLabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AcceptButton = this.answerButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.question);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "QuizApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem survivalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label sub;
        private System.Windows.Forms.Button answerButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem stoicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem makeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.ToolStripComboBox shuffleComboBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripComboBox hintComboBox1;
    }
}

