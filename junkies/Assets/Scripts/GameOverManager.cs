using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MainCharacter mainCharacter = new MainCharacter();
        mainCharacter.ClearPrefs();
    }

    // Update is called once per frame
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
