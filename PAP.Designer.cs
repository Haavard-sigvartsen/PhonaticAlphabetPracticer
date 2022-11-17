namespace PhonaticAlphabetPracticer
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.TbxCurrentWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnTimed = new System.Windows.Forms.Button();
            this.Btn60s = new System.Windows.Forms.Button();
            this.Btn120s = new System.Windows.Forms.Button();
            this.BtnEndurance = new System.Windows.Forms.Button();
            this.Btn30s = new System.Windows.Forms.Button();
            this.RtbxUserInput = new System.Windows.Forms.RichTextBox();
            this.lblTest = new System.Windows.Forms.Label();
            this.LblTimer = new System.Windows.Forms.Label();
            this.timeClock = new System.Windows.Forms.Timer(this.components);
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CboxWOrdCLimit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCheatSheet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Word";
            // 
            // TbxCurrentWord
            // 
            this.TbxCurrentWord.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TbxCurrentWord.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbxCurrentWord.Location = new System.Drawing.Point(123, 9);
            this.TbxCurrentWord.Name = "TbxCurrentWord";
            this.TbxCurrentWord.ReadOnly = true;
            this.TbxCurrentWord.Size = new System.Drawing.Size(541, 32);
            this.TbxCurrentWord.TabIndex = 2;
            this.TbxCurrentWord.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "You\'re typing";
            // 
            // BtnTimed
            // 
            this.BtnTimed.Location = new System.Drawing.Point(12, 132);
            this.BtnTimed.Name = "BtnTimed";
            this.BtnTimed.Size = new System.Drawing.Size(49, 23);
            this.BtnTimed.TabIndex = 5;
            this.BtnTimed.Text = "Timed";
            this.BtnTimed.UseVisualStyleBackColor = true;
            this.BtnTimed.Click += new System.EventHandler(this.BtnTimed_Click);
            // 
            // Btn60s
            // 
            this.Btn60s.Location = new System.Drawing.Point(179, 132);
            this.Btn60s.Name = "Btn60s";
            this.Btn60s.Size = new System.Drawing.Size(95, 23);
            this.Btn60s.TabIndex = 6;
            this.Btn60s.Text = "1 Minutt Timer";
            this.Btn60s.UseVisualStyleBackColor = true;
            this.Btn60s.Click += new System.EventHandler(this.Btn60s_Click);
            // 
            // Btn120s
            // 
            this.Btn120s.Location = new System.Drawing.Point(280, 132);
            this.Btn120s.Name = "Btn120s";
            this.Btn120s.Size = new System.Drawing.Size(94, 23);
            this.Btn120s.TabIndex = 7;
            this.Btn120s.Text = "2 Minutt Timer";
            this.Btn120s.UseVisualStyleBackColor = true;
            this.Btn120s.Click += new System.EventHandler(this.Btn120s_Click);
            // 
            // BtnEndurance
            // 
            this.BtnEndurance.Location = new System.Drawing.Point(380, 132);
            this.BtnEndurance.Name = "BtnEndurance";
            this.BtnEndurance.Size = new System.Drawing.Size(75, 23);
            this.BtnEndurance.TabIndex = 8;
            this.BtnEndurance.Text = "Ëndurance";
            this.BtnEndurance.UseVisualStyleBackColor = true;
            this.BtnEndurance.Click += new System.EventHandler(this.BtnEndurance_Click);
            // 
            // Btn30s
            // 
            this.Btn30s.Location = new System.Drawing.Point(67, 132);
            this.Btn30s.Name = "Btn30s";
            this.Btn30s.Size = new System.Drawing.Size(106, 23);
            this.Btn30s.TabIndex = 9;
            this.Btn30s.Text = "30 Second Timer";
            this.Btn30s.UseVisualStyleBackColor = true;
            this.Btn30s.Click += new System.EventHandler(this.button5_Click);
            // 
            // RtbxUserInput
            // 
            this.RtbxUserInput.BackColor = System.Drawing.SystemColors.Menu;
            this.RtbxUserInput.Enabled = false;
            this.RtbxUserInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RtbxUserInput.Location = new System.Drawing.Point(123, 38);
            this.RtbxUserInput.Multiline = false;
            this.RtbxUserInput.Name = "RtbxUserInput";
            this.RtbxUserInput.Size = new System.Drawing.Size(541, 23);
            this.RtbxUserInput.TabIndex = 12;
            this.RtbxUserInput.Text = "";
            this.RtbxUserInput.TextChanged += new System.EventHandler(this.TbxUserInput_TextChanged);
            this.RtbxUserInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RtbxUserInput_KeyPress);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Enabled = false;
            this.lblTest.Location = new System.Drawing.Point(93, 102);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(0, 15);
            this.lblTest.TabIndex = 13;
            this.lblTest.Visible = false;
            // 
            // LblTimer
            // 
            this.LblTimer.AutoSize = true;
            this.LblTimer.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTimer.Location = new System.Drawing.Point(12, 98);
            this.LblTimer.Name = "LblTimer";
            this.LblTimer.Size = new System.Drawing.Size(86, 28);
            this.LblTimer.TabIndex = 22;
            this.LblTimer.Text = "00:00:00";
            // 
            // timeClock
            // 
            this.timeClock.Tick += new System.EventHandler(this.timeClock_Tick);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(12, 72);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(75, 23);
            this.BtnSubmit.TabIndex = 23;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Enabled = false;
            this.BtnStop.Location = new System.Drawing.Point(93, 72);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(75, 23);
            this.BtnStop.TabIndex = 24;
            this.BtnStop.TabStop = false;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 60);
            this.label3.TabIndex = 25;
            this.label3.Text = "Instructrions:\r\ncase insensitive\r\nseperate each word with a space\r\nPress \"Enter\" " +
    "for submit\r\n";
            // 
            // CboxWOrdCLimit
            // 
            this.CboxWOrdCLimit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxWOrdCLimit.FormattingEnabled = true;
            this.CboxWOrdCLimit.Location = new System.Drawing.Point(461, 132);
            this.CboxWOrdCLimit.Name = "CboxWOrdCLimit";
            this.CboxWOrdCLimit.Size = new System.Drawing.Size(102, 23);
            this.CboxWOrdCLimit.TabIndex = 26;
            this.CboxWOrdCLimit.SelectedIndexChanged += new System.EventHandler(this.CboxWOrdCLimit_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 45);
            this.label4.TabIndex = 27;
            this.label4.Text = "Choose Word \r\nCharacter limit\r\n0 for any";
            // 
            // btnCheatSheet
            // 
            this.btnCheatSheet.Location = new System.Drawing.Point(569, 132);
            this.btnCheatSheet.Name = "btnCheatSheet";
            this.btnCheatSheet.Size = new System.Drawing.Size(100, 23);
            this.btnCheatSheet.TabIndex = 28;
            this.btnCheatSheet.Text = "Cheat sheet";
            this.btnCheatSheet.UseVisualStyleBackColor = true;
            this.btnCheatSheet.Click += new System.EventHandler(this.btnCheatSheet_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 167);
            this.Controls.Add(this.btnCheatSheet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CboxWOrdCLimit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.LblTimer);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.RtbxUserInput);
            this.Controls.Add(this.Btn30s);
            this.Controls.Add(this.BtnEndurance);
            this.Controls.Add(this.Btn120s);
            this.Controls.Add(this.Btn60s);
            this.Controls.Add(this.BtnTimed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbxCurrentWord);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Phonatic Alphabet Practicer";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TbxCurrentWord;
        private Label label2;
        private Button BtnTimed;
        private Button Btn60s;
        private Button Btn120s;
        private Button BtnEndurance;
        private Button Btn30s;
        private RichTextBox RtbxUserInput;
        private Label lblTest;
        private Label LblTimer;
        private System.Windows.Forms.Timer timeClock;
        private Button BtnSubmit;
        private Button BtnStop;
        private Label label3;
        private ComboBox CboxWOrdCLimit;
        private Label label4;
        private Button btnCheatSheet;
    }
}