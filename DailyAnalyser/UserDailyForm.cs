using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DailyAnalyser.ExcelManager;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using ComboBox = System.Windows.Forms.ComboBox;
using TrackBar = System.Windows.Forms.TrackBar;

namespace DailyAnalyser
{
    public partial class UserDailyForm : Form
    {
        public User user;
        public bool saved = false;
        
        public UserDailyForm(User u) // Feed user into the form
        {
            InitializeComponent();
            user = u;
        }

        private void DailyForm_Load(object sender, EventArgs e) // Ran on load
        {
            Label heading = new Label()
            {
                Text = "Daily Form",
                Location = new Point(20, 20),
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                AutoSize = true
            };
            Controls.Add(heading);
            int y = 60; // Default position for UI elements

            foreach (var cat in user.categories) // For each category in user
            {
                // Question label
                Label lbl = new Label();
                lbl.Text = cat.Question;
                lbl.AutoSize = true;
                lbl.Location = new Point(20, y);
                Controls.Add(lbl);

                // Height of element
                int height = 0;

                if (cat.Type is TrackBar) // If category is TrackBar (Slider)
                {
                    TrackBar trackBar = (TrackBar)cat.Type;
                    trackBar.Minimum = Convert.ToInt32(cat.Bounds[0]);
                    trackBar.Maximum = Convert.ToInt32(cat.Bounds[1]); // Recall { min, max }
                    trackBar.SmallChange = 1; // Increments 
                    trackBar.LargeChange = 1; // Increments 
                    trackBar.TickStyle = TickStyle.None; // Don't display ticks (can change when editing UI)
                    trackBar.Width = 200; // Width of element
                    trackBar.TickFrequency = 100; // Number of ticks within slider

                    height = trackBar.Height + 20; // Set height for object for formatting

                    trackBar.Location = new Point(20, y + lbl.Height + 5);
                    Controls.Add(trackBar); // Adds trackbar
                    
                    // TrackBar does not have labels for the minimum and maximum values so this displays them
                    Label lblMin = new Label 
                    {
                        Text = Convert.ToString(Convert.ToInt32(cat.Bounds[0]) / 10), 
                        Location = new Point(trackBar.Left, trackBar.Bottom) 
                    };
                    Label lblMax = new Label 
                    { 
                        Text = Convert.ToString(Convert.ToInt32(cat.Bounds[1])/ 10), // Reason for /10 on line 74
                        Location = new Point(trackBar.Right - 20, trackBar.Bottom) 
                    };

                    // Displays the value currently selected
                    // IMPORTANT: ALL TRACKBAR BOUNDS SHOULD BE 10 TIMES LARGER SO IT CAN BE DIVIDED BY 10 TO BECOME A 1D.P. DOUBLE. 
                    Label lblValue = new Label { Text = ((double)trackBar.Value/10).ToString(), Location = new Point(trackBar.Right + 10, trackBar.Top + 5) };
                    

                    trackBar.Scroll += (s, e2) =>
                    {
                        lblValue.Text = ((double)trackBar.Value / 10).ToString(); // Updates label when trackbar value changes
                    };

                    // Adds labels
                    Controls.Add(lblMin);
                    Controls.Add(lblMax);
                    Controls.Add(lblValue);
                }
                else if (cat.Type is NumericUpDown)
                {
                    NumericUpDown numericUpDown = (NumericUpDown)cat.Type;
                    numericUpDown.Minimum = Convert.ToInt32(cat.Bounds[0]);
                    numericUpDown.Maximum = Convert.ToInt32(cat.Bounds[1]);

                    height = numericUpDown.Height;

                    numericUpDown.Location = new Point(20, y + lbl.Height + 5);
                    Controls.Add(numericUpDown);
                }
                else if (cat.Type is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)cat.Type;
                    comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                    foreach (var option in cat.Bounds) // Recall bounds for combobox are strings { Low, Medium, High }
                    {
                        if (!comboBox.Items.Contains(option))
                            comboBox.Items.Add(option);
                    }

                    height = comboBox.Height;

                    comboBox.Location = new Point(20, y + lbl.Height + 5);
                    Controls.Add(comboBox);
                }
                // Feel free to follow the above formatting for any other types you want to implement

                // Increase Y after loop so elements don't overlap
                y += lbl.Height + height + 20;

            }

            Button saveButton = new Button()
            {
                Text = "Save",
                Location = new Point(20, y + 10)
            };
            saveButton.Click += SaveButton_Click; // Runs SaveButton_Click method on click
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
            foreach (var cat in user.categories)
            {
                if (cat.Type is NumericUpDown num)
                    cat.Answer = (int)num.Value; 
                else if (cat.Type is TrackBar tb)
                    cat.Answer = (double)tb.Value/10;
                else if (cat.Type is ComboBox cb)
                    cat.Answer = (string)cb.Text;
            }
            UserDailyNote userDailyNote = new UserDailyNote(user);
            userDailyNote.ShowDialog();
            saved = true; // Not fully functional, if you save once and update it after saving it will remain true despite not updating
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
            } else // Closes if saved without asking
            {
                this.Close();
            }
        }
    }
}
