using UnityEngine;
using System.IO;

public class CheckTextFiles : MonoBehaviour
{
    public string folder;

    void Start()
    {
        //string[] files = Directory.GetFiles(folder, "*.txt");
        string[] files = Directory.GetFiles(folder);


        if (files.Length > 0)
        {
            Debug.Log(files.Length);
            Debug.Log("Text file/s exist");
        }
        else
            Debug.Log("Text files does not exist");
    }

}
