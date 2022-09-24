using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTreasure : MonoBehaviour
{
    public GameObject TreasureBox;
    void Update()
    {
        int count=0;
        do 
        {
         if(Input.GetKeyDown("c"))
         {
             Vector3 randomSpawnPosition = new Vector3(Random.Range(-67, 67), -5.65f, Random.Range(-37, 23)); // -67 to 67 is width of ground place. -4 is the position of ground
             Instantiate(TreasureBox, randomSpawnPosition, Quaternion.identity);
            count++;
          }
        }while(count>5);
    }
}