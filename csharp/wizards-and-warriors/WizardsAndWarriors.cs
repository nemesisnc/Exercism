using System;

abstract class Character
{
    string characterType;
    protected Character(string characterType)
    {
        this.characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => false;

    public override string ToString() => $"Character is a {characterType}";
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (target is Wizard && target.Vulnerable())
        {
            return 10; 
        }
        else
        {
            return 6; 
        }
    }
}

class Wizard : Character
{
    bool vulnerable = true;
    bool spellReady = false;

    public Wizard() : base("Wizard")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (spellReady)
        {
            return 12;
        }
        else
        {
            return 3;
        }
    }

    public void PrepareSpell()
    {
        vulnerable = false;
        spellReady = true;
    }

    public override bool Vulnerable() => vulnerable;
}
