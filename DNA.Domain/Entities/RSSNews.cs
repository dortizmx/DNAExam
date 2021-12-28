using System;
namespace DNA.Domain.Entities
{
    public class RSSNews
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublishingDate { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
    }
}
