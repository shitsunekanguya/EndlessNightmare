using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMove : MonoBehaviour
{
    Coin coinScrips;
    public bool move;

    // Start is called before the first frame update
    void Start()
    {
        coinScrips = gameObject.GetComponent<Coin>();
    }

    void Update()
    {
        move = Magnet.MagnetActive;
        if (move == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, coinScrips.playerTransform.position, coinScrips.moveSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player Bubble")
        {
            Destroy(gameObject);
        }
    }
}
