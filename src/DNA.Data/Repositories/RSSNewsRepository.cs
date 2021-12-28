using System;
using System.Collections.Generic;
using System.Linq;
using DNA.Domain.Entities;

namespace DNA.Data.Repositories
{
    public class RSSNewsRepository
    {
        List<RSSNews> _retvalues;
        public RSSNewsRepository()
        {
            _retvalues = new List<RSSNews>();
            _retvalues.Add(new RSSNews() { Id = 1, Description = "E New 1, Description", PublishingDate = new DateTime(2020, 1, 1), Title = "New1", Link = "www.link.com" });
            _retvalues.Add(new RSSNews() { Id = 2, Description = "D New 2, Description", PublishingDate = new DateTime(2020, 1, 2), Title = "New2", Link = "www.link.com" });
            _retvalues.Add(new RSSNews() { Id = 3, Description = "C New 3, Description", PublishingDate = new DateTime(2020, 1, 3), Title = "New3", Link = "www.link.com" });
            _retvalues.Add(new RSSNews() { Id = 4, Description = "B New 4, Description", PublishingDate = new DateTime(2020, 1, 4), Title = "New4", Link = "www.link.com" });
            _retvalues.Add(new RSSNews() { Id = 5, Description = "A New 5, Description", PublishingDate = new DateTime(2020, 1, 5), Title = "New5", Link = "www.link.com" });

        }

        public List<RSSNews> getAll()
        {
            var retvalue = _retvalues;
            return retvalue;
        }

        public RSSNews getById(int id)
        {
            var retvalue = _retvalues.Where(x => x.Id == id).FirstOrDefault();
            return retvalue;
        }

        public List<RSSNews> getAllSorting(string item)
        {
            switch (item)
            {
                case "Id":
                    return _retvalues.OrderBy(x => x.Id).ToList();
                    
                case "PublishingDate":
                    return _retvalues.OrderBy(x => x.PublishingDate).ToList();
                   
                case "Description":
                    return _retvalues.OrderBy(x => x.Description).ToList();
                    
                case "Title":
                    return _retvalues.OrderBy(x => x.Title).ToList();
                   

            }
            return _retvalues;
                
                    
        }
    }
}
