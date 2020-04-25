using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flour : MonoBehaviour, IGoods
{
    [SerializeField]
    public int buyPrice {get;} = 3;
    [SerializeField]
    public string productName {get;} = "Flour";
    [SerializeField]
    public string description {get;} = "White powder from which bread is created";
}
