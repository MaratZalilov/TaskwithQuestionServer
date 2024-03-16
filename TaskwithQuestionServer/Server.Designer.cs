namespace TaskwithQuestionServer
{
    partial class Server
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonConection = new System.Windows.Forms.Button();
            this.ButtonLoadingQuestion = new System.Windows.Forms.Button();
            this.ButtonGetAnswer = new System.Windows.Forms.Button();
            this.MainText = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonConection
            // 
            this.ButtonConection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonConection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonConection.Location = new System.Drawing.Point(365, 280);
            this.ButtonConection.Name = "ButtonConection";
            this.ButtonConection.Size = new System.Drawing.Size(155, 45);
            this.ButtonConection.TabIndex = 0;
            this.ButtonConection.Text = "Подключиться";
            this.ButtonConection.UseVisualStyleBackColor = true;
            this.ButtonConection.Click += new System.EventHandler(this.ButtonConection_Click);
            // 
            // ButtonLoadingQuestion
            // 
            this.ButtonLoadingQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonLoadingQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonLoadingQuestion.Location = new System.Drawing.Point(365, 330);
            this.ButtonLoadingQuestion.Name = "ButtonLoadingQuestion";
            this.ButtonLoadingQuestion.Size = new System.Drawing.Size(155, 45);
            this.ButtonLoadingQuestion.TabIndex = 2;
            this.ButtonLoadingQuestion.Text = "Загрузить список вопросов";
            this.ButtonLoadingQuestion.UseVisualStyleBackColor = true;
            this.ButtonLoadingQuestion.Click += new System.EventHandler(this.ButtonLoadingQuestion_Click);
            // 
            // ButtonGetAnswer
            // 
            this.ButtonGetAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonGetAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonGetAnswer.Location = new System.Drawing.Point(365, 380);
            this.ButtonGetAnswer.Name = "ButtonGetAnswer";
            this.ButtonGetAnswer.Size = new System.Drawing.Size(155, 45);
            this.ButtonGetAnswer.TabIndex = 3;
            this.ButtonGetAnswer.Text = "Получить ответы";
            this.ButtonGetAnswer.UseVisualStyleBackColor = true;
            this.ButtonGetAnswer.Click += new System.EventHandler(this.ButtonGetAnswer_Click);
            // 
            // MainText
            // 
            this.MainText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainText.AutoSize = true;
            this.MainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainText.ForeColor = System.Drawing.Color.White;
            this.MainText.Location = new System.Drawing.Point(200, 70);
            this.MainText.Name = "MainText";
            this.MainText.Size = new System.Drawing.Size(504, 46);
            this.MainText.TabIndex = 4;
            this.MainText.Text = "Серверное главное меню";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.openToolStripMenuItem.Text = "Открыть Excel документ";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.MainText);
            this.Controls.Add(this.ButtonGetAnswer);
            this.Controls.Add(this.ButtonLoadingQuestion);
            this.Controls.Add(this.ButtonConection);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Server";
            this.Text = "Server";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonConection;
        private System.Windows.Forms.Button ButtonLoadingQuestion;
        private System.Windows.Forms.Button ButtonGetAnswer;
        private System.Windows.Forms.Label MainText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}

