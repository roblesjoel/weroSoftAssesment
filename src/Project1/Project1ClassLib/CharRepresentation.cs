namespace Project1ClassLib
{
    // Static class so that the values do not default on wrong input
    public static class CharRepresentation
    {
        // Values & Defaults
        public static string windowName = "Assessment weroSoft von Joel Robles";
        private static string _color = "red";
        private static int _size = 42;
        private static int _weight = 100;

        // Properties
        public static string Color { 
            get { 

                return _color; 
            } 
            set {
                //Set value to lowercase
                string colorName = value.ToLower();

                // Check if the color is known by the system, if it is set it, if not do not set it
                var color = System.Drawing.Color.FromName(colorName);
                if(!(color.R == 0 && color.G == 0 && color.B == 0 && colorName != "black"))
                {
                    _color = colorName;
                }
            } 
        }

        public static int Size { 
            get { return _size; } 
            set { 
                // Input validation
                if(value >= 5 && value <= 100)
                {
                    _size = value;
                }
                
            } 
        }
        public static int Weight { 
            get { return _weight; } 
            set {
                // Input validation
                if (value >= 100 && value <= 900)
                {
                    _weight = value;
                }
            } 
        }
    }
}
