using System;

namespace MyPhotoshop
{
    public struct Pixel
    {
        private double r;
        private double g;
        private double b;

        public double R { get => r; set => r = Check(value); }

        public double G { get => g; set => g = Check(value); }

        public double B { get => b; set => b = Check(value); }

        public static double Trim(double value)
        {
            if (value < 0) return 0;
            if (value > 1) return 1;

            return value;
        }

        private double Check(double value)
        {
            if (value < 0 || value > 1)
                throw new ArgumentException($"Wrong channel value {value} (the value must be between 0 and 1).");

            return value;
        }
    }
}
