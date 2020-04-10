using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candies : MonoBehaviour, IGoods
{
    [SerializeField]
    public int buyPrice {get;} = 4;
    [SerializeField]
    public string productName {get;} = "Candy";
    [SerializeField]
    public string description {get;} = "Yummy blue candies";
}
