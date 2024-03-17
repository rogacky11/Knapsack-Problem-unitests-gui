using Knapsack_Problem;
using System;

namespace KnapsackGUI
{
    public partial class Form1 : Form
    {

        //int n = 0;
        //int seed = 0;
        // int capasity = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void n_textBox_TextChanged(object sender, EventArgs e)
        {


            // if (n < 0) { n_textBox.BackColor = Color.Red; }



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void run_button_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(n_textBox.Text);
            int seed = Convert.ToInt32(seed_textBox.Text);
            int capasity = Convert.ToInt32(capasity_textBox.Text);

            if (n < 0) { n_textBox.BackColor = Color.Red; }
            if (capasity < 0) { capasity_textBox.BackColor = Color.Red; }
            Problem problem = new Problem(n, seed);
            Result result = problem.Solve(capasity);
            listBox2.Items.Add($"Items: {string.Join(", ", result.items)}");
            //listBox2.Items.Add(Environment.NewLine);
            listBox2.Items.Add($"Total value: {result.TotalValue}");
            listBox2.Items.Add($"Total weight: {result.TotalWeight}");

            //listBox1.Items.Add(problem.ToString());
            //listBox1.Items.Add(Environment.NewLine);

            foreach(var item in problem.GetStrings()) { listBox1.Items.Add(item); }
            
        }

        private void capasity_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
