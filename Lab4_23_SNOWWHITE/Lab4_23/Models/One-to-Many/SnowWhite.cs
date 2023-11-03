using Lab4_23.Models.Base;

namespace Lab4_23.Models.One_to_Many
{
    public class SnowWhite: BaseEntity
    {
        public string? Name { get; set; }

        // relation 
        public ICollection<Pitici>? Pitici { get; set; }
    }
}
