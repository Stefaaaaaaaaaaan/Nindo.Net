<p align="center">
  <img src="docs/images/logo.png"  Height=350/>
  <p align="center">
  <a href="https://github.com/AlexGipp/Nindo.Net/actions?query=workflow%3A%22Build+%26+Test%22">
    <img src="https://github.com/AlexGipp/Nindo.Net/workflows/Build%20&%20Test/badge.svg" alt="Build status">
  </a>
    <a href="https://github.com/AlexGipp/Nindo.Net/actions?query=workflow%3A%22Publish+Packages%22">
    <img src="https://github.com/AlexGipp/Nindo.Net/workflows/Publish%20Packages/badge.svg" alt="Build status">
  </a>
  </br>
    Nindo.Net is an API wrapper, built in C# .Net Standard, for the official <a href="https://nindo.de/">Nindo.de</a> api.
  </p>
</p>

## ℹ Add Nindo.Net to your project.
From the PackageManager CLI

```cs
PM> Install-Package Nindo.Net -Version 1.0.0
```

From the DotNet CLI

```cs
> dotnet add package Nindo.Net --version 1.0.0
```

Or place this line in your `.csproj` & do a `dotnet restore`.

```cs
<PackageReference Include="Nindo.Net" Version="1.0.0" />
```

## 🤔 How To Use

### Creating a request to send to the API.

```cs
//Initialise a NindoClient
var client = new RanksClient();

//Call a method to send a request
var result = await client.GetViewsScoreboardAsync(RankViewerPlatform.Twitch, Size.Big);
```

## 📚 Clients

### All available clients.

```cs
var artistClient = new ArtistClient();
var channelClient = new ChannelClient();
var couponsClient = new CouponsClient();
var feedbackClient = new FeedbackClient();
var postsClient = new PostsClient();
var ranksClient = new RanksClient();
var searchClient = new SearchClient();
var viralClient = new ViralClient();
```

