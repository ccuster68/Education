using Microsoft.Extensions.Configuration;

namespace AspNetCoreVideo.Services
{
    public class ConfigurationMessageService:IMessageService
    {
        private readonly IConfiguration _configuration;

        public ConfigurationMessageService(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        public string GetMessage()
        {
            return _configuration["Message"];
        }
    }
}
