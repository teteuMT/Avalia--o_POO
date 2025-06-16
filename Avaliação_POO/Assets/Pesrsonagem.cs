using UnityEngine;

public class Personagem : MonoBehaviour
{
    // Atributos básicos
    [SerializeField] 
    private string nome;
    [SerializeField]
    private int nivel;
    [SerializeField]
    private int vida;
    [SerializeField]
    private int forca;

    // Construtor
    public Personagem(string nome, int nivel, int vida, int forca)
    {
        this.nome = nome;
        this.nivel = nivel;
        this.vida = vida;
        this.forca = forca;
    }

    // Getters e Setters
    public string GetNome() { return nome; }
    public void SetNome(string nome) { this.nome = nome; }

    public int GetNivel() { return nivel; }
    public void SetNivel(int nivel) { this.nivel = nivel; }

    public int GetVida() { return vida; }
    public void SetVida(int vida) { this.vida = vida; }

    public int GetForca() { return forca; }
    public void SetForca(int forca) { this.forca = forca; }

    // Função de comparação
    public string CompararCom(Personagem outro)
    {
        if (this.nivel > outro.nivel)
            return $"{this.nome} é mais forte que {outro.nome}.";
        else if (this.nivel < outro.nivel)
            return $"{outro.nome} é mais forte que {this.nome}.";
        else
            return $"{this.nome} e {outro.nome} estão no mesmo nível.";
    }
}