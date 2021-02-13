using System;
namespace ConsoleApp
{
    public delegate void SquareSizeChanged(double num); // 1

    class Square
    { //publisher
        public event SquareSizeChanged OnSizeChanged; // 2

        double ulx,uly;
        double brx,bry;

        public double UpperLeftX
        {
            get
            {
                return ulx;
            }
            set
            {
                ulx = value;
                OnSizeChanged?.Invoke(brx - ulx);
            }
        }

        public double UpperLeftY
        {
            get
            {
                return uly;
            }
            set
            {
                uly = value;
                OnSizeChanged?.Invoke(bry-uly);
            }
        }

        public double BottomRightX
        {
            get
            {
                return brx;
            }
            set
            {
                brx = value;
                OnSizeChanged?.Invoke(brx - ulx);
            }
        }
        public double BottomRightY
        {
            get
            {
                return bry;
            }
            set
            {
                bry = value;
                OnSizeChanged?.Invoke(bry - uly);
            }
        }
    }
    class Handler1
    { // subscriber
        public void Message(double num)
        { // 4
            Console.WriteLine(num);
        }
    }

    class Program
    {
        static void Main()
        {
            Square c = new Square();
            Handler1 handler1 = new Handler1();
            c.OnSizeChanged += handler1.Message; // 5

            c.BottomRightX = 15;
            c.BottomRightY = 10;

            c.UpperLeftX = 22;
            c.UpperLeftY = 10;

        }
    }



}