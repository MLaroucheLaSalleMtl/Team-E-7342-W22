using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnCheckpoint : MonoBehaviour
{
    private GameObject RespawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        RespawnPoint = GetComponent<GameObject>();
    }

    public void RespawnEvent()
    {
        //if (isGameOver)
        //{

        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
