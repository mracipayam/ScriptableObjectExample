using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI typeText = null;
    [SerializeField] private EnemyType _enemyType = null;
    
    
    void Start()
    {
        GetComponent<Renderer>().material.color = _enemyType.enemyColor;
        transform.localScale = _enemyType.enemyScale;
        typeText.text = _enemyType.typeName;
    }

    
}
