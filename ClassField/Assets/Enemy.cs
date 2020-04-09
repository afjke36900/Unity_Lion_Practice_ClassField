using UnityEngine;

public class Enemy : MonoBehaviour
{
    /// <summary>
    /// 血量
    /// </summary>
    [Header("血量"),Tooltip("怪物的血量"),Range(50,500)]
    public int hp = 200;
    /// <summary>
    /// 魔力
    /// </summary>
    [Header("魔力"), Tooltip("怪物的魔力"),Range(10,100)]
    public int mp = 50;
    /// <summary>
    /// 移動速度
    /// </summary>
    [Header("移動速度"),Range(1f,50.5f)]
    public float speed = 10.5f;
    /// <summary>
    /// 攻擊力
    /// </summary>
    [Header("攻擊力"),Range(20,200)]
    public int attack = 50;
    /// <summary>
    /// 防禦力
    /// </summary>
    [Header("防禦力"),Range(0,100)]
    public int defense = 30;
    /// <summary>
    /// 武器名稱
    /// </summary>
    [Header("武器名稱")]
    public string weapon = "噬血小刀";
    /// <summary>
    /// 裝備名稱
    /// </summary>
    [Header("裝備名稱")]
    public string equipment = "皮衣";
    /// <summary>
    /// 是否帶有鑰匙
    /// </summary>
    [Header("是否帶有鑰匙"), Tooltip("怪物是否帶有鑰匙")]
    public bool key = false;
    /// <summary>
    /// 是否掉落寶物
    /// </summary>
    [Header("是否帶有寶物"), Tooltip("怪物是否帶有寶物")]
    public bool treasure = false;
}
