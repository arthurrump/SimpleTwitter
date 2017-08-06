using System;

namespace SimpleTwitter
{
    public class Tweet
    {
        internal Tweet(string text, DateTimeOffset createdAt)
        {
            Text = text;
            CreatedAt = createdAt;
        }

        public string Text { get; }
        public DateTimeOffset CreatedAt { get; }
    }
}
