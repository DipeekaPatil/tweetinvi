﻿using Tweetinvi.Core.Interfaces.Parameters;

namespace Tweetinvi.Core.Parameters
{
    public class TimelineRequestParameters : CustomRequestParameters, ITimelineRequestParameters
    {
        protected TimelineRequestParameters()
        {
            MaximumNumberOfTweetsToRetrieve = 40;

            SinceId = TweetinviSettings.DEFAULT_ID;
            MaxId = TweetinviSettings.DEFAULT_ID;

            TrimUser = false;
            IncludeEntities = true;
        }

        public int MaximumNumberOfTweetsToRetrieve { get; set; }
        public long SinceId { get; set; }
        public long MaxId { get; set; }
        public bool TrimUser { get; set; }
        public bool IncludeEntities { get; set; }
    }
}