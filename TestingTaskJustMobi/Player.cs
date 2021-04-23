using System;
using System.Collections.Generic;
using System.Text;

namespace TestingTaskJustMobi
{
    class Player : Character
    {
        private Converter _converter;
        private bool _isOnLocation;

        public delegate void DiscoveringVariantsActions();
        public event DiscoveringVariantsActions AskVariants;

        public delegate void InspectionSurroundings();
        public event InspectionSurroundings LookAround;

        public delegate void WalkingToSwangman();
        public event WalkingToSwangman GoToCharacter;

        public delegate void ExitLocation();
        public event ExitLocation DecideToLeave;

        public Player(string name) : base(name)
        {
            _converter = new Converter();
            _isOnLocation = true;
        }

        public void Play()
        {
            while (_isOnLocation)
            {
                AskVariants?.Invoke();

                int userChoice = _converter.ConvertNumber();

                switch (userChoice)
                {
                    case 1:
                        GoToCharacter?.Invoke();
                        break;
                    case 2:
                        LookAround?.Invoke();
                        break;
                    case 3:
                        DecideToLeave?.Invoke();
                        _isOnLocation = false;
                        break;
                    default:
                        Console.WriteLine("Выберите из предложенных вариантов.");
                        break;
                }

                WaitNextStep();
            }
        }

        private void WaitNextStep()
        {
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
