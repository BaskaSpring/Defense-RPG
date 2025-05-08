using UnityEngine;
using Newtonsoft.Json;


public class GameLoader : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TalentsTree.Tree = new Tree(SkillEnum.Protect,false,false);

        Tree Shield = new Tree(SkillEnum.Shield, false, false);
        Tree Fireball = new Tree(SkillEnum.Fireball, false, false);
        Tree Firestorm = new Tree(SkillEnum.Firestorm, false, false);
        Tree FireWall = new Tree(SkillEnum.FireWall, false, false);
        Tree FireShield = new Tree(SkillEnum.FireShield, false, false);
        Tree Iceball = new Tree(SkillEnum.Iceball, false, false);

        FireShield.AddChild(Iceball);
        FireWall.AddChild(FireShield);
        Fireball.AddChild(FireWall);
        Fireball.AddChild(Firestorm);
        TalentsTree.Tree.AddChild(Fireball);
        TalentsTree.Tree.AddChild(Shield);

        string json = JsonConvert.SerializeObject(TalentsTree.Tree, Formatting.Indented);
        Debug.Log(json);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
