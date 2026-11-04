using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class LoadPngToRawImage : MonoBehaviour
{
    public RawImage rawImage;
    public string path = @"C:\AdminFiles\02_Sample\1.png";

    void Start()
    {
        if (!File.Exists(path))
        {
            Debug.Log("File not found.");
            return;
        }
        Debug.Log("File found");

        byte[] data = File.ReadAllBytes(path);
        Texture2D tex = new Texture2D(2, 2);
        tex.LoadImage(data);
        rawImage.texture = tex;
    }
}