using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IClientCharacter
{
    IFace Face{ get; set; }
    IProduct DesiredProduct { get; set; }
    IDictionary<IMessageType, string> Messages { get; set; }
}
