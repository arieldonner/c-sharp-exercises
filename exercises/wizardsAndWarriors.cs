using System;
abstract class Character
{
    private string character;

    protected Character(string characterType)
    {
        character = characterType;
    }
    public abstract int DamagePoints(Character target);
    public virtual bool Vulnerable()
    {
        return false;
    }
    public override string ToString()
    {
       return "Character is a " + character;
    }
}
class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }
    public override int DamagePoints(Character target)
    {
        if (target.Vulnerable() == true)
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
    private bool prepared = false;
    public Wizard() : base("Wizard")
    {
    }
    public override int DamagePoints(Character target)
    {
        if (prepared == true) {
            return 12;
        } else {
            return 3;
        }
    }
    public void PrepareSpell()
    {
       prepared = true;
    }
    public override bool Vulnerable()
    {
        if (prepared == true) {
            return false;
        }
        return true;
    }
}
