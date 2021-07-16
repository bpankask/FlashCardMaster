using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCardMaster
{
    public class FlashCardGroup
    {
        private string groupName;
        private List<FlashCard> flashCards;

        public FlashCardGroup(string name)
        {
            GroupName = name;
            flashCards = new List<FlashCard>();
        }

        public string GroupName { get => groupName; set => groupName = value; }
 
        public void AddFlashCard(string front, string back)
        {
            flashCards.Add(new FlashCard(front, back));
        }

        public void AddFlashCard(FlashCard fc)
        {
            flashCards.Add(fc);
        }

        public void RemoveFlashCard(FlashCard flashCard)
        {
            flashCards.Remove(flashCard);   
        }
    }
}
