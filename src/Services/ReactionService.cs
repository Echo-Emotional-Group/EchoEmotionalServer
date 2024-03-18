using Models;
using Contexts;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class ReactionService
    {
        private readonly DbEchoEmotional _dbEchoEmotional;

        public ReactionService(DbEchoEmotional dbEchoEmotional)
        {
            _dbEchoEmotional = dbEchoEmotional;
        }

        public async Task<Reaction> InsertReaction(ReactionInputModel model)
        {
            var emotionExists = await _dbEchoEmotional.Emotions.AnyAsync(e => e.PostId == model.PostId);
            if (!emotionExists)
            {
                var newEmotion = new Emotion { PostId = model.PostId };
                _dbEchoEmotional.Emotions.Add(newEmotion);
            }

            var reactionExists = await _dbEchoEmotional.Reactions.AnyAsync(r => r.PostId == model.PostId && r.ReactionId == model.ReactionId);
            if (!reactionExists)
            {
                var newReaction = new Reaction
                {
                    PostId = model.PostId,
                    ReactionId = model.ReactionId
                };
                _dbEchoEmotional.Reactions.Add(newReaction);
                await _dbEchoEmotional.SaveChangesAsync();

                return newReaction;
            }

            return null;
        }

        public async Task<bool> DeleteReaction(ReactionInputModel deleteReaction)
        {
            var reaction = await _dbEchoEmotional.Reactions.FirstOrDefaultAsync(e => e.PostId == deleteReaction.PostId && e.ReactionId == deleteReaction.ReactionId);
            
            if (reaction == null)
            {
                return false;
            }

            _dbEchoEmotional.Reactions.Remove(reaction);
            await _dbEchoEmotional.SaveChangesAsync();
            
            return true;
        }
    }
}
