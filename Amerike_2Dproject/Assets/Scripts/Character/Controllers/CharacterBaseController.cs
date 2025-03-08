using Character.Models;
using Character.Views;

namespace Character.Controllers
{
    public class CharacterBaseController : ICharacterBaseController
    {
        private ICharacterView characterView;
        private ICharacterData characterData;
        
            public CharacterBaseController(ICharacterView characterView, ICharacterData characterData)
            {
                this.characterView = characterView;
                this.characterData = characterData;
            }
            
        public void StartCharacter()
        {
        
        }
    }
   
}