using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

public static GameManager Instance;

public int changeNumber;

public int numBlanks;

public TestView engUpdate;
public ButtonText gerUpdate0;
public ButtonText gerUpdate1;
public ButtonText gerUpdate2;
public ButtonText gerUpdate3;
public ButtonText gerUpdate4;

public TMP_Text wrong;

void Awake()
{
    //singleton
    if (Instance == null)
    {
        DontDestroyOnLoad(gameObject);
        Instance = this;
    }
    else
    {
        Destroy(gameObject);
    }
    //makes the WRONG disappear
    wrong.gameObject.SetActive(false);
}

// Start is called before the first frame update
    void Start()
    {
        wrong.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if we've clicked on the same number of words as there are blanks
        if (numBlanks == changeNumber)
        {
            //engUpdate.UpdateEnglish();
            //gerUpdate0.ChangeButtonText();
            //gerUpdate1.ChangeButtonText();
           // gerUpdate2.ChangeButtonText();
           // gerUpdate3.ChangeButtonText();
           // gerUpdate4.ChangeButtonText();
            ShowWrong();
            //Invoke("Reload", 3f);
        }

        //reload on space
        if (Input.GetKey(KeyCode.Space))
        {
            Reload();
        }
        
    }

    void ShowWrong()
    {
        wrong.gameObject.SetActive(true);
    }

    void Reload()
    {
        SceneManager.LoadScene(0);
    }
    
}
