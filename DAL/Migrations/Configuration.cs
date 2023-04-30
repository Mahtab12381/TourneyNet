namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.TourneyNetDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.TourneyNetDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            Random random =new Random();
            for(int i=1; i<=20; i++)
            {
                context.Players.AddOrUpdate(new Model.Player
                {
                    gender = "male",
                    nationality = "Bangladeshi",
                    age =random.Next(18, 30),
                });
            }


            for (int i = 1; i <= 20; i++)
            {
                context.Fans.AddOrUpdate(new Model.Fan
                {
                    
                    Bio = "I am _______",
                    ContactInformation = "+08801614******"
                    
                });
            }

<<<<<<< HEAD

            for (int i = 1; i <= 20; i++)
            {
                context.Registrations.AddOrUpdate(new Model.Registration
                {

                    FirstName = " Person-"+i,
                    LastName = "---",
                    UserName = "user-"+i,
                    Email = "____@gmail.com",
                    Password = "Password",
                    Type = "Organizer"
=======
            for (int i = 1; i <= 20; i++)
            {
                context.FanPosts.AddOrUpdate(new Model.FanPost
                {

                    PostContent = "This is a fan post!"+i,
                    PostDate = DateTime.Now,
>>>>>>> c306a5ddb04bf0e36e8071b942192d7c993a20be

                });
            }
        }
    }
}
