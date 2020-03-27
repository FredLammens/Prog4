namespace FactoryPattern.Models
{
    class CCRecipient : Recipient
    {
        public CCRecipient(string address)
        {
            base.address = address;
        }
    }
}
