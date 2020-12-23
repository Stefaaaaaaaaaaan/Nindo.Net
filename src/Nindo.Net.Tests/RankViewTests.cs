using System.Threading.Tasks;
using Nindo.Net.Models.Enums;
using Xunit;

namespace Nindo.Net.Tests
{
    public class RankViewTests
    {
        [Theory]
        [InlineData(RankViewsPlatform.Youtube, Size.Big)]
        [InlineData(RankViewsPlatform.TikTok, Size.Big)]
        [InlineData(RankViewsPlatform.Youtube, Size.Small)]
        [InlineData(RankViewsPlatform.TikTok, Size.Small)]
        public async Task ToApiString_RankViewsPlatformEnumsProvided_GivesBackPropperlyFormattedPlatformForAPI(RankViewsPlatform platform, Size size)
        {
            //Arrange
            NindoClient client = new NindoClient();

            //Act
            var result =await client.GetRankViewsAsync(platform, size);
            //Assert
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData(RankViewerPlatform.Twitch, Size.Big)]
        [InlineData(RankViewerPlatform.Twitch, Size.Small)]
        public async Task ToApiString_RankViewerPlatformEnumsProvided_GivesBackPropperlyFormattedPlatformForAPI(RankViewerPlatform platform, Size size)
        {
            //Arrange
            NindoClient client = new NindoClient();

            //Act
            var result = await client.GetRankViewerAsync(platform, size);

            //Assert
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData(RankAllPlatform.Youtube, Size.Big)]
        [InlineData(RankAllPlatform.Instagram, Size.Big)]
        [InlineData(RankAllPlatform.TikTok, Size.Big)]
        [InlineData(RankAllPlatform.Twitch, Size.Big)]
        [InlineData(RankAllPlatform.Youtube, Size.Small)]
        [InlineData(RankAllPlatform.Instagram, Size.Small)]
        [InlineData(RankAllPlatform.TikTok, Size.Small)]
        [InlineData(RankAllPlatform.Twitch, Size.Small)]
        public async Task ToApiString_RankPlatformEnumsProvided_GivesBackPropperlyFormattedPlatformForAPI(RankAllPlatform platform, Size size)
        {
            //Arrange
            NindoClient client = new NindoClient();

            //Act
            var result = await client.GetRankAsync(platform, size);
            //Assert
            Assert.NotNull(result);
        }
    }
}