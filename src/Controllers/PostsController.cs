using Microsoft.AspNetCore.Mvc;
using Services;
using Models;
using Interfaces;
using Contexts;
using Microsoft.EntityFrameworkCore;


namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly DbEchoEmotional _dbEchoEmotional;
        private readonly PostService _postService;
        private readonly EmotionService _emotionService;
        private readonly ReactionService _reactionService;

        public PostsController(PostService postService, EmotionService emotionService, ReactionService reactionService, DbEchoEmotional dbEchoEmotional)
        {
            _postService = postService;
            _emotionService = emotionService;
            _reactionService = reactionService;
            _dbEchoEmotional = dbEchoEmotional;
        }

        [HttpGet("GetPostsReaction")]
        public async Task<IActionResult> GetPostReactions([FromQuery] string postIds)
        {
            if (postIds == null)
                return BadRequest("Post IDs list cannot be empty!");

            var postList = await _postService.GetReactionsForPost(postIds);

            return Ok(postList);
        }

        [HttpPost("InsertEmotion")]
        public async Task<IActionResult> InsertEmotion([FromBody] ReactionInputModel reaction)
        {
            if (reaction == null)
            {
                return BadRequest("Invalid emotion data!");
            }

            try
            {
                var insertedEmotion = await _reactionService.InsertReaction(reaction);
                return Ok(insertedEmotion);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }

        [HttpPatch("CreateOrUpdatePostDescription")]
        public async Task<IActionResult> CreateOrUpdatePostDescription([FromBody] UpdatePostDescriptionRequest request)
        {
            if (request == null || string.IsNullOrEmpty(request.PostId) || request.Description == null)
            {
                return BadRequest("Invalid request data!");
            }

            try
            {
                var emotion = await _emotionService.CreateOrUpdatePostDescription(request.PostId, request.Description);
                return Ok(emotion);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }

        [HttpDelete("DeleteReaction/{reactionId}")]
        public async Task<IActionResult> DeleteReaction(int reactionId)
        {
            bool deleted = await _reactionService.DeleteReaction(reactionId);

            if (!deleted)
            {
                return NotFound($"Reaction with ID {reactionId} not found!");
            }

            return Ok($"Reaction with ID {reactionId} deleted successfully!");
        }

    }
}
