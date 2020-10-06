using provaquestao06.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace provaquestao06.Context
{
    public class ContextData : DbContext
    {
        public DbSet<Aluno> Alunos{ get; set; }

    }
}