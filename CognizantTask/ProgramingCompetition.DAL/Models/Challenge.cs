using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProgramingCompetition.DAL.Models
{
    public class Challenge
    {
        [Key]
        public virtual int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public virtual string UserName { get; set; }
        public RootObject Rootobject { get; set; }
        [Required]
        public List<ClassificatorTaskType> TaskTypes { get; set; }
    }
}
