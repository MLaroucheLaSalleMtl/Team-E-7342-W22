using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    //public GameObject trigger;
    //GameObject trigger1;
    public GameObject[] spawnPoint;
    public GameObject enemy;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
        //trigger = GetComponentInChildren<GameObject>();
        target = GameObject.FindGameObjectWithTag("Player");
        spawnPoint = new GameObject[3];
        for(int i =0;i< spawnPoint.Length; i++)
        {
             spawnPoint[i] = transform.GetChild(i).gameObject;
        }
    }

    private void SpawnEnemy()
    {
        
        int spawnID = Random.Range(0, spawnPoint.Length);
        Instantiate(enemy, spawnPoint[spawnID].transform.position, spawnPoint[spawnID].transform.rotation);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Invoke("SpawnEnemy", 0.5f);
            gameObject.GetComponent<Collider>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //float dist = Vector3.Distance(transform.position, target.transform.position);
        if (Input.GetKeyDown(KeyCode.E))
        {
            SpawnEnemy();
        }
    }
}
