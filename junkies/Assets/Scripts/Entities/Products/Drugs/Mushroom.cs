using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : IDrug
{
    public int sellPrice {get;} = 90;
    public int buyPrice {get;} = 50;
    public string productName {get;} = "Mushroom";
    public string description {get;} = "Mushrooms of unknown origin";
}
