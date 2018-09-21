using Microsoft.Extensions.Configuration;

namespace OdeToFood.Services
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