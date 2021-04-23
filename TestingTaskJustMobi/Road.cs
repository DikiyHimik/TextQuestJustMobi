using System;
using System.Collections.Generic;
using System.Text;

namespace TestingTaskJustMobi
{
    class Road : Location
    {
        private Swagman _swagman;

        public Road(string name) : base(name)
        {
            InformationAboutLocation = "Вы полной грудью вдыхаете свежий лесной воздух, вдалеке замечая огромный и красивый замок. \nВаши уши наполняют трели птиц. Одним словом... Умиротворение.";
            VariantsAction = new string[] { "Подойти к бродяге.", "Осмотреть окрестности.", "Покинуть локацию." };
            
            _swagman = new Swagman("Доррегарай");
            Player.GoToCharacter += TalkWithCharacter;
        }

        private void TalkWithCharacter()
        {
            if (_swagman.TryTalk())
            {
                Exchanger exchanger = new Exchanger();
                exchanger.TransferItem(_swagman, Player);
            }
        }
    }
}
