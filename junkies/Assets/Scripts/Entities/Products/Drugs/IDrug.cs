using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDrug : IProduct {
    [SerializeField]
    int buyPrice {get;}
}