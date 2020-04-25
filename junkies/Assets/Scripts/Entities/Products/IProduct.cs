using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IProduct{
    [SerializeField]
    int buyPrice {get;}
    [SerializeField]
    string productName {get;}
    [SerializeField]
    string description {get;}
}
