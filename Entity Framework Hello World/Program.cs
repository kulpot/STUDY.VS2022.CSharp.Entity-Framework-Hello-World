using System;
using System.Data.Entity;

//ref link:https://www.youtube.com/watch?v=v2tO15ctPyY&list=PLRwVmtr-pp06bXl6mbwDfK1eW9sAIvWUZ
//

class Video
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}

class MeContext : DbContext
{
    public MeContext() : base(@"Data Source=.;Initial Catalog=KulpotDB;Integrated Security=True")
    {

    }
    public DbSet<Video> Videos { get; set; }
}

class MainClass
{
    static void Main()
    {
        var vid = new Video
        {
            Title = "Hello World Entity Framework",
            Description = "Learn about the entity framework"
        };
        var meContext = new MeContext();
        meContext.Videos.Add(vid);
        meContext.SaveChanges();
    }
}