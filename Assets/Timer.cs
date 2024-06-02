using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private bool _timerActive;
    private float _currentTime;
    [SerializeField] private TMP_Text _text;

    void Start()
    {
        _currentTime = 0;
        _timerActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (_timerActive)
        {
            _currentTime += Time.deltaTime;
        }

        _text.text = _currentTime.ToString("F1");
    }
}