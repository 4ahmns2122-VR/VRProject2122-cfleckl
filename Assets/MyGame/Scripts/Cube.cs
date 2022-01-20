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
public class Cube : MonoBehaviour
{

    private int ballCount;

    public GameObject ChristmasBall;
    public GameObject Hebel;

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "ChristmasBall")
        {
            ballCount++;
        }
       
        if (ballCount == 3)
        {
            print("3333333");
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
