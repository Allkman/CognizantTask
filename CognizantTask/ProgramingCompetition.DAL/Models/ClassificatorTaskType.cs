using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramingCompetition.DAL.Models
{
    public class ClassificatorTaskType
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual string TaskTitle { get; set; }
        public virtual string TaskDescription { get; set; }   
    }
}
