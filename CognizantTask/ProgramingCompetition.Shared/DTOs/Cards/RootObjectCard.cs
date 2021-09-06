using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramingCompetition.Shared.DTOs.Cards
{
    public class RootObjectCard
    {
        public virtual int Id { get; set; }
        public string clientId { get; } = "8d0d5d459d0a4e60932ea4ae64e7dbc5";
        public string clientSecret { get; } = "2da8ea6a183736630a6f8aef5f8253a70bcf2c32fb0a741c6353ee3d2c5d4bdf";
        [Required]
        [MaxLength(5000)] //optional
        public virtual string script { get; set; } = "";
        public string stdin { get; } = "";
        public string language { get; } = "csharp";
        public string versionIndex { get; } = "0";
    }
}
