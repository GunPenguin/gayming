using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Entities;
using Assets.Scripts.Entities.ClientCharacter;
using UnityEngine;

public abstract class ClientCharacter : IClientCharacter
{
    public IFace Face { get; set; }
    public IProduct DesiredProduct { get; set; }
    public IDictionary<string, string> Messages { get; set; }
    public CharacterType Type { get; protected set; }
    public void Update(){}
}
