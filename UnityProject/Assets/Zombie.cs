using UnityEngine;

public class Zombie : MonoBehaviour
{
    [Header("血量")]
    public float Hp = 50;
    [Header("攻擊力")]
    public float Atk = Random.Range(20f, 30f);
    [Header("玩家")]
    public Player Player;  // 可以使用Player的參數
    [Header("喇叭")]
    public AudioSource Aud;
    [Header("音效")]
    public AudioClip SoundAtk;

    public void Attake()   // 殭屍的攻擊
    {
        if (Input.GetKeyDown("b"))
        {
            Atk = Random.Range(20f, 30f);
            print("玩家受到的傷害: " + Atk);
            Player.Hurt(Atk);
        }
    }

    public void Hurt(float damage)  // 殭屍的受傷
    {
        Hp = Hp - damage;
        print("殭屍剩下的血量: " + Hp);
    }

    public void Dead()  // 殭屍的死亡
    {
        if (Hp <= 0)
        {
            print("殭屍死亡");
        }
    }

    private void Update()
    {
        Attake();
        Dead();
    }
}
