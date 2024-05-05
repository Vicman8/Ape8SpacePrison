using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager Instance { get; private set; }

    //UI references
    public GameObject DialogueParent;
    public TextMeshProUGUI DialogueTitleText, DialogueBodyText;
    public GameObject responseButtonPrefab;
    public Transform responseButtonContainer;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        HideDialogue();
    }

    public void StartDialogue(string title, DialogueNode node)
    {
        //Display the dialogue UI
        ShowDialogue();

        //Set dialogue title and body text
        DialogueTitleText.text = title;
        DialogueBodyText.text = node.dialogueText;

        //Remove any exisiting response buttons
        foreach(Transform child in responseButtonContainer)
        {
            Destroy(child.gameObject);
        }

        //Create and setup response buttons based on current dialogue node
        foreach(DialogueResponse response in node.responses)
        {
            GameObject buttonObj = Instantiate(responseButtonPrefab, responseButtonContainer);
            buttonObj.GetComponentInChildren<TextMeshProUGUI>().text = response.responseText;

            //Setup button to trigger SelectResponse when clicked
            buttonObj.GetComponent<Button>().onClick.AddListener(() => SelectResponse(response, title));
        }
    }

    //Handles response selection and triggers next dialogue node
    public void SelectResponse(DialogueResponse response, string title)
    {
        //Check if theres a follow-up node
        if(response.nextNode != null)
        {
            StartDialogue(title, response.nextNode); //Start next dialogue
        }
        else
        {
            //if no follow-up node, end the dialogue
            HideDialogue();
        }
    }

    //Hide the dialogue UI
    public void HideDialogue()
    {
        DialogueParent.SetActive(false);
    }

    //Show the dialogue UI
    private void ShowDialogue()
    {
        DialogueParent.SetActive(true);
    }

    public bool IsDialogueActive()
    {
        return DialogueParent.activeSelf;
    }
}
