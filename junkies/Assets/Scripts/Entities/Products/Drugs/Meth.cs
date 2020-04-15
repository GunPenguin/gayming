using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meth : MonoBehaviour, IDrug
{
    public int sellPrice {get;} = 35;
    public int buyPrice {get;} = 20;
    public string productName {get;} = "Meth";
    public string description {get;} = "Blue-crystalled drug";
}
