using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//scriptable objects for words
[CreateAssetMenu(
    fileName = "New German Word",
    menuName = "ScriptableObjects/German",
    order = 0
)]

public class GermanWords : ScriptableObject
{
    public string word;
}
