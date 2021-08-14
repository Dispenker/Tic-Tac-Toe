using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using T_T_T.Q_Learning.Utilities;

namespace T_T_T.Q_Learning
{
    public class QRewards
    {
        public double LastReward { get; set; } = 0d;
        private BotPlayer BotPlayer { get; set; }
        public QRewards(BotPlayer botPlayer)
        {
            this.BotPlayer = botPlayer;
        }

        public double CalculateReward(int cellNumber)
        {
            BotPlayer.GetCells(cellNumber, out int countYourCells, out int[] countOppCells);
            return RewardCalculation(countYourCells, countOppCells);
        }

        public double CalculateFutureReward(int cellNumber)
        {
            var countCells = BotPlayer.GetFutureCells(cellNumber);
            return -YourRewardPoints[countCells];
        }

        private double RewardCalculation(int countYourCells, int[] countOppCells)
        {
            double reward = YourRewardPoints[countYourCells];
            foreach (var oppCells in countOppCells)
            {
                reward += YourRewardPoints[-oppCells];
            }

            return reward;
        }

        private Dictionary<int, double> YourRewardPoints = new Dictionary<int, double> 
        {
            {-7, -6.035d }, {-6, 5.3d }, {-5, 5.3d }, {-4, 5.3d }, {-3, 4.8d }, {-2, 2.36d }, {-1, 1.907d }, {0, -0.4000065d },
            {1, 2.153d }, {2, 2.756d}, {3, 5.424d }, {4, 6.254d }, {5, 8.623d }, {6, 8.623d }, {7, 8.623d }
        };
    }

    public delegate double RewardFunction();
}
