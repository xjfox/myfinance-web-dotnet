using System.ComponentModel.DataAnnotations;

namespace myfinance_web_netcore.Entities.Base
{
    public class EntityBase
    {
        [Key]
        public int? Id { get; set; }
    }
}