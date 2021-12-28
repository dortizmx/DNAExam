using System;
using System.Collections.Generic;
using DNA.Data.Repositories;
using DNA.Domain;
using DNA.Domain.Entities;
using DNA.Domain.ViewModels;

namespace DNA.Services
{
    public class RSSNewsService
    {
        RSSNewsRepository _repository;
        public RSSNewsService()
        {
            _repository = new RSSNewsRepository();
        }

        public List<RSSNewViewModel> getAll()
        {
            return GeneralConverter<RSSNewViewModel, RSSNews>.Convert(_repository.getAll());
        }

        public RSSNews getById(int id)
        {
            return _repository.getById(id);
        }

        public List<RSSNewViewModel> getSorting(string item)
        {
            return GeneralConverter<RSSNewViewModel, RSSNews>.Convert(_repository.getAllSorting(item));
        }
    }
}
