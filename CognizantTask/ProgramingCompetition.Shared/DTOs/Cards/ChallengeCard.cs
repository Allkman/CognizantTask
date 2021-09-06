using ProgramingCompetition.Shared.DTOs.Lists;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProgramingCompetition.Shared.DTOs.Cards
{
    public class ChallengeCard
    {
        [Key]
        public virtual int? Id { get; set; }
        [Required]
        [MaxLength(50)]
        public virtual string UserName { get; set; }
        public RootObjectListItem Rootobject { get; set; }
        [Required]
        public List<ClassificatorTaskTypeListItem> TaskTypes { get; set; }
    }
}
