using BlogProject.Core.Entity;

namespace BlogProject.Entity.Entity
{
    public class Image : EntityBase
    {
        public string FileName { get; set; }
        public string FileType { get; set; }

        //References
        public ICollection<Article> Articles { get; set; }
    }
}
