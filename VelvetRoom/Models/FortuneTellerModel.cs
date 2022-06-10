using VelvetRoom.Views.Shared;
using VelvetRoom.Data;

namespace VelvetRoom.Models

{
    public class FortuneTellerModel
    {
        public FortuneTeller fortuneTellerIgor = new FortuneTeller("igor", "Igor takes pride in his professional tellings and straightforward approach. He will always tell the customer what the cards say with no regards to what the tellings said.", "~/img/FortuneTellers/Igor.png");
        public FortuneTeller fortuneTellerUrsula = new FortuneTeller("Ursula", "Ursula is a sinister woman that loves to tell the Costumers the worst possible interpretation of their Fate. She gloats about bad readings and downplays good ones.", "~/img/FortuneTellers /Ursula.png");
        public FortuneTeller fortuneTellerScheherazade = new FortuneTeller("Scheherazade", "abcdefghijklmnopqrstuvwxyz yuhe.", "~/img/FortuneTellers/Scheherazade.jpg");

        public static void Initialize(IServiceProvider serviceProvider)
        {
    /*        using (var context = new FortuneTellerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<FortuneTellerContext>>()))
            {
                // Look for any movies.
                if (context.FortuneTeller.Any())
                {
                    return;   // DB has been seeded
                }

                context.FortuneTeller.AddRange(
                    new FortuneTeller("igor", "Igor takes pride in his professional tellings and straightforward approach. He will always tell the customer what the cards say with no regards to what the tellings said.", "~/img/FortuneTellers/Igor.png"),

                    new FortuneTeller("Ursula", "Ursula is a sinister woman that loves to tell the Costumers the worst possible interpretation of their Fate. She gloats about bad readings and downplays good ones.", "~/img/FortuneTellers /Ursula.png"),

                    new FortuneTeller("Scheherazade", "abcdefghijklmnopqrstuvwxyz yuhe.", "~/img/FortuneTellers/Scheherazade.jpg")
  
                );
                context.SaveChanges();
            }
    */    }

    }
}
