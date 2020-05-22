using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pills : IGoods
{
    [SerializeField]
    public int sellPrice {get;} = 5;
    [SerializeField]
    public string productName {get;} = "Pills";
    [SerializeField]
    public string description {get;} = "Homeopatic pills";
}
