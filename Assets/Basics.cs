using UnityEngine;

public class Basics : MonoBehaviour
{
    public float timer = 0f;
    public float health = 100;
    public float moveSpeed = 5f;
    public AudioClip soundEffect;
    private AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Cube is about to move");
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2f)
        {
            audioSource.Play();
            Debug.Log("Cube is Moving");
            timer = 0f;
        }


        transform.position = new Vector3(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y, transform.position.z);


        if (health < 1)
        {
            Debug.Log("Dead!");
            Destroy(gameObject);
        }

    }
}