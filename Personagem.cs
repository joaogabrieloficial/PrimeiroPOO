namespace PrimeiroPOO
{
    public class Personagem
    {
        
        public string nome = "Soi fong";

        public int idade = 100;

        public string arma;


        public int Atacar(int forca, int velocidade){

            return forca * velocidade;
        }

        public string Defender (){

            return "O personagem esquivou!";
        }
    }
}