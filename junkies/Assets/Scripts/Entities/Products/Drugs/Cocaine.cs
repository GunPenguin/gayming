using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cocaine : MonoBehaviour, IDrug
{
    public int sellPrice {get;} = 50;
    public int buyPrice {get;} = 30;
    public string productName {get;} = "Cocaine";
    public string description {get;} = "High-end white drug";
}
