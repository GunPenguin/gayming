using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DayGameManager : MonoBehaviour
{
    public GameObject GameOverScreen;
    public GameObject GameOverBackground;
    public GameObject moneyField;
    private bool isGameOver = false;
    public List<GameObject> textList;
    public GameObject faceHolder;
    private IFace customerFace;
    private MainCharacter mainCharacter = new MainCharacter();
    private List<IClientCharacter> clients;
    private Dictionary<string, string> currentMessages;
    private int clientNum = 0;
    private float timeBetweenCustomers = 2f;
    private float currentTimeBetweenCustomers = 0;
    // All fucking drug shit ass balls
    public GameObject WeedCount;
    public GameObject EcstasyCount;
    public GameObject MethCount;
    public GameObject CocaineCount;
    public GameObject MushroomCount;
    // Shitty dumb state machine heh
    private bool isCustomerHere = false;
    private bool isControlGivenToCustomer = false;
    private float messagePauseGeneral = 1.0f;
    private float messagePauseCurrent = 0;
    private int listCount = 0;
    // Transitions are: greeting -> buy -> random? -> idle -> (correct | angry | shocked)
    private string currentCustomerState;
    public AudioClip ambient;
    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        GameOverBackground.SetActive(false);
        GameOverScreen.SetActive(false);
        customerFace = faceHolder.GetComponent<Face>();
        mainCharacter.LoadFromPrefs();
        var randomNorm = Random.Range(5, 7);
        var randomJunk = Random.Range(1, 3);
        clients = new QueueGenerator(10, randomNorm, randomJunk, customerFace).generate();
        LoadDrugsToUI();
        moneyField.GetComponent<Text>().text = mainCharacter.Cash.ToString();
        source = GetComponent<AudioSource>();
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver){
            if (isControlGivenToCustomer){
                if (messagePauseGeneral > messagePauseCurrent) {
                    messagePauseCurrent += Time.deltaTime;
                } else {
                    messagePauseCurrent = 0;
                    switch (currentCustomerState){
                        case "greeting":
                            currentCustomerState = "buy";
                            textList[listCount].GetComponent<Text>().text = currentMessages["greeting"];
                            listCount++;
                            break;
                        case "buy":
                            currentCustomerState = "random";
                            textList[listCount].GetComponent<Text>().text = currentMessages["buy"];
                            listCount++;
                            break;
                        case "random":
                            if (currentMessages.ContainsKey("random")){
                                // Message out
                                textList[listCount].GetComponent<Text>().text = currentMessages["random"];
                                listCount++;
                            }
                            currentCustomerState = "idle";
                            break;
                        case "idle":
                            textList[listCount].GetComponent<Text>().text = currentMessages["idle"];
                            listCount++;
                            messagePauseCurrent = -2323232;
                            break;
                    }
                }
            } else {
                if (timeBetweenCustomers > currentTimeBetweenCustomers){
                    currentTimeBetweenCustomers += Time.deltaTime;
                } else {
                    currentTimeBetweenCustomers = 0;
                    SetupNext();
                }
            }
        }
    }

    public void CloseFace(){
        ((Face) customerFace).gameObject.SetActive(false);
        clientNum++;
        if (clientNum == clients.Count){
            SwitchToNight();
        }
    }


    // Private parts are shitcoded

    private void LoadDrugsToUI(){
        foreach (KeyValuePair<string, int> drugs in mainCharacter.Drugs){
            switch (drugs.Key){
                case "Weed":
                    WeedCount.GetComponent<Text>().text = drugs.Value.ToString();
                    break;
                case "Meth":
                    MethCount.GetComponent<Text>().text = drugs.Value.ToString();
                    break;
                case "Ecstasy":
                    EcstasyCount.GetComponent<Text>().text = drugs.Value.ToString();
                    break;
                case "Mushroom":
                    MushroomCount.GetComponent<Text>().text = drugs.Value.ToString(); 
                    break;
                case "Cocaine":
                    CocaineCount.GetComponent<Text>().text = drugs.Value.ToString();
                    break;
            }
        }
    }

    private void SetupNext(){
        Debug.Log(clients.Count);
        Debug.Log(clientNum);
        if (clientNum == clients.Count){
            SwitchToNight();
        }
        customerFace = (Face) clients[clientNum].Face;
        ((Face) customerFace).gameObject.SetActive(true);
        currentMessages = (Dictionary<string, string>) clients[clientNum].Messages;
        isControlGivenToCustomer = true;
        messagePauseCurrent = 0;
        currentCustomerState = "greeting";
        listCount = 0;
        ClearMessagesUI();
    }

    public void GiveCustomerProduct(string product){
        if (currentCustomerState != "random" && currentCustomerState != "idle"){
            return;
        }

        if (mainCharacter.Drugs.ContainsKey(product)){
            if (mainCharacter.Drugs[product] < 1) return;
            mainCharacter.Drugs[product]--;
            LoadDrugsToUI();
        }
        if (product == clients[clientNum].DesiredProduct.productName){
            if (currentMessages.ContainsKey("correct")){
                textList[listCount].GetComponent<Text>().text = currentMessages["correct"];
            }
            currentCustomerState = "correct";
            if (clients[clientNum].Type == Assets.Scripts.Entities.ClientCharacter.CharacterType.Cop){
                GameOver();
                return;
                // Game over
            }
            mainCharacter.AddMoney(clients[clientNum].DesiredProduct.sellPrice);
            moneyField.GetComponent<Text>().text = mainCharacter.Cash.ToString();
        } else {
            var drugList = new List<string>() {"Cocaine", "Ecstasy", "Meth", "Mushroom", "Weed"};
            if ((clients[clientNum].Type == Assets.Scripts.Entities.ClientCharacter.CharacterType.GoodsBuyer ||
                clients[clientNum].Type == Assets.Scripts.Entities.ClientCharacter.CharacterType.Cop) && 
                drugList.Exists(element => element == product)){
                    currentCustomerState = "shocked";
                    if (currentMessages.ContainsKey("shocked")){
                        textList[listCount].GetComponent<Text>().text = currentMessages["shocked"];
                    }
                    if (clients[clientNum].Type == Assets.Scripts.Entities.ClientCharacter.CharacterType.Cop){
                        GameOver();
                        return;
                        // Game over
                    }   
                    // Hysteria
            } else{
                currentCustomerState = "angry";
                if (currentMessages.ContainsKey("angry")){
                    textList[listCount].GetComponent<Text>().text = currentMessages["angry"];
                }
                // Wrong
            }
        }
        CloseFace();
        isControlGivenToCustomer = false;
    }

    private void ClearMessagesUI(){
        foreach (GameObject g in textList){
            g.GetComponent<Text>().text = "";
        }
    }

    private void GameOver(){
        isGameOver = true;
        GameOverScreen.SetActive(true);
        GameOverBackground.SetActive(true);
    }

    private void SwitchToNight(){
        mainCharacter.SaveToPrefs();
        PlayerPrefs.SetString("LastScene", "NightScene");
        SceneManager.LoadScene("NightScene");
    }

    public void ReloadCurrent(){
        SceneManager.LoadScene("SampleScene");
    }

    public void LoadMenu(){
        SceneManager.LoadScene("Menu");
    }
}
