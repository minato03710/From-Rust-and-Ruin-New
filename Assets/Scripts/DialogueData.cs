using UnityEngine;
using System;
using TMPro;

public class DialogueData : MonoBehaviour
{
    Animator visualsAnimator;
    Animator cameraAnimator;
    [Serializable] // Makes the class serialisable
    public class Lines
    {
        public string[] lines;
    }
    
    [SerializeField] private TMP_Text textActive; // To assign TMP
    [SerializeField] private GameObject dialogueBox; // To assign dialogue box
    [SerializeField] private Lines dialogue; // Dialogue lines stored here
    private int lineCount = 0; // Sets current line

     // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject searchCanvas = GameObject.Find("Dialogue Canvas");
        searchCanvas.SetActive(false);
        dialogueBox.SetActive(true);
        ShowDialogue();
    }

    void ShowDialogue()
    {
        if(lineCount < dialogue.lines.Length)
        {
            textActive.text = dialogue.lines[lineCount];
        }
    }

    public void OnButtonPressed()
    {
        ShowNext();
    }

    void ShowNext()
    {
        lineCount++;

        if(lineCount < dialogue.lines.Length)
        {
            ShowDialogue();
        }
        else
        {
            GameObject searchCanvas = GameObject.Find("Dialogue Canvas");
            searchCanvas.SetActive(false);
            GameObject searchCamera = GameObject.Find("Camera");
            cameraAnimator = searchCamera.GetComponent<Animator>();
            cameraAnimator.Play("CameraReturn");
            RustRelease();
            
        }
    }
    public void RustRelease()
    {
        GameObject searchRust = GameObject.Find("Rust_Puppet_Rig_Coloured"); // Finds Rust
        searchRust.GetComponent<RustController>().enabled = true; // Stops Rust's script that allows for player control in order to freeze movement
        searchRust.GetComponent<RustVisuals>().enabled = true;
        visualsAnimator = searchRust.GetComponentInChildren<Animator>();
        visualsAnimator.Play("rust_on_ground");
    }
}
