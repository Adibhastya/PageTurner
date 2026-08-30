using System.ComponentModel.DataAnnotations;

namespace PageTurnerWeb.Models
{
    public class Category
    {
        //[Key]- If PK name is not Id, use this attribute.
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

    }
}
