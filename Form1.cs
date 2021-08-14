using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using T_T_T.Q_Learning;
using T_T_T.Q_Learning.Utilities;
using T_T_T.Tools;
using T_T_T.GameManager;
using T_T_T.GameManager.PlayerManager;

namespace T_T_T
{
    public partial class MainForm : Form
    {
        private LearningSpeed LearningSpeed { get; set; }
        private CellField CellField { get; set; }
        private Tic_Tac_Toe Tic_Tac_Toe { get; set; }
        private int CellCount { get; set; } = 7;
        private QLearning QLearningOne { get; set; }
        private QLearning QLearningTwo { get; set; }
        private QHundler QHundler { get; set; }

        public MainForm()
        {
            InitializeComponent();

            LearningSpeed = new LearningSpeed(speed_3, speed_4, speed_2, speed_1, speed_0, speed_6, speed_5, speed_7);

            CellField = new CellField(LearningSpeed, PGamingField, PCells, CellCount, backgroundWorker);

            CellField.FillControls();
            SetInformation();
        }

        private void SpeedLabelClick(object sender, EventArgs e)
        {
            Label label = sender as Label;
            byte number = byte.Parse(label.Name[label.Name.Length - 1].ToString());
            number = (byte)(0b_0000_0001 << number);
            LearningSpeed.LabelClick(number);
        }

        private void StartPlay_Click(object sender, EventArgs e)
        {
            Player playerOne = new Player(0, "Pobedonosec");
            Player playerTwo = new Player(1, "Looser");

            Tic_Tac_Toe = new Tic_Tac_Toe(CellCount, playerOne, playerTwo);

            CellField.Game = Tic_Tac_Toe;

            Tic_Tac_Toe.StartGame();
            backgroundWorker.DoWork += ClickCellAsync;
        }

        private void StartLearning_Click(object sender, EventArgs e)
        {
            QLearningOne = new QLearning(0.7d, 0.3d, 49);
            QLearningTwo = new QLearning(0.3d, 0.7d, 49);
            QHundler = new QHundler();

            BotPlayer playerOne = new BotPlayer(0, "Pobedonosec", QHundler, QLearningOne);
            BotPlayer playerTwo = new BotPlayer(1, "Looser", QHundler, QLearningTwo);

            Tic_Tac_Toe = new Tic_Tac_Toe(CellCount, playerOne, playerTwo);

            QHundler.Game = Tic_Tac_Toe;
            QHundler.BotPlayers.Add(playerOne);
            QHundler.BotPlayers.Add(playerTwo);

            backgroundWorker.DoWork -= ClickCellAsync;
            backgroundWorker.DoWork += StartLearningAsync;
            backgroundWorker.RunWorkerAsync();
        }

        private void SetInformation()
        {
            information.SetToolTip(LCountCell, "Количество клеток в столбе И линии");
            information.SetToolTip(LCountFigure, "Количество фигур, которое необходимо собрать в ряд");
            information.SetToolTip(LLearningCoef, "Коэффициент обучения. Чем больше, тем агент доверчивее к новой информации");
            information.SetToolTip(LDiscountCoef, "Коэффициент дисконтирования. Чем меньше, тем меньше агент задумывается о выгоде от будущих своих действий");
            information.SetToolTip(LSpeed, "Скорость перехода от конца игры к новой партии (Байтовое значение * 10)");
            information.SetToolTip(BStartPlay, "Блокировка всех вводимых значений и начало обучения");
            information.SetToolTip(LYourCells, "Вознаграждение за кол-во собранных фигур в ряде");
            information.SetToolTip(LOpponentsCells, "Вознаграждение за перекрытие фигур оппоненты");
        }

        private void ClickCellAsync(object sender, DoWorkEventArgs e)
        {
            CellField.ChangeControls(e.Argument as FieldChanges);

            CellField.Game.CanMakeMove = true;
        }

        private void StartLearningAsync(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            worker.ReportProgress(1, new FieldChanges() { IsClearingField = true });

            QHundler.StartGame();

            while (true)
            {
                var fieldchanges = QHundler.DoTurn();

                CellField.ChangeControls(fieldchanges);
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            label15.Text = $"Played {e.ProgressPercentage} game.";
            CellField.UpdateControls(e.UserState as FieldChanges);
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}
