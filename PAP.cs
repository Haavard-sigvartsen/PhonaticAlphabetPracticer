using System.Diagnostics;

namespace PhonaticAlphabetPracticer;

/* Refrences
* https://www.javatpoint.com/c-sharp-function
* https://stackoverflow.com/questions/2706500/how-do-i-generate-a-random-integer-in-c
* https://zetcode.com/csharp/array/
* https://www.delftstack.com/howto/csharp/convert-string-array-to-string-in-csharp/
* https://www.youtube.com/watch?v=lKMzicLC9J4
* 
* 
* TODO: ironing
* Timer does not submit before showing results, might be the cheap trigger i made - solved? 
* word changes when time runs out
* 
* Tests:
* regular submit finish
* Submit with failures
* Submit too many arrays
* 
* Timer:
* Timer ends during writing and submit the missing once
* Timer ends during writing after completing a few words with a few missing words
* Timer ends during writing after completing everything completed
* 
*/

public partial class MainMenu : Form {
    private int intCharacterLengthLimit;
    private string strCurrentWord;
    private String[] arrWordList;
    Boolean fileFound;
    private String[] strArrCurrentWords;
    private String[] strArrUserInputWords;
    private List<String> CorrectionList = new List<string>();
    private int intCurrentPoints;
    private int intMaxPoints;
    Stopwatch stopWatch;
    private int intTimeLimit;
    private int ScoreBoredShowed;
    private bool TimedWord;
    private bool PerformedManualStop;
    private bool TimedPassed;

    public MainMenu() //constructor
    {   // Initializes work
        InitializeComponent();
    }
    public void MainMenu_Load(object sender, EventArgs e) {
        this.PerformedManualStop = false;
        this.intCharacterLengthLimit = 0;
        stopWatch = new Stopwatch();
        this.TimedWord = false;
        BtnSubmit.Enabled = false;
        this.fileFound = false;
        LoadList();
        ResetTimer();
    }
    public void RefreshWord() { // just changes the word
        Random ranSelectRandom = new Random();
        bool IsWordValid = false;
        int Counter = 0;
        while (IsWordValid == false) {
            this.strCurrentWord = this.arrWordList[ranSelectRandom.Next(0, this.arrWordList.Length)]; //Random word gets selected between the 0 and the length of the Word list
            if (this.intCharacterLengthLimit == 0) {
                IsWordValid = true;
            } else { // if its set to 0, it will just pick what ever
                if (this.strCurrentWord.Length == this.intCharacterLengthLimit) {
                    IsWordValid = true;
                } // else it will continue
            }
            Counter++; // prevents infinite loop
            if (Counter >= this.arrWordList.Length * 3) {
                MessageBox.Show("no valid words found, exiting");
                return;
            }
        }
        int o = 0;
        Array.Resize(ref this.strArrCurrentWords, this.strCurrentWord.Length);
        foreach (char strCurrentWordSplice in this.strCurrentWord) {
            this.strArrCurrentWords[o] = char.ToString(strCurrentWordSplice);
            o++;
        }
        Phoneticize(this.strArrCurrentWords);
        TbxCurrentWord.Text = this.strCurrentWord;
        StartTimer(); // starts sequence once a word is found
        RtbxUserInput.Focus();
    }
    public static void Phoneticize(string[] arrLetter) {
        for (int i = 0; i < arrLetter.Length; i++) {
            switch (arrLetter[i]) {
                case "a":
                    arrLetter[i] = "alpha";
                    break;
                case "b":
                    arrLetter[i] = "bravo";
                    break;
                case "c":
                    arrLetter[i] = "charlie";
                    break;
                case "d":
                    arrLetter[i] = "delta";
                    break;
                case "e":
                    arrLetter[i] = "echo";
                    break;
                case "f":
                    arrLetter[i] = "foxtrot";
                    break;
                case "g":
                    arrLetter[i] = "golf";
                    break;
                case "h":
                    arrLetter[i] = "hotel";
                    break;
                case "i":
                    arrLetter[i] = "indi";
                    break;
                case "j":
                    arrLetter[i] = "juliett";
                    break;
                case "k":
                    arrLetter[i] = "kilo";
                    break;
                case "l":
                    arrLetter[i] = "lima";
                    break;
                case "m":
                    arrLetter[i] = "mike";
                    break;
                case "n":
                    arrLetter[i] = "november";
                    break;
                case "o":
                    arrLetter[i] = "oscar";
                    break;
                case "p":
                    arrLetter[i] = "papa";
                    break;
                case "q":
                    arrLetter[i] = "qubec";
                    break;
                case "r":
                    arrLetter[i] = "romeo";
                    break;
                case "s":
                    arrLetter[i] = "sierra";
                    break;
                case "t":
                    arrLetter[i] = "tango";
                    break;
                case "u":
                    arrLetter[i] = "uniform";
                    break;
                case "v":
                    arrLetter[i] = "victor";
                    break;
                case "w":
                    arrLetter[i] = "whiskey";
                    break;
                case "x":
                    arrLetter[i] = "x-ray";
                    break;
                case "y":
                    arrLetter[i] = "yankee";
                    break;
                case "z":
                    arrLetter[i] = "zulu";
                    break;
            }
        }
    }

    private void LoadList() {
        while (fileFound == false) {
            if (File.Exists("default.txt")) {
                fileFound = true;
                this.arrWordList = File.ReadAllLines("default.txt");
            } else {
                MessageBox.Show("defualt.txt not found, please place default.txt with the words seperated line by line in Root directory and press OK");
            }
        }
        int LongestWord = 0;

        // finds the longest and then the shortest word
        foreach (String word in this.arrWordList) {
            if (word.Length > LongestWord) {
                LongestWord = word.Length;
            }
        }
        int ShortestWord = LongestWord;
        foreach (String word in this.arrWordList) {
            if (word.Length < ShortestWord) {
                ShortestWord = word.Length;
            }
        }
        CboxWOrdCLimit.Items.Add(0);
        // Adds them to the collectionbox so the user can choose
        for (int i = ShortestWord; i <= LongestWord; i++) {
            CboxWOrdCLimit.Items.Add(i);
        }

    }

    private void TbxUserInput_TextChanged(object sender, EventArgs e) {
        if (string.IsNullOrEmpty(TbxCurrentWord.Text)) { // prevent errors, unless there is a word it has grabbed from the list
        } else {
            if (string.IsNullOrEmpty(RtbxUserInput.Text)) { // prevents errors
            } else {
                this.strArrUserInputWords = RtbxUserInput.Text.ToLower().Split(" "); //split based on spaces
                if (this.strArrUserInputWords.Length > strArrCurrentWords.Length) {
                    RtbxUserInput.BackColor = Color.LightYellow;
                } else {
                    RtbxUserInput.BackColor = SystemColors.Menu;
                }
            }
        }
    }
    private void BtnSubmit_Click(object sender, EventArgs e) {
        Submit();
    }
    private void RtbxUserInput_KeyPress(object sender, KeyPressEventArgs e) { // when the users presses "enter" it will check how well it did it and compare it
        if (e.KeyChar == (char)Keys.Enter) {
            Submit();
        }
    }
    private void DisableButtons() {
        Btn120s.Enabled = false;
        Btn30s.Enabled = false;
        Btn60s.Enabled = false;
        BtnTimed.Enabled = false;
        BtnEndurance.Enabled = false;
        BtnSubmit.Enabled = true;
        RtbxUserInput.Enabled = true;
        BtnStop.Enabled = true;
    }
    private void EnableButtons() {
        Btn120s.Enabled = true;
        Btn30s.Enabled = true;
        Btn60s.Enabled = true;
        BtnTimed.Enabled = true;
        BtnEndurance.Enabled = true;
        BtnSubmit.Enabled = false;
        BtnStop.Enabled = false;
        RtbxUserInput.Enabled = false;
    }
    private void StartTimer() {
        this.stopWatch.Start();
        timeClock.Start();
        timeClock.Enabled = true;
        DisableButtons();
    }
    private void StopTimer() {
        this.stopWatch.Stop();
        timeClock.Stop();
        timeClock.Enabled = false;
    }
    private void ResetTimer() {
        this.PerformedManualStop = false;
        this.stopWatch.Reset();
        this.ScoreBoredShowed = 0;
        this.intMaxPoints = 0;
        this.intCurrentPoints = 0;
        this.ScoreBoredShowed = 0;
        this.TimedPassed = false;
        LblTimer.Text = "00:00:00";
        RtbxUserInput.Text = "";
        TbxCurrentWord.Text = "";
        CorrectionList.Clear();
    }

    private void CheckTimer() {
        if (this.TimedPassed == false) {
            LblTimer.Text = String.Format("{0:00}:{1:00}:{2:00}", this.stopWatch.Elapsed.Minutes, this.stopWatch.Elapsed.Seconds, this.stopWatch.Elapsed.Milliseconds / 10);
            if (this.stopWatch.Elapsed.Seconds >= this.intTimeLimit) {
                this.TimedPassed = true;
                StopTimer();
                EnableButtons();
                Submit();
                ShowPoints();
            }

        } // does nothing if the time is not right
    }
    private void ShowPoints() {
        if (this.ScoreBoredShowed == 0) { // prevents wayyyyyyy too many boxes and BSODs... if it works
            this.ScoreBoredShowed = 1;

            string Score = string.Format("Score: {0} out of {1}", this.intCurrentPoints, this.intMaxPoints);

            Scoreboard Scoreboard = new Scoreboard();
            Scoreboard.ScoreReciever(Score, string.Join(" ", CorrectionList));
            Scoreboard.Show();
        }
        StopTimer();
        EnableButtons();
    }
    private void timeClock_Tick(object sender, EventArgs e) {
        CheckTimer();
    }
    private void button5_Click(object sender, EventArgs e) {
        ResetTimer();
        RefreshWord();
        this.intTimeLimit = 3;
    }
    private void Btn60s_Click(object sender, EventArgs e) {
        ResetTimer();
        RefreshWord();
        this.intTimeLimit = 60;
    }

    private void Btn120s_Click(object sender, EventArgs e) {
        ResetTimer();
        RefreshWord();
        this.intTimeLimit = 120;
    }
    private void BtnTimed_Click(object sender, EventArgs e) {
        ResetTimer();
        this.TimedWord = true;
        RefreshWord();
        this.intTimeLimit = 300;
    }

    private void BtnEndurance_Click(object sender, EventArgs e) {
        RefreshWord();
        this.intTimeLimit = 3600; // not realistic, but who does it hurt?
    }
    private void Submit() {
        if (!string.IsNullOrEmpty(TbxCurrentWord.Text)) { // prevent errors, unless there is a word it has grabbed from the list
            Array.Resize(ref this.strArrUserInputWords, this.strArrCurrentWords.Length); // adjustes the array to the length of array of the current words
            for (int i = 0; i < strArrCurrentWords.Length; i++) {
                if (this.strArrUserInputWords[i] == this.strArrCurrentWords[i]) { // Comparin the user input vs answer, sensetive
                    this.intCurrentPoints++;
                } else {
                    // any errors gets logged for comparison sake
                    CorrectionList.Add(this.strArrUserInputWords[i]);
                    CorrectionList.Add("=");
                    CorrectionList.Add(this.strArrCurrentWords[i]);
                    CorrectionList.Add("|");
                }
            }
            this.intMaxPoints += strArrCurrentWords.Length;
            if (this.TimedWord == true) { // if its timed, it will stop everything at the posted time
                StopTimer();
                this.TimedWord = false;
                ShowPoints();
            } else { // when user presses submit, it well.. submits the and gets a new word until the time rounds out or he gets bored
                if (this.PerformedManualStop == true) {
                    StopTimer();
                    this.TimedWord = false;
                    ShowPoints();
                } else if (this.TimedPassed == true) {
                    StopTimer();
                    this.TimedWord = false;
                    ShowPoints();
                } else {
                    RtbxUserInput.Text = "";
                    RefreshWord();
                }
            }
        } else {
            MessageBox.Show("You havent selected the gamemode yet");
        }
    }

    private void BtnStop_Click(object sender, EventArgs e) { // could have been cleaner with !=, but w/e
        this.PerformedManualStop = true;
        if (this.TimedWord == true) {
            if (this.intCurrentPoints > 0) { // will just stop if there is nothing written in the textbox
                StopTimer();
                this.TimedWord = false;
                Submit();
            } else {
                if (RtbxUserInput.Text == "") {
                    StopTimer();
                    EnableButtons();
                    ResetTimer();
                } else {
                    StopTimer();
                    this.TimedWord = false;
                    Submit();
                    EnableButtons();
                    ResetTimer();
                }
            }
        } else {
            StopTimer();
            this.TimedWord = false;
            Submit();
            EnableButtons();
            ResetTimer();
        }
    }

    private void CboxWOrdCLimit_SelectedIndexChanged(object sender, EventArgs e) {
        this.intCharacterLengthLimit = Int32.Parse(CboxWOrdCLimit.Text);
    }

    private void btnCheatSheet_Click(object sender, EventArgs e) {
        CheatSheet cheatSheet = new CheatSheet();
        cheatSheet.Show();
    }
}
