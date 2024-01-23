using BlogProject.Core.Entity;

namespace BlogProject.Entity.Entity
{
    public class Category : EntityBase
    {
        public string Name { get; set; }

        //References
        public ICollection<Article> Articles { get; set; }
    }
}
