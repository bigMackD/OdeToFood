using Microsoft.Extensions.Configuration;

namespace OdeToFood
{
    public interface IGreeter
    {
        string GetMessageOfTheDay();

    }

    public class Greeter : IGreeter
    {
        private IConfiguration _config;

        public string GetMessageOfTheDay()
        {
            return _config["Greeting"];
        }
        public Greeter(IConfiguration configuration)
        {
            _config = configuration;
        }
    }
}