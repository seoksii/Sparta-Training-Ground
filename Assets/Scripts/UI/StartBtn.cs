using UnityEngine;
using UnityEngine.UI;

public class StartBtn : MonoBehaviour
{
    private void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        SceneController.LoadScene("MainScene");
    }
}
