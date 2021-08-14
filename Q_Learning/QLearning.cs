using System;
using System.Collections.Generic;
using T_T_T.GameManager;
using T_T_T.Q_Learning.Utilities;

namespace T_T_T.Q_Learning
{
    public class QLearning
    {
        public double LearningRate { get; set; }
        public double DiscountFactor { get; set; }
        private int CountActions { get; set; }
        private QTable QTable { get; set; }

        public QLearning(double learningRate, double discountFactor, int countActions)
        {
            this.LearningRate = learningRate;
            this.DiscountFactor = discountFactor;
            this.CountActions = countActions;
            this.QTable = new QTable(CountActions);
        }

        public int MoveHundler(GameField gameField, QRewards rewards)
        {
            string QKey = QTable.GetTableKey(gameField);
            QActions actionsTable = QTable.GetActions(QKey);

            UpdateQTableActions(actionsTable, rewards);

            return SearchMax(QKey);
        }

        private void UpdateQTableActions(QActions actions, QRewards rewards)
        {
            for (int i = 0; i < CountActions; i++)
            {
                double oldValue = actions.Actions[i];
                double newValue = oldValue + LearningRate * (GetReward(rewards, i) + DiscountFactor * GetRewardInFuture(rewards, i) - oldValue);
                actions.Actions[i] = newValue;
            }
        }

        private double GetReward(QRewards rewards, int cellNumber)
        {
            return rewards.CalculateReward(cellNumber);
        }

        private double GetRewardInFuture(QRewards rewards, int cellNumber)
        {
            return rewards.CalculateFutureReward(cellNumber);
        }

        private int SearchMax(string key)
        {
            Random random = new Random();
            double max = -100000;
            List<int> maxed = new List<int>();
            List<double> actions = QTable.GetActions(key).Actions;

            for (int i = 0; i < actions.Count; i++)
            {
                if (actions[i] > max)
                {
                    max = actions[i];
                    maxed = new List<int> { i };
                }
                else if (actions[i] == max)
                    maxed.Add(i);
            }

            return maxed[random.Next(0, maxed.Count - 1)];
        }
    }
}
