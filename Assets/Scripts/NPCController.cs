using UnityEngine;
using UnityEngine.UI;
using TMPro;
using LLMUnity;

public class NPCController : MonoBehaviour
{
    public LLMAgent llmAgent;
    public TMP_InputField inputField;
    public TextMeshProUGUI chatLogText;
    public Button sendButton;

    private string fullLog = "";

    void Start()
    {
        sendButton.onClick.AddListener(OnSendClicked);
        inputField.onSubmit.AddListener(delegate { OnSendClicked(); });
    }

    void OnSendClicked()
    {
        string userMessage = inputField.text.Trim();
        if (string.IsNullOrEmpty(userMessage)) return;

        fullLog += $"\n<color=#4DA6FF><b>You:</b></color> {userMessage}\n";
        fullLog += "<color=#26D999><b>NPC:</b></color> ";
        chatLogText.text = fullLog;

        inputField.text = "";
        inputField.interactable = false;
        sendButton.interactable = false;

        _ = llmAgent.Chat(userMessage, HandleReply, OnReplyComplete);
    }

    void HandleReply(string replySoFar)
    {
        chatLogText.text = fullLog + replySoFar;
    }

    void OnReplyComplete()
    {
        fullLog = chatLogText.text + "\n";
        inputField.interactable = true;
        sendButton.interactable = true;
        inputField.ActivateInputField();
    }
}