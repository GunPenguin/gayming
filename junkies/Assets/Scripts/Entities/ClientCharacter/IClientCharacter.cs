using Assets.Scripts.Entities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IClientCharacter
{
    IFace Face{ get; set; }
    IProduct DesiredProduct { get; set; }
    IDictionary<MessageType, string> Messages { get; set; }
}
