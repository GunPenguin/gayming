
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : MonoBehaviour, IMainCharacter
{
    public ICollection<IDrug> Drugs { get; private set; }
    public int Cash { get; private set; }
    public event System.Action<IMainCharacter> OnMoneyRanOut;
    public event System.Action<int> OnMoneyTake;
    public event System.Action<int> OnMoneyAdd;

    public void AddMoney(int money){
        Cash += money;
        OnMoneyAdd(money);
    }

    public void TakeMoney(int money){
        Cash -= money;
        OnMoneyTake(money);
        if(Cash <= 0)
            OnMoneyRanOut?.Invoke(this);
    }
}
