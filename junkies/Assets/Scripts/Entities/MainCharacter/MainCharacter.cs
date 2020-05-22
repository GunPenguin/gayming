
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainCharacter : MonoBehaviour, IMainCharacter
{
    public Dictionary<string, int> Drugs { get; set; } = new Dictionary<string, int>();
    public int Cash { get; set; }
    public int Day { get;  set; }
    public void AddMoney(int money){
        Cash += money;
    }

    public void TakeMoney(int money){
        Cash -= money;
    }

    public void LoadFromPrefs(){
        Cash = PlayerPrefs.GetInt("Money");
        Day = PlayerPrefs.GetInt("Day");
        Drugs.Add("Cocaine", PlayerPrefs.GetInt("Cocaine"));
        Drugs.Add("Ecstasy", PlayerPrefs.GetInt("Ecstasy"));
        Drugs.Add("Meth", PlayerPrefs.GetInt("Meth"));
        Drugs.Add("Mushroom", PlayerPrefs.GetInt("Mushroom"));
        Drugs.Add("Weed", PlayerPrefs.GetInt("Weed"));
    }
    public void ClearPrefs(){
        PlayerPrefs.DeleteAll();
    }
    
    public void SaveToPrefs(){
        PlayerPrefs.SetInt("Money", Cash);
        PlayerPrefs.SetInt("Day", Day);
        foreach(KeyValuePair<string, int> pair in Drugs){
            PlayerPrefs.SetInt(pair.Key, pair.Value);
        }
    }
}
