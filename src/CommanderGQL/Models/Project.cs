using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HotChocolate;

namespace CommanderGQL.Models
{
    [GraphQLDescription("Representer a Project")]
    public class Project
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Owner { get; set; }
        public string Partner { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        public int Budget { get; set; }
        public int TeamSize { get; set; }
        public int Status { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}