namespace Eyes
{
    public partial class EyesForm : Form
    {
        int xAxisSize = 0;
        int yAxisSize = 0;

        int xAxisPos = 0;
        int yAxisPos = 0;

        int xMargin = 0;
        int yMargin = 0;

        public EyesForm()
        {
            InitializeComponent();
        }

        private void EyesForm_Resize(object sender, EventArgs e)
        {
            getSize();
            placeContainer();
        }

        private void EyesForm_Load(object sender, EventArgs e)
        {
            getSize();
            placeContainer();
        }

        private void EyesForm_MouseMove(object sender, MouseEventArgs e)
        {
            xAxisPos = e.X;
            yAxisPos = e.Y;

            int[] quadrant = getQuadrant();

            setEyesImage(quadrant[0], quadrant[1]);
        }

        public void placeContainer()
        {
            xMargin = (xAxisSize - eyesImage.Width) / 2;
            yMargin = (yAxisSize - eyesImage.Height) / 2;

            eyesImage.Location = new Point(xMargin, yMargin);
        }

        public void getSize()
        {
            xAxisSize = this.Width;
            yAxisSize = this.Height;
        }

        public int[] getQuadrant()
        {
            int[] quadrantCoordinates = new int[2];
            int i, j = 0;

            if (xAxisPos <= xMargin)
            {
                i = 0;
            }
            else if (xAxisPos > xMargin && xAxisPos <= xAxisSize - xMargin)
            {
                i = 1;
            }
            else
            {
                i = 2;
            }

            quadrantCoordinates[0] = i;

            if (yAxisPos <= yMargin)
            {
                j = 0;
            }
            else if (yAxisPos > yMargin && yAxisPos <= yAxisSize - yMargin)
            {
                j = 1;
            }
            else
            {
                j = 2;
            }

            quadrantCoordinates[1] = j;

            return quadrantCoordinates;
        }

        public void setEyesImage(int quadrantX, int quadrantY)
        {
            switch (quadrantX)
            {
                case 0:
                    switch (quadrantY)
                    {
                        case 0:
                            eyesImage.Image = Properties.Resources.eyes_TopLeft;
                            break;
                        case 1:
                            eyesImage.Image = Properties.Resources.eyes_Left;
                            break;
                        case 2:
                            eyesImage.Image = Properties.Resources.eyes_BottomLeft;
                            break;
                    }
                    break;
                case 1:
                    switch (quadrantY)
                    {
                        case 0:
                            eyesImage.Image = Properties.Resources.eyes_Top;
                            break;
                        case 1:
                            eyesImage.Image = Properties.Resources.eyes_Center;
                            break;
                        case 2:
                            eyesImage.Image = Properties.Resources.eyes_Bottom;
                            break;
                    }
                    break;
                case 2:
                    switch (quadrantY)
                    {
                        case 0:
                            eyesImage.Image = Properties.Resources.eyes_TopRight;
                            break;
                        case 1:
                            eyesImage.Image = Properties.Resources.eyes_Right;
                            break;
                        case 2:
                            eyesImage.Image = Properties.Resources.eyes_BottomRight;
                            break;
                    }
                    break;
            }
        }

        private void eyesImage_MouseMove(object sender, MouseEventArgs e)
        {
            eyesImage.Image = Properties.Resources.eyes_Squint;
        }
    }
}
