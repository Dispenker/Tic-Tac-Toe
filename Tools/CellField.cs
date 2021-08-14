using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using T_T_T.GameManager;
using T_T_T.GameManager.PlayerManager;

namespace T_T_T.Tools
{
    public class CellField
    {
        private BackgroundWorker BackgroundWorker { get; set; }
        public LearningSpeed LearningSpeed { get; set; }
        public GameClass Game { get; set; } = null;
        private Panel GamingPanel { get; set; }
        private Panel CellsPanel { get; set; }
        public int CellCount { get; set; }
        public List<Control> Controls { get; set; }
        public int ControlSize { get => CellsPanel.Width / CellCount; }
        public string FontStyle { get; set; } = "Microsoft Sans Serif";
        public int FontSize { get; set; } = 15;

        public CellField(LearningSpeed learningSpeed, Panel gamingPanel, Panel cellsPanel, int cellCount, BackgroundWorker backgroundWorker) 
        {
            this.LearningSpeed = learningSpeed;
            this.GamingPanel = gamingPanel;
            this.CellsPanel = cellsPanel;
            this.CellCount = cellCount;
            this.Controls = new List<Control>(CellCount * CellCount);
            this.BackgroundWorker = backgroundWorker;
        }

        public void FillControls()
        {
            for (int i = 0; i < CellCount * CellCount; i++)
            {
                Label label = new Label
                {
                    Name = "cell_" + i,
                    BackColor = Color.White,
                    Location = GetLocation(i),
                    MinimumSize = GetControlSize(),
                    MaximumSize = GetControlSize(),
                    BorderStyle = BorderStyle.FixedSingle,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = GetFont()
                };
                int k = i;
                label.Click += new EventHandler((s, e) => CellClick(s, e, k));
                Controls.Add(label);
            }

            CellsPanel.Controls.AddRange(Controls.ToArray());
            ChangePanelLocation();
        }

        private Point GetLocation(int i)
        {
            return new Point(-1 + (i % CellCount) * (ControlSize - 1), -1 + (i / CellCount) * (ControlSize - 1));
        }

        private Size GetControlSize()
        {
            return new Size(ControlSize, ControlSize);
        }

        private Font GetFont()
        {
            return new Font(FontStyle, FontSize);
        }

        private void ChangePanelLocation()
        {
            CellsPanel.Size = new Size((ControlSize - 1) * CellCount + 1, (ControlSize - 1) * CellCount + 1);
            CellsPanel.Location = new Point((GamingPanel.Width - CellsPanel.Width) / 2 - 1, CellsPanel.Location.Y);
        }

        public void ChangeControls(FieldChanges fieldChanges)
        {
            fieldChanges.LearningSpeed = LearningSpeed;

            if (fieldChanges.Cell != -1)
            {
                Thread.Sleep(fieldChanges.CellSleep);

                BackgroundWorker.ReportProgress(1, new FieldChanges() { Cell = fieldChanges.Cell, Symbol = fieldChanges.Symbol });
            }

            if (fieldChanges.IsPaintingField)
            {
                Thread.Sleep(fieldChanges.PaintSleep);

                BackgroundWorker.ReportProgress(1, new FieldChanges() { IsPaintingField = true, ChangesCell = fieldChanges.ChangesCell, Symbol = fieldChanges.Symbol });
            }

            if (fieldChanges.IsClearingField)
            {
                Thread.Sleep(fieldChanges.ClearSleep);

                BackgroundWorker.ReportProgress(1, new FieldChanges() { IsClearingField = true });
            }
        }

        public void UpdateControls(FieldChanges fieldChanges)
        {
            if (fieldChanges.Cell != -1)
            {
                ChangeControl(fieldChanges);
            }

            if (fieldChanges.IsPaintingField)
            {
                PaintControls(fieldChanges);
            }

            if (fieldChanges.IsClearingField)
            {
                ClearControls();
            }
        }

        private void ChangeControl(FieldChanges changes)
        {
            Controls[changes.Cell].Text = PlayerTextSymbols[changes.Symbol];
        }

        private void PaintControls(FieldChanges changes)
        {
            foreach (var cell in changes.ChangesCell)
            {
                Controls[cell].BackColor = PlayerColorSymbols[changes.Symbol];
            }
        }

        private void ClearControls()
        {
            foreach (var control in Controls)
            {
                control.Text = PlayerTextSymbols[PlayerSymbol.Zero];
                control.BackColor = PlayerColorSymbols[PlayerSymbol.Zero];
            }
        }

        private void CellClick(object sender, EventArgs e, int cellNumber)
        {
            if (Game == null)
                return;

            if (!Game.CanMakeMove)
                return;

            FieldChanges changes = Game.ClickHundler(cellNumber);

            Game.CanMakeMove = false;

            BackgroundWorker.RunWorkerAsync(changes);
        }

        private Dictionary<PlayerSymbol, string> PlayerTextSymbols = new Dictionary<PlayerSymbol, string>
        {
            { PlayerSymbol.Krestik, "X" },
            { PlayerSymbol.Nolik, "0" },
            { PlayerSymbol.Plus, "+" },
            { PlayerSymbol.Minus, "-" },
            { PlayerSymbol.Zero, " " }
        };

        private Dictionary<PlayerSymbol, Color> PlayerColorSymbols = new Dictionary<PlayerSymbol, Color>
        {
            { PlayerSymbol.Krestik, Color.LightGreen },
            { PlayerSymbol.Nolik, Color.LightCoral },
            { PlayerSymbol.Plus, Color.LightBlue },
            { PlayerSymbol.Minus, Color.LightSalmon },
            { PlayerSymbol.Zero, Color.White }
        };
    }
}
