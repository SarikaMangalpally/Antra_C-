namespace Assignment3;

    public class Ball
    {
        private int size;
        private Color color;
        private int throwCount;

        public Ball(int size, Color color)
        {
            this.Size = size;
            this.color = color;
            this.throwCount = 0;
        }

        public int Size
        {
            get { return size; }
            set
            {
                if (value >= 0)
                    size = value;
                else
                    throw new ArgumentException("Size must be non-negative");
            }
        }

        public Color BallColor
        {
            get { return color; }
            set { color = value; }
        }

        public void Pop()
        {
            Size = 0;
        }

        public void Throw()
        {
            if (Size > 0)
                throwCount++;
        }

        public int GetThrowCount()
        {
            return throwCount;
        }
    }