using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InfoGather : MonoBehaviour
{
    public GameObject[] userInterfaceInputs; // Input Variable

    public List<string> output = new List<string>(); // Output Variable

    public GameObject docEditObject; // Connection to the DocEdit script.

    public void GatherData() // Runs on "Submit" button click.
    {
        foreach(GameObject input in userInterfaceInputs)
        {
            if (input.gameObject.tag == "Input Field") // Check what input the var in the list is.
            {
                output.Add(input.GetComponent<TMP_InputField>().text);
            } else if (input.gameObject.tag == "Checkbox") // Add input field value.
            {
                output.Add(Convert.ToInt32(input.GetComponent<Toggle>().isOn).ToString()); // Add checkbox value.
            }
        }

        PassToDocEdit();
    }

    private void PassToDocEdit()
    {
        docEditObject.GetComponent<DocEdit>().SaveNewToDoc(output); // Transfers output data to the DocEdit script.
    }
}