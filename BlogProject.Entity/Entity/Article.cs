using BlogProject.Core.Entity;

namespace BlogProject.Entity.Entity
{
    public class Article : EntityBase
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int ViewCount { get; set; }
       
        //References
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public Guid ImageId { get; set; }
        public Image Image { get; set; }
    }
}
