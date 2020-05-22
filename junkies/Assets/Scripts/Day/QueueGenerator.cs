using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueGenerator : MonoBehaviour
{
    int people { get; }
    int cops { get; }
    int normies { get; }
    int junkies { get; }
    CharacterFactory characterFactory;
    List<IDrug> drugs = new List<IDrug>();
    List<IProduct> products = new List<IProduct>();
    Random random = new Random();
    Face customerFace;
    public QueueGenerator(int people, int normies, int junkies, IFace customerFace){
        this.customerFace = Instantiate((Face) customerFace);

        this.people = people;
        this.normies = normies;
        this.junkies = junkies;
        this.cops = this.people - normies - junkies;
        characterFactory = new CharacterFactory();

        drugs.Add(new Cocaine());
        drugs.Add(new Ecstasy());
        drugs.Add(new Meth());
        drugs.Add(new Mushroom());
        drugs.Add(new Weed());

        products.Add(new Candies());
        products.Add(new Flour());
        products.Add(new Groceries());
        products.Add(new Pills());
        products.Add(new Shrooms());
    }

    public List<IClientCharacter> generate(){
        List<IClientCharacter> charList = new List<IClientCharacter>();
        for (int i = 0; i < normies; i++){
            int index = Random.Range(0, products.Count);
            charList.Add(characterFactory.CreateGoodsBuyer(Instantiate(customerFace), products[index]));
            Face face = (Face) charList[charList.Count - 1].Face;
            face.gameObject.SetActive(false);
        }
        for (int i = 0; i < junkies; i++) {
            int index = Random.Range(0, drugs.Count);
            charList.Add(characterFactory.CreateDrugsBuyer(Instantiate(customerFace), drugs[index]));
            Face face = (Face) charList[charList.Count - 1].Face;
            face.gameObject.SetActive(false);
        }
        for (int i = 0; i < cops; i++) {
            int index = Random.Range(0, drugs.Count);
            charList.Add(characterFactory.CreateCop(Instantiate(customerFace), drugs[index]));
            Face face = (Face) charList[charList.Count - 1].Face;
            face.gameObject.SetActive(false);
        }
        List<IClientCharacter> newList = new List<IClientCharacter>();
        var a = charList.Count;
        for (int i = 0; i < a; i++){
            int randNum = Random.Range(0, charList.Count);
            newList.Add(charList[randNum]);
            charList.Remove(charList[randNum]);
        }
        return newList;
    }
}
