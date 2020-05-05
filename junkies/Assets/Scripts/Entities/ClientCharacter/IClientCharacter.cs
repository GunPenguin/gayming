using Assets.Scripts.Entities;
using Assets.Scripts.Entities.ClientCharacter;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IClientCharacter
{
    IFace Face{ get; set; }
    IProduct DesiredProduct { get; set; }
    IDictionary<MessageType, string> Messages { get; set; }
    CharacterType Type { get; }
}
