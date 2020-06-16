using System;

namespace Aula18Dojo1
{
    public class Jogador
    {
        public string Nome { get; set; }
         public string Posicao { get; set; }
          public DateTime DatadeNascimento { get; set; }
          public string Nacionalidade { get; set; }
           public float Altura { get; set; }
           public float Peso { get; set; }

            //$=Interpolação, mais pratico na junção dos metodos.
           public string Dados(){
               return $"Nome: {Nome}, Posicao: {Posicao}, Data de Nascimento: {DatadeNascimento}, Nacionalidade: {Nacionalidade}, Altura: {Altura}, Peso: {Peso}";
           }
            
            public int idade { get; set; }
            public int idadeAtual { get; set; }

            //ToString é pra converter DateTime em string e utilizamos o metodo split.
            public int CalcularIdade(){
               int anodeNascismento = Int32.Parse(DatadeNascimento.ToString().Split('/', ' ') [2]);
               int anoAtual = Int32.Parse(DateTime.Now.ToString().Split('/', ' ') [2]);

               idade = anoAtual - anodeNascismento;
               idadeAtual = 35 - idade;

               return idade;
            }

            string Aposentadoria = "";
            

            //Pode usar if depois do else, quando há outras condições.
            public string CalcularAposentadoria(){
                if(Posicao == "Atacante" && idade >= 35){
                    Aposentadoria = "Você pode se aposentar";
                }else if(Posicao == "Meio-Campo" && idade >= 38){
                    Aposentadoria = "Você pode se aposentar";
                }else if(Posicao == "Defesa" && idade >= 40){
                    Aposentadoria = "Você pode se aposentar";
                }else{
                    Aposentadoria = "Você ainda não está apto para a sua aposentadoria";
                }

                return Aposentadoria;
            }
            
    }
}