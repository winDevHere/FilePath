using UnityEngine;
using System.IO;

public class SimplestFilePath : MonoBehaviour
{
    public string path;

    void Start()
    {
        if (File.Exists(path))
            Debug.Log("File exist");
        else
            Debug.Log("File does not exist");
            
    }

}
