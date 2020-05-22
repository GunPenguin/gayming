using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject LastSave;
    public AudioClip MMMusic;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Day") != 0){
            var textField = LastSave.GetComponent<Text>();
            string tmpText = "Day ";
            tmpText += PlayerPrefs.GetInt("Day").ToString();
            tmpText += ", ";
            if (PlayerPrefs.GetString("LastScene") == "SampleScene") {
                tmpText += "daytime, ";
            } else {
                tmpText += "nighttime, ";
            }
            tmpText += PlayerPrefs.GetInt("Money").ToString() + "$";
            textField.text = tmpText;
        }
        GetComponent<AudioSource>().PlayOneShot(MMMusic);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Continue(){
        SceneManager.LoadScene(PlayerPrefs.GetString("LastScene"));
    }

    public void NewGame(){
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("Money", 20);
        PlayerPrefs.SetInt("Day", 1);
        PlayerPrefs.SetInt("Cocaine", 0);
        PlayerPrefs.SetInt("Weed", 3);
        PlayerPrefs.SetInt("Meth", 0);
        PlayerPrefs.SetInt("Mushroom", 0);
        PlayerPrefs.SetInt("Ecstasy", 2);
        PlayerPrefs.SetString("LastScene", "SampleScene");
        SceneManager.LoadScene("SampleScene");
    }

    public void Exit(){
        Application.Quit();
    }
}
