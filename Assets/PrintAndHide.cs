using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    int i;
    public Renderer rend;
    int random;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        random = Random.Range(199, 250);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + ": " + i);
        i++;
        if (gameObject.tag == "Blue" && i == random)
        {
            rend.enabled = false;
        }
        if (gameObject.tag == "Red" && i == 100)
        {
            gameObject.SetActive(false);
        }
    }
}
