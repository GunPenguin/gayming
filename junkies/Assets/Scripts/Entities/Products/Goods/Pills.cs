using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pills : MonoBehaviour, IGoods
{
    [SerializeField]
    public int buyPrice {get;} = 5;
    [SerializeField]
    public string productName {get;} = "Pills";
    [SerializeField]
    public string description {get;} = "Homeopatic pills";
}
