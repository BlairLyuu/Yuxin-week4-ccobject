using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    [System.Serializable]
    public class Page { public string id; public GameObject root; }

    public List<Page> pages = new List<Page>();
    public string defaultId = "startpanel";

    Dictionary<string, GameObject> map = new();
    string currentId;

    void Awake()
    {
        foreach (var p in pages)
        {
            if (p.root == null || string.IsNullOrEmpty(p.id)) continue;
            map[p.id] = p.root;
            p.root.SetActive(false);
        }
        Show(defaultId);
    }

    public void Show(string id)
    {
        if (string.IsNullOrEmpty(id) || !map.ContainsKey(id)) { Debug.LogWarning("No panel: " + id); return; }
        if (!string.IsNullOrEmpty(currentId) && map.ContainsKey(currentId)) map[currentId].SetActive(false);
        map[id].SetActive(true);
        currentId = id;
    }

    // 方便按钮直接传字符串
    public void Show_ById(string id) => Show(id);
}
