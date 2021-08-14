namespace T_T_T
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.PSettings = new System.Windows.Forms.Panel();
            this.BStartLearning = new System.Windows.Forms.Button();
            this.BStartPlay = new System.Windows.Forms.Button();
            this.LCoefficients = new System.Windows.Forms.Label();
            this.PCoefficients = new System.Windows.Forms.Panel();
            this.LLearningCoef = new System.Windows.Forms.Label();
            this.TBLearningCoef = new System.Windows.Forms.TextBox();
            this.TBDiscountCoef = new System.Windows.Forms.TextBox();
            this.LDiscountCoef = new System.Windows.Forms.Label();
            this.LRewards = new System.Windows.Forms.Label();
            this.PRewards = new System.Windows.Forms.Panel();
            this.LYourCells = new System.Windows.Forms.Label();
            this.LOpponentsCells = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LUOne = new System.Windows.Forms.Label();
            this.LFieldSettings = new System.Windows.Forms.Label();
            this.PFieldSettings = new System.Windows.Forms.Panel();
            this.LCountCell = new System.Windows.Forms.Label();
            this.TBCountFigure = new System.Windows.Forms.TextBox();
            this.TBCountCell = new System.Windows.Forms.TextBox();
            this.LCountFigure = new System.Windows.Forms.Label();
            this.speed_0 = new System.Windows.Forms.Label();
            this.LSpeed = new System.Windows.Forms.Label();
            this.speed_4 = new System.Windows.Forms.Label();
            this.speed_6 = new System.Windows.Forms.Label();
            this.speed_1 = new System.Windows.Forms.Label();
            this.speed_7 = new System.Windows.Forms.Label();
            this.speed_5 = new System.Windows.Forms.Label();
            this.speedNull = new System.Windows.Forms.Label();
            this.speed_3 = new System.Windows.Forms.Label();
            this.speedX = new System.Windows.Forms.Label();
            this.speed_2 = new System.Windows.Forms.Label();
            this.LSettings = new System.Windows.Forms.Label();
            this.PGamingField = new System.Windows.Forms.Panel();
            this.LLog = new System.Windows.Forms.Label();
            this.PLog = new System.Windows.Forms.Panel();
            this.LogCountFigure = new System.Windows.Forms.Label();
            this.LogBW = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PCells = new System.Windows.Forms.Panel();
            this.LGamingField = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.information = new System.Windows.Forms.ToolTip(this.components);
            this.PSettings.SuspendLayout();
            this.PCoefficients.SuspendLayout();
            this.PRewards.SuspendLayout();
            this.PFieldSettings.SuspendLayout();
            this.PGamingField.SuspendLayout();
            this.PLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // PSettings
            // 
            this.PSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PSettings.Controls.Add(this.BStartLearning);
            this.PSettings.Controls.Add(this.BStartPlay);
            this.PSettings.Controls.Add(this.LCoefficients);
            this.PSettings.Controls.Add(this.PCoefficients);
            this.PSettings.Controls.Add(this.LRewards);
            this.PSettings.Controls.Add(this.PRewards);
            this.PSettings.Controls.Add(this.LFieldSettings);
            this.PSettings.Controls.Add(this.PFieldSettings);
            this.PSettings.Controls.Add(this.LSettings);
            this.PSettings.Location = new System.Drawing.Point(4, 5);
            this.PSettings.Margin = new System.Windows.Forms.Padding(2);
            this.PSettings.Name = "PSettings";
            this.PSettings.Size = new System.Drawing.Size(198, 326);
            this.PSettings.TabIndex = 0;
            // 
            // BStartLearning
            // 
            this.BStartLearning.Location = new System.Drawing.Point(126, 298);
            this.BStartLearning.Margin = new System.Windows.Forms.Padding(2);
            this.BStartLearning.Name = "BStartLearning";
            this.BStartLearning.Size = new System.Drawing.Size(68, 24);
            this.BStartLearning.TabIndex = 27;
            this.BStartLearning.Text = "Start learn";
            this.BStartLearning.UseVisualStyleBackColor = true;
            this.BStartLearning.Click += new System.EventHandler(this.StartLearning_Click);
            // 
            // BStartPlay
            // 
            this.BStartPlay.Location = new System.Drawing.Point(2, 298);
            this.BStartPlay.Margin = new System.Windows.Forms.Padding(2);
            this.BStartPlay.Name = "BStartPlay";
            this.BStartPlay.Size = new System.Drawing.Size(68, 24);
            this.BStartPlay.TabIndex = 26;
            this.BStartPlay.Text = "Start play";
            this.BStartPlay.UseVisualStyleBackColor = true;
            this.BStartPlay.Click += new System.EventHandler(this.StartPlay_Click);
            // 
            // LCoefficients
            // 
            this.LCoefficients.AutoSize = true;
            this.LCoefficients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LCoefficients.Location = new System.Drawing.Point(9, 109);
            this.LCoefficients.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LCoefficients.Name = "LCoefficients";
            this.LCoefficients.Size = new System.Drawing.Size(109, 15);
            this.LCoefficients.TabIndex = 25;
            this.LCoefficients.Text = "КОЭФФИЦИЕНТЫ";
            // 
            // PCoefficients
            // 
            this.PCoefficients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PCoefficients.Controls.Add(this.LLearningCoef);
            this.PCoefficients.Controls.Add(this.TBLearningCoef);
            this.PCoefficients.Controls.Add(this.TBDiscountCoef);
            this.PCoefficients.Controls.Add(this.LDiscountCoef);
            this.PCoefficients.Location = new System.Drawing.Point(2, 121);
            this.PCoefficients.Margin = new System.Windows.Forms.Padding(2);
            this.PCoefficients.Name = "PCoefficients";
            this.PCoefficients.Size = new System.Drawing.Size(192, 51);
            this.PCoefficients.TabIndex = 24;
            // 
            // LLearningCoef
            // 
            this.LLearningCoef.AutoSize = true;
            this.LLearningCoef.Location = new System.Drawing.Point(2, 5);
            this.LLearningCoef.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LLearningCoef.Name = "LLearningCoef";
            this.LLearningCoef.Size = new System.Drawing.Size(129, 13);
            this.LLearningCoef.TabIndex = 1;
            this.LLearningCoef.Text = "Коэффициент обучения:";
            // 
            // TBLearningCoef
            // 
            this.TBLearningCoef.Location = new System.Drawing.Point(137, 2);
            this.TBLearningCoef.Margin = new System.Windows.Forms.Padding(2);
            this.TBLearningCoef.Name = "TBLearningCoef";
            this.TBLearningCoef.Size = new System.Drawing.Size(51, 20);
            this.TBLearningCoef.TabIndex = 2;
            // 
            // TBDiscountCoef
            // 
            this.TBDiscountCoef.Location = new System.Drawing.Point(137, 27);
            this.TBDiscountCoef.Margin = new System.Windows.Forms.Padding(2);
            this.TBDiscountCoef.Name = "TBDiscountCoef";
            this.TBDiscountCoef.Size = new System.Drawing.Size(51, 20);
            this.TBDiscountCoef.TabIndex = 4;
            // 
            // LDiscountCoef
            // 
            this.LDiscountCoef.AutoSize = true;
            this.LDiscountCoef.Location = new System.Drawing.Point(2, 29);
            this.LDiscountCoef.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LDiscountCoef.Name = "LDiscountCoef";
            this.LDiscountCoef.Size = new System.Drawing.Size(132, 13);
            this.LDiscountCoef.TabIndex = 3;
            this.LDiscountCoef.Text = "Коэф. дисконтирования:";
            // 
            // LRewards
            // 
            this.LRewards.AutoSize = true;
            this.LRewards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LRewards.Location = new System.Drawing.Point(9, 175);
            this.LRewards.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LRewards.Name = "LRewards";
            this.LRewards.Size = new System.Drawing.Size(117, 15);
            this.LRewards.TabIndex = 23;
            this.LRewards.Text = "ВОЗНАГРАЖДЕНИЯ";
            // 
            // PRewards
            // 
            this.PRewards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PRewards.Controls.Add(this.LYourCells);
            this.PRewards.Controls.Add(this.LOpponentsCells);
            this.PRewards.Controls.Add(this.textBox6);
            this.PRewards.Controls.Add(this.textBox7);
            this.PRewards.Controls.Add(this.textBox8);
            this.PRewards.Controls.Add(this.textBox9);
            this.PRewards.Controls.Add(this.textBox10);
            this.PRewards.Controls.Add(this.label5);
            this.PRewards.Controls.Add(this.label6);
            this.PRewards.Controls.Add(this.label7);
            this.PRewards.Controls.Add(this.label8);
            this.PRewards.Controls.Add(this.label9);
            this.PRewards.Controls.Add(this.textBox5);
            this.PRewards.Controls.Add(this.textBox4);
            this.PRewards.Controls.Add(this.textBox3);
            this.PRewards.Controls.Add(this.textBox2);
            this.PRewards.Controls.Add(this.textBox1);
            this.PRewards.Controls.Add(this.label4);
            this.PRewards.Controls.Add(this.label3);
            this.PRewards.Controls.Add(this.label2);
            this.PRewards.Controls.Add(this.label1);
            this.PRewards.Controls.Add(this.LUOne);
            this.PRewards.Location = new System.Drawing.Point(2, 187);
            this.PRewards.Margin = new System.Windows.Forms.Padding(2);
            this.PRewards.Name = "PRewards";
            this.PRewards.Size = new System.Drawing.Size(192, 107);
            this.PRewards.TabIndex = 22;
            // 
            // LYourCells
            // 
            this.LYourCells.AutoSize = true;
            this.LYourCells.Location = new System.Drawing.Point(66, 3);
            this.LYourCells.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LYourCells.Name = "LYourCells";
            this.LYourCells.Size = new System.Drawing.Size(56, 13);
            this.LYourCells.TabIndex = 20;
            this.LYourCells.Text = "Your cells:";
            // 
            // LOpponentsCells
            // 
            this.LOpponentsCells.AutoSize = true;
            this.LOpponentsCells.Location = new System.Drawing.Point(50, 53);
            this.LOpponentsCells.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LOpponentsCells.Name = "LOpponentsCells";
            this.LOpponentsCells.Size = new System.Drawing.Size(88, 13);
            this.LOpponentsCells.TabIndex = 21;
            this.LOpponentsCells.Text = "Opponent\'s cells:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(2, 84);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(33, 20);
            this.textBox6.TabIndex = 19;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(40, 84);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(33, 20);
            this.textBox7.TabIndex = 18;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(79, 84);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(33, 20);
            this.textBox8.TabIndex = 17;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(117, 84);
            this.textBox9.Margin = new System.Windows.Forms.Padding(2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(33, 20);
            this.textBox9.TabIndex = 16;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(155, 84);
            this.textBox10.Margin = new System.Windows.Forms.Padding(2);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(33, 20);
            this.textBox10.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Lose";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 69);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 69);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 69);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "1";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(2, 32);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(33, 20);
            this.textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(40, 32);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(33, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(79, 32);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(33, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 32);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(33, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(33, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Win";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "2";
            // 
            // LUOne
            // 
            this.LUOne.AutoSize = true;
            this.LUOne.Location = new System.Drawing.Point(12, 18);
            this.LUOne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LUOne.Name = "LUOne";
            this.LUOne.Size = new System.Drawing.Size(13, 13);
            this.LUOne.TabIndex = 0;
            this.LUOne.Text = "1";
            // 
            // LFieldSettings
            // 
            this.LFieldSettings.AutoSize = true;
            this.LFieldSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LFieldSettings.Location = new System.Drawing.Point(9, 20);
            this.LFieldSettings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LFieldSettings.Name = "LFieldSettings";
            this.LFieldSettings.Size = new System.Drawing.Size(40, 15);
            this.LFieldSettings.TabIndex = 21;
            this.LFieldSettings.Text = "ПОЛЕ";
            // 
            // PFieldSettings
            // 
            this.PFieldSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PFieldSettings.Controls.Add(this.LCountCell);
            this.PFieldSettings.Controls.Add(this.TBCountFigure);
            this.PFieldSettings.Controls.Add(this.TBCountCell);
            this.PFieldSettings.Controls.Add(this.LCountFigure);
            this.PFieldSettings.Controls.Add(this.speed_0);
            this.PFieldSettings.Controls.Add(this.LSpeed);
            this.PFieldSettings.Controls.Add(this.speed_4);
            this.PFieldSettings.Controls.Add(this.speed_6);
            this.PFieldSettings.Controls.Add(this.speed_1);
            this.PFieldSettings.Controls.Add(this.speed_7);
            this.PFieldSettings.Controls.Add(this.speed_5);
            this.PFieldSettings.Controls.Add(this.speedNull);
            this.PFieldSettings.Controls.Add(this.speed_3);
            this.PFieldSettings.Controls.Add(this.speedX);
            this.PFieldSettings.Controls.Add(this.speed_2);
            this.PFieldSettings.Location = new System.Drawing.Point(2, 32);
            this.PFieldSettings.Margin = new System.Windows.Forms.Padding(2);
            this.PFieldSettings.Name = "PFieldSettings";
            this.PFieldSettings.Size = new System.Drawing.Size(192, 74);
            this.PFieldSettings.TabIndex = 20;
            // 
            // LCountCell
            // 
            this.LCountCell.AutoSize = true;
            this.LCountCell.Location = new System.Drawing.Point(18, 5);
            this.LCountCell.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LCountCell.Name = "LCountCell";
            this.LCountCell.Size = new System.Drawing.Size(107, 13);
            this.LCountCell.TabIndex = 16;
            this.LCountCell.Text = "Количество клеток:";
            // 
            // TBCountFigure
            // 
            this.TBCountFigure.Location = new System.Drawing.Point(148, 28);
            this.TBCountFigure.Margin = new System.Windows.Forms.Padding(2);
            this.TBCountFigure.Name = "TBCountFigure";
            this.TBCountFigure.Size = new System.Drawing.Size(40, 20);
            this.TBCountFigure.TabIndex = 19;
            this.TBCountFigure.Text = "5";
            this.TBCountFigure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBCountCell
            // 
            this.TBCountCell.Location = new System.Drawing.Point(148, 2);
            this.TBCountCell.Margin = new System.Windows.Forms.Padding(2);
            this.TBCountCell.Name = "TBCountCell";
            this.TBCountCell.ReadOnly = true;
            this.TBCountCell.Size = new System.Drawing.Size(40, 20);
            this.TBCountCell.TabIndex = 17;
            this.TBCountCell.Text = "7";
            this.TBCountCell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LCountFigure
            // 
            this.LCountFigure.AutoSize = true;
            this.LCountFigure.Location = new System.Drawing.Point(1, 30);
            this.LCountFigure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LCountFigure.Name = "LCountFigure";
            this.LCountFigure.Size = new System.Drawing.Size(148, 13);
            this.LCountFigure.TabIndex = 18;
            this.LCountFigure.Text = "Необходимое кол-во фигур:";
            // 
            // speed_0
            // 
            this.speed_0.AutoSize = true;
            this.speed_0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.speed_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.speed_0.Location = new System.Drawing.Point(173, 55);
            this.speed_0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speed_0.Name = "speed_0";
            this.speed_0.Size = new System.Drawing.Size(15, 15);
            this.speed_0.TabIndex = 15;
            this.speed_0.Text = "1";
            this.speed_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.speed_0.Click += new System.EventHandler(this.SpeedLabelClick);
            // 
            // LSpeed
            // 
            this.LSpeed.AutoSize = true;
            this.LSpeed.Location = new System.Drawing.Point(1, 55);
            this.LSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LSpeed.Name = "LSpeed";
            this.LSpeed.Size = new System.Drawing.Size(58, 13);
            this.LSpeed.TabIndex = 5;
            this.LSpeed.Text = "Скорость:";
            // 
            // speed_4
            // 
            this.speed_4.AutoSize = true;
            this.speed_4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.speed_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.speed_4.Location = new System.Drawing.Point(122, 55);
            this.speed_4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speed_4.Name = "speed_4";
            this.speed_4.Size = new System.Drawing.Size(15, 15);
            this.speed_4.TabIndex = 11;
            this.speed_4.Text = "1";
            this.speed_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.speed_4.Click += new System.EventHandler(this.SpeedLabelClick);
            // 
            // speed_6
            // 
            this.speed_6.AutoSize = true;
            this.speed_6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.speed_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.speed_6.Location = new System.Drawing.Point(97, 55);
            this.speed_6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speed_6.Name = "speed_6";
            this.speed_6.Size = new System.Drawing.Size(15, 15);
            this.speed_6.TabIndex = 9;
            this.speed_6.Text = "1";
            this.speed_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.speed_6.Click += new System.EventHandler(this.SpeedLabelClick);
            // 
            // speed_1
            // 
            this.speed_1.AutoSize = true;
            this.speed_1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.speed_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.speed_1.Location = new System.Drawing.Point(160, 55);
            this.speed_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speed_1.Name = "speed_1";
            this.speed_1.Size = new System.Drawing.Size(15, 15);
            this.speed_1.TabIndex = 14;
            this.speed_1.Text = "1";
            this.speed_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.speed_1.Click += new System.EventHandler(this.SpeedLabelClick);
            // 
            // speed_7
            // 
            this.speed_7.AutoSize = true;
            this.speed_7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.speed_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.speed_7.Location = new System.Drawing.Point(84, 55);
            this.speed_7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speed_7.Name = "speed_7";
            this.speed_7.Size = new System.Drawing.Size(15, 15);
            this.speed_7.TabIndex = 8;
            this.speed_7.Text = "1";
            this.speed_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.speed_7.Click += new System.EventHandler(this.SpeedLabelClick);
            // 
            // speed_5
            // 
            this.speed_5.AutoSize = true;
            this.speed_5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.speed_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.speed_5.Location = new System.Drawing.Point(110, 55);
            this.speed_5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speed_5.Name = "speed_5";
            this.speed_5.Size = new System.Drawing.Size(15, 15);
            this.speed_5.TabIndex = 10;
            this.speed_5.Text = "1";
            this.speed_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.speed_5.Click += new System.EventHandler(this.SpeedLabelClick);
            // 
            // speedNull
            // 
            this.speedNull.AutoSize = true;
            this.speedNull.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.speedNull.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.speedNull.Location = new System.Drawing.Point(60, 55);
            this.speedNull.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speedNull.Name = "speedNull";
            this.speedNull.Size = new System.Drawing.Size(15, 15);
            this.speedNull.TabIndex = 6;
            this.speedNull.Text = "0";
            this.speedNull.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speed_3
            // 
            this.speed_3.AutoSize = true;
            this.speed_3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.speed_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.speed_3.Location = new System.Drawing.Point(135, 55);
            this.speed_3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speed_3.Name = "speed_3";
            this.speed_3.Size = new System.Drawing.Size(15, 15);
            this.speed_3.TabIndex = 12;
            this.speed_3.Text = "1";
            this.speed_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.speed_3.Click += new System.EventHandler(this.SpeedLabelClick);
            // 
            // speedX
            // 
            this.speedX.AutoSize = true;
            this.speedX.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.speedX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.speedX.Location = new System.Drawing.Point(73, 55);
            this.speedX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speedX.Name = "speedX";
            this.speedX.Size = new System.Drawing.Size(14, 15);
            this.speedX.TabIndex = 7;
            this.speedX.Text = "x";
            this.speedX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speed_2
            // 
            this.speed_2.AutoSize = true;
            this.speed_2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.speed_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.speed_2.Location = new System.Drawing.Point(148, 55);
            this.speed_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speed_2.Name = "speed_2";
            this.speed_2.Size = new System.Drawing.Size(15, 15);
            this.speed_2.TabIndex = 13;
            this.speed_2.Text = "1";
            this.speed_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.speed_2.Click += new System.EventHandler(this.SpeedLabelClick);
            // 
            // LSettings
            // 
            this.LSettings.AutoSize = true;
            this.LSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LSettings.Location = new System.Drawing.Point(62, 6);
            this.LSettings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LSettings.Name = "LSettings";
            this.LSettings.Size = new System.Drawing.Size(76, 15);
            this.LSettings.TabIndex = 0;
            this.LSettings.Text = "НАСТРОЙКИ";
            // 
            // PGamingField
            // 
            this.PGamingField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PGamingField.Controls.Add(this.LLog);
            this.PGamingField.Controls.Add(this.PLog);
            this.PGamingField.Controls.Add(this.label17);
            this.PGamingField.Controls.Add(this.label16);
            this.PGamingField.Controls.Add(this.label15);
            this.PGamingField.Controls.Add(this.label12);
            this.PGamingField.Controls.Add(this.label11);
            this.PGamingField.Controls.Add(this.label10);
            this.PGamingField.Controls.Add(this.PCells);
            this.PGamingField.Controls.Add(this.LGamingField);
            this.PGamingField.Location = new System.Drawing.Point(204, 5);
            this.PGamingField.Margin = new System.Windows.Forms.Padding(2);
            this.PGamingField.Name = "PGamingField";
            this.PGamingField.Size = new System.Drawing.Size(392, 326);
            this.PGamingField.TabIndex = 1;
            // 
            // LLog
            // 
            this.LLog.AutoSize = true;
            this.LLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LLog.Location = new System.Drawing.Point(9, 244);
            this.LLog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LLog.Name = "LLog";
            this.LLog.Size = new System.Drawing.Size(31, 15);
            this.LLog.TabIndex = 11;
            this.LLog.Text = "LOG";
            // 
            // PLog
            // 
            this.PLog.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PLog.Controls.Add(this.LogCountFigure);
            this.PLog.Controls.Add(this.LogBW);
            this.PLog.Location = new System.Drawing.Point(2, 256);
            this.PLog.Margin = new System.Windows.Forms.Padding(2);
            this.PLog.Name = "PLog";
            this.PLog.Size = new System.Drawing.Size(389, 66);
            this.PLog.TabIndex = 10;
            // 
            // LogCountFigure
            // 
            this.LogCountFigure.AutoSize = true;
            this.LogCountFigure.Location = new System.Drawing.Point(2, 4);
            this.LogCountFigure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LogCountFigure.Name = "LogCountFigure";
            this.LogCountFigure.Size = new System.Drawing.Size(10, 13);
            this.LogCountFigure.TabIndex = 3;
            this.LogCountFigure.Text = "-";
            // 
            // LogBW
            // 
            this.LogBW.AutoSize = true;
            this.LogBW.Location = new System.Drawing.Point(2, 23);
            this.LogBW.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LogBW.MaximumSize = new System.Drawing.Size(380, 41);
            this.LogBW.Name = "LogBW";
            this.LogBW.Size = new System.Drawing.Size(10, 13);
            this.LogBW.TabIndex = 2;
            this.LogBW.Text = "-";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 142);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "CountWin";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 116);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "WinRate";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 89);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "GamePlayed";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 63);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Win";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(329, 32);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Name 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 31);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Name 1";
            // 
            // PCells
            // 
            this.PCells.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PCells.Location = new System.Drawing.Point(94, 28);
            this.PCells.Margin = new System.Windows.Forms.Padding(0);
            this.PCells.Name = "PCells";
            this.PCells.Size = new System.Drawing.Size(204, 204);
            this.PCells.TabIndex = 1;
            // 
            // LGamingField
            // 
            this.LGamingField.AutoSize = true;
            this.LGamingField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LGamingField.Location = new System.Drawing.Point(149, 6);
            this.LGamingField.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LGamingField.Name = "LGamingField";
            this.LGamingField.Size = new System.Drawing.Size(94, 15);
            this.LGamingField.TabIndex = 0;
            this.LGamingField.Text = "ИГРОВОЕ ПОЛЕ";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 336);
            this.Controls.Add(this.PGamingField);
            this.Controls.Add(this.PSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "T-T-T";
            this.PSettings.ResumeLayout(false);
            this.PSettings.PerformLayout();
            this.PCoefficients.ResumeLayout(false);
            this.PCoefficients.PerformLayout();
            this.PRewards.ResumeLayout(false);
            this.PRewards.PerformLayout();
            this.PFieldSettings.ResumeLayout(false);
            this.PFieldSettings.PerformLayout();
            this.PGamingField.ResumeLayout(false);
            this.PGamingField.PerformLayout();
            this.PLog.ResumeLayout(false);
            this.PLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PSettings;
        private System.Windows.Forms.Label LSettings;
        private System.Windows.Forms.Panel PGamingField;
        private System.Windows.Forms.Label speed_0;
        private System.Windows.Forms.Label speed_1;
        private System.Windows.Forms.Label speed_2;
        private System.Windows.Forms.Label speed_3;
        private System.Windows.Forms.Label speed_4;
        private System.Windows.Forms.Label speed_5;
        private System.Windows.Forms.Label speed_6;
        private System.Windows.Forms.Label speed_7;
        private System.Windows.Forms.Label speedX;
        private System.Windows.Forms.Label speedNull;
        private System.Windows.Forms.Label LSpeed;
        private System.Windows.Forms.TextBox TBDiscountCoef;
        private System.Windows.Forms.Label LDiscountCoef;
        private System.Windows.Forms.TextBox TBLearningCoef;
        private System.Windows.Forms.Label LLearningCoef;
        private System.Windows.Forms.Label LGamingField;
        private System.Windows.Forms.Panel PCells;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label LogBW;
        private System.Windows.Forms.Label LogCountFigure;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TBCountFigure;
        private System.Windows.Forms.Label LCountFigure;
        private System.Windows.Forms.TextBox TBCountCell;
        private System.Windows.Forms.Label LCountCell;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel PLog;
        private System.Windows.Forms.Label LFieldSettings;
        private System.Windows.Forms.Panel PFieldSettings;
        private System.Windows.Forms.ToolTip information;
        private System.Windows.Forms.Button BStartPlay;
        private System.Windows.Forms.Label LCoefficients;
        private System.Windows.Forms.Panel PCoefficients;
        private System.Windows.Forms.Label LRewards;
        private System.Windows.Forms.Panel PRewards;
        private System.Windows.Forms.Label LLog;
        private System.Windows.Forms.Label LYourCells;
        private System.Windows.Forms.Label LOpponentsCells;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LUOne;
        private System.Windows.Forms.Button BStartLearning;
    }
}

