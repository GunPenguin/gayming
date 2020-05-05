using Assets.Scripts.Entities;
using Assets.Scripts.Entities.ClientCharacter;
using Assets.Scripts.Entities.MessagesStorage;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Cop : ClientCharacter
{
    public Cop(IFace face, IProduct product)
    {
        Face = face;
        DesiredProduct = product;
        Messages = GetMessages();
        Type = CharacterType.Cop;
    }

    private Dictionary<MessageType, string> GetMessages()
    {
        var messages = new Dictionary<MessageType, string>();

        var greetings = MessagesStorage.GetGreetingMessages();
        var copMessages = MessagesStorage.GetCopMessages();
        var purchaseMessages = MessagesStorage.GetPurchaseMessages(DesiredProduct);

        int randomMessageNumber = Random.Range(0, greetings.Count);
        messages.Add(MessageType.Greeting, greetings.ElementAt(randomMessageNumber));

        randomMessageNumber = Random.Range(0, copMessages.Count);
        messages.Add(MessageType.Cop, copMessages.ElementAt(randomMessageNumber));

        randomMessageNumber = Random.Range(0, purchaseMessages.Count);
        messages.Add(MessageType.Purchase, purchaseMessages.ElementAt(randomMessageNumber));

        return messages;
    }
}
