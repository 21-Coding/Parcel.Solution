using System;

namespace Parcel.Models
{
    public class Parcel
    {
        public int Height { get; set; }
        public int Depth { get; set; }
        public int Width { get; set; }
        public int Weight { get; set; }
    

        public Parcel(int height ,int depth, int width, int weight, )
        {
            Height = height;
            Depth = depth;
            Width = width;
            Weight = weight;

        }

        public int Volume()
        {
            int Volume = Height*Depth*Width;
            return Volume;
        }
        

     
    }
}