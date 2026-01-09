
namespace MiniChallengeFiveToSeven.Services
{
    public class MadLab
    {
        
        public string GenerateMadLib(
        

            string name,
            string adjective1,
            string adjective2,
            string noun1,
            string noun2,
            string verb1,
            string verb2,
            string adverb,
           string place,           
           string emotion
        ) 
{
           return $"One day, {name} was feeling very {emotion} while walking through the {adjective1} {place}. " +
                   $"Suddenly, a {adjective2} {noun1} appeared and decided to {verb1}. " +
                   $"{name} quickly {adverb} {verb2} toward a nearby {noun2}. " +
                   $"It turned out to be a day no one would ever forget.";
        
    }

    }
    }