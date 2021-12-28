using System;
using System.Collections.Generic;
using AutoMapper;
using DNA.Domain.Entities;
using DNA.Domain.ViewModels;

namespace DNA.Domain
{
    public static class GeneralConverter<T, D>
    {
        private static MapperConfiguration config;

        private static void Setup()
        {
            if (config == null)
            {
                config = new MapperConfiguration(cfg =>
                {
                    cfg.AllowNullCollections = true;
                    cfg.CreateMap<RSSNews, RSSNewsViewModel>().ReverseMap();
                    cfg.CreateMap<RSSNews, RSSNewViewModel>().ReverseMap();

                });
            }
        }

        public static T Convert(D obj)
        {
            Setup();
            var mapper = new Mapper(config);
            var _item = mapper.Map<D, T>(obj);
            return _item;
        }

        public static List<T> Convert(List<D> obj)
        {
            Setup();
            var mapper = new Mapper(config);
            List<T> _item = mapper.Map<List<D>, List<T>>(obj);
            return _item;
        }
    }

}
