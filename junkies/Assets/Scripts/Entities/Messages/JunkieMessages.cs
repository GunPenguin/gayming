using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class JunkieMessages
{
    public static List<string> GetHelloMessages() {
        List<string> ss = new List<string>(){
            "Hey maaaaan",
            "IM PICKLE RICK!!",
            "Did you stole my nose?? Just kidding",
            "Hello, lol, your face is so funny"
        };
        foreach (string s in CustomerMessage.GetHelloMessages()){
            ss.Add(s);
        }
        return ss;
    }

    public static List<string> GetBuyMessages(){
        List<string> ss = new List<string>(){
            "We'd like to buy ",
            "I want to get ahahahahha ",
            "I whant.. wath.. want to get ",
            "Can you give me give me "
        };
        foreach (string s in CustomerMessage.GetBuyMessages()){
            ss.Add(s);
        }
        return ss;
    }

    public static List<string> GetRandomMessages(){
        List<string> ss = new List<string>(){
            "Woah do are you always so bright?",
            "Where is your nose?",
            "Sometimes i dream about PONIES and TESTICLES",
            "Where is my gun.. It is in the pants",
            "Life is sooo good man"
        };
        return ss;
    }

    public static List<string> GetCorrectMessages(){
        return new List<string>(){
            "Thanks piggie",
            "NICE MAAAN"
        };
    }

    public static List<string> GetAngryMessages(){
        return new List<string>(){
            "Whadda hell man I go somwhere else ok"
        };
    }

    public static List<string> GetIdleMessages(){
        List<string> ss = new List<string>(){
            "What a beautiful day outside...",
            "Can you give me GIVE ME OK"
        };
        foreach (string s in CustomerMessage.GetIdleMessages()){
            ss.Add(s);
        }
        return ss;
    }
}
