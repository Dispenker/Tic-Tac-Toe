using System.Collections.Generic;
using System.Windows.Forms;

namespace T_T_T.Tools
{
    public class LearningSpeed
    {
        public byte ActualSpeed { get; set; } = 0b_1110_0000;
        private List<Label> Labels { get; set; } = new List<Label>(8);
        public LearningSpeed(params Label[] label)
        {
            Labels.AddRange(label);
            Labels.Sort(new LabelComparer());
            RenameLabels();
        }

        private void RenameLabels()
        {
            const byte firstBit = 0b_0000_0001;
            byte speed = ActualSpeed;
            foreach (var label in Labels)
            {
                label.Text = (firstBit & speed).ToString();
                speed >>= 1;
            }
        }

        public void LabelClick(byte number)
        {
            byte newSpeed = (byte)(ActualSpeed ^ number);
            ActualSpeed = newSpeed;
            RenameLabels();
        }
    }
}