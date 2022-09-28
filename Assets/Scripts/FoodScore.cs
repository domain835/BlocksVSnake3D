using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FoodScore : MonoBehaviour
{
    public TMP_Text FoodScoreText;

    [SerializeField, Range(1, 5)]
    private int _score = 1;

    void Start()
    {
        FoodScoreText.text = _score.ToString();
    }

}
