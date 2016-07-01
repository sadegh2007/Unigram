// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLBotInlineMessageMediaContact : TLBotInlineMessageBase 
	{
		[Flags]
		public enum Flag : int
		{
			ReplyMarkup = (1 << 2),
		}

		public bool HasReplyMarkup { get { return Flags.HasFlag(Flag.ReplyMarkup); } set { Flags = value ? (Flags | Flag.ReplyMarkup) : (Flags & ~Flag.ReplyMarkup); } }

		public Flag Flags { get; set; }
		public String PhoneNumber { get; set; }
		public String FirstName { get; set; }
		public String LastName { get; set; }

		public TLBotInlineMessageMediaContact() { }
		public TLBotInlineMessageMediaContact(TLBinaryReader from, TLType type = TLType.BotInlineMessageMediaContact)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.BotInlineMessageMediaContact; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.BotInlineMessageMediaContact)
		{
			Flags = (Flag)from.ReadInt32();
			PhoneNumber = from.ReadString();
			FirstName = from.ReadString();
			LastName = from.ReadString();
			if (HasReplyMarkup) { ReplyMarkup = TLFactory.Read<TLReplyMarkupBase>(from); }
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x35EDB4D4);
			to.Write((Int32)Flags);
			to.Write(PhoneNumber);
			to.Write(FirstName);
			to.Write(LastName);
			if (HasReplyMarkup) to.WriteObject(ReplyMarkup);
		}
	}
}