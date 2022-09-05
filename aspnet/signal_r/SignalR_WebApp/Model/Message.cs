namespace SignalR_WebApp.Model
{
    public class Message
    {
        public Message() { }

        public Message(string user, string texto)
        {
            User = user;
            Texto = texto;
        }
        public string User { get; set; }
        public string Texto { get; set; }
    }
}
