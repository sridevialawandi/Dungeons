using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonView : MonoBehaviour
{
    public GameObject Camera3;
    public GameObject Camera1;
    public int CamMode;


    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space))
       {
           if (CamMode==1){
               CamMode=0;
           }
           else{
               CamMode=CamMode+1;
           }
           StartCoroutine(CamChange());
       } 
    }
    IEnumerator CamChange(){
        yield return new WaitForSeconds(0.01f);
        if (CamMode==0){
            Camera3.SetActive(true);
            Camera1.SetActive(false);
        }
        if (CamMode==1){
            Camera3.SetActive(false);
            Camera1.SetActive(true);
        }
    }
}