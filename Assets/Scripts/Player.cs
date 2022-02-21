using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public UnityEngine.UI.Text scoreText;
    private int _scoreValue;
    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0f,0f,2f * Time.deltaTime,Space.World);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0f, 0f, -0.2f * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(2f * Time.deltaTime, 0f, 0f, Space.World);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.2f * Time.deltaTime, 0f, 0f, Space.World);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Target"))
        {
            _scoreValue++;
            scoreText.text = "Score : " + _scoreValue;
            Destroy(other.gameObject);
        }
    }

}
