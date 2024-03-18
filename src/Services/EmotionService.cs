using Models;
using Contexts;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class EmotionService
    {
        private readonly DbEchoEmotional _dbEchoEmotional;

        public EmotionService(DbEchoEmotional dbEchoEmotional)
        {
            _dbEchoEmotional = dbEchoEmotional;
        }

        public async Task<Emotion> CreateOrUpdatePostDescription(string postId, string description)
        {
            var emotion = await _dbEchoEmotional.Emotions.FirstOrDefaultAsync(e => e.PostId == postId);
            
            if (emotion == null)
            {
                emotion = new Emotion
                {
                    PostId = postId,
                    Description = description,
                };
                _dbEchoEmotional.Emotions.Add(emotion);
            }
            else
            {
                emotion.Description = description;
                emotion.LastEdition = DateTime.UtcNow;
            }

            await _dbEchoEmotional.SaveChangesAsync();
            return emotion;
        }
    }
}
