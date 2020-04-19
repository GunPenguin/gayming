using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMainCharacter
{
    ICollection<IDrug> Drugs { get; }
    int Cash { get; }
    void AddMoney(int money);
    void TakeMoney(int money);
    event System.Action<IMainCharacter> OnMoneyRanOut;
    event System.Action<int> OnMoneyTake;
    event System.Action<int> OnMoneyAdd;
}
