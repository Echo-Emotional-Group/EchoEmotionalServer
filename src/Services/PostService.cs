using Interfaces;
using Contexts;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class PostService
    {
        private readonly DbEchoEmotional _dbEchoEmotional;

        public PostService(DbEchoEmotional dbEchoEmotional)
        {
            _dbEchoEmotional = dbEchoEmotional;
        }

        public async Task<List<PostReactionDto>> GetReactionsForPost(string postIdsJson)
        {
            var postIds = JsonSerializer.Deserialize<List<string>>(postIdsJson);

            var postReactions = new List<PostReactionDto>();

            foreach (string postId in postIds)
            {
                var post = await _dbEchoEmotional.Emotions
                    .FirstOrDefaultAsync(e => e.PostId == postId);

                var reactions = await _dbEchoEmotional.Reactions
                    .Where(r => r.PostId == postId)
                    .Select(r => new ReactionDto
                    {
                        Id = r.Id,
                        ReactionId = r.ReactionId
                    })
                    .ToListAsync();

                postReactions.Add(new PostReactionDto
                {
                    PostId = postId,
                    PostDescription = post?.Description,
                    LastEdition = post?.LastEdition,
                    Reactions = reactions
                });
            }
            return postReactions;
        }

    }
}
