#region

using System.Collections.Generic;
using System.Globalization;
using HearthDb.Enums;

#endregion

namespace Hearthstone_Deck_Tracker.Hearthstone
{
	public static class HearthDbConverter
	{
		public static string ConvertClass(CardClass cardClass) => (int)cardClass < 2 || (int)cardClass > 10
																	  ? null : CultureInfo.InvariantCulture.TextInfo.ToTitleCase(cardClass.ToString().ToLowerInvariant());

		public static string CardTypeConverter(CardType type) => type == CardType.HERO_POWER ? "Hero Power" : CultureInfo.InvariantCulture.TextInfo.ToTitleCase(type.ToString().ToLowerInvariant().Replace("_", ""));


		public static string RaceConverter(Race race)
		{
			switch(race)
			{
				case Race.INVALID:
					return null;
				case Race.GOBLIN2:
					return "Goblin";
				case Race.PET:
					return "Beast";
				default:
					return CultureInfo.InvariantCulture.TextInfo.ToTitleCase(race.ToString().ToLowerInvariant());
			}
		}

		public static Dictionary<string, CardSet> UISetStringToCardSet = new Dictionary<string, CardSet>()
		{
			{ "BASIC", CardSet.CORE },
			{ "CLASSIC", CardSet.EXPERT1 },
			{ "PROMOTION", CardSet.PROMO },
			{ "CURSE OF NAXXRAMAS", CardSet.FP1 },
			{ "GOBLINS VS GNOMES", CardSet.PE1 },
			{ "BLACKROCK MOUNTAIN", CardSet.BRM },
			{ "THE GRAND TOURNAMENT", CardSet.TGT },
			{ "LEAGUE OF EXPLORERS", CardSet.LOE },
			{ "WHISPERS OF THE OLD GODS", CardSet.OG },
		};
	}
}