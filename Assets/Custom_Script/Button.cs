using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    // Reference to the Button component
    private Button button;

    // Reference to the interface Panel that you want to close
    public GameObject interfacePanel;
/*
    private void Start()
    {
        // Get the Button component
        button = GetComponent<Button>();

        // Add a listener to the button that calls the OnButtonClicked method
        button.onClick.AddListener(OnButtonClicked);
    }

    private void OnButtonClicked()
    {
        // Your code for what happens when the button is clicked goes here
        Debug.Log("Button clicked!");

        // Close the interface Panel
        button.gameObject.SetActive(false);
    }
    private void NoButtonClicked()
    {
        // Your code for what happens when the button is clicked goes here
        Debug.Log("Button clicked!");

        // Close the interface Panel
        button.gameObject.SetActive(false);
    } */
}
