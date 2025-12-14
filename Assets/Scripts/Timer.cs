using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

public class Timer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TMP_Text tmp_text;
    double time;
    void Start()
    {
        time = Time.realtimeSinceStartupAsDouble;
    }

    // Update is called once per frame
    void Update()
    {
        tmp_text.text = (Time.realtimeSinceStartupAsDouble - time).ToString("0");
    }
}
