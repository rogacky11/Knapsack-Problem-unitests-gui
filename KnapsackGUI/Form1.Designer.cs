namespace KnapsackGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            n_textBox = new TextBox();
            seed_textBox = new TextBox();
            capasity_textBox = new TextBox();
            n_label = new Label();
            seed_label = new Label();
            capasity_label = new Label();
            run_button = new Button();
            label1 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // n_textBox
            // 
            n_textBox.Location = new Point(49, 50);
            n_textBox.Name = "n_textBox";
            n_textBox.Size = new Size(100, 23);
            n_textBox.TabIndex = 0;
            n_textBox.TextChanged += n_textBox_TextChanged;
            // 
            // seed_textBox
            // 
            seed_textBox.Location = new Point(49, 110);
            seed_textBox.Name = "seed_textBox";
            seed_textBox.Size = new Size(100, 23);
            seed_textBox.TabIndex = 1;
            // 
            // capasity_textBox
            // 
            capasity_textBox.Location = new Point(49, 167);
            capasity_textBox.Name = "capasity_textBox";
            capasity_textBox.Size = new Size(100, 23);
            capasity_textBox.TabIndex = 2;
            capasity_textBox.TextChanged += capasity_textBox_TextChanged;
            // 
            // n_label
            // 
            n_label.AutoSize = true;
            n_label.Location = new Point(49, 32);
            n_label.Name = "n_label";
            n_label.Size = new Size(95, 15);
            n_label.TabIndex = 3;
            n_label.Text = "number of items";
            // 
            // seed_label
            // 
            seed_label.AutoSize = true;
            seed_label.Location = new Point(49, 92);
            seed_label.Name = "seed_label";
            seed_label.Size = new Size(31, 15);
            seed_label.TabIndex = 4;
            seed_label.Text = "seed";
            // 
            // capasity_label
            // 
            capasity_label.AutoSize = true;
            capasity_label.Location = new Point(49, 149);
            capasity_label.Name = "capasity_label";
            capasity_label.Size = new Size(50, 15);
            capasity_label.TabIndex = 5;
            capasity_label.Text = "capasity";
            // 
            // run_button
            // 
            run_button.Location = new Point(235, 110);
            run_button.Name = "run_button";
            run_button.Size = new Size(100, 23);
            run_button.TabIndex = 6;
            run_button.Text = "run";
            run_button.UseVisualStyleBackColor = true;
            run_button.Click += run_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(281, 222);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 7;
            label1.Text = "results";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(498, 66);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(255, 304);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(21, 240);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(301, 184);
            listBox2.TabIndex = 9;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(712, 48);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 10;
            label2.Text = "interface";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(run_button);
            Controls.Add(capasity_label);
            Controls.Add(seed_label);
            Controls.Add(n_label);
            Controls.Add(capasity_textBox);
            Controls.Add(seed_textBox);
            Controls.Add(n_textBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox n_textBox;
        private TextBox seed_textBox;
        private TextBox capasity_textBox;
        private Label n_label;
        private Label seed_label;
        private Label capasity_label;
        private Button run_button;
        private Label label1;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label2;
    }
}
