using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DescSend : MonoBehaviour
{

    public UDPReceive udpReceive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(udpReceive.lastReceivedUDPPacket != "")
        this.gameObject.GetComponent<Text>().text = udpReceive.lastReceivedUDPPacket;
    }
}
