# SimpleTwitter

A very simple library for Twitter, intended for usage in the C# for fun course.

You should not use this library for any production application.

Download via [NuGet](https://www.nuget.org/packages/SimpleTwitter).

## Usage
1. Create a new Twitter application via <https://apps.twitter.com>
2. `Twitter.Authenticate("Key", "Secret")` with the Key and Secret you can find on the Keys and Access Tokens tab of your newly created application
3. Get a users latest tweet: `Twitter.GetLastTweet("username")`
4. Get a users display name: `Twitter.GetName("username")`