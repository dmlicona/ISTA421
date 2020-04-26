﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace cssb_ex11.VectorDistanceCalculation
{
    class Program
    {
        public struct Coord
        {
            public double X { get; set; }
            public double Y { get; set; }
            public double Z { get; set; }

            private static Random rnd = new Random();


            public static Coord GetRandomCoordinate(int i)
            {
                Coord coordinate = new Coord();
                coordinate.X = rnd.Next(101);
                coordinate.Y = rnd.Next(101);
                return coordinate;
            }

            public static double DistanceXY(Coord j, Coord k)
            {
                return Math.Sqrt((Math.Pow(k.X - j.X, 2) + (Math.Pow(k.Y - j.Y, 2))));
            }

            public static double DistanceXYZ(Coord j, Coord k)
            {
                return Math.Sqrt((Math.Pow(k.X - j.X, 2) + (Math.Pow(k.Y - j.Y, 2) + (Math.Pow(k.Z - j.Z, 2)))));
            }

            public static Coord[] Vector(List<Coord> CoordList)
            {
                double shortestVector = DistanceXY(CoordList[0], CoordList[1]);
                Coord[] currentVector = new Coord[2];

                for (int i = 1; i < CoordList.Count; i++)
                {
                    for (int j = i + 1; j < CoordList.Count; j++)
                    {
                        double distance = DistanceXY(CoordList[i], CoordList[j]);
                        if (distance < shortestVector)
                        {
                            shortestVector = distance;
                            currentVector[0] = CoordList[i];
                            currentVector[1] = CoordList[j];
                            Console.WriteLine($"The shortest Vector is {shortestVector}");
                        }
                    }
                }

                return currentVector;
            }

        }

        static void Main(string[] args)
        {
            List<Coord> CoordList = new List<Coord>(100);
            for (int i = 0; i < 100; i++)
            {
                CoordList.Add(Coord.GetRandomCoordinate(i));
                //Console.WriteLine();
            }
            foreach (Coord x in CoordList)
            {
                Console.WriteLine($"{x.X}, {x.Y}");
            }

            Coord[] coordArr1 = new Coord[2];
            coordArr1 = Coord.Vector(CoordList);

            foreach (Coord x in coordArr1)
            {
                Console.WriteLine($"The closest points are {x.X}, {x.Y}");
            }

        }
    }
}