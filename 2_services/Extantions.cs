using _2_services.Models;
using _3_repositories;
using _3_repositories.Entities;
using _3_repositories.Interfaces;
using _3_repositories.Repositories;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_services
{
    public static class Extantions
    {
        public static void AddRepoDependencies(this IServiceCollection services)
        {
            services.AddScoped<IPersonRepository, PersonRepository>();
            MapperConfiguration config = new MapperConfiguration(
                conf => conf.CreateMap<Person, PersonModel>().ReverseMap());
            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);
            /////
            services.AddScoped<IChildRepository, ChildRepository>();
            MapperConfiguration configcild = new MapperConfiguration(
               conf => conf.CreateMap<Child, ChildModel>().ReverseMap());
            IMapper mapperCild = configcild.CreateMapper();
            services.AddSingleton(mapperCild);
            /////
            services.AddScoped<IDataBase, DataBase>();
            //services.AddDbContext<IDataBase, DataBase>();
            //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        }
    }
}
