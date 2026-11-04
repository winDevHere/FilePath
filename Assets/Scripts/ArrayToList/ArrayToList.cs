using System.Linq;
using UnityEngine;
using System.Collections.Generic;

public class ArrayToList : MonoBehaviour
{
    [SerializeField] string[] names = { "Anna", "Barry", "Curry" };


    //Converts Array to String
    void Start()
    {
        List<string> myNames = names.ToList();
        Debug.Log(myNames[0]);
        List<string> myNames1 = new List<string>(names);
        Debug.Log(myNames1[1]);
    }
}
