﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEditor;

namespace Program_For_Testing
{
    public class Participant : IFormat
    {
        public Participant()
        {
            Points = 0;
        }
        public string FullName { get; set; }
        public string Specialty { get; set; }
        public string Course { get; set; }
        public string Group { get; set; }
        public double Points { get; set; }

        public List<QuestionModel> questions = new List<QuestionModel>();

        public string DoFormat(double myPoints)
        {
            var s = string.Format("{0:0.00}", myPoints);

            if (s.EndsWith("00"))
            {
                return ((int)myPoints).ToString();
            }
            else
            {
                return s;
            }
        }
    }
}
