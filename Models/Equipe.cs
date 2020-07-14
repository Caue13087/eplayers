usin
namespace E_PLAYERS.Models
{
    public class Equipe : EPlayersBase , IEquipe 
    {
        public int IdEquipe {get;set;}

        public string Nome {get;set;}

        public string Imagem {get;set;}
          
    }
}