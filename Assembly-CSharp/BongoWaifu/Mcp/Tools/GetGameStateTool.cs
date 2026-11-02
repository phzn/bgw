using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BongoWaifu.Mcp.Tools
{
	// Token: 0x02000158 RID: 344
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class GetGameStateTool
	{
		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060017D9 RID: 6105 RVA: 0x00076E62 File Offset: 0x00075062
		public string Schema
		{
			get
			{
				return "{\n          \"name\": \"get_game_state\",\n          \"description\": \"Read current companion state. Default returns character only. Pass `sections` to include achievements / inventory / gauges / stats. gauges.hot is the combo gauge (0..100): increases by hot_per_click per user click on the character; decays by hot_decay_per_sec when idle; hot_level is the discrete tier {0,1,2,3} with thresholds 25/50/75. stats exposes Steam lifetime counters (click_count, orgasm_count, craft_count).\",\n          \"inputSchema\": {\n            \"type\": \"object\",\n            \"properties\": {\n              \"sections\": {\n                \"type\": \"array\",\n                \"items\": { \"type\": \"string\", \"enum\": [\"character\", \"achievements\", \"inventory\", \"gauges\", \"stats\"] },\n                \"description\": \"Which sections to include. Default: ['character'].\"\n              },\n              \"include_locked\": {\n                \"type\": \"boolean\",\n                \"description\": \"When achievements is requested, include locked ones. Default: true.\"\n              }\n            }\n          }\n        }";
			}
		}

		// Token: 0x060017DA RID: 6106 RVA: 0x00076E6C File Offset: 0x0007506C
		[NullableContext(2)]
		[return: TupleElementNames(new string[] { "isError", "payload" })]
		[return: Nullable(new byte[] { 0, 1 })]
		public ValueTuple<bool, string> Handle(JToken args)
		{
			HashSet<string> hashSet = GetGameStateTool.ParseSections(args);
			bool? flag;
			if (args == null)
			{
				flag = null;
			}
			else
			{
				JToken jtoken = args["include_locked"];
				flag = ((jtoken != null) ? jtoken.Value<bool?>() : null);
			}
			bool flag2 = flag ?? true;
			JObject jobject = new JObject();
			JArray jarray = new JArray();
			if (hashSet.Contains("character"))
			{
				CharacterInfoDto characterInfoDto = GameStateReader.ReadCharacter();
				JObject jobject2 = jobject;
				string text = "character";
				JObject jobject3 = new JObject();
				jobject3["character_id"] = characterInfoDto.CharacterId;
				jobject3["character_name"] = characterInfoDto.CharacterName;
				jobject3["character_type"] = characterInfoDto.CharacterType;
				jobject3["current_skin"] = characterInfoDto.CurrentSkin;
				jobject3["current_clothes"] = new JArray(characterInfoDto.CurrentClothes);
				jobject2[text] = jobject3;
			}
			if (hashSet.Contains("achievements"))
			{
				List<AchievementDto> list = GameStateReader.ReadAchievements(flag2);
				if (list == null)
				{
					jobject["achievements"] = JValue.CreateNull();
					JArray jarray2 = jarray;
					JObject jobject4 = new JObject();
					jobject4["section"] = "achievements";
					jobject4["error"] = "stats_not_ready";
					jarray2.Add(jobject4);
				}
				else
				{
					JArray jarray3 = new JArray();
					foreach (AchievementDto achievementDto in list)
					{
						JArray jarray4 = jarray3;
						JObject jobject5 = new JObject();
						jobject5["api_name"] = achievementDto.ApiName;
						jobject5["display_name"] = achievementDto.DisplayName;
						jobject5["description"] = achievementDto.Description;
						jobject5["unlocked"] = achievementDto.Unlocked;
						jobject5["unlock_time_utc"] = achievementDto.UnlockTimeUtc;
						jarray4.Add(jobject5);
					}
					jobject["achievements"] = jarray3;
				}
			}
			if (hashSet.Contains("inventory"))
			{
				List<InventoryItemDto> list2 = GameStateReader.ReadInventory();
				if (list2 == null)
				{
					jobject["inventory"] = JValue.CreateNull();
					JArray jarray5 = jarray;
					JObject jobject6 = new JObject();
					jobject6["section"] = "inventory";
					jobject6["error"] = "inventory_not_ready";
					jarray5.Add(jobject6);
				}
				else
				{
					JArray jarray6 = new JArray();
					foreach (InventoryItemDto inventoryItemDto in list2)
					{
						JArray jarray7 = jarray6;
						JObject jobject7 = new JObject();
						jobject7["item_id"] = inventoryItemDto.ItemId;
						jobject7["definition_id"] = inventoryItemDto.DefinitionId;
						jobject7["name"] = inventoryItemDto.Name;
						jobject7["quantity"] = inventoryItemDto.Quantity;
						jarray7.Add(jobject7);
					}
					jobject["inventory"] = jarray6;
				}
			}
			if (hashSet.Contains("gauges"))
			{
				GaugeInfoDto gaugeInfoDto = GameStateReader.ReadGauges();
				if (gaugeInfoDto == null)
				{
					jobject["gauges"] = JValue.CreateNull();
					JArray jarray8 = jarray;
					JObject jobject8 = new JObject();
					jobject8["section"] = "gauges";
					jobject8["error"] = "girl_not_ready";
					jarray8.Add(jobject8);
				}
				else
				{
					JObject jobject9 = jobject;
					string text2 = "gauges";
					JObject jobject10 = new JObject();
					jobject10["hot"] = gaugeInfoDto.Hot;
					jobject10["hot_level"] = gaugeInfoDto.HotLevel;
					jobject10["hot_per_click"] = gaugeInfoDto.HotPerClick;
					jobject10["hot_decay_per_sec"] = gaugeInfoDto.HotDecayPerSec;
					jobject9[text2] = jobject10;
				}
			}
			if (hashSet.Contains("stats"))
			{
				StatsInfoDto statsInfoDto = GameStateReader.ReadStats();
				if (statsInfoDto == null)
				{
					jobject["stats"] = JValue.CreateNull();
					JArray jarray9 = jarray;
					JObject jobject11 = new JObject();
					jobject11["section"] = "stats";
					jobject11["error"] = "stats_not_ready";
					jarray9.Add(jobject11);
				}
				else
				{
					JObject jobject12 = jobject;
					string text3 = "stats";
					JObject jobject13 = new JObject();
					jobject13["click_count"] = ((statsInfoDto.ClickCount != null) ? statsInfoDto.ClickCount.Value : JValue.CreateNull());
					jobject13["orgasm_count"] = ((statsInfoDto.OrgasmCount != null) ? statsInfoDto.OrgasmCount.Value : JValue.CreateNull());
					jobject13["craft_count"] = ((statsInfoDto.CraftCount != null) ? statsInfoDto.CraftCount.Value : JValue.CreateNull());
					jobject12[text3] = jobject13;
				}
			}
			if (jarray.Count > 0)
			{
				jobject["errors"] = jarray;
			}
			return new ValueTuple<bool, string>(false, jobject.ToString(Formatting.None, Array.Empty<JsonConverter>()));
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x000773E4 File Offset: 0x000755E4
		private static HashSet<string> ParseSections([Nullable(2)] JToken args)
		{
			HashSet<string> hashSet = new HashSet<string>();
			JArray jarray = ((args != null) ? args["sections"] : null) as JArray;
			if (jarray != null && jarray.Count > 0)
			{
				foreach (JToken jtoken in jarray)
				{
					string text = (string)jtoken;
					if (!string.IsNullOrEmpty(text))
					{
						hashSet.Add(text);
					}
				}
			}
			if (hashSet.Count == 0)
			{
				hashSet.Add("character");
			}
			return hashSet;
		}
	}
}
