using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using ComboBox = System.Windows.Forms.ComboBox;
using TrackBar = System.Windows.Forms.TrackBar;

namespace DailyAnalyser
{
    public partial class DailyForm : Form
    {
        public User user;
        public bool saved = false;
        
        public DailyForm(User u)
        {
            InitializeComponent();
            user = u;
        }

        private void DailyForm_Load(object sender, EventArgs e)
        {
            int y = 20;

            foreach (var cat in user.categories)
            {
                Label lbl = new Label();
                lbl.Text = cat.Question;
                lbl.AutoSize = true;
                lbl.Location = new Point(20, y);
                Controls.Add(lbl);

                Control inputControl = null;
                int height = 0;

                if (cat.Type is TrackBar)
                {
                    TrackBar trackBar = (TrackBar)cat.Type;
                    trackBar.Minimum = (int)cat.Bounds[0];
                    trackBar.Maximum = (int)cat.Bounds[1];
                    trackBar.SmallChange = 1;
                    trackBar.LargeChange = 1;
                    trackBar.TickStyle = TickStyle.None;
                    trackBar.Width = 200;
                    trackBar.TickFrequency = 100;

                    height = trackBar.Height + 20;

                    trackBar.Location = new Point(20, y + lbl.Height + 5);
                    Controls.Add(trackBar);

                    Label lblValue = new Label { Text = ((double)trackBar.Value/1000).ToString(), Location = new Point(trackBar.Right + 10, trackBar.Top + 5) };
                    Label lblMin = new Label { Text = Convert.ToString(cat.Bounds[0]), Location = new Point(trackBar.Left, trackBar.Bottom + 5) };
                    Label lblMax = new Label { Text = Convert.ToString((int)cat.Bounds[1]/1000), Location = new Point(trackBar.Right - 20, trackBar.Bottom + 5) };

                    trackBar.Scroll += (s, e2) =>
                    {
                        lblValue.Text = ((double)trackBar.Value / 1000).ToString();
                    };

                    Controls.Add(lblMin);
                    Controls.Add(lblMax);
                    Controls.Add(lblValue);
                }
                else if (cat.Type is NumericUpDown)
                {
                    NumericUpDown numericUpDown = (NumericUpDown)cat.Type;
                    numericUpDown.Minimum = (int)cat.Bounds[0];
                    numericUpDown.Maximum = (int)cat.Bounds[1];

                    height = numericUpDown.Height;

                    numericUpDown.Location = new Point(20, y + lbl.Height + 5);
                    Controls.Add(numericUpDown);
                }
                else if (cat.Type is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)cat.Type;
                    comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                    foreach (var option in cat.Bounds)
                    {
                        comboBox.Items.Add(option);
                    }

                    height = comboBox.Height;

                    comboBox.Location = new Point(20, y + lbl.Height + 5);
                    Controls.Add(comboBox);
                }


                y += lbl.Height + height + 20;

            }

            Button saveButton = new Button()
            {
                Text = "Save",
                Location = new Point(20, y + 10)
            };
            saveButton.Click += SaveButton_Click;
            Controls.Add(saveButton);

            Button closeButton = new Button()
            {
                Text = "Close",
                Location = new Point(170, y + 10)
            };
            closeButton.Click += CloseButton_Click;
            Controls.Add(closeButton);

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //foreach (Control ctrl in Controls)
            //{
            //    if (ctrl.Tag is ICategory cat)
            //    {
            //        if (ctrl is NumericUpDown num)
            //            cat.Answer = (int)num.Value;
            //        else if (ctrl is TrackBar tb)
            //            cat.Answer = (double)tb.Value;
            //        else if (ctrl is ComboBox cb)
            //            cat.Answer = (string)cb.Text;
            //    }
            //}

            foreach (var cat in user.categories)
            {
                if (cat.Type is NumericUpDown num)
                    cat.Answer = (int)num.Value;
                else if (cat.Type is TrackBar tb)
                    cat.Answer = (double)tb.Value/1000;
                else if (cat.Type is ComboBox cb)
                    cat.Answer = (string)cb.Text;
                MessageBox.Show($"{cat.Question}: {cat.Answer}", "Result Debug", MessageBoxButtons.OK);
            }
            saved = true;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (!saved)
            {
                DialogResult result = MessageBox.Show("Want to exit without saving?", "Quit without saving?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            } else
            {
                this.Close();
            }
        }
    }
}
