using UnityEngine;
using System.IO;
using System.Collections.Generic;
using System.Linq;

public class AddToList : MonoBehaviour
{
    [SerializeField] string folder;         // folder with the default frames
    [SerializeField] string addedFolder;    // folder where customers added new frames 

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
        Debug.Log(addedFiles.Count);

        if (addedFiles.Count == 0)
            Debug.Log("No added frames by client");
        else
        {
            files.AddRange(addedFiles);                                     //Add new list to the initital list
            Debug.Log("Customized frames by client added to the list");
        }
            


    }

}
