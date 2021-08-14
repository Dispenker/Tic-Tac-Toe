using System;
using System.Collections.Generic;
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
        public LearningSpeed LearningSpeed { get; set; }
        public GameClass Game { get; set; } = null;
        private Panel GamingPanel { get; set; }
        private Panel CellsPanel { get; set; }
        public int CellCount { get; set; }
        public List<Control> Controls { get; set; }
        public int ControlSize { get => CellsPanel.Width / CellCount; }
        public string FontStyle { get; set; } = "Microsoft Sans Serif";
        public int FontSize { get; set; } = 15;
        public CellField(LearningSpeed learningSpeed, Panel gamingPanel, Panel cellsPanel, int cellCount) 
        {
            this.LearningSpeed = learningSpeed;
            this.GamingPanel = gamingPanel;
            this.CellsPanel = cellsPanel;
            this.CellCount = cellCount;
            this.Controls = new List<Control>(CellCount * CellCount);
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
                ChangeControl(fieldChanges);
            }

            if (fieldChanges.IsPaintingField)
            {
                PaintControls(fieldChanges);
            }

            if (fieldChanges.IsClearingField)
            {
                ClearControls(fieldChanges);
            }
        }

        private void ChangeControl(FieldChanges changes)
        {
            Controls[changes.Cell].Text = PlayerTextSymbols[changes.Symbol];
            //UpdateControls(changes.Cell);

            //Thread.Sleep(changes.CellSleep);
        }

        private void PaintControls(FieldChanges changes)
        {
            //Thread.Sleep(changes.PaintSleep);

            foreach (var cell in changes.ChangesCell)
            {
                Controls[cell].BackColor = PlayerColorSymbols[changes.Symbol];
            }
            //UpdateControls(changes.ChangesCell.ToArray());
        }

        private void ClearControls(FieldChanges changes)
        {
            //Thread.Sleep(changes.ClearSleep);

            foreach (var control in Controls)
            {
                control.Text = PlayerTextSymbols[PlayerSymbol.Zero];
                control.BackColor = PlayerColorSymbols[PlayerSymbol.Zero];
            }
            //UpdateControls(Enumerable.Range(0, CellCount * CellCount).ToArray());
        }

        public void UpdateControls(params int[] controls)
        {
            foreach (var control in controls)
            {
                Controls[control].Update();
            }
        }

        private void CellClick(object sender, EventArgs e, int cellNumber)
        {
            if (Game == null)
                return;

            FieldChanges changes = Game.ClickHundler(cellNumber);
            ChangeControls(changes);

            Game.CanMakeMove = true;
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
