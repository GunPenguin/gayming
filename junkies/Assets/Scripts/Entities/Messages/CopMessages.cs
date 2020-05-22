using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CopMessages
{
    public static List<string> GetHelloMessages() {
        List<string> ss = new List<string>(){
            "Hello, my dear",
            "Well, i was woundering",
            "Well, well, well..",
            "HHEY IM NARCO"
        };
        foreach (string s in CustomerMessage.GetHelloMessages()){
            ss.Add(s);
        }
        return ss;
    }

    public static List<string> GetBuyMessages(){
        return JunkieMessages.GetBuyMessages();
    }

    public static List<string> GetRandomMessages(){
        List<string> ss = new List<string>(){
            "~pssshshs 'Calling patrol I-I232' ~click",
            "~pssshshs 'Calling patrol I-I232' ~click",
            "~pssshshs 'Calling patrol I-I232' ~click",
            "~pssshshs 'Calling patrol I-I232' ~click",
            "~pssshshs 'Calling patrol I-I232' ~click",
            "~pssshshs 'Calling patrol I-I232' ~click",
            "~pssshshs 'Calling patrol I-I232' ~click",
            "~pssshshs 'Calling patrol I-I232' ~click",
            "~pssshshs 'Calling patrol I-I232' ~click",
            "Where is my badg... Khm",
            "Where is my badg... Khm",
            "Where is my badg... Khm",
            "Where is my badg... Khm",
            "Where is my badg... Khm",
            "Where is my badg... Khm",
            "Where is my badg... Khm",
            "Where is my badg... Khm",
            "Where is my badg... Khm",
            "Where is my badg... Khm",
            "Where is my badg... Khm",
        };
        foreach (string s in CustomerMessage.GetRandomMessages()){
            ss.Add(s);
        }
        return ss; 
    }

    public static List<string> GetCorrectMessages(){
        return new List<string>
            {
                "You are caught red-handed. You have the right to remain silent. Everything you say can be used against you."
            };
    }

    public static List<string> GetIdleMessages(){
        return CommonMessages.GetIdleMessages();
    }
}
