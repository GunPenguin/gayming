using System.Collections.Generic;

namespace Assets.Scripts.Entities.MessagesStorage
{
    public static class MessagesStorage
    {
        public static ICollection<string> GetGreetingMessages()
        {
            return new List<string>
            {
                "Yo!",
                "Hello.",
                "Wazap niga"
            };
        }

        public static ICollection<string> GetCopMessages()
        {
            return new List<string>
            {
                "You are caught red-handed. You have the right to remain silent. Everything you say can be used against you."
            };
        }

        public static ICollection<string> GetPurchaseMessages(IProduct product)
        {
            return new List<string>
            {
                "I need " + product.productName,
                "Gimme " + product.productName,
                "Faster, " + product.productName,
                "Give me please " + product.productName
            };
        }

        public static ICollection<string> GetThanksMessages()
        {
            return new List<string>
            {
                "Thanks.",
                "Ty.",
                "Thank you!",
            };
        }
    }
}
