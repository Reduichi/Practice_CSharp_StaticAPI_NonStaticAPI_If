using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("血量")]
    public float Hp = 100;
    [Header("攻擊力")]
    public float Atk;
    [Header("殭屍")]
    public Zombie Zb;  // 可以使用Zombie的參數
    [Header("喇叭")]
    public AudioSource Aud;
    [Header("音效")]
    public AudioClip SoundAtk;


    public void Attake() // 玩家的攻擊
    {
        if (Input.GetKeyDown("a"))
        {
            Atk = Random.Range(10f, 20f);
            print("殭屍受到的傷害: " + Atk);
            Zb.Hurt(Atk);
        }
    }

    public void Hurt(float damage) // 玩家的受傷
    {
        Hp = Hp - damage;
        print("玩家剩下的血量: " + Hp);
    }

    public void Dead() // 玩家的死亡
    {
        if (Hp <= 0)
        {
            print("玩家死亡");
        }
    }

    private void Update()
    {
        Attake();
        Dead();
    }
    
}
