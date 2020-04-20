using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Entities;
using UnityEngine;

public class ClientCharacter : MonoBehaviour, IClientCharacter
{
    public IFace Face { get; set; }
    public IProduct DesiredProduct { get; set; }
    public IDictionary<MessageType, string> Messages { get; set; }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
