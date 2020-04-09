using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    /// <summary>
    /// 定義怪物
    /// </summary>
    [Header("怪物 1 號")]
    public Enemy enemy1;
    [Header("怪物 2 號")]
    public Enemy enemy2;

    /// <summary>
    /// 開始事件
    /// </summary>
    public void Start()
    {
        //取得
        print(enemy1.mp);               //怪物1號的魔力
        print(enemy2.equipment);        //怪物2號的裝備名稱

        //設定
        enemy1.hp = 100;                //怪物1號的血量
        enemy2.hp = 300;                //怪物2號的血量
        enemy1.defense = 50;            //怪物1號的防禦力
        enemy1.weapon = "木棍";         //怪物1號的武器
        enemy2.weapon = "短刀";         //怪物2號的武器
        enemy1.key = true;              //怪物1號帶有鑰匙
        enemy2.treasure = true;         //怪物2號帶有寶物
    }
}
