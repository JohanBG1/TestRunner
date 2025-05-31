using UnityEngine;
using TMPro;

public class CarController : MonoBehaviour
{
    [SerializeField] float RotateSpeed;
    [SerializeField] float MoveSpeed;
    [SerializeField] TMP_Text winsText;
    private int wins = 0;

    private void Update()
    {
        winsText.text = "Wins: " + wins.ToString();
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 1 * MoveSpeed * Time.deltaTime, 0);
        }

        else if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 1 * MoveSpeed * Time.deltaTime, 0);
        }

        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, 1 * RotateSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, -1 * RotateSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "FinshLine")
        {
            wins++;
        }
    }
}
