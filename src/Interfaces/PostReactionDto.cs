using Models;

namespace Interfaces
{

    public class PostReactionDto
    {
        public string PostId { get; set; }
        public List<ReactionDto> Reactions { get; set; }
        public string PostDescription { get; set; }
        public DateTime? LastEdition { get; set; }
    }

}
