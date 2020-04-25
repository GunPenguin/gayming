using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IDrug : IProduct {
    [SerializeField]
    int sellPrice {get;}
}