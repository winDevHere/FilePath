using NUnit.Framework;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class AssignTextureFromFolder : MonoBehaviour
{
    [SerializeField] string folder;
    [SerializeField] string addedFolder;


    void Start()
    {
        if (!Directory.Exists(folder) || !Directory.Exists(addedFolder))    //Check if 2 paths are valid
        {
            Debug.Log("Invalid directory");
            return;
        }

        List<string> files = new List<string>(Directory.GetFiles(folder));
        List<string> addedFiles = new List<string>(Directory.GetFiles(addedFolder));

        Debug.Log(files.Count);

        files.AddRange(addedFiles);

        Debug.Log(files.Count);
    }

}
