namespace _05.SOLID.DependencyInversion
{
    public interface IEmail : IMessageSender
    {
        string Subject { get; set; }
    }
}