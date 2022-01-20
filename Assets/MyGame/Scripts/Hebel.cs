using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using Microsoft.Unity.VisualStudio.Editor.Messaging;
using Microsoft.Unity.VisualStudio.Editor.Testing;
using UnityEditor;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.Requests;
using UnityEngine;
using MessageType = Microsoft.Unity.VisualStudio.Editor.Messaging;

public class Hebel : MonoBehaviour
{

    private int hebelCount;
    private Vector3 hebelSwitch;

    public GameObject LeftHandController;
    public GameObject HebelSwitch;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "LeftHandController")
        {
            print("eeeeeeeeeee");
            hebelCount++;
        }

        if (hebelCount == 1)
        {
            HebelSwitch.transform.Rotate(0, 180, 0);
            print("123123123");
        }  
        
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
