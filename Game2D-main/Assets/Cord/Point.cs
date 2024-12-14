using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Point : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI point;
    gamemanager g;

    private void Start()
    {
        g = gamemanager.Instance;
    }
    private void OnGUI()
    {
        point.text = g.PrettyScore();
    }
}
