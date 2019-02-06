using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiSimpleExample.Models;

namespace WebApiSimpleExample.Data
{
  public class MyDataContext : DbContext
  {
    public MyDataContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Etudiant> Etudiants { get; set; }

  }
}
