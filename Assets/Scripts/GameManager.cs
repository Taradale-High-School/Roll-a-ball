using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject pickUp;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 4; i = i + 1)
        {
            float spawnPosX = Random.Range(-9, 9);
            float spawnPosY = Random.Range(-9, 9);
            Instantiate(pickUp, new Vector3(spawnPosX, 0.5f, spawnPosY), pickUp.transform.rotation);
        }

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
