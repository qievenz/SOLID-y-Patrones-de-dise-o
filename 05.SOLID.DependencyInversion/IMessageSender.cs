namespace _05.SOLID.DependencyInversion
{
    public interface IMessageSender
    {
        string Origin { get; set; }
        string Destiny { get; set; }
        string Content { get; set; }
        void Send();
    }
}