using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise04 : MonoBehaviour
{
    public string[] words;
    private string RandomWord()
    {
        int randomIndex = Random.Range(0, words.Length);
        return words[randomIndex];
    }
}
