using System.Collections
using UnityEditor;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    private string nome;
    private int energia;
    private int forca_ataque;
    private float forca_do_pulo;
    private float velocidade;
    private int numero_de_pes;
    private int numero_de_maos;

    public void AtribuirNome(string nome)
    {
        this.nome = nome;
    }

    public string Nome()
    {
        return this.nome;
    }

    public void AtribuirEnergia(int energia)
    {
        this.energia = energia;
    }

    public int Energia()
    {
        return this.energia;
    }

    public void AtribuirForca_Ataque(int forca_ataque)
    {
        this.forca_ataque = forca_ataque;
    }

    public int Forca_Ataque()
    {
        return this.forca_ataque;
    }
    
    public void AtribuirForca_do_pulo(float forca_do_pulo);
    {
        this.forca_do_pulo = forca_do_pulo;
    }

    public float Forca_do_pulo()
    {
        return this.forca_do_pulo;
    }






    void Start()
    {
        
    }
    void Update()
    {
        
    }
}