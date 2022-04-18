using System;
using System.ComponentModel;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace KarliCards.Gui
{
    [Serializable]
    public class GameOptions
    {
        //public bool PlayAgainstComputer { get; set; }
        //public int NumberOfPlayers { get; set; }
        //public int MinutesBeforeLoss { get; set; }
        //public ComputerSkillLevel ComputerSkill { get; set; }

        private bool playAgainstComputer = true;
        private int numberOfPlayers = 2;
        private ComputerSkillLevel computerSkill = ComputerSkillLevel.Dumb;

        public int NumberOfPlayers
        {
            get { return numberOfPlayers; }
            set
            {
                numberOfPlayers = value;
                OnPropertyChanged(nameof(NumberOfPlayers));
            }
        }
        public bool PlayAgainstComputer
        {
            get { return playAgainstComputer; }
            set
            {
                playAgainstComputer = value;
                OnPropertyChanged(nameof(PlayAgainstComputer));
            }
        }
        public ComputerSkillLevel ComputerSkill
        {
            get { return computerSkill; }
            set
            {
                computerSkill = value;
                OnPropertyChanged(nameof (ComputerSkill));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    [Serializable]
    public enum ComputerSkillLevel
    {
        Dumb,
        Good,
        Cheats
    }
}
