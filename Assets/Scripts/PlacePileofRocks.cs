using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacePileofRocks : MonoBehaviour
{
 public GameObject Rubble;
    void Update()
    {
        var count=0;
        if(Input.GetKeyDown("c"))
        {
            count++;
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-67, 67), -3.55f, Random.Range(-37, 23)); // -67 to 67 is width of ground place. -4 is the position of ground
            Instantiate(Rubble, randomSpawnPosition, Quaternion.identity);
        } 
    }
}