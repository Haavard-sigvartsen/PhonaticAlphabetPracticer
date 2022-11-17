namespace PhonaticAlphabetPracticer {
    partial class Scoreboard {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.BtnOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblScoreText = new System.Windows.Forms.Label();
            this.WrongResultsList = new System.Windows.Forms.ListView();
            this.WrongAnswers = new System.Windows.Forms.ColumnHeader();
            this.LblNoMistakes = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(12, 666);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(274, 29);
            this.BtnOk.TabIndex = 0;
            this.BtnOk.Text = "Ok";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.LblScoreText);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 100);
            this.panel1.TabIndex = 1;
            // 
            // LblScoreText
            // 
            this.LblScoreText.AutoSize = true;
            this.LblScoreText.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblScoreText.Location = new System.Drawing.Point(44, 16);
            this.LblScoreText.Name = "LblScoreText";
            this.LblScoreText.Size = new System.Drawing.Size(110, 30);
            this.LblScoreText.TabIndex = 1;
            this.LblScoreText.Text = "Score text";
            // 
            // WrongResultsList
            // 
            this.WrongResultsList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.WrongResultsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.WrongAnswers});
            this.WrongResultsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.WrongResultsList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.WrongResultsList.Location = new System.Drawing.Point(12, 118);
            this.WrongResultsList.Name = "WrongResultsList";
            this.WrongResultsList.Size = new System.Drawing.Size(274, 542);
            this.WrongResultsList.TabIndex = 2;
            this.WrongResultsList.UseCompatibleStateImageBehavior = false;
            this.WrongResultsList.View = System.Windows.Forms.View.Details;
            // 
            // WrongAnswers
            // 
            this.WrongAnswers.Text = "Wrong Answers";
            this.WrongAnswers.Width = 270;
            // 
            // LblNoMistakes
            // 
            this.LblNoMistakes.AutoSize = true;
            this.LblNoMistakes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LblNoMistakes.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNoMistakes.ForeColor = System.Drawing.Color.ForestGreen;
            this.LblNoMistakes.Location = new System.Drawing.Point(12, 118);
            this.LblNoMistakes.Name = "LblNoMistakes";
            this.LblNoMistakes.Size = new System.Drawing.Size(269, 30);
            this.LblNoMistakes.TabIndex = 3;
            this.LblNoMistakes.Text = "You did everything right! :)";
            this.LblNoMistakes.Visible = false;
            // 
            // Scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 707);
            this.Controls.Add(this.LblNoMistakes);
            this.Controls.Add(this.WrongResultsList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnOk);
            this.MaximizeBox = false;
            this.Name = "Scoreboard";
            this.Text = "ScoreBoard";
            this.Load += new System.EventHandler(this.Scoreboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnOk;
        private Panel panel1;
        private Label LblScoreText;
        private ListView WrongResultsList;
        private ColumnHeader WrongAnswers;
        private Label LblNoMistakes;
    }
}