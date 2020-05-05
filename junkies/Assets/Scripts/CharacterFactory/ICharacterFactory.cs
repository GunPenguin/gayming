using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacterFactory
{
    IClientCharacter CreateCop(IFace face, IDrug drug);
    IClientCharacter CreateDrugsBuyer(IFace face, IDrug drug);
    IClientCharacter CreateGoodsBuyer(IFace face, IProduct product);
}
