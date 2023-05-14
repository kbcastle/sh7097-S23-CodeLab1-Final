using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestView : MonoBehaviour
{
    
    public EnglishPhrases englishDisplay;

    public List<EnglishPhrases> english;

    //public int numBlanks;
    

    public int englishIndex;

   
    // Start is called before the first frame update
    void Start()
    {
        UpdateEnglish();
        // englishIndex = Random.Range(0, 9);
       // GetComponent<TextMeshProUGUI>().text = english[englishIndex].phrase;
       // numBlanks = english[englishIndex].numOfBlanks;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
   //pick a random position in the list, take the text from that scriptable object
    public void UpdateEnglish()
    {
        englishIndex = Random.Range(0, 9);
        GetComponent<TextMeshProUGUI>().text = english[englishIndex].phrase;
        GameManager.Instance.numBlanks = english[englishIndex].numOfBlanks; //set number of blanks equal to the number of blanks from that specific scriptable object
    }
}

