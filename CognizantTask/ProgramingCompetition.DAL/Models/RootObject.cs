using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramingCompetition.DAL.Models
{
    public class RootObject
    {
        [Key]
        public virtual int Id { get; set; }
        public string clientId { get; set; }
        public string clientSecret { get; set; }
        [MaxLength(5000)] //optional
        public virtual string script { get; set; }
        public string stdin { get; set; }
        public string language { get; set; }
        public string versionIndex { get; set; }
    }
}
