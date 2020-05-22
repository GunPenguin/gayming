using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NightGameManager : MonoBehaviour
{
    // All fucking drug shit ass balls
    public GameObject WeedCount;
    public GameObject EcstasyCount;
    public GameObject MethCount;
    public GameObject CocaineCount;
    public GameObject MushroomCount;
    public GameObject WeedPrice;
    public GameObject EcstasyPrice;
    public GameObject CocainePrice;
    public GameObject MethPrice;
    public GameObject MushroomPrice;
    public GameObject CurrentMoney;
    public GameObject RentPay;
    public GameObject TotalLeft;
    public GameObject DayNO;
    private MainCharacter mainCharacter = new MainCharacter();
    // Start is called before the first frame update
    void Start()
    {
        Reset();
    }

     private void LoadDrugsToUI(){
        foreach (KeyValuePair<string, int> drugs in mainCharacter.Drugs){
            switch (drugs.Key){
                case "Weed":
                    WeedCount.GetComponent<Text>().text = drugs.Value.ToString();
                    WeedPrice.GetComponent<Text>().text = new Weed().buyPrice.ToString() + "$";
                    break;
                case "Meth":
                    MethCount.GetComponent<Text>().text = drugs.Value.ToString();
                    MethPrice.GetComponent<Text>().text = new Meth().buyPrice.ToString() + "$";
                    break;
                case "Ecstasy":
                    EcstasyCount.GetComponent<Text>().text = drugs.Value.ToString();
                    EcstasyPrice.GetComponent<Text>().text = new Ecstasy().buyPrice.ToString() + "$";
                    break;
                case "Mushroom":
                    MushroomCount.GetComponent<Text>().text = drugs.Value.ToString(); 
                    MushroomPrice.GetComponent<Text>().text = new Mushroom().buyPrice.ToString() + "$";
                    break;
                case "Cocaine":
                    CocaineCount.GetComponent<Text>().text = drugs.Value.ToString();
                    CocainePrice.GetComponent<Text>().text = new Cocaine().buyPrice.ToString() + "$";
                    break;
            }
        }
    }

    public void BuyDrug(string name){
        IDrug drug = null;
        switch (name){
            case "Weed":
                drug = new Weed();
                break;
            case "Meth":
                drug = new Meth();
                break;
            case "Ecstasy":
                drug = new Ecstasy();
                break;
            case "Mushroom":
                drug = new Mushroom();
                break;
            case "Cocaine":
                drug = new Cocaine();
                break;
        }
        if (mainCharacter.Cash - drug.buyPrice < 0) return;

        mainCharacter.Cash -= drug.buyPrice;
        mainCharacter.Drugs[drug.productName]++;
        TotalLeft.GetComponent<Text>().text = mainCharacter.Cash.ToString();
        switch (name){
            case "Weed":
                WeedCount.GetComponent<Text>().text = mainCharacter.Drugs[drug.productName].ToString();
                break;
            case "Meth":
                MethCount.GetComponent<Text>().text = mainCharacter.Drugs[drug.productName].ToString();
                break;
            case "Ecstasy":
                EcstasyCount.GetComponent<Text>().text = mainCharacter.Drugs[drug.productName].ToString();
                break;
            case "Mushroom":
                MushroomCount.GetComponent<Text>().text = mainCharacter.Drugs[drug.productName].ToString();
                break;
            case "Cocaine":
                CocaineCount.GetComponent<Text>().text = mainCharacter.Drugs[drug.productName].ToString();
                break;
        }
        // uiElement.GetComponent<Text>().text = mainCharacter.Drugs[drug.productName].ToString();
    }

    public void Reset(){
        mainCharacter = new MainCharacter();
        mainCharacter.LoadFromPrefs();
        LoadDrugsToUI();
        DayNO.GetComponent<Text>().text = mainCharacter.Day.ToString();
        CurrentMoney.GetComponent<Text>().text = mainCharacter.Cash.ToString();
        RentPay.GetComponent<Text>().text = (mainCharacter.Day * 10).ToString();
        mainCharacter.Cash -= (mainCharacter.Day * 10);
        TotalLeft.GetComponent<Text>().text = mainCharacter.Cash.ToString();
    }

    public void NextDay(){
        if (mainCharacter.Cash < 0) {
            SceneManager.LoadScene("GameOverScene");
        }
        if (mainCharacter.Cash >= 1000) {
            SceneManager.LoadScene("WinScene");
        }
        mainCharacter.Day += 1;
        mainCharacter.SaveToPrefs();
        PlayerPrefs.SetString("LastScene", "SampleScene");
        SceneManager.LoadScene("SampleScene");
    }
}
