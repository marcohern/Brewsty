using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Brewsty.Entities
{
    public class Entity
    {
        [StringLength(150, MinimumLength = 5)]
        public string Id { get; set; }
    }
}
