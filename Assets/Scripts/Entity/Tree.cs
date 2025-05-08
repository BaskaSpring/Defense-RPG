using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Tree
{
    public SkillEnum Skill;
    public Boolean Active;
    public Boolean Selected;
    public List<Tree> Children = new List<Tree>();

    public Tree(SkillEnum skill,bool active, bool selected)
    {
        Skill = skill;
        Active = active;
        Selected = selected;
    }

    public void AddChild(Tree child)
    {
        Children.Add(child);
    }
}