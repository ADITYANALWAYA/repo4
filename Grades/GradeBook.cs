﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {
        public GradeBook()
        {
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            
            foreach (float grade in grades)
            {
                if (grade > stats.HighestGrade)
                {
                    stats.HighestGrade = grade;
                }
                if (grade < stats.LowestGrade)
                {
                    stats.LowestGrade = grade;
                }
                sum = sum + grade;
            }

            stats.AverageGrade = sum / grades.Count;

            return stats;
        }
        public void AddGrade(float grade)
        {
            grades.Add(grade);

        }

        List<float> grades;
    }
}
