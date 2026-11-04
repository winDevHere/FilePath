using NUnit.Framework;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class AssignTextureFromFolder : MonoBehaviour
{
    [SerializeField] RawImage mayRawImage;
    [SerializeField] Texture2D myTexture;
    [SerializeField] string folder;

    void Start()
    {
        List<string> files = new List <string> (Directory.GetFiles(folder));
        Debug.Log(files[0]);

        
    }

}
