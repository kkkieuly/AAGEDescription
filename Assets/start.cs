using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    public UDPReceive UDP;

    // Start is called before the first frame update
    void Start()
    {
        UDP.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
