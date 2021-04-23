using System;
using System.Collections.Generic;
using System.Text;

namespace TestingTaskJustMobi
{
    abstract class Location
    {
        protected string Name;
        protected string InformationAboutLocation;
        protected Player Player;
        protected string[] VariantsAction;

        public Location(string name)
        {
            Name = name;
            Player = new Player("Player");
            Player.AskVariants += ShowVariantsAction;
            Player.LookAround += ShowInformationAboutLocation;
            Player.DecideToLeave += LeftLoaction;
        }

        public void StartActLocation()
        {
            Player.Play();
        }

        protected void ShowInformationAboutLocation()
        {
            Console.WriteLine(InformationAboutLocation);
        }

        protected void ShowVariantsAction()
        {
            Console.WriteLine($"Вы находитесь на локации \"{Name}\".\nВозможные действия:");

            for (int i = 0; i < VariantsAction.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {VariantsAction[i]}");
            }
        }

        protected void LeftLoaction()
        {
            Console.WriteLine($"Вы покидаете локацию \"{Name}\"");
        }
    }
}
