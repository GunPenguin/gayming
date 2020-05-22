using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CustomerMessage {
    public static List<string> GetHelloMessages() {
        return CommonMessages.GetHelloMessages();
    }

    public static List<string> GetBuyMessages(){
        return CommonMessages.GetBuyMessages();
    }

    public static List<string> GetRandomMessages(){
        return CommonMessages.GetRandomMessages();
    }

    public static List<string> GetCorrectMessages(){
        return new List<string>{
            "Thanks a lot"
        };
    }

    public static List<string> GetAngryMessages(){
        return new List<string>{
            "Uhh.. That is not what i wanted. But I'm short on time.."
        };
    }

    public static List<string> GetShockedMessages(){
        return new List<string>{
            "What is that? Oh my god. I'd better leave",
            "You are a drug dealer! Oh shit",
            "Omg don't kill me I have children!",
            "What the hell.. Expect cops u bastard"
        };
    }

    public static List<string> GetIdleMessages(){
        return CommonMessages.GetIdleMessages();
    }
}
