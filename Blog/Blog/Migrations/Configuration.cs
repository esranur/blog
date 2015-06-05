namespace Blog.Migrations
{
    using Blog.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Blog.Models.BookDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Blog.Models.BookDBContext context)
        {
            context.Books.AddOrUpdate( i => i.Title,
                new Book
                {
                 Title="Þeker Portakalý",
                 ReleaseDate = DateTime.Parse("	2015-04-17"),
                 Genre = "	Çocuk Kitabý",
                 Price = 17
                },
                new Book
                {
                 Title="Uçurtma Avcýsý",
                 ReleaseDate = DateTime.Parse("	2015-04-03"),
                 Genre = "Roman",
                 Price = 15
                },
                 new Book
                {
                 Title="Gümüþ Gözyaþlarý",
                 ReleaseDate = DateTime.Parse("	2015-04-13"),
                 Genre = "Roman",
                 Price = 25
                },
                   new Book
                {
                 Title="Mihmandar",
                 ReleaseDate = DateTime.Parse("	2014-01-06"),
                 Genre = "Roman",
                 Price = 19
                },

                new Book
                {
                 Title="Nar Aðacý",
                 ReleaseDate = DateTime.Parse("	2014-10-13"),
                 Genre = "Roman",
                 Price = 24
                },
                 new Book
                {
                 Title="Kardeþimin Hikayesi",
                 ReleaseDate = DateTime.Parse("	2014-05-09"),
                 Genre = "Roman",
                 Price = 19
                }

                );


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
