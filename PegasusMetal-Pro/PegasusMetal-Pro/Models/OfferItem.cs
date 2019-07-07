using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PegasusMetal_Pro
{
    using System;
    using System.Collections.Generic;

    public partial class OfferItem
    {
        public int Id { get; set; }
        public int OfferId { get; set; }
        public int PieceId { get; set; }
        public int TotalCount { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public Nullable<decimal> LaserCuttingTime { get; set; }
        public Nullable<int> LaserCuttingGain { get; set; }
        public Nullable<decimal> LaserCuttingPrice { get; set; }
        public Nullable<decimal> TwistTime { get; set; }
        public Nullable<int> TwistCount { get; set; }
        public Nullable<int> TwistGain { get; set; }
        public Nullable<decimal> TwistPrice { get; set; }
        public Nullable<decimal> WeldTime { get; set; }
        public Nullable<int> WeldGain { get; set; }
        public Nullable<decimal> WeldPrice { get; set; }
        public Nullable<int> CoveringMaterialId { get; set; }
        public Nullable<int> CoveringValue { get; set; }
        public Nullable<int> CoveringGain { get; set; }
        public Nullable<decimal> CoveringPrice { get; set; }
        public Nullable<int> CountersinkCount { get; set; }
        public Nullable<int> CountersinkGain { get; set; }
        public Nullable<decimal> CountersinkPrice { get; set; }
        public Nullable<decimal> AssemblyJobPrice { get; set; }
        public Nullable<int> AssemblyTotalSetCount { get; set; }
        public Nullable<int> AssemblyGain { get; set; }
        public Nullable<decimal> AssemblyPrice { get; set; }
        public Nullable<bool> MaskingTapeType { get; set; }
        public Nullable<decimal> MaskingTapeJobPrice { get; set; }
        public Nullable<int> MaskingTapeArea { get; set; }
        public Nullable<int> MaskingTapeGain { get; set; }
        public Nullable<decimal> MaskingTapePrice { get; set; }
        public Nullable<int> PaintArea { get; set; }
        public Nullable<int> PaintGain { get; set; }
        public Nullable<decimal> PaintPrice { get; set; }
        public Nullable<int> MachiningOneCount { get; set; }
        public Nullable<decimal> MachiningOneJobPrice { get; set; }
        public Nullable<int> MachiningOneGain { get; set; }
        public Nullable<decimal> MachiningOnePrice { get; set; }
        public Nullable<int> MachiningTwoCount { get; set; }
        public Nullable<int> MachiningTwoDiameter { get; set; }
        public Nullable<decimal> MachiningTwoJobPrice { get; set; }
        public Nullable<int> MachiningTwoGain { get; set; }
        public Nullable<decimal> MachiningTwoPrice { get; set; }
        public Nullable<decimal> TighteningJobPrice { get; set; }
        public Nullable<int> TighteningSetCount { get; set; }
        public Nullable<int> TighteningTotalSet { get; set; }
        public Nullable<int> TighteningGain { get; set; }
        public Nullable<decimal> TighteningPrice { get; set; }
        public Nullable<int> IndentionCount { get; set; }
        public Nullable<int> IndentionDimensions { get; set; }
        public Nullable<int> HelicoilCount { get; set; }
        public Nullable<decimal> HelicoilJobPrice { get; set; }
        public Nullable<int> IndentionHelicoilGain { get; set; }
        public Nullable<decimal> IndentionHelicoilPrice { get; set; }
    }
}
