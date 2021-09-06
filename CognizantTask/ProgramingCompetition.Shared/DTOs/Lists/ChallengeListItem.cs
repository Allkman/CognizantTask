using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramingCompetition.Shared.DTOs.Lists
{
    public class ChallengeListItem
    {
        public virtual int Id { get; set; }
        public virtual string UserName { get; set; }
        public RootObjectListItem Rootobject { get; set; }
        public List<ClassificatorTaskTypeListItem> TaskTypes { get; set; }
    }
}
