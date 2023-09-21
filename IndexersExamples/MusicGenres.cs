using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersExamples
{
    public class MusicGenres
    {
        private string[] genres = new string[5];

        public string this[int index]
        {
            get { return genres[index]; }
            set { genres[index] = value; }
        }
    }
}
