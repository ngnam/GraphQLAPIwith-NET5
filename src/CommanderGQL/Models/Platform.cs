using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommanderGQL.Models
{
    public class Platform
    {
        public Platform()
        {
            this.Commands = new HashSet<Command>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string LisenceKey { get; set; }
        public ICollection<Command> Commands { get; set; }
    }
}