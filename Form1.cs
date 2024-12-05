using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backprop;

namespace BackpropagationNN_Tolentino
{
    public partial class ForAm1 : Form
    {
        NeuralNet nnet;
        int epochsMade = 0;
        int hiddenLayers = 0;
        public ForAm1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool CheckOptimization()
        {

            double[][] inputs = new double[][]
            {
        new double[] {0.0, 0.0, 0.0, 0.0},
        new double[] {0.0, 0.0, 0.0, 1.0},
        new double[] {0.0, 0.0, 1.0, 0.0},
        new double[] {0.0, 0.0, 1.0, 1.0},
        new double[] {0.0, 1.0, 0.0, 0.0},
        new double[] {0.0, 1.0, 0.0, 1.0},
        new double[] {0.0, 1.0, 1.0, 0.0},
        new double[] {0.0, 1.0, 1.0, 1.0},
        new double[] {1.0, 0.0, 0.0, 0.0},
        new double[] {1.0, 0.0, 0.0, 1.0},
        new double[] {1.0, 0.0, 1.0, 0.0},
        new double[] {1.0, 0.0, 1.0, 1.0},
        new double[] {1.0, 1.0, 0.0, 0.0},
        new double[] {1.0, 1.0, 0.0, 1.0},
        new double[] {1.0, 1.0, 1.0, 0.0},
        new double[] {1.0, 1.0, 1.0, 1.0}
            };

            double[] expectedOutputs = new double[]
            {
        0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0
            };

            for (int i = 0; i < inputs.Length; i++)
            {
                nnet.setInputs(0, inputs[i][0]);
                nnet.setInputs(1, inputs[i][1]);
                nnet.setInputs(2, inputs[i][2]);
                nnet.setInputs(3, inputs[i][3]);
                nnet.run();

                double output = Math.Round(nnet.getOuputData(0), MidpointRounding.AwayFromZero);
                if (output != expectedOutputs[i])
                {
                    return false;
                }
            }

            return true;
        }

        private void ForAm1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            epochsMade += Convert.ToInt32(textBox3.Text);
            textBox5.Text = epochsMade + "";
            for (int x = 0; x < Convert.ToInt32(textBox3.Text); x++)
            {
                // #1
                // 0 0 0 0 = 0
                nnet.setInputs(0, 0.0);
                nnet.setInputs(1, 0.0);
                nnet.setInputs(2, 0.0);
                nnet.setInputs(3, 0.0);
                nnet.setDesiredOutput(0, 0.0);
                nnet.learn();

                // #2
                // 0 0 0 1 = 0
                nnet.setInputs(0, 0.0);
                nnet.setInputs(1, 0.0);
                nnet.setInputs(2, 0.0);
                nnet.setInputs(3, 1.0);
                nnet.setDesiredOutput(0, 0.0);
                nnet.learn();

                // #3
                // 0 0 1 0 = 0
                nnet.setInputs(0, 0.0);
                nnet.setInputs(1, 0.0);
                nnet.setInputs(2, 1.0);
                nnet.setInputs(3, 0.0);
                nnet.setDesiredOutput(0, 0.0);
                nnet.learn();

                // #4
                // 0 0 1 1 = 0
                nnet.setInputs(0, 0.0);
                nnet.setInputs(1, 0.0);
                nnet.setInputs(2, 1.0);
                nnet.setInputs(3, 1.0);
                nnet.setDesiredOutput(0, 0.0);
                nnet.learn();

                // #5
                // 0 1 0 0 = 0
                nnet.setInputs(0, 0.0);
                nnet.setInputs(1, 1.0);
                nnet.setInputs(2, 0.0);
                nnet.setInputs(3, 0.0);
                nnet.setDesiredOutput(0, 0.0);
                nnet.learn();

                // #6
                // 0 1 0 1 = 0
                nnet.setInputs(0, 0.0);
                nnet.setInputs(1, 1.0);
                nnet.setInputs(2, 0.0);
                nnet.setInputs(3, 1.0);
                nnet.setDesiredOutput(0, 0.0);
                nnet.learn();

                // #7
                // 0 1 1 0 = 0
                nnet.setInputs(0, 0.0);
                nnet.setInputs(1, 1.0);
                nnet.setInputs(2, 1.0);
                nnet.setInputs(3, 0.0);
                nnet.setDesiredOutput(0, 0.0);
                nnet.learn();

                // #8
                // 0 1 1 1 = 0
                nnet.setInputs(0, 0.0);
                nnet.setInputs(1, 1.0);
                nnet.setInputs(2, 1.0);
                nnet.setInputs(3, 1.0);
                nnet.setDesiredOutput(0, 0.0);
                nnet.learn();

                // #9
                // 1 0 0 0 = 0
                nnet.setInputs(0, 1.0);
                nnet.setInputs(1, 0.0);
                nnet.setInputs(2, 0.0);
                nnet.setInputs(3, 0.0);
                nnet.setDesiredOutput(0, 0.0);
                nnet.learn();

                // #10
                // 1 0 0 1 = 0
                nnet.setInputs(0, 1.0);
                nnet.setInputs(1, 0.0);
                nnet.setInputs(2, 0.0);
                nnet.setInputs(3, 1.0);
                nnet.setDesiredOutput(0, 0.0);
                nnet.learn();

                // #11
                // 1 0 1 0 = 0
                nnet.setInputs(0, 1.0);
                nnet.setInputs(1, 0.0);
                nnet.setInputs(2, 1.0);
                nnet.setInputs(3, 0.0);
                nnet.setDesiredOutput(0, 0.0);
                nnet.learn();

                // #12
                // 1 0 1 1 = 0
                nnet.setInputs(0, 1.0);
                nnet.setInputs(1, 0.0);
                nnet.setInputs(2, 1.0);
                nnet.setInputs(3, 1.0);
                nnet.setDesiredOutput(0, 0.0);
                nnet.learn();

                // #13
                // 1 1 0 0 = 0
                nnet.setInputs(0, 1.0);
                nnet.setInputs(1, 1.0);
                nnet.setInputs(2, 0.0);
                nnet.setInputs(3, 0.0);
                nnet.setDesiredOutput(0, 0.0);
                nnet.learn();

                // #14
                // 1 1 0 1 = 0
                nnet.setInputs(0, 1.0);
                nnet.setInputs(1, 1.0);
                nnet.setInputs(2, 0.0);
                nnet.setInputs(3, 1.0);
                nnet.setDesiredOutput(0, 0.0);
                nnet.learn();

                // #15
                // 1 1 1 0 = 0
                nnet.setInputs(0, 1.0);
                nnet.setInputs(1, 1.0);
                nnet.setInputs(2, 1.0);
                nnet.setInputs(3, 0.0);
                nnet.setDesiredOutput(0, 0.0);
                nnet.learn();

                // #16
                // 1 1 1 1 = 1
                nnet.setInputs(0, 1.0);
                nnet.setInputs(1, 1.0);
                nnet.setInputs(2, 1.0);
                nnet.setInputs(3, 1.0);
                nnet.setDesiredOutput(0, 1.0);
                nnet.learn();

            }




        }

        private void button3_Click(object sender, EventArgs e)
        {
            int A = checkBox1.Checked ? 1 : 0;
            int B = checkBox2.Checked ? 1 : 0;
            int C = checkBox3.Checked ? 1 : 0;
            int D = checkBox4.Checked ? 1 : 0;

            nnet.setInputs(0, A);
            nnet.setInputs(1, B);
            nnet.setInputs(2, C);
            nnet.setInputs(3, D);
            nnet.run();




            String output = (Math.Round(nnet.getOuputData(0), MidpointRounding.AwayFromZero) == 1.0) ? "True" : "False";

            textBox4.Text = "" + output;
            textBox1.Text = "" + nnet.getOuputData(0);

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nnet = new NeuralNet(4, Convert.ToInt32(textBox2.Text), 1);
            hiddenLayers = Convert.ToInt32(textBox2.Text);
            textBox7.Text = "" + hiddenLayers;
            textBox6.Text = "True";
            epochsMade = 0;
            textBox5.Text = "" + epochsMade;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            textBox3.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ctr = 0;
            
            while (!CheckOptimization())
            {
                ctr++;
                // #1
                // 0 0 0 0 = 0
                nnet.setInputs(0, 0.0);
                nnet.setInputs(1, 0.0);
                nnet.setInputs(2, 0.0);
                nnet.setInputs(3, 0.0);
                nnet.setDesiredOutput(0, 0.0);
                nnet.learn();

                // #2
                // 0 0 0 1 = 0
                nnet.setInputs(0, 0.0);
                nnet.setInputs(1, 0.0);
                nnet.setInputs(2, 0.0);
                nnet.setInputs(3, 1.0);
                nnet.setDesiredOutput(0, 0.0);
                nnet.learn();

                // #3
                // 0 0 1 0 = 0
                nnet.setInputs(0, 0.0);
                nnet.setInputs(1, 0.0);
                nnet.setInputs(2, 1.0);
                nnet.setInputs(3, 0.0);
                nnet.setDesiredOutput(0, 0.0);
                nnet.learn();

                // #4
                // 0 0 1 1 = 0
                nnet.setInputs(0, 0.0);
                nnet.setInputs(1, 0.0);
                nnet.setInputs(2, 1.0);
                nnet.setInputs(3, 1.0);
                nnet.setDesiredOutput(0, 0.0);
                nnet.learn();

                // #5
                // 0 1 0 0 = 0
                nnet.setInputs(0, 0.0);
                nnet.setInputs(1, 1.0);
                nnet.setInputs(2, 0.0);
                nnet.setInputs(3, 0.0);
                nnet.setDesiredOutput(0, 0.0);
                nnet.learn();

                // #6
                // 0 1 0 1 = 0
                nnet.setInputs(0, 0.0);
                nnet.setInputs(1, 1.0);
                nnet.setInputs(2, 0.0);
                nnet.setInputs(3, 1.0);
                nnet.setDesiredOutput(0, 0.0);
                nnet.learn();

                // #7
                // 0 1 1 0 = 0
                nnet.setInputs(0, 0.0);
                nnet.setInputs(1, 1.0);
                nnet.setInputs(2, 1.0);
                nnet.setInputs(3, 0.0);
                nnet.setDesiredOutput(0, 0.0);
                nnet.learn();

                // #8
                // 0 1 1 1 = 0
                nnet.setInputs(0, 0.0);
                nnet.setInputs(1, 1.0);
                nnet.setInputs(2, 1.0);
                nnet.setInputs(3, 1.0);
                nnet.setDesiredOutput(0, 0.0);
                nnet.learn();

                // #9
                // 1 0 0 0 = 0
                nnet.setInputs(0, 1.0);
                nnet.setInputs(1, 0.0);
                nnet.setInputs(2, 0.0);
                nnet.setInputs(3, 0.0);
                nnet.setDesiredOutput(0, 0.0);
                nnet.learn();

                // #10
                // 1 0 0 1 = 0
                nnet.setInputs(0, 1.0);
                nnet.setInputs(1, 0.0);
                nnet.setInputs(2, 0.0);
                nnet.setInputs(3, 1.0);
                nnet.setDesiredOutput(0, 0.0);
                nnet.learn();

                // #11
                // 1 0 1 0 = 0
                nnet.setInputs(0, 1.0);
                nnet.setInputs(1, 0.0);
                nnet.setInputs(2, 1.0);
                nnet.setInputs(3, 0.0);
                nnet.setDesiredOutput(0, 0.0);
                nnet.learn();

                // #12
                // 1 0 1 1 = 0
                nnet.setInputs(0, 1.0);
                nnet.setInputs(1, 0.0);
                nnet.setInputs(2, 1.0);
                nnet.setInputs(3, 1.0);
                nnet.setDesiredOutput(0, 0.0);
                nnet.learn();

                // #13
                // 1 1 0 0 = 0
                nnet.setInputs(0, 1.0);
                nnet.setInputs(1, 1.0);
                nnet.setInputs(2, 0.0);
                nnet.setInputs(3, 0.0);
                nnet.setDesiredOutput(0, 0.0);
                nnet.learn();

                // #14
                // 1 1 0 1 = 0
                nnet.setInputs(0, 1.0);
                nnet.setInputs(1, 1.0);
                nnet.setInputs(2, 0.0);
                nnet.setInputs(3, 1.0);
                nnet.setDesiredOutput(0, 0.0);
                nnet.learn();

                // #15
                // 1 1 1 0 = 0
                nnet.setInputs(0, 1.0);
                nnet.setInputs(1, 1.0);
                nnet.setInputs(2, 1.0);
                nnet.setInputs(3, 0.0);
                nnet.setDesiredOutput(0, 0.0);
                nnet.learn();

                // #16
                // 1 1 1 1 = 1
                nnet.setInputs(0, 1.0);
                nnet.setInputs(1, 1.0);
                nnet.setInputs(2, 1.0);
                nnet.setInputs(3, 1.0);
                nnet.setDesiredOutput(0, 1.0);
                nnet.learn();
            }

            epochsMade += ctr;
            textBox5.Text = epochsMade + "";


            MessageBox.Show($"Minimum of epochs are {ctr} for a model with hidden layer of {hiddenLayers}!");
        }
    }
}
