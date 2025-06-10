using UnityEngine;

public class Golemancer : MonoBehaviour
{
    public class Personagem : MonoBehaviour
    {
        private string barreiradegolens;
        private string Golendepedra;

        public enum ProteçãoDopersonagem
        {
            BARREIRADEGOLEN,MONTANHADEGOLEN
        }

        public enum HabilidadeEspecial
        {
            GOLENDEPEDRA
        }

        [ SerializeField ]
        private ProteçãoDopersonagem armadura;
        [ SerializeField ]
        private HabilidadeEspecial arma;

        public void AtribuirArmadura(string armadura)
        public void AtribuirArmadura(ProteçãoDopersonagem armadura)
        {
            this.armadura = armadura;
        }

        public string AtribuirArmadura()
        public ProteçãoDopersonagem Armadura()
        {
            return this.armadura;
        }

        public void AtribuirArma(string arma)
        public void AtribuirArma( HabilidadeEspecial arma)
        {
            this.HabilidadeEspecial = arma;
        }

        public string AtriburArma()
        public HabilidadeEspecial arma()
        {
            return this.arma;
        }

      
}
