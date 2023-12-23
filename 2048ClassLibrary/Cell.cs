using System.Drawing;
using System.Windows.Forms;

namespace _2048ClassLibrary
{
    public class Cell : Label
    {
        public int Row { get; }
        public int Column { get; }
        public static readonly byte SideLength = 80;
        public static readonly byte SmallIndent = 10;
        public static readonly byte LargeIndent = 80;
        public static readonly byte GapBetweenCells = 6;
        public Color[] CellColors { get; } =
        {
            Color.LightBlue,
            Color.LightGreen,
            Color.LightSalmon,
            Color.Moccasin,
            Color.MediumOrchid,
            Color.MediumAquamarine,
            Color.LightCoral,
            Color.MediumVioletRed,
            Color.GreenYellow,
            Color.MintCream,
            Color.Magenta,
            Color.Olive
        };
        public Cell(int indexRow, int indexColumn)
        {
            BackColor = Color.Gray;
            Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            Size = new Size(SideLength, SideLength);
            TextAlign = ContentAlignment.MiddleCenter;
            Row = indexRow;
            Column = indexColumn;
            var x = SmallIndent + Column * (SideLength + GapBetweenCells);
            var y = LargeIndent + Row * (SideLength + GapBetweenCells);
            Location = new Point(x, y);
            Text = string.Empty;
        }
    }
}