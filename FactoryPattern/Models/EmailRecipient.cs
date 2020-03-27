namespace FactoryPattern.Models
{
    class EmailRecipient : Recipient
    {
        public EmailRecipient(string address)
        {
            base.address = address;
        }
    }
}
