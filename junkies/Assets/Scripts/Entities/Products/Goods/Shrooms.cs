using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrooms : MonoBehaviour, IGoods
{
    [SerializeField]
    public int buyPrice {get;} = 5;
    [SerializeField]
    public string productName {get;} = "Canned mushrooms";
    [SerializeField]
    public string description {get;} = "Can of mushrooms of unknown origin";
}
