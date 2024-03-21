using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COA_PRIS.Utilities
{
    internal class Colors
    {
        public static Color Hex_To_RGB(string hex)
        {
            // Remove '#' if present
            hex = hex.TrimStart('#');

            // Check if the hex string is valid
            if (hex.Length != 6)
                throw new ArgumentException("Invalid hexadecimal color representation.", nameof(hex));

            // Parse hexadecimal values for each color component
            int r = int.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
            int g = int.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
            int b = int.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

            // Return the corresponding Color object
            return Color.FromArgb(r, g, b);
        }
    }
}
