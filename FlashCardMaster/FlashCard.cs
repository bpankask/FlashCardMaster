using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCardMaster
{
    public class FlashCard
    {
        private string front;
        private string back;
        private LearningStatus learningStatus;
        private int groupId;

        public FlashCard()
        {

        }

        public FlashCard(string front, string back)
        {
            this.front = front;
            this.back = back;
        }

        public string Front { get => front; set => front = value; }
        public string Back { get => back; set => back = value; }
        public LearningStatus LearningStatus { get => learningStatus; set => learningStatus = value; }
        public int GroupId { get => groupId; set => groupId = value; }
    }
}
