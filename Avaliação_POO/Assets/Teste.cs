using UnityEngine;

public class TestePersonagem : MonoBehaviour
{
    void Start()
    {
        // Criando personagens
        Personagem guerreiro = new Personagem("Arthur", 5, 100, 20);
        Golemancer golemancer = new Golemancer("Matheus", 7, 80, 10, 150);

        // Testando leitura e escrita
        Debug.Log("Nome do Guerreiro: " + guerreiro.GetNome());
        Debug.Log("Força do Guerreiro: " + guerreiro.GetForca());

        Debug.Log("Nome do Golemancer: " + golemancer.GetNome());
        Debug.Log("Mana do Golemancer: " + golemancer.GetMana());

        // Comparação entre os personagens
        Debug.Log(guerreiro.CompararCom(golemancer));
    }
}