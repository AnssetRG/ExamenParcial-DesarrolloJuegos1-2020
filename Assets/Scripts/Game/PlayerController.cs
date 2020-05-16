using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private GameObject uno;
    [SerializeField]
    private GameObject dos;
    [SerializeField]
    private GameObject tres;
    [SerializeField]
    private GameObject cuarto;
    [SerializeField]
    private GameObject quinto;
    void Start()
    {
        string monster = PlayerPrefs.GetString("player");
        GameObject monsterGO = new GameObject();
        switch (monster)
        {
            case "1":
                monsterGO = uno;
                break;
            case "2":
                monsterGO = dos;
                break;
            case "3":
                monsterGO = tres;
                break;
            case "4":
                monsterGO = cuarto;
                break;
            case "5":
                monsterGO = quinto;
                break;
            default:
                break;
        }
        Instantiate(monsterGO, transform.position, Quaternion.identity);
    }

}
