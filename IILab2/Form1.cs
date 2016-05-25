using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IILab2 {
    public partial class Form1: Form {
        private MNIST _mnist;
        private NeuralNetwork _network;
        private MImage tempImage;
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;
            _mnist = new MNIST();
            _mnist.LoadImages(@"t10k-images.idx3-ubyte");
            _mnist.LoadLabels(@"t10k-labels.idx1-ubyte");
            numberImage.Maximum = _mnist.Images.Count - 1;
            _network = new NeuralNetwork();
            tempImage = _mnist.Images[0];
            symbolBox.Image = MakeBitmap(tempImage, 10);

            _network.Load();
        }

        public static Bitmap MakeBitmap(MImage dImages, int mag) {
            int width = 28 * mag;
            int height = 28 * mag;
            Bitmap result = new Bitmap(width, height);
            Graphics gr = Graphics.FromImage(result);
            for (int i = 0; i < 28; ++i) {
                for (int j = 0; j < 28; ++j) {
                    int pixelColor = 255 - dImages.pixels[i][j];
                    Color c = Color.FromArgb(pixelColor, pixelColor, pixelColor);
                    SolidBrush sb = new SolidBrush(c);
                    gr.FillRectangle(sb, j * mag, i * mag, mag, mag);
                }
            }
            return result;
        }

        private void memoryButton_Click(object sender, EventArgs e) {
            _network.Load();
        }

        private void loadButton_Click(object sender, EventArgs e) {
            if (comboBox1.Text == "MNIST") {
                tempImage = _mnist.Images[(int)numberImage.Value];
                numberImage.Value++;
            } else if (comboBox1.Text == "File") {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    Bitmap te = new Bitmap(openFileDialog1.FileName);
                    convertImage(new Bitmap(te));
                    te.Dispose();
                }
            }

            symbolBox.Image = MakeBitmap(tempImage, 10);
        }
        private void convertImage(Bitmap img) {
            tempImage = new MImage();
            tempImage.pixels = new List<List<int>>();
            for (int i = 0; i < img.Height; i++) {
                tempImage.pixels.Add(new List<int>());
                for (int j = 0; j < img.Width; j++) {
                    tempImage.pixels[i].Add(255 - img.GetPixel(j, i).R);
                }
            }
        }

        private void learnButton_Click(object sender, EventArgs e) {
            if (clearMemoryCheckbox.Checked)
                _network.New();
            MNIST learns = new MNIST();
            learns.LoadImages(@"t10k-images.idx3-ubyte");
            learns.LoadLabels(@"t10k-labels.idx1-ubyte");
            progressLearn.Maximum = learns.Images.Count - 1;
            for (int i = 0; i < learns.Images.Count; i++) {
                _network.Learn(learns.Images[i].pixels, learns.Labels[i]);
                progressLearn.Value = i;
                Application.DoEvents();
            }
            _network.Save();
            progressLearn.Value = 0;
        }

        private void analyseButton_Click(object sender, EventArgs e) {
            int falseAnswer, trueAnswer;
            falseAnswer = 0;
            trueAnswer = 0;
            progressLearn.Maximum = _mnist.Images.Count;
            for (int i = 0; i < _mnist.Images.Count; i++) {
                if (_network.Analyse(_mnist.Images[i].pixels) == _mnist.Labels[i])
                    ++trueAnswer;
                else ++falseAnswer;
                progressLearn.Value = i;
                Application.DoEvents();
            }
            string s = "Верных ответов: " + trueAnswer.ToString() + "\n"
                      + "Неверных ответов: " + falseAnswer.ToString() + "\n"
                      + "Процент: " + ((double)trueAnswer / (double)_mnist.Images.Count) * 100 + "%";
            MessageBox.Show(s, "Ответ", MessageBoxButtons.OK, MessageBoxIcon.None);
            progressLearn.Value = 0;

        }

        private void button1_Click(object sender, EventArgs e) {
            MessageBox.Show(_network.Analyse(tempImage.pixels).ToString(), "Ответ", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBox1.Text == "File")
                numberImage.Enabled = false;
            else numberImage.Enabled = true;
        }
    }
}
