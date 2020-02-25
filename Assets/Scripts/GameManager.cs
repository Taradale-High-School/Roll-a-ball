using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Set public variables


    // variables related to the game objects
    public GameObject pickUp;
    public GameObject dropDown;
    private int numberOfPickUps = 2;
    private int numberOfDropDowns = 12;
    private float spawnRangeX = 9;
    private float spawnRangeY = 9;

    // Variables related to displaying the score and winstate
    public Text countText;
    public Text winText;
    private int count = 0;
    public bool isGameActive;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfPickUps; i++)
        {
            spawnObject(pickUp);
        }

        for (int i = 0; i < numberOfDropDowns; i++)
        {

            spawnObject(dropDown);
        }

        SetCountText();
        winText.text = "";
        isGameActive = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void increaseCount()
    {
        count = count + 1;
        SetCountText();
    }

    public void descreaseCount()
    {
        count = count - 1;
        SetCountText();
    }

    private void SetCountText()
    {

        countText.text = "Count : " + count.ToString();
        if (count >= numberOfPickUps)
        {
            winText.text = "You win!!";
            isGameActive = false;
        } else if (count < 0)
        {
            winText.text = "You Lose!!";
            isGameActive = false;
        } 
    }

    void spawnObject(GameObject shape)
    {
        float spawnPosX = Random.Range(-spawnRangeX, spawnRangeX);
        float spawnPosZ = Random.Range(-spawnRangeY, spawnRangeY);
        Instantiate(shape, new Vector3(spawnPosX, 0.5f, spawnPosZ), pickUp.transform.rotation);
    }
}
