using UnityEngine;
using TMPro;

public class CarController : MonoBehaviour
{
    [SerializeField] float RotateSpeed;
    [SerializeField] float MoveSpeed;
    [SerializeField] TMP_Text winsText;
    private int wins = 0;

    private void Start()
    {
        winsText.text = "Wins: " + wins.ToString();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 1 * MoveSpeed * Time.deltaTime, 0);
        }

        else if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -1 * MoveSpeed * Time.deltaTime, 0);
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
        Debug.Log("Hit");
        if (other.gameObject.tag == "FinshLine")
        {
            wins++;
            winsText.text = "Wins: " + wins.ToString();
        }
    }
}
