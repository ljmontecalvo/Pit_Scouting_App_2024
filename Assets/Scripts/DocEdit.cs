using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class DocEdit : MonoBehaviour
{
    private const string SAVE_SEPARATOR = ","; // Value esparator variable.

    public void SaveNewToDoc(List<string> contents)
    {
        string saveString = string.Join(SAVE_SEPARATOR, contents); // Prepares data from the InfoGather script to be written.
        
        File.WriteAllText("DATA.txt", saveString); // Writes output data from the string to the txt file.
    }
}
