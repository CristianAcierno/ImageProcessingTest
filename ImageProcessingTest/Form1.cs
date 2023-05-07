namespace ImageProcessingTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static void SeparateRGB(string imagePath, PictureBox[] pictureBoxes)
        {
            // Load the image from the file
            Bitmap inputImage = new Bitmap(imagePath);

            // Create new Bitmaps for the red, green, and blue channels
            Bitmap redImage = new Bitmap(inputImage.Width, inputImage.Height);
            Bitmap greenImage = new Bitmap(inputImage.Width, inputImage.Height);
            Bitmap blueImage = new Bitmap(inputImage.Width, inputImage.Height);

            // Iterate over each pixel in the input image and assign its red, green, and blue components to the corresponding channel Bitmap
            for (int y = 0; y < inputImage.Height; y++)
            {
                for (int x = 0; x < inputImage.Width; x++)
                {
                    Color pixelColor = inputImage.GetPixel(x, y);
                    redImage.SetPixel(x, y, Color.FromArgb(pixelColor.R, 0, 0));
                    greenImage.SetPixel(x, y, Color.FromArgb(0, pixelColor.G, 0));
                    blueImage.SetPixel(x, y, Color.FromArgb(0, 0, pixelColor.B));
                }
            }

            // Display the red, green, and blue channel Bitmaps in the corresponding picture boxes
            pictureBoxes[0].Image = redImage;
            pictureBoxes[1].Image = greenImage;
            pictureBoxes[2].Image = blueImage;
        }


        private void btnProcess_Click(object sender, EventArgs e)
        {
            PictureBox[] pictureBoxes = { pbxRed, pbxGreen, pbxBlue };
            string imagePath = tbxPicture.Text;

            SeparateRGB(imagePath, pictureBoxes);
            pbxBordes.Image = ApplySobelEdgeDetection((Bitmap)pbxMain.Image, 10);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
               // dlg.Filter = "bmp files (*.bmp)|*.bmp";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property
                    pbxMain.Image = new Bitmap(dlg.FileName);
                    // Save address of the Picture
                    tbxPicture.Text = dlg.FileName;
                }
            }
        }
        public static Bitmap ApplySobelEdgeDetection(Bitmap inputImage, int threshold)
        {
            Bitmap outputImage = new Bitmap(inputImage.Width, inputImage.Height);

            int[,] gx = new int[3, 3] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
            int[,] gy = new int[3, 3] { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };

            for (int x = 1; x < inputImage.Width - 1; x++)
            {
                for (int y = 1; y < inputImage.Height - 1; y++)
                {
                    int pixelX = 0, pixelY = 0;
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            pixelX += gx[i + 1, j + 1] * inputImage.GetPixel(x + i, y + j).R;
                            pixelY += gy[i + 1, j + 1] * inputImage.GetPixel(x + i, y + j).R;
                        }
                    }

                    int magnitude = (int)Math.Sqrt(pixelX * pixelX + pixelY * pixelY);
                    if (magnitude > threshold)
                    {
                        outputImage.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        outputImage.SetPixel(x, y, Color.Black);
                    }
                }
            }

            return outputImage;
        }
    }
}