using Lab4_23.Models.Base;

namespace Lab4_23.Models.One_to_Many
{
    public class Pitici: BaseEntity
    {
        public string Name { get; set; }

        // relation
        public SnowWhite SnowWhite { get; set; }

        public Guid SnowWhiteID { get; set; }
    }
}
