using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrangPhucController : MonoBehaviour
{
    public GameObject trangPhuc;
    // Start is called before the first frame update
    void Start()
    {
        // Ðãng k? s? ki?n
        UnityEngine.UI.Button button = GetComponent<UnityEngine.UI.Button>();
        button.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        ShowMenu();
        // Vi?t m? x? l? b?n mu?n th?c hi?n khi nút ðý?c nh?n ? ðây
    }
    public void ShowMenu()
    {
        trangPhuc.SetActive(true); // Hi?n th? Menu
    }
}