using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groceries : MonoBehaviour, IGoods
{
    [SerializeField]
    public int buyPrice {get;} = 2;
    [SerializeField]
    public string productName {get;} = "Groceries";
    [SerializeField]
    public string description {get;} = "Groceries of different type";
}
