using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;
    [SerializeField]
    private GameObject blueObj;

    Vector3 redPos = new Vector3(2, 0, 0);
    Vector3 bluePos = new Vector3(-2, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(redObj, redPos, Quaternion.identity);
        Instantiate(blueObj, bluePos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
