using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MovieCollection
{
    public partial class MovieCollection : Form
    {
        public MovieCollection()
        {
            InitializeComponent();
            PopulateComboBox();
        }

        List<Movie> MovieList = new List<Movie>();
        string[] FormatList = new string[] { "DVD", "Blu Ray", "4K Blu Ray" };

        #region ADD/EDIT/DELETE
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // TODO: Check all fields are filled before adding new Object
            AddMovie();
            DisplayMovies();
            ClearFields();
        }
        private void AddMovie()
        {
            Movie m = new Movie(textBoxTitle.Text);
            m.SetYear(int.Parse(textBoxYear.Text));
            m.SetDirector(textBoxDir.Text);
            m.SetFormat(comboBoxFormat.Text);
            m.SetSteelbook(RadioButtonString());
            MovieList.Add(m);
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            // TODO: Add yes/no confirmation
            int index = listViewMovies.SelectedIndices[0];
            MovieList.RemoveAt(index);
            AddMovie();
            DisplayMovies();
            ClearFields();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // TODO: Add yes/no confirmation
            int index = listViewMovies.SelectedIndices[0];
            MovieList.RemoveAt(index);
            DisplayMovies();
            ClearFields();
        }
        #endregion ADD/EDIT/DELETE

        #region SORT
        private void buttonSortTitle_Click(object sender, EventArgs e)
        {
            MovieList.Sort();
            DisplayMovies();
        }

        private void buttonSortYear_Click(object sender, EventArgs e)
        {
            //MovieList.Sort(CompareYear);
        }

        private void buttonSortDir_Click(object sender, EventArgs e)
        {

        }
        #endregion SORT

        #region RADIO BUTTONS
        private string RadioButtonString()
        {
            if (radioButtonYes.Checked)
                return "True";
            else
                return "False";
        }

        private void RadioButtonHighlight(int index)
        {
            if (index == 0)
                radioButtonYes.Checked = true;
            else
                radioButtonNo.Checked = true;
        }
        #endregion RADIO BUTTONS

        #region DISPLAY
        private void DisplayMovies()
        {
            listViewMovies.Items.Clear();
            foreach (var item in MovieList)
            {
                listViewMovies.Items.Add(item.Display());
            }
        }

        private void listViewMovies_Click(object sender, EventArgs e)
        {
            int index = listViewMovies.SelectedIndices[0];
            ShowDataFields(index);
        }

        private void ShowDataFields(int index)
        {
            textBoxTitle.Text = MovieList[index].GetTitle();
            textBoxYear.Text = MovieList[index].GetYear().ToString();
            textBoxDir.Text = MovieList[index].GetDirector();
            comboBoxFormat.SelectedItem = MovieList[index].GetFormat();
            if (MovieList[index].GetSteelbook())
                RadioButtonHighlight(0);
            else
                RadioButtonHighlight(1);
        }

        private void ClearFields()
        {
            textBoxTitle.Clear();
            textBoxYear.Clear();
            textBoxDir.Clear();
            comboBoxFormat.SelectedItem = null;
            radioButtonYes.Checked = false;
            radioButtonNo.Checked = false;
        }
        private void PopulateComboBox()
        {
            comboBoxFormat.Items.AddRange(FormatList);
        }
        #endregion DISPLAY

        #region SAVE/LOAD
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveRecords();
            SaveRecordsText();
        }

        // Saves Movie Objects in binary format
        private void SaveRecords()
        {
            if (MovieList.Count > 0)
            {
                using (var stream = File.Open("movies.bin", FileMode.Create))
                {
                    using (var writer = new BinaryWriter(stream, Encoding.UTF8, false))
                    {
                        foreach (var item in MovieList)
                        {
                            writer.Write(item.GetTitle());
                            writer.Write(item.GetYear());
                            writer.Write(item.GetDirector());
                            writer.Write(item.GetFormat());
                            writer.Write(item.GetSteelbook());
                        }
                    }
                }
            }
            else
                Console.WriteLine("error");
        }

        // Saves Movie Objects as comma separated values in text
        private void SaveRecordsText()
        {
            if (MovieList.Count > 0)
            {
                using (var stream = File.Open("movies.txt", FileMode.Create))
                {
                    using (var writer = new StreamWriter(stream, Encoding.UTF8))
                    {
                        foreach (var item in MovieList)
                        {
                            writer.Write(item.GetTitle() + ',');
                            writer.Write(item.GetYear().ToString() + ',');
                            writer.Write(item.GetDirector() + ',');
                            writer.Write(item.GetFormat() + ',');
                            writer.Write(item.GetSteelbook().ToString() + '\n');
                        }
                    }
                }
            }
            else
                Console.WriteLine("error");
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            LoadRecords();
            DisplayMovies();
        }

        private void LoadRecords()
        {
            if (File.Exists("movies.bin"))
            {
                using (var stream = File.Open("movies.bin", FileMode.Open))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        MovieList.Clear();
                        while (stream.Position < stream.Length)
                        {
                            Movie load = new Movie();
                            load.SetTitle(reader.ReadString());
                            load.SetYear(reader.ReadInt32());
                            load.SetDirector(reader.ReadString());
                            load.SetFormat(reader.ReadString());
                            load.SetSteelbook(reader.ReadBoolean().ToString());
                            MovieList.Add(load);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        #endregion SAVE/LOAD

        
    }


}
