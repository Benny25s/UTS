using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObs : MonoBehaviour
{
    public GameObject zombies;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObstacle", 1f, 2.5f);
    }
    void CreateObstacle()
    {
        Instantiate(zombies);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
