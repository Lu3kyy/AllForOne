// the shape of our data coming in from the client
// c# class to represent the data we expect to receive in a request

namespace project_template.Models
{
    public class GuessItRequest
    {
        public int Guess { get; set; }
    }
}
