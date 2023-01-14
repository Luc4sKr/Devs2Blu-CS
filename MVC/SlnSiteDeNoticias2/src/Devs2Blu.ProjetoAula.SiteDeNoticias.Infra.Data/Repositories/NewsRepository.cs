﻿using Devs2Blu.ProjetoAula.SiteDeNoticias.Domain.Entities;
using Devs2Blu.ProjetoAula.SiteDeNoticias.Domain.IRepositories;
using Devs2Blu.ProjetoAula.SiteDeNoticias.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetoAula.SiteDeNoticias.Infra.Data.Repositories
{
    public class NewsRepository : BaseRepository<News>, INewsRepository
    {
        private readonly SQLServerContext _context;

        public NewsRepository(SQLServerContext context) : base(context) 
        {
        }
    }
}
