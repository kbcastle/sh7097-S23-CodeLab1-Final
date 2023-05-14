using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
 //change text color when clicked, add 1 to the counter of how many words have been clicked
    public void ButtonChange()
    {
        GetComponentInChildren<TMP_Text>().color = Color.red;
        GameManager.Instance.changeNumber++;
    }
}
