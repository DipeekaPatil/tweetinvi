﻿using System;
using Tweetinvi.Core;
using Tweetinvi.Core.Interfaces.Factories;
using Tweetinvi.Core.Interfaces.Models;
using Tweetinvi.Core.Parameters;

namespace Tweetinvi.Factories.Lists
{
    public class TwitterListIdentifierFactory : ITwitterListIdentifierFactory
    {
        public TwitterListIdentifierFactory()
        {
        }

        public ITwitterListIdentifier Create(long listId)
        {
            return new TwitterListIdentifier(listId);
        }

        public ITwitterListIdentifier Create(string slug, IUserIdentifier userIdentifier)
        {
            if (userIdentifier == null)
            {
                return null;
            }

            if (userIdentifier.Id != TweetinviSettings.DEFAULT_ID)
            {
                return Create(slug, userIdentifier.Id);
            }

            if (!String.IsNullOrEmpty(userIdentifier.ScreenName))
            {
                return Create(slug, userIdentifier.ScreenName);
            }

            return null;
        }

        public ITwitterListIdentifier Create(string slug, long ownerId)
        {
            return new TwitterListIdentifier(slug, ownerId);
        }

        public ITwitterListIdentifier Create(string slug, string ownerScreenName)
        {
            return new TwitterListIdentifier(slug, ownerScreenName);
        }
    }
}
