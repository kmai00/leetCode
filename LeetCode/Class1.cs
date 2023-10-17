using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;

namespace LeetCode
{
    public struct Coordinate
    {
        public int x;
        public int y;
        public int value;
        public string Key()
        {
            return $"{y},{x}";
        }
    };

    // Assuming exactly two island
    public class Problem934
    {
        public int ShortestBridge(int[][] grid)
        {
            var islands = new Dictionary<int, List<Coordinate>> {
                { 0, new List<Coordinate>()},
                { 1, new List<Coordinate>()}
            };

            var islandNumber = 0;
            var visitedLand = new HashSet<string>();
            //Explore the land
            for (var row = 0; row < grid.Length; row++)
            {
                for (var col = 0; col < grid.Length; col++)
                {
                    var currentCord = new Coordinate { y = row, x = col, value = grid[row][col] };
                    if (visitedLand.Contains(currentCord.Key()))
                    {
                        continue;
                    }

                    if (currentCord.value == 1)
                    {
                        var island = ExploreIsland(currentCord, grid, visitedLand);
                        islands[islandNumber] = island;
                        islandNumber++;
                    }
                }
            }

            //Navigate to land 2
           var bridgeCost = FindCheapestBridge(islands, grid);

            return bridgeCost;
        }

        public int FindCheapestBridge(Dictionary<int, List<Coordinate>> islands, int[][] grid)
        {
            var costGrid = new int[grid.Length, grid.Length];
            var calculatedNode = new HashSet<string>();
            var waterNeighbors = new Queue<Coordinate>();
            // Start building on an island
            islands[0].ForEach(land =>
            {
                waterNeighbors.Enqueue(land);
                calculatedNode.Add(land.Key());
            });
            var secondIslandHash = islands[1].Select(s => s.Key()).ToHashSet<string>();

            while (waterNeighbors.Count > 0)
            {
                var currentNode = waterNeighbors.Dequeue();
                if (secondIslandHash.Contains(currentNode.Key()))
                {
                    return costGrid[currentNode.y, currentNode.x] - 1;
                }

                var north = new Coordinate { y = currentNode.y - 1, x = currentNode.x };
                var south = new Coordinate { y = currentNode.y + 1, x = currentNode.x };
                var east = new Coordinate { y = currentNode.y, x = currentNode.x + 1 };
                var west = new Coordinate { y = currentNode.y, x = currentNode.x - 1 };
                var neighborCost = costGrid[currentNode.y, currentNode.x] + 1;

                // Mark water tile I added cost to, enqueue the ones I need to expand on

                if (north.y > -1 && !calculatedNode.Contains(north.Key()))
                {
                    costGrid[north.y, north.x] = neighborCost;
                    calculatedNode.Add(north.Key());
                    waterNeighbors.Enqueue(north);
                }
                if (south.y < grid.Length && !calculatedNode.Contains(south.Key()))
                {
                    costGrid[south.y, south.x] = neighborCost;
                    calculatedNode.Add(south.Key());
                    waterNeighbors.Enqueue(south);
                }
                if (east.x < grid[0].Length && !calculatedNode.Contains(east.Key()))
                {
                    costGrid[east.y, east.x] = neighborCost;
                    calculatedNode.Add(east.Key());
                    waterNeighbors.Enqueue(east);
                }
                if (west.x > -1 && !calculatedNode.Contains(west.Key()))
                {
                    costGrid[west.y, west.x] = neighborCost;
                    calculatedNode.Add(west.Key());
                    waterNeighbors.Enqueue(west);
                }
            }

            return -1;
        }

        // The idea is that explore island will land on new island
        public List<Coordinate> ExploreIsland(
            Coordinate startingNode,
            int[][] grid,
            HashSet<string> visitedLand)
        {
            var landNeighbors = new Queue<Coordinate>();
            landNeighbors.Enqueue(startingNode);

            var islandLand = new List<Coordinate>();

            while (landNeighbors.Count > 0)
            {
                var currentNode = landNeighbors.Dequeue();

                if (visitedLand.Contains(currentNode.Key()) || currentNode.value == 0)
                {
                    continue;
                }

                islandLand.Add(currentNode);
                visitedLand.Add(currentNode.Key());

                var north = new Coordinate { y = currentNode.y - 1, x = currentNode.x };
                var south = new Coordinate { y = currentNode.y + 1, x = currentNode.x };
                var east = new Coordinate { y = currentNode.y, x = currentNode.x + 1 };
                var west = new Coordinate { y = currentNode.y, x = currentNode.x - 1 };

                if (north.y > -1 && !visitedLand.Contains(north.Key()))
                {
                    north.value = grid[north.y][north.x];
                    landNeighbors.Enqueue(north);
                }
                if (south.y < grid.Length && !visitedLand.Contains(south.Key()))
                {
                    south.value = grid[south.y][south.x];
                    landNeighbors.Enqueue(south);
                }
                if (east.x < grid[0].Length && !visitedLand.Contains(east.Key()))
                {
                    east.value = grid[east.y][east.x];
                    landNeighbors.Enqueue(east);
                }
                if (west.x > -1 && !visitedLand.Contains(west.Key()))
                {
                    west.value = grid[west.y][west.x];
                    landNeighbors.Enqueue(west);
                }
            }

            return islandLand;
        }
    }
}
