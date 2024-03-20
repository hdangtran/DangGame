using TMPro;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    public static CoinCounter Instance;
    public TMP_Text coinText;
    public int currentCoins = 0;
    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        coinText.text = "COINS: " + currentCoins.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void IncreaseCoin(int v)
    {
        currentCoins += v;

        coinText.text = "COINS: " + currentCoins.ToString();
        Debug.Log(coinText.text);
    }
}
