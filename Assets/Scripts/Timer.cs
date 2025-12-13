using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TMP_Text tmp_text;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        tmp_text.text = Time.realtimeSinceStartupAsDouble.ToString("0");
    }
}
