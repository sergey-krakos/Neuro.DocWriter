namespace DAL.Entities
{
    public class ResourceItem
    {
        public int Id { get; set; }

        public int Title { get; set; }

        public int Label { get; set; }

        public int ToolTip { get; set; }

        public int GroupId { get; set; }
        public virtual ResourceItemGroup Group { get; set; }

        public int AuthorId { get; set; }
        public virtual User Author { get; set; }
    }
}