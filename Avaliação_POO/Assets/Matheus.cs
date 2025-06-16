using UnityEngine;

public class Golemancer : Personagem
{
    private int mana;

    public Golemancer(string nome, int nivel, int vida, int forca, int mana) : base(nome, nivel, vida, forca)
    {
        this.mana = mana;
    }

    public int GetMana() { return mana; }
    public void SetMana(int mana) { this.mana = mana; }
}