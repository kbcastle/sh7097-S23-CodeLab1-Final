using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//make scriptable objects for phrases
[CreateAssetMenu(
    fileName = "New English Phrase",
    menuName = "ScriptableObjects/English",
    order = 0
)]

public class EnglishPhrases : ScriptableObject
{
    public string phrase;
    public int numOfBlanks;
}
