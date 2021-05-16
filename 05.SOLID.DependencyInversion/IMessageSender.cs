namespace _05.SOLID.DependencyInversion
{
    public interface IMessageSender
    {
        public string Origin { get; set; }
        public string Destiny { get; set; }
        public string Content { get; set; }
        void Send();
    }
}