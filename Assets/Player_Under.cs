using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Under : MonoBehaviour
{
    // �Q��
    public Player sc_move;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PosReset()
    {
        transform.localPosition = new Vector3(0, 0, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") return;

        if (other.gameObject.tag == "View") return;

        if (other.gameObject.tag == "Door_HIT") return;

        sc_move.Set_IsUnder(true);
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player") return;

        if (other.gameObject.tag == "View") return;

        if (other.gameObject.tag == "Door_HIT") return;

        sc_move.Set_IsUnder(true);
    }

    void OnTriggerExit(Collider other)
    {
        sc_move.Set_IsUnder(false);
    }
}
