namespace FarbmisherLib
{
    public static class ColorMixer
    {
        // Defaults
        public static string windowName = "Assessment weroSoft von Joel Robles";
        private static int _red = -1;
        private static int _green = -1;
        private static int _blue = -1;
        private static bool _startup = true;

        // Properties
        public static int Red { 
            get { return _red; } 
            set 
            { 
                if(value >= 0 &&  value <= 255 && _red != -1)
                {
                    _red = value;
                }
                else if(_red == -1)
                {
                    _red = 200;
                }
            }
        } 
        public static int Green { 
            get { return _green; } 
            set 
            {
                if (value >= 0 && value <= 255 && _green != -1)
                {
                    _green = value;
                }
                else if (_green == -1)
                {
                    _green = 20;
                }
            }
        }
        public static int Blue { 
            get { return _blue; } 
            set
            {
                if (value >= 0 && value <= 255 && _blue != -1)
                {
                    _blue = value;
                }
                else if (_blue == -1)
                {
                    _blue = 2;
                }
            }
        }

        public static bool Startup
        {
            get { return _startup; }
        }

        public static void unSetStartup()
        {
            _startup = false;
        }
    }
}
