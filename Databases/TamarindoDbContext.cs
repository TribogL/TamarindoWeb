using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TamarindoWeb.Pages.Models;

namespace TamarindoWeb.Databases;
public class TamarindoDbContext : DbContext
{
    public DbSet<Traveller> Travellers { get; set; }


    public TamarindoDbContext(DbContextOptions<TamarindoDbContext> options) : base(options)
    {

    }
}
