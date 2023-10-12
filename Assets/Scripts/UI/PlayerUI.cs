using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public TextMeshProUGUI promptText;

    private void Start()
    {
        
    }

    public void UpdateText(string promptMessage)
    {
        promptText.text = promptMessage;
    }
}
