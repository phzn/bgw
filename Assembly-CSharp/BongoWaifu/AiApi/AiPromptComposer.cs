using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using BongoWaifu.Mcp;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;

namespace BongoWaifu.AiApi
{
	// Token: 0x02000169 RID: 361
	[NullableContext(1)]
	[Nullable(0)]
	public static class AiPromptComposer
	{
		// Token: 0x06001827 RID: 6183 RVA: 0x000788F0 File Offset: 0x00076AF0
		[return: TupleElementNames(new string[] { "system", "user" })]
		[return: Nullable(new byte[] { 0, 1, 1 })]
		public static ValueTuple<string, string> Build(string playerTemplate, AiTriggerKind kind, [Nullable(2)] string detail)
		{
			string text = CompanionPersona.BuildDirectApiSystemPrompt(string.IsNullOrWhiteSpace(playerTemplate) ? "You are a charming desktop companion who lives on the player's screen. Speak warmly and playfully, with light teasing. Stay in character and keep it brief." : playerTemplate);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("## Current context\n");
			stringBuilder.Append("Player's language: ").Append(AiPromptComposer.CurrentLanguageName()).Append(" (reply in this language).\n");
			CharacterInfoDto characterInfoDto = GameStateReader.ReadCharacter();
			stringBuilder.Append("Character: name=\"").Append(characterInfoDto.CharacterName).Append("\", type=")
				.Append(characterInfoDto.CharacterType)
				.Append(", skin=")
				.Append(characterInfoDto.CurrentSkin)
				.Append(".\n");
			if (characterInfoDto.CurrentClothes != null && characterInfoDto.CurrentClothes.Count > 0)
			{
				stringBuilder.Append("Outfit tokens: ").Append(string.Join(", ", characterInfoDto.CurrentClothes)).Append(".\n");
			}
			GaugeInfoDto gaugeInfoDto = GameStateReader.ReadGauges();
			if (gaugeInfoDto != null)
			{
				stringBuilder.Append("Mood level: ").Append(AiPromptComposer.DescribeMood(gaugeInfoDto.HotLevel)).Append(" (")
					.Append(gaugeInfoDto.HotLevel)
					.Append("/3).\n");
			}
			stringBuilder.Append("Occasion: ").Append(AiPromptComposer.DescribeTrigger(kind, detail)).Append('\n');
			stringBuilder.Append("Now say ONE short in-character line that fits this moment.");
			return new ValueTuple<string, string>(text, stringBuilder.ToString());
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x00078A58 File Offset: 0x00076C58
		public static string GetLocalizedDefaultTemplate()
		{
			string text2;
			try
			{
				LocalizedStringDatabase stringDatabase = LocalizationSettings.StringDatabase;
				StringTable stringTable = ((stringDatabase != null) ? stringDatabase.GetTable("UI", null) : null);
				StringTableEntry stringTableEntry = ((stringTable != null) ? stringTable.GetEntry("directapi.default_template") : null);
				string text = ((stringTableEntry != null) ? stringTableEntry.GetLocalizedString() : null);
				text2 = (string.IsNullOrEmpty(text) ? "You are a charming desktop companion who lives on the player's screen. Speak warmly and playfully, with light teasing. Stay in character and keep it brief." : text);
			}
			catch
			{
				text2 = "You are a charming desktop companion who lives on the player's screen. Speak warmly and playfully, with light teasing. Stay in character and keep it brief.";
			}
			return text2;
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x00078ACC File Offset: 0x00076CCC
		private static string CurrentLanguageName()
		{
			string text;
			try
			{
				Locale selectedLocale = LocalizationSettings.SelectedLocale;
				if (selectedLocale == null)
				{
					text = "the player's language";
				}
				else
				{
					CultureInfo cultureInfo = selectedLocale.Identifier.CultureInfo;
					text = ((cultureInfo != null) ? cultureInfo.NativeName : selectedLocale.Identifier.Code);
				}
			}
			catch
			{
				text = "the player's language";
			}
			return text;
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x00078B38 File Offset: 0x00076D38
		private static string DescribeMood(int hotLevel)
		{
			string text;
			if (hotLevel > 0)
			{
				if (hotLevel != 1)
				{
					if (hotLevel != 2)
					{
						text = "very worked up";
					}
					else
					{
						text = "playful and excited";
					}
				}
				else
				{
					text = "warmed up and cheerful";
				}
			}
			else
			{
				text = "calm and relaxed";
			}
			return text;
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x00078B74 File Offset: 0x00076D74
		private static string DescribeTrigger(AiTriggerKind kind, [Nullable(2)] string detail)
		{
			string text;
			switch (kind)
			{
			case AiTriggerKind.Launch:
				text = "the app just opened — greet the player";
				break;
			case AiTriggerKind.IdleChatter:
				text = "a quiet idle moment — make light, spontaneous small talk";
				break;
			case AiTriggerKind.OutfitChange:
				text = "the player just changed your outfit" + AiPromptComposer.Suffix(detail);
				break;
			case AiTriggerKind.Achievement:
				text = "an achievement was just unlocked" + AiPromptComposer.Suffix(detail) + " — celebrate it";
				break;
			case AiTriggerKind.OrgasmMilestone:
				text = "an intense peak-excitement moment just happened";
				break;
			case AiTriggerKind.HotMilestone:
				text = "the mood just rose to a new level" + AiPromptComposer.Suffix(detail);
				break;
			case AiTriggerKind.Manual:
				text = "the player asked you to say something right now";
				break;
			case AiTriggerKind.ItemDrop:
				text = "the player just received a new item" + AiPromptComposer.Suffix(detail) + " — react to it";
				break;
			default:
				text = "react naturally to the moment";
				break;
			}
			return text;
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x00078C26 File Offset: 0x00076E26
		private static string Suffix([Nullable(2)] string detail)
		{
			if (!string.IsNullOrEmpty(detail))
			{
				return " (" + detail + ")";
			}
			return "";
		}

		// Token: 0x04000C61 RID: 3169
		private const string FallbackTemplate = "You are a charming desktop companion who lives on the player's screen. Speak warmly and playfully, with light teasing. Stay in character and keep it brief.";
	}
}
