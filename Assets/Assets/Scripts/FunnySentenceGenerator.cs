using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class FunnySentenceGenerator : MonoBehaviour
{
    
    void Start()
    {
        string[] words={"Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird"}; 

        int index;
        int count = 7;
        String funnySentence= "";
        while(count >0){
            index = UnityEngine.Random.Range(0,words.Length);
            funnySentence+=words[index]+ " ";
            count--;

        }
          Debug.Log(funnySentence);
        
    }
    
}
