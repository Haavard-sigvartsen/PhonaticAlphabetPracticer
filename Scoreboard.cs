namespace PhonaticAlphabetPracticer {
    public partial class Scoreboard : Form {
        String Score;
        String MissedWords;

        public Scoreboard() {
            InitializeComponent();
        }

        private void Scoreboard_Load(object sender, EventArgs e) {
            WrongResultsList.Items.Clear();
            LblScoreText.Text = Score;

            string[] ItemList = MissedWords.Split("|");
            for (int i = 0; i < ItemList.Length - 1; i++) { // -1 ignores the blank one in the end
                WrongResultsList.Items.Add(ItemList[i]);
            }
            if (WrongResultsList.Items.Count < 1) {
                LblNoMistakes.Visible = true;
            }
        }

        public void ScoreReciever(String A, String B) {
            Score = A;
            MissedWords = B;
        }

        private void BtnOk_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
