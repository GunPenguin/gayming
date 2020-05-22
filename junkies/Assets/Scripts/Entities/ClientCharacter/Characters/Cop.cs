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

    private Dictionary<string, string> GetMessages()
    {
        var messages = new Dictionary<string, string>();

        var greetings = CopMessages.GetHelloMessages();
        var buys = CopMessages.GetBuyMessages();
        var randoms = CopMessages.GetRandomMessages();
        var correct = CopMessages.GetCorrectMessages();
        var idles = CopMessages.GetIdleMessages();

        int randomMessageNumber = Random.Range(0, greetings.Count);
        messages.Add("greeting", greetings.ElementAt(randomMessageNumber));

        randomMessageNumber = Random.Range(0, buys.Count);
        messages.Add("buy", buys.ElementAt(randomMessageNumber) + DesiredProduct);

        randomMessageNumber = Random.Range(0, randoms.Count);
        messages.Add("random", randoms.ElementAt(randomMessageNumber));
        
        randomMessageNumber = Random.Range(0, idles.Count);
        messages.Add("idle", idles.ElementAt(randomMessageNumber));

        randomMessageNumber = Random.Range(0, correct.Count);
        messages.Add("correct", correct.ElementAt(randomMessageNumber));
        messages.Add("shocked", correct.ElementAt(randomMessageNumber));
        messages.Add("angry", "Hmm, so you're clear");
        return messages;
    }
}
