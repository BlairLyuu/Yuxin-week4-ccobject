using UnityEngine;

public class PanelSwitcher : MonoBehaviour
{
    [Header("startpanel")]
    public GameObject currentPanel;

    [Header("zhongchang")]
    public GameObject nextPanel;

    // �����ťʱ�����������
    public void SwitchPanel()
    {
        if (currentPanel != null)
            currentPanel.SetActive(false);

        if (nextPanel != null)
            nextPanel.SetActive(true);
    }
}
