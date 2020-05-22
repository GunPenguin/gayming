using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMainCharacter
{
    Dictionary<string, int> Drugs { get; set; }
    int Cash { get; set; }
    int Day { get; set; }
    void AddMoney(int money);
    void TakeMoney(int money);
}