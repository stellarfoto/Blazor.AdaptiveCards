using System;
using System.Collections.Generic;
using System.Linq;
using AdaptiveCards;

namespace Blazor.AdaptiveCards.Actions
{
    public class ActionCreator
    {
        public global::AdaptiveCards.AdaptiveCard Create(global::AdaptiveCards.AdaptiveCard adaptiveCard, Func<dynamic, List<AdaptiveAction>> actions,
            object obj)
        {
            if (actions == null)
            {
                return adaptiveCard;
            }

            var createdActions = actions(obj);

            if (createdActions?.Any() != true)
            {
                return adaptiveCard;
            }

            adaptiveCard.Actions.AddRange(createdActions);

            return adaptiveCard;
        }
    }
}