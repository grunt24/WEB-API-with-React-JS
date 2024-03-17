namespace ASSISTmentsBackend.Core.Entities
{
    public class Message: BaseEntity<long>
    {
        public string? SenderUserName { get; set; }
        public string? ReceiveUserName { get; set; }
        public string? Text { get; set; }
    }
}
