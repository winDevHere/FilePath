using UnityEngine;
using System.IO;

public class CheckTextFiles : MonoBehaviour
{
    [SerializeField] string folder;

    void Start()
    {
        //string[] files = Directory.GetFiles(folder);
        string[] files = Directory.GetFiles(folder, "*.txt");

        if (files.Length > 0)
        {
            Debug.Log(files.Length);
            Debug.Log("Text file/s exist");
        }
        else
            Debug.Log("Text files does not exist");
    }
}
