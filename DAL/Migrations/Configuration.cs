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
            Random random = new Random();
            for (int i = 1; i <= 20; i++)
            {
                context.Players.AddOrUpdate(new Model.Player
                {
                    gender = "male",
                    nationality = "Bangladeshi",
                    age = random.Next(18, 30),
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

            for (int i = 1; i <= 20; i++)
            {
                context.FanPosts.AddOrUpdate(new Model.FanPost
                {

                    PostContent = "This is a fan post!" + i,
                    PostDate = DateTime.Now,

                });
            }

            for (int i = 1; i <= 20; i++)
            {
                context.Payments.AddOrUpdate(new Model.Payment
                {

                    amount_paid = 400 + (i * 2),
                    payment_date = DateTime.Now,

                });
            }

            for (int i = 1; i <= 20; i++)
            {
                context.Rankings.AddOrUpdate(new Model.Ranking
                {

                    rank = 1 + i,

                });

            }

            for (int i = 1; i <= 20; i++)
            {
                context.Tournaments.AddOrUpdate(new Model.Tournament
                {

                    tournament_name = "E_Pulsar",
                    tournament_description = "**************",
                    tournament_rules = "**********aaabdac",
                    end_date = DateTime.Now,
                    start_date = DateTime.Now,
                    registration_deadline = DateTime.Now,


                });
            }


            for (int i = 1; i <= 20; i++)
            {
                context.Registrations.AddOrUpdate(new Model.Registration
                {
                    FirstName = "MR.",
                    LastName = "___",
                    UserName= "user-"+i,
                    Email ="____@gmail.com",
                    Password = "******",
                    Type ="Player"
                });
            }

            for (int i = 1; i <= 20; i++)
            {
                context.Organizers.AddOrUpdate(new Model.Organizer
                {

                    Organizer_Description = "This is ______"
                   

                });
            }

        }
    }
}
