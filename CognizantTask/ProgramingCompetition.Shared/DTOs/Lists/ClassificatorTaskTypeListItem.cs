using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramingCompetition.Shared.DTOs.Lists
{
    public class ClassificatorTaskTypeListItem
    {
        public virtual int Id { get; set; }
        public virtual string TaskTitle { get; set; }
        public virtual string TaskDescription { get; set; }
    }
}
