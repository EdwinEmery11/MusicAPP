using Microsoft.EntityFrameworkCore;
using MusicApplicationWebLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApplication.Data
{//creates the dbset/entity 
    public class ApplicationDbContext : DbContext
    {
        // constructor chaining 
        //creating a contructor within the child class passing this entity 
        //over into the parent class 
        //picking out  properties (dbContextOptions) of this
        //class (applicationDBcontext)
        // and passing it over to the parent class to go use it 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Album> Albums { get; set; }
        //Albums will be the name of the table
        //table that contains rows of albums
        // this is the entity 
        //generic class 

        //enable songs - so if i add a new model and i need it to be a databse table it must be added in here 
        public DbSet<Song> Songs { get; set; }

    }
}
