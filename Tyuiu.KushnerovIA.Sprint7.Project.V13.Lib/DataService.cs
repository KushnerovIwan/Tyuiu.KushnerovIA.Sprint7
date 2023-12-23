﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.KushnerovIA.Sprint7.Project.V13.Lib
{
    public class DataService
    {
        public double avgPopulation(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            double avg = 0;

            for (int i = 0; i < rows; i++)
            {
                avg += matrix[i, 2];
            }
            avg = avg / rows;
            return Math.Round(avg, 2);
        }

        public double avgArea(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            double avg = 0;

            for (int i = 0; i < rows; i++)
            {
                avg += matrix[i, 3];
            }
            avg = avg / rows;
            return Math.Round(avg, 2);
        }
    }
}
