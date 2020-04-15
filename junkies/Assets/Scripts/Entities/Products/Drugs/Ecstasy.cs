using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Ecstasy : MonoBehaviour, IDrug
{
    public int sellPrice {get;} = 25;
    public int buyPrice {get;} = 15;
    public string productName {get;} = "Ecstasy";
    public string description {get;} = "Drug in form of cylinder pills";
}
