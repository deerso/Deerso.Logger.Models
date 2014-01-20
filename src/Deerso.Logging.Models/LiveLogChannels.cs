namespace Deerso.Logging.Models
{
    public sealed class LiveLogChannel
    {
        private readonly string _channelName;

        public static LiveLogChannel Debug = new LiveLogChannel("DeersoWebDebug");
        public static LiveLogChannel Exception = new LiveLogChannel("DeersoWebExceptions"); 
        public static LiveLogChannel Requests = new LiveLogChannel("DeersoWebRequests");
        public static LiveLogChannel Orders = new LiveLogChannel("DeersoWebOrders");

        private LiveLogChannel(string channelValue)
        {
            _channelName = channelValue;
        }

        public override string ToString()
        {
            return _channelName;
        }
    }
}