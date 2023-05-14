using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonText : MonoBehaviour
{
    public GermanWords germanDisplay;

    public List<GermanWords> german;

    public Button germanWord;

    public int germanIndex;
    // Start is called before the first frame update
    void Start()
    {
        ChangeButtonText();
        german.RemoveAt(germanIndex);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //pick a random spot in the list and assign that word to a button text field
    public void ChangeButtonText()
    {
        germanIndex = Random.Range(0, 19);
        GetComponentInChildren<TMP_Text>().text = german[germanIndex].word;
        german.RemoveAt(germanIndex); //remove that word from the list to avoid repeats -- I don't think this works
    }
    
    
}
