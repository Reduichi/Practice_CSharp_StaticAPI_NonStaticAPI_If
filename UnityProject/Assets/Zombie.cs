using UnityEngine;

public class Zombie : MonoBehaviour
{
    [Header("血量")]
    public float Hp = 50;
    [Header("攻擊力")]
    public float Atk;
    [Header("玩家")]
    public GameObject Player;
    [Header("喇叭")]
    public AudioSource Aud;
    [Header("音效")]
    public AudioClip SoundAtk;



    private void Start()
    {
        
    }
    private void Update()
    {

        if (Input.GetKeyDown("a"))
        {
            Hp = Hp - Atk;
            print("殭屍剩餘的血量: " + Hp);

        }
        else if(Input.GetKeyDown("d"))
        {
            Atk = Random.Range(20f, 30f);
            print("玩家受到的傷害: " + Atk);
        }
    }
}
