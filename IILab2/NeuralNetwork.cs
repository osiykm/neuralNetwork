using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IILab2 {
    class NeuralNetwork {
        private List<Neuron> neurons;

        public NeuralNetwork() {
            neurons = new List<Neuron>();
        }

        public void New() {
            for (int i = 0; i < 10; i++) 
                neurons.Add(new Neuron(28, 28));
        }
        public void Load() {
            FileStream stream;
            BinaryReader reader;
            List<List<int>> temp;
            for (int n = 0; n < 10; ++n) {
                stream = new FileStream(n.ToString(), FileMode.Open);
                reader = new BinaryReader(stream);
                temp = new List<List<int>>();
                for (int i = 0; i < 28; i++) {
                    temp.Add(new List<int>());
                    for (int j = 0; j < 28; j++) {
                        temp[i].Add(reader.ReadInt32());
                    }
                }

                neurons.Add(new Neuron(temp));
                reader.Close();
                stream.Close();
            }
        }

        public byte Analyse(List<List<int>> input) {
            List<int> result = new List<int>();
            for(int i = 0; i < neurons.Count; ++i) {
                result.Add(neurons[i].GetResult(input));
            }

            return (byte)result.IndexOf(result.Max()); ;
        }

        public void Learn(List<List<int>> input, byte label) {
            byte temp = Analyse(input);
            if (label != temp) {
                neurons[label].Learn(input, false);
                neurons[temp].Learn(input, true);
            }
        }

        public void Save() {
            FileStream stream;
            BinaryWriter writer;
            for (int n = 0; n < neurons.Count; ++n) {
                stream = new FileStream(n.ToString(), FileMode.Create);
                writer = new BinaryWriter(stream);
                for (int i = 0; i < neurons[n].Memory.Count; i++) {
                    for (int j = 0; j < neurons[n].Memory[i].Count; j++) {
                        writer.Write((Int32)neurons[n].Memory[i][j]);
                    }
                }
                writer.Close();
                stream.Close();
            }
        }
    }
}
