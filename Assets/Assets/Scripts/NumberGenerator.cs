using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGenerator : MonoBehaviour
{
    
    void Start()
    {
        int count =0;
        while(count < 20 ){
            int r = Random.Range(1,21);
            if(r==5){
                Debug.Log("c");
                continue;
            }if(r==15){
                Debug.Log(r);
                break;
            }else
            Debug.Log(r);
            count++;

        }
        
    }

    
    void Update()
    {
        
    }
}
