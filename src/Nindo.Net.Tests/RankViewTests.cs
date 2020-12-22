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
    }
}