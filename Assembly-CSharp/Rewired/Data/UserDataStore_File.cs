using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using <PrivateImplementationDetails>{543FE4B1-57C3-4AD8-B6FD-57588652D254};
using Rewired.Utils.Libraries.CLZF2;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

namespace Rewired.Data
{
	// Token: 0x0200018D RID: 397
	public class UserDataStore_File : UserDataStore_KeyValue
	{
		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06001B2E RID: 6958 RVA: 0x0007C714 File Offset: 0x0007A914
		// (set) Token: 0x06001B2F RID: 6959 RVA: 0x0007C743 File Offset: 0x0007A943
		public string low
		{
			get
			{
				if (string.IsNullOrEmpty(this.jqv))
				{
					return this.jqv = Application.persistentDataPath;
				}
				return this.jqv;
			}
			set
			{
				this.jqv = value;
				if (this.jqy)
				{
					this.ell();
				}
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06001B30 RID: 6960 RVA: 0x0007C75A File Offset: 0x0007A95A
		// (set) Token: 0x06001B31 RID: 6961 RVA: 0x0007C762 File Offset: 0x0007A962
		public string lox
		{
			get
			{
				return this._fileName;
			}
			set
			{
				this._fileName = value;
				if (this.jqy)
				{
					this.ell();
				}
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06001B32 RID: 6962 RVA: 0x0007C779 File Offset: 0x0007A979
		// (set) Token: 0x06001B33 RID: 6963 RVA: 0x0007C781 File Offset: 0x0007A981
		public UserDataStore_File.DataFormat loy
		{
			get
			{
				return this._dataFormat;
			}
			set
			{
				this._dataFormat = value;
				if (this.jqy)
				{
					this.ell();
				}
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06001B34 RID: 6964 RVA: 0x0007C798 File Offset: 0x0007A998
		// (set) Token: 0x06001B35 RID: 6965 RVA: 0x0007C7D5 File Offset: 0x0007A9D5
		protected UserDataStore_File.hb loz
		{
			get
			{
				if (this.jqx == null)
				{
					return this.jqx = new UserDataStore_File.gx(new Func<UserDataStore_File.DataFormat>(this.elm), new UserDataStore_File.ha());
				}
				return this.jqx;
			}
			set
			{
				this.jqx = value;
				if (this.jqy)
				{
					this.ell();
				}
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06001B36 RID: 6966 RVA: 0x0007C7EC File Offset: 0x0007A9EC
		protected override UserDataStore_KeyValue.hg lpa
		{
			get
			{
				return this.jqw;
			}
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x00005090 File Offset: 0x00003290
		protected virtual void elk()
		{
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x0007C7F4 File Offset: 0x0007A9F4
		protected override void OnInitialize()
		{
			this.elk();
			this.jqy = true;
			this.ell();
			base.OnInitialize();
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x0007C80F File Offset: 0x0007AA0F
		private void ell()
		{
			this.jqw = new UserDataStore_File.gw((!string.IsNullOrEmpty(this._fileName)) ? this._fileName : a.emk(), this.low, this.loz);
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x0007C779 File Offset: 0x0007A979
		[CompilerGenerated]
		private UserDataStore_File.DataFormat elm()
		{
			return this._dataFormat;
		}

		// Token: 0x04000E74 RID: 3700
		private static readonly string jqq = typeof(UserDataStore_File).Name;

		// Token: 0x04000E75 RID: 3701
		private const string jqr = "Rewired: ";

		// Token: 0x04000E76 RID: 3702
		private const string jqs = ".json";

		// Token: 0x04000E77 RID: 3703
		private const string jqt = ".bin";

		// Token: 0x04000E78 RID: 3704
		private const string jqu = "RewiredSaveData.json";

		// Token: 0x04000E79 RID: 3705
		[SerializeField]
		private string _fileName = a.emk();

		// Token: 0x04000E7A RID: 3706
		[SerializeField]
		private UserDataStore_File.DataFormat _dataFormat;

		// Token: 0x04000E7B RID: 3707
		[NonSerialized]
		private string jqv;

		// Token: 0x04000E7C RID: 3708
		[NonSerialized]
		private UserDataStore_File.gw jqw;

		// Token: 0x04000E7D RID: 3709
		[NonSerialized]
		private UserDataStore_File.hb jqx;

		// Token: 0x04000E7E RID: 3710
		[NonSerialized]
		private bool jqy;

		// Token: 0x0200018E RID: 398
		private sealed class gw : UserDataStore_KeyValue.hg
		{
			// Token: 0x06001B3D RID: 6973 RVA: 0x0007C86B File Offset: 0x0007AA6B
			public gw(string a, string b, UserDataStore_File.hb c)
			{
				this.jql = Path.Combine(b, a);
				if (c == null)
				{
					throw new ArgumentNullException(a.emi());
				}
				this.jqm = c;
				this.jqk = new Dictionary<string, object>();
				this.ekv();
			}

			// Token: 0x06001B3E RID: 6974 RVA: 0x0007C8A7 File Offset: 0x0007AAA7
			public bool ekt(string a, out object b)
			{
				if (string.IsNullOrEmpty(a))
				{
					b = null;
					return false;
				}
				return this.jqk.TryGetValue(a, out b);
			}

			// Token: 0x06001B3F RID: 6975 RVA: 0x0007C8C3 File Offset: 0x0007AAC3
			public bool eku(string a, object b)
			{
				if (string.IsNullOrEmpty(a))
				{
					return false;
				}
				this.jqk[a] = b;
				return true;
			}

			// Token: 0x06001B40 RID: 6976 RVA: 0x0007C8E0 File Offset: 0x0007AAE0
			public bool Save()
			{
				bool flag;
				try
				{
					flag = this.jqm.Save(this.jql, JsonWriter.ToJson(this.jqk));
				}
				catch (Exception ex)
				{
					Debug.LogError(ex);
					flag = false;
				}
				return flag;
			}

			// Token: 0x06001B41 RID: 6977 RVA: 0x0007C928 File Offset: 0x0007AB28
			public bool ekv()
			{
				bool flag2;
				try
				{
					string text;
					bool flag = this.jqm.ekx(this.jql, out text);
					if (flag)
					{
						Dictionary<string, object> dictionary = JsonParser.FromJson<Dictionary<string, object>>(text);
						if (dictionary == null)
						{
							dictionary = new Dictionary<string, object>();
						}
						this.jqk = dictionary;
					}
					flag2 = flag;
				}
				catch (Exception ex)
				{
					Debug.LogError(ex);
					flag2 = false;
				}
				return flag2;
			}

			// Token: 0x06001B42 RID: 6978 RVA: 0x0007C980 File Offset: 0x0007AB80
			public bool ekw()
			{
				bool flag;
				try
				{
					flag = this.jqm.eky(this.jql);
				}
				catch (Exception ex)
				{
					Debug.LogError(ex);
					flag = false;
				}
				this.jqk.Clear();
				return flag;
			}

			// Token: 0x04000E7F RID: 3711
			private Dictionary<string, object> jqk;

			// Token: 0x04000E80 RID: 3712
			private readonly string jql;

			// Token: 0x04000E81 RID: 3713
			private UserDataStore_File.hb jqm;
		}

		// Token: 0x0200018F RID: 399
		private sealed class gx : UserDataStore_File.hb
		{
			// Token: 0x06001B43 RID: 6979 RVA: 0x0007C9C8 File Offset: 0x0007ABC8
			public gx(Func<UserDataStore_File.DataFormat> a, UserDataStore_File.gy b)
			{
				if (a == null)
				{
					throw new ArgumentNullException(a.emj());
				}
				this.jqn = a;
				if (b == null)
				{
					b = new UserDataStore_File.gz();
				}
				this.jqo = b;
			}

			// Token: 0x06001B44 RID: 6980 RVA: 0x0007C9F8 File Offset: 0x0007ABF8
			public bool ekx(string a, out string b)
			{
				b = null;
				if (string.IsNullOrEmpty(a))
				{
					return false;
				}
				if (!File.Exists(a))
				{
					return false;
				}
				bool flag;
				try
				{
					UserDataStore_File.DataFormat dataFormat = this.jqn();
					if (dataFormat != UserDataStore_File.DataFormat.Text)
					{
						if (dataFormat != UserDataStore_File.DataFormat.Binary)
						{
							throw new NotImplementedException();
						}
						byte[] array = File.ReadAllBytes(a);
						b = this.jqo.ela(array);
						flag = array != null && array.Length != 0;
					}
					else
					{
						b = File.ReadAllText(a);
						flag = !string.IsNullOrEmpty(b);
					}
				}
				catch (Exception ex)
				{
					Debug.LogError(ex);
					flag = false;
				}
				return flag;
			}

			// Token: 0x06001B45 RID: 6981 RVA: 0x0007CA88 File Offset: 0x0007AC88
			public bool Save(string absoluteFilePath, string data)
			{
				if (string.IsNullOrEmpty(absoluteFilePath))
				{
					return false;
				}
				bool flag;
				try
				{
					string directoryName = Path.GetDirectoryName(absoluteFilePath);
					if (!string.IsNullOrEmpty(directoryName) && !Directory.Exists(directoryName))
					{
						Directory.CreateDirectory(directoryName);
					}
					UserDataStore_File.DataFormat dataFormat = this.jqn();
					if (dataFormat != UserDataStore_File.DataFormat.Text)
					{
						if (dataFormat != UserDataStore_File.DataFormat.Binary)
						{
							throw new NotImplementedException();
						}
						File.WriteAllBytes(absoluteFilePath, this.jqo.ekz(data));
					}
					else
					{
						File.WriteAllText(absoluteFilePath, data);
					}
					flag = true;
				}
				catch (Exception ex)
				{
					Debug.LogError(ex);
					flag = false;
				}
				return flag;
			}

			// Token: 0x06001B46 RID: 6982 RVA: 0x0007CB14 File Offset: 0x0007AD14
			public bool eky(string a)
			{
				if (string.IsNullOrEmpty(a))
				{
					return false;
				}
				try
				{
					if (File.Exists(a))
					{
						File.Delete(a);
						return true;
					}
				}
				catch (Exception ex)
				{
					Debug.LogError(ex);
				}
				return false;
			}

			// Token: 0x04000E82 RID: 3714
			private readonly Func<UserDataStore_File.DataFormat> jqn;

			// Token: 0x04000E83 RID: 3715
			private readonly UserDataStore_File.gy jqo;
		}

		// Token: 0x02000190 RID: 400
		private abstract class gy
		{
			// Token: 0x06001B47 RID: 6983
			public abstract byte[] ekz(string a);

			// Token: 0x06001B48 RID: 6984
			public abstract string ela(byte[] a);
		}

		// Token: 0x02000191 RID: 401
		private sealed class gz : UserDataStore_File.gy
		{
			// Token: 0x06001B4A RID: 6986 RVA: 0x0007CB5C File Offset: 0x0007AD5C
			public override byte[] ekz(string a)
			{
				return Encoding.UTF8.GetBytes(a);
			}

			// Token: 0x06001B4B RID: 6987 RVA: 0x0007CB69 File Offset: 0x0007AD69
			public override string ela(byte[] a)
			{
				return Encoding.UTF8.GetString(a);
			}
		}

		// Token: 0x02000192 RID: 402
		private sealed class ha : UserDataStore_File.gy
		{
			// Token: 0x06001B4D RID: 6989 RVA: 0x0007CB7E File Offset: 0x0007AD7E
			public ha()
			{
				this.jqp = new CLZF2();
			}

			// Token: 0x06001B4E RID: 6990 RVA: 0x0007CB91 File Offset: 0x0007AD91
			public override byte[] ekz(string a)
			{
				return this.jqp.Compress(Encoding.UTF8.GetBytes(a));
			}

			// Token: 0x06001B4F RID: 6991 RVA: 0x0007CBA9 File Offset: 0x0007ADA9
			public override string ela(byte[] a)
			{
				return Encoding.UTF8.GetString(this.jqp.Decompress(a));
			}

			// Token: 0x04000E84 RID: 3716
			private readonly CLZF2 jqp;
		}

		// Token: 0x02000193 RID: 403
		public interface hb
		{
			// Token: 0x06001B50 RID: 6992
			bool ekx(string a, out string b);

			// Token: 0x06001B51 RID: 6993
			bool Save(string absoluteFilePath, string data);

			// Token: 0x06001B52 RID: 6994
			bool eky(string a);
		}

		// Token: 0x02000194 RID: 404
		public enum DataFormat
		{
			// Token: 0x04000E86 RID: 3718
			Text,
			// Token: 0x04000E87 RID: 3719
			Binary
		}
	}
}
