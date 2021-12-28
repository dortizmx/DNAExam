using System;
namespace DNA.Domain.ViewModels
{
    public class RSSNewsViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublishingDate { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
    }
}
