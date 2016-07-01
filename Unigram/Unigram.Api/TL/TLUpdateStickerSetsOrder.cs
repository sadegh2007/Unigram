// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateStickerSetsOrder : TLUpdateBase 
	{
		public TLVector<Int64> Order { get; set; }

		public TLUpdateStickerSetsOrder() { }
		public TLUpdateStickerSetsOrder(TLBinaryReader from, TLType type = TLType.UpdateStickerSetsOrder)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.UpdateStickerSetsOrder; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.UpdateStickerSetsOrder)
		{
			Order = TLFactory.Read<TLVector<Int64>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xF0DFB451);
			to.WriteObject(Order);
		}
	}
}