using System;
using System.Threading.Tasks;
using Tweetinvi;

namespace SimpleTwitter
{
    public static class Twitter
    {
        public static void Authenticate(string key, string secret)
        {
            var creds = Auth.SetApplicationOnlyCredentials(key, secret);
            Auth.InitializeApplicationOnlyCredentials(creds);
        }

        public static Tweet GetLastTweet(string username) =>
            Request(() =>
            {
                var tweet = User.GetUserFromScreenName(username).Status;
                return new Tweet(tweet.Text, new DateTimeOffset(tweet.CreatedAt).ToLocalTime());
            });

        public static string GetName(string username) =>
            Request(() => User.GetUserFromScreenName(username).Name);

        private static T Request<T>(Func<T> func)
        {
            if (!Auth.Credentials.AreSetupForApplicationAuthentication())
                throw new InvalidOperationException($"You are not authenticated. Please call {nameof(Authenticate)} first.");

            try
            {
                return func();
            }
            catch
            {
                return default(T);
            }
        }
    }
}
