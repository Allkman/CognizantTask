using ProgramingCompetition.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramingCompetition.DAL.InitialData
{
    static partial class DataSeed
    {
        public readonly static ClassificatorTaskType[] ClassificatorTaskTypes =
          {
            new ClassificatorTaskType { Id = 1, TaskTitle = "FibbonacciSequence", TaskDescription = "Write a code snippet to display first 25 fib numbers"},
            new ClassificatorTaskType { Id = 2, TaskTitle = "PrimaryNumber", TaskDescription = "Write a code snippet to display first 25 primary numbers"},
          };
    }
}
