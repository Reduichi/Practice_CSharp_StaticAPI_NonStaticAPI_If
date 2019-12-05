using UnityEngine;

public class Zombie : MonoBehaviour
{
    [Header("血量")]
    public float Hp = 50;
    [Header("攻擊力")]
    public float Atk;
    [Header("玩家")]
    public Player Player;  // 可以使用Player的參數
    [Header("喇叭")]
    public AudioSource Aud;
    [Header("音效")]
    public AudioClip SoundAtk;

    public void Attake()   // 殭屍的攻擊與儲存數值
    {
        if (Input.GetKeyDown("b"))
        {
            Atk = Random.Range(20f, 30f);
            print("<color=red>玩家受到的傷害: " + Atk + "</color>");
            Player.Hurt(Atk);  // 將Atk的數值存到Player中的Hurt方法
            Aud.PlayOneShot(SoundAtk, 1f);  //開啟音效
        }
    }

    public void Hurt(float damage)  // 殭屍的受傷與剩餘的血量
    {
        Hp = Hp - damage;  // damage用來讀取Player的攻擊數值
        print("<color=blue>殭屍剩下的血量: " + Hp + "</color>");
    }

    public void Dead()  // 殭屍的死亡
    {
        if (Hp <= 0)
        {
            print("<color=blue>殭屍死亡</color>");
        }
    }

    private void Update()
    {
        Attake();
        Dead();
    }
}
