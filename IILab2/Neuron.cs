using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IILab2 {
    class Neuron {
        private const int RNDValue = 5;
        private List<List<int>> _memory;

        public List<List<int>> Memory { get { return _memory; }}

        public Neuron(List<List<int>> memory) {
            _memory = memory;
        }
        public Neuron(int width, int height) {
            _memory = new List<List<int>>();
            for (int i = 0; i < width; ++i) {
                _memory.Add(new List<int>());
                for (int k = 0; k < height; k++) {
                    _memory[i].Add(RND.getInt(RNDValue));
                }
            }
        }

        public void Learn(List<List<int>> input, bool result) {
            int temp;
            if (result)
                temp = -1;
            else temp = 1;
            for (int i = 0; i < input.Count; i++) {
                for (int j = 0; j < input[i].Count; j++) {
                    _memory[i][j] += temp * input[i][j];
                }
            }
        }
        public int GetResult(List<List<int>> input) {
            int result = 0; ;
            for (int i = 0; i < input.Count; ++i) {
                for (int j = 0; j < input[i].Count; j++) {
                    result += input[i][j] * _memory[i][j];
                }
            }
            return result;
        }
    }
}
