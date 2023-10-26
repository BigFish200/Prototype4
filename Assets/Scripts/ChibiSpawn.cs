using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChibiSpawn : MonoBehaviour
{
    public GameObject[] chibiPrefabs;
    public int chibiIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            chibiIndex = Random.Range(0, chibiPrefabs.Length);
            Instantiate(chibiPrefabs[chibiIndex], new Vector3(14, 20, 7), chibiPrefabs[chibiIndex].transform.rotation);
        }
    }
}
