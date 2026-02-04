using project_template.Models;

namespace project_template.Services
{
    public class MadLibService
    {
        public string GenerateMadLib(MadLibRequest request)
        {
            return $"Once upon a time, there was a {request.Adjective1} {request.Noun1} who loved to {request.Verb1} {request.Adverb}. " +
                   $"One day, they went to the {request.PlaceNoun} and met a {request.Adjective2} {request.Noun2}. " +
                   $"Together, they decided to {request.Verb2} and lived happily ever after!";
        }
    }
}
