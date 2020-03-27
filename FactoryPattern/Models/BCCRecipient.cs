namespace FactoryPattern.Models
{
    class BCCRecipient : Recipient
    {
        public BCCRecipient(string address)
        {
            base.address = address;
        }
    }
}
