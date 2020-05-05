using Assets.Scripts.Entities;
using Assets.Scripts.Entities.ClientCharacter;
using Assets.Scripts.Entities.MessagesStorage;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GoodsBuyer : ClientCharacter
{
    public GoodsBuyer(IFace face, IProduct product)
    {
        Face = face;
        DesiredProduct = product;
        Messages = GetMessages();
        Type = CharacterType.GoodsBuyer;
    }

    private Dictionary<MessageType, string> GetMessages()
    {
        var messages = new Dictionary<MessageType, string>();

        var greetings = MessagesStorage.GetGreetingMessages();
        var purchaseMessages = MessagesStorage.GetPurchaseMessages(DesiredProduct);
        var thanksMessages = MessagesStorage.GetThanksMessages();

        int randomMessageNumber = Random.Range(0, greetings.Count - 1);
        messages.Add(MessageType.Greeting, greetings.ElementAt(randomMessageNumber));

        randomMessageNumber = Random.Range(0, purchaseMessages.Count - 1);
        messages.Add(MessageType.Purchase, purchaseMessages.ElementAt(randomMessageNumber));

        randomMessageNumber = Random.Range(0, thanksMessages.Count - 1);
        messages.Add(MessageType.Thanks, thanksMessages.ElementAt(randomMessageNumber));

        return messages;
    }
}
