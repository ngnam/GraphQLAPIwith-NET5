using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HotChocolate;

namespace CommanderGQL.Models
{
    [GraphQLDescription("Representer a Platform model")]
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
        [GraphQLDescription("Platform valid licensekey for the platform")]
        public string LisenceKey { get; set; }
        public ICollection<Command> Commands { get; set; }
    }
}