using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weed : IDrug
{
    public int sellPrice {get;} = 12;
    public int buyPrice {get;} = 5;
    public string productName {get;} = "Weed";
    public string description {get;} = "Snoop's choice";
}
