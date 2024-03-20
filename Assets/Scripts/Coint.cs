using UnityEngine;

public class Coint : MonoBehaviour
{
    public int value;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            CoinCounter.Instance.IncreaseCoin(value);
        }
    }
}
