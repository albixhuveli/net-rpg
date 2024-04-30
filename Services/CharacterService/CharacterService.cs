using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using net_RPG.Models;

namespace net_RPG.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        
        public List<Character> AddCharacter(Character newCharacter)
        {
            throw new NotImplementedException();
        }

        public List<Character> GetAllCharacters()
        {
            return characters;
        }

        public Character GetCharacterByID(int id)
        {
            return characters.FirstOrDefault(c => c.Id == id);
        }
    }
}