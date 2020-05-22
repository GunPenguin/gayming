using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrooms : IGoods
{
    [SerializeField]
    public int sellPrice {get;} = 5;
    [SerializeField]
    public string productName {get;} = "Canned mushrooms";
    [SerializeField]
    public string description {get;} = "Can of mushrooms of unknown origin";
}
