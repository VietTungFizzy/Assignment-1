using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
namespace Assignment_1_1
{
    enum RequestType
    {
        start_level,
        game_over,
        time_tick,
        next_level,
        get_wrong_answer,
        change_language
    }
    enum Language
    {
        Vietnamese,
        English
    }

    class Engine
    {
        private byte score;
        private byte errorCount;
        private byte level;
        private Color wrongColor;
        private Color rightColor;
        private sbyte timeSecond; //-127 -> 127
        private byte highScore;
        private Language language;
        private Random r;
        private float correctionFactor;
        public void RequestHandler(RequestType requestType)
        {
            switch(requestType)
            {
                case RequestType.time_tick:
                    time_tick();
                    break;
                case RequestType.game_over:
                    game_over();
                    break;
                case RequestType.next_level:
                    setup_next_level();
                    break;
                case RequestType.get_wrong_answer:
                    penalize_for_wrong_answer();
                    break;
                case RequestType.change_language:
                    change_language();
                    break;
            }
        }

        

        public Package send_result()
        {
            Package package = new Package();
            package.packedScore = score;
            package.errorCount = errorCount;
            package.timeLeft = timeSecond;
            package.language = language;
            package.level = level;
            package.highScore = highScore;
            package.wrongColor = wrongColor;
            package.rightColor = rightColor;
            return package;
        }
        public Engine()
        {
            score = 0;
            errorCount = 0;
            level = 2;
            wrongColor = Color.Aquamarine;
            rightColor = change_Color_Brightness(0.6f,wrongColor);
            timeSecond = 15;
            correctionFactor = 0.6f;
            r = new Random();
            language = Language.Vietnamese;
            highScore = 0;
        }
        private void time_tick()
        {
            timeSecond--;
        }

        private void game_over()
        {
            if (highScore < score)
                highScore = score;
            Game_over_form game_Over_Form = new Game_over_form(send_result());
            game_Over_Form.ShowDialog();
        }
        private void setup_next_level()
        {
            score++;
            if (score > 0) level = 3;
            if (score > 3) level = 4;
            if (score > 7) level = 5;
            if (score > 11) level = 6;
            if (score > 20) level = 7;
            if (score > 35) level = 8;
            if (score > 39) level = 9;
            if (score > 43) level = 10;
            if (score > 47) level = 11;
            if (score > 50)   level = 12;
            wrongColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            timeSecond = 15;
            switch(score)
            {
                case 1:
                    correctionFactor = 0.6f;
                    break;
                case 2:
                    correctionFactor = 0.55f;
                    break;
                case 3:
                    correctionFactor = 0.45f;
                    break;
                case 4:
                    correctionFactor = 0.35f;
                    break;
                case 5:
                    correctionFactor = 0.3f;
                    break;
                case 6:
                    correctionFactor = 0.25f;
                    break;
                case 7:
                    correctionFactor = 0.2f;
                    break;
                case 8:
                    correctionFactor = 0.18f;
                    break;
                case 9:
                    correctionFactor = 0.15f;
                    break;
            }
            if (score > 9) correctionFactor = 0.13f;
            if (score > 12) correctionFactor = 0.1f;
            if (score > 16) correctionFactor = 0.09f;
            if (score > 20) correctionFactor = 0.07f;
            if (score > 24) correctionFactor = 0.05f;
            if (score > 27) correctionFactor = 0.03f;
            if (score > 29) correctionFactor = 0.02f;
            if (score > 31) correctionFactor = 0.01f;
            rightColor = change_Color_Brightness(correctionFactor, wrongColor);
        }
        private void penalize_for_wrong_answer()
        {
            errorCount++;
            timeSecond -= 3;
        }
        private Color change_Color_Brightness(float factor, Color baseColor)
        {
            float red = (float)baseColor.R;
            float green = (float)baseColor.G;
            float blue = (float)baseColor.B;
            if (factor >= -1 || factor <= 1)
            {
                if (factor < 0)
                {
                    factor += 1;
                    red *= factor;
                    blue *= factor;
                    green *= factor;
                }
                else
                {
                    red = (255 - red) * factor + red;
                    blue = (255 - blue) * factor + blue;
                    green = (255 - green) * factor + green;
                }
            }
            return Color.FromArgb((int)red, (int)green, (int)blue);
        }
        private void change_language()
        {
            LanguageMenu menu = new LanguageMenu();
            menu.ShowDialog();
            language = menu.send_back_answer();
        }
    }
}
