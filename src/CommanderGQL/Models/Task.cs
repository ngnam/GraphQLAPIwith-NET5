using System;
using System.ComponentModel.DataAnnotations;

namespace CommanderGQL.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Scope { get; set; }
        [Required]
        public int AsignTo { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}