using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InfoGather : MonoBehaviour
{
    public GameObject[] userInterfaceInputs; // Input Variable
    public GameObject docEditObject; // Reference to the DocEdit Utility

    private List<string> output = new List<string>(); // Output Variable

    // Compiles the data from the UI elements added to the userInterfaceInputs array.
    public void SubmitButton() {
        for (int i = 0; i < userInterfaceInputs.Length; i++) {
            if (userInterfaceInputs[i].gameObject.tag == "Input Field") { // If the UI element is an input, add its text to the ouput list.
                output.Add(userInterfaceInputs[i].GetComponent<TMP_InputField>().text);
            } else if (userInterfaceInputs[i].gameObject.tag == "Checkbox") { // If the UI element is a checkbox, add its value to the ouput list.
                if (userInterfaceInputs[i].GetComponent<Toggle>().isOn)
                {
                    output.Add("1");
                } else {
                    output.Add("0");
                }
            }
        }
        docEditObject.GetComponent<DocEdit>().SaveNewToDoc(output);
    }
}