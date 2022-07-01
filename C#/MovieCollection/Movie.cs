using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieCollection
{
    [Serializable]
    internal class Movie : IComparable
    {
        private string Title;
        private int Year;
        private string Director;
        private string Format;
        bool Steelbook = false;

        #region CONSTRUCTORS
        public Movie()
        {}

        // Overloaded Constructor setting Title
        public Movie(string NewTitle)
        {
            Title = NewTitle;
        }
        #endregion CONSTRUCTORS

        public int CompareTo(object obj)
        {
            Movie compare = obj as Movie;
            return Title.CompareTo(compare.Title);
        }

        // TODO: Implement additional sorting options by Year and Director properties
        //public int CompareTo(object obj)
        //{
        //    Movie compare = obj as Movie;
        //    return Year.CompareTo(compare.Year);
        //}

        //public int CompareYear(object obj)
        //{
        //    Movie compare = obj as Movie;
        //    return Year.CompareTo(compare.Year);
        //}

        public ListViewItem Display()
        {
            ListViewItem lvi = new ListViewItem(GetTitle());
            return lvi;
        }
        #region GETTERS/SETTERS
        public string GetTitle()
        {
            return Title;
        }
        public void SetTitle(string NewTitle)
        {
            Title = NewTitle;
        }
        public int GetYear()
        {
            return Year;
        }
        public void SetYear(int NewYear)
        {
            Year = NewYear;
        }
        public string GetDirector()
        {
            return Director;
        }
        public void SetDirector(string NewDirector)
        {
            Director = NewDirector;
        }
        public string GetFormat()
        {
            return Format;
        }
        public void SetFormat(string NewFormat)
        {
            Format = NewFormat;
        }
        public bool GetSteelbook()
        {
            return Steelbook;
        }
        public void SetSteelbook(string NewSteelbook)
        {
            if (NewSteelbook.Equals("True"))
                Steelbook = true;
            else
                Steelbook = false;
        }
        #endregion GETTERS/SETTERS
    }
}
