namespace Assignment3;

public class Color
{
        private int red;
        private int green;
        private int blue;
        private int alpha;

        public Color(int red, int green, int blue, int alpha = 255)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
            this.Alpha = alpha;
        }

        public int Red
        {
            get { return red; }
            set
            {
                if (value >= 0 && value <= 255)
                    red = value;
                else
                    throw new ArgumentException("Value must be between 0 and 255");
            }
        }

        public int Green
        {
            get { return green; }
            set
            {
                if (value >= 0 && value <= 255)
                    green = value;
                else
                    throw new ArgumentException("Value must be between 0 and 255");
            }
        }

        public int Blue
        {
            get { return blue; }
            set
            {
                if (value >= 0 && value <= 255)
                    blue = value;
                else
                    throw new ArgumentException("Value must be between 0 and 255");
            }
        }

        public int Alpha
        {
            get { return alpha; }
            set
            {
                if (value >= 0 && value <= 255)
                    alpha = value;
                else
                    throw new ArgumentException("Value must be between 0 and 255");
            }
        }

        public double GetGrayscale()
        {
            return (Red + Green + Blue) / 3.0;
        }
    }