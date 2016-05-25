using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace IILab2 {
    public struct MImage {
        public List<List<int>> pixels;
    }
    class MNIST {
        
        private BinaryReader _brLabels;
        private BinaryReader _brImages; 
        private List<MImage> _images;
        private List<byte> _labels;
        
        public List<MImage> Images { get { return _images; } }
        public List<byte> Labels { get { return _labels; } }

        public MNIST() {
            _images = new List<MImage>();
            _labels = new List<byte>();
        }


        /// <summary>
        /// Загружает MNIST файл картинок
        /// </summary>
        /// <returns></returns>
        public void LoadImages(string path) {
            FileStream stream = new FileStream(path, FileMode.Open);
            _brImages = new BinaryReader(stream);
            int magic = _brImages.ReadInt32();
            magic = ReverseBytes(magic); // преобразуем в формат Intel
            int imageCount = _brImages.ReadInt32();
            imageCount = ReverseBytes(imageCount);
            int numRows = _brImages.ReadInt32();
            numRows = ReverseBytes(numRows);
            int numCols = _brImages.ReadInt32();
            numCols = ReverseBytes(numCols);
            for (int k = 0; k < imageCount; k++) {
                MImage temp = new MImage();
                temp.pixels = new List<List<int>>();
                for (int i = 0; i < 28; i++) {
                    temp.pixels.Add(new List<int>());
                    for (int j = 0; j < 28; j++) {
                        temp.pixels[i].Add(_brImages.ReadByte());
                    }
                }
                _images.Add(temp);
            }
            stream.Close(); _brImages.Close();
        }

        public void LoadLabels(string path) {
            FileStream stream = new FileStream(path, FileMode.Open);
            _brLabels = new BinaryReader(stream);
            int magic = _brLabels.ReadInt32();
            magic = ReverseBytes(magic);
            int numLabels = _brLabels.ReadInt32();
            numLabels = ReverseBytes(numLabels);
            for (int i = 0; i < numLabels; i++) {
                _labels.Add(_brLabels.ReadByte());
            }
            stream.Close(); _brLabels.Close();
        }

        public static int ReverseBytes(int v) {
            byte[] intAsBytes = BitConverter.GetBytes(v);
            Array.Reverse(intAsBytes);
            return BitConverter.ToInt32(intAsBytes, 0);
        }
    }
}
