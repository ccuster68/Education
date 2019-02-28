namespace AspNetCoreVideo.Services
{
    public class HardcodedMessageService : IMessageService
    {
        public string GetMessage()
        {
            return "string Hardcoded message from a service.";
        }
    }
}
