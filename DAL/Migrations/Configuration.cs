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
            //Random random = new Random();
            //for (int i = 1; i <= 20; i++)
            //{
            //    context.Players.AddOrUpdate(new Model.Player
            //    {
            //        gender = "male",
            //        nationality = "Bangladeshi",
            //        age = random.Next(18, 30),
            //    });
            //}


            //for (int i = 1; i <= 20; i++)
            //{
            //    context.Fans.AddOrUpdate(new Model.Fan
            //    {

            //        Bio = "I am _______",
            //        ContactInformation = "+08801614******"

            //    });
            //}

            

            //for (int i = 1; i <= 20; i++)
            //{
            //    context.Payments.AddOrUpdate(new Model.Payment
            //    {

            //        amount_paid = 400 + (i * 2),
            //        payment_date = DateTime.Now,

            //    });
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    context.Rankings.AddOrUpdate(new Model.Ranking
            //    {

            //        rank = 1 + i,

            //    });

            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    context.Tournaments.AddOrUpdate(new Model.Tournament
            //    {

            //        tournament_name = "E_Pulsar",
            //        tournament_description = "**************",
            //        tournament_rules = "**********aaabdac",
            //        end_date = DateTime.Now,
            //        start_date = DateTime.Now,
            //        registration_deadline = DateTime.Now,


            //    });
            //}


            //for (int i = 1; i <= 20; i++)
            //{
            //    context.Registrations.AddOrUpdate(new Model.Registration
            //    {
            //        FirstName = "MR.",
            //        LastName = "___",
            //        UserName= "user-"+i,
            //        Email ="____@gmail.com",
            //        Password = "******",
            //        Type ="Player"
            //    });
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    context.Organizers.AddOrUpdate(new Model.Organizer
            //    {

            //        Organizer_Description = "This is ______"
                   

            //    });
            //}
            //for (int i = 1; i <= 20; i++)
            //{
            //    context.Participants.AddOrUpdate(new Model.Participant
            //    {

            //        tournament_id = i,
            //        player_id = i + 1000,
            //        team_name = "GCxVenom",
            //        team_logo = "logo"
            //    });
            //}
            //for (int i = 1; i <= 20; i++)
            //{
            //    context.Events.AddOrUpdate(new Model.Event
            //    {
            //        organizer_id = i,
            //        event_name = "name",
            //        event_description = "description",
            //        event_start_date = DateTime.Now,
            //        event_end_date = DateTime.Now,
            //        location = "Location",
            //        rules = "rules",
            //        prizes = "prizes",
            //        registration_deadline = DateTime.Now
            //    });
            //}
            //for (int i = 1; i <= 20; i++)
            //{
            //    context.SocialMediaSharings.AddOrUpdate(new Model.SocialMediaSharing
            //    {
            //        event_id = i,
            //        share_date = DateTime.Now,
            //        share_description = "description",
            //        platform = "Twitch"
            //    });
            //}


            //for (int i = 1; i <= 20; i++)
            //{
            //    context.PlayerGames.AddOrUpdate(new Model.PlayerGame
            //    {

            //        Game_Name = "Call Of Duty",
            //        Player_Skill = "Noob"
            //    });
            //}
            //for (int i = 1; i <= 20; i++)
            //{
            //    context.Teams.AddOrUpdate(new Model.Team
            //    {

            //        Team_name="Bangladesh",
            //        Team_logo="BD_Flag"

            //    });
            //}
           
        }
    }
}
