using Assets.Scripts.Entities;
using Assets.Scripts.Entities.ClientCharacter;
using Assets.Scripts.Entities.MessagesStorage;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DrugBuyer : ClientCharacter
{
    public DrugBuyer(IFace face, IProduct product)
    {
        Face = face;
        DesiredProduct = product;
        Messages = GetMessages();
        Type = CharacterType.DrugBuyer;
    }

    private Dictionary<string, string> GetMessages()
    {
        var messages = new Dictionary<string, string>();

        var greetings = JunkieMessages.GetHelloMessages();
        var buys = JunkieMessages.GetBuyMessages();
        var randoms = JunkieMessages.GetRandomMessages();
        var correct = JunkieMessages.GetCorrectMessages();
        var idles = JunkieMessages.GetIdleMessages();
        var angry = JunkieMessages.GetAngryMessages();

        int randomMessageNumber = Random.Range(0, greetings.Count);
        messages.Add("greeting", greetings.ElementAt(randomMessageNumber));

        randomMessageNumber = Random.Range(0, buys.Count);
        messages.Add("buy", buys.ElementAt(randomMessageNumber)  + DesiredProduct);
        if (Random.Range(0, 10) > 5){
            randomMessageNumber = Random.Range(0, randoms.Count);
            messages.Add("random", randoms.ElementAt(randomMessageNumber));
        }
        randomMessageNumber = Random.Range(0, correct.Count);
        messages.Add("correct", correct.ElementAt(randomMessageNumber));
        
        randomMessageNumber = Random.Range(0, idles.Count);
        messages.Add("idle", idles.ElementAt(randomMessageNumber));

        randomMessageNumber = Random.Range(0, angry.Count);
        messages.Add("angry", angry.ElementAt(randomMessageNumber));
        return messages;
    }
}
