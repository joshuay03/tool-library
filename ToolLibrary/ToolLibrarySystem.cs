using System;
using System.Threading;

namespace ToolLibrary
{
    public class ToolLibrarySystem : iToolLibrarySystem
    {
        public MemberCollection members = new();

        ToolCollection[][] tools;

        ToolCollection[] gardeningTools;
        ToolCollection gardeningLineTrimmers = new();
        ToolCollection gardeningLawnMowers = new();
        ToolCollection gardeningHandTools = new();
        ToolCollection gardeningWheelbarrows = new();
        ToolCollection gardeningGardenPowerTools = new();

        ToolCollection[] flooringTools;
        ToolCollection flooringScrapers = new();
        ToolCollection flooringFloorLasers = new();
        ToolCollection flooringFloorLevellingTools = new();
        ToolCollection flooringFloorLevellingMaterials = new();
        ToolCollection flooringFlooeHandTools = new();
        ToolCollection flooringTilingTools = new();

        ToolCollection[] fencingTools;
        ToolCollection fencingHandTools = new();
        ToolCollection fencingElectricFencing = new();
        ToolCollection fencingSteelFencingTools = new();
        ToolCollection fencingPowerTools = new();
        ToolCollection fencingFencingAccessories = new();

        ToolCollection[] measuringTools;
        ToolCollection measuringDistanceTools = new();
        ToolCollection measuringLaserMeasurer = new();
        ToolCollection measuringMeasuringJugs = new();
        ToolCollection measuringTemperatureAndHumidityTools = new();
        ToolCollection measuringLevellingTools = new();
        ToolCollection measuringMarkers = new();

        ToolCollection[] cleaningTools;
        ToolCollection cleaningDraining = new();
        ToolCollection cleaningCarCleaning = new();
        ToolCollection cleaningVacuum = new();
        ToolCollection cleaningPressureCleaners = new();
        ToolCollection cleaningPoolCleaning = new();
        ToolCollection cleaningFloorCleaning = new();

        ToolCollection[] paintingTools;
        ToolCollection paintingSandingTools = new();
        ToolCollection paintingBrushes = new();
        ToolCollection paintingRollers = new();
        ToolCollection paintingPaintRemovalTools = new();
        ToolCollection paintingPaintScrapers = new();
        ToolCollection paintingSprayers = new();

        ToolCollection[] electronicTools;
        ToolCollection electronicsVoltageTester = new();
        ToolCollection electronicsOscilloscopes = new();
        ToolCollection electronicsThermalImaging = new();
        ToolCollection electronicsDataTestTool = new();
        ToolCollection electronicsInsulationTesters = new();

        ToolCollection[] electricityTools;
        ToolCollection electricityTestEquipment = new();
        ToolCollection electricitySafetyEquipment = new();
        ToolCollection electricityBasicHandTools = new();
        ToolCollection electricityCircuitProtectin = new();
        ToolCollection electricityCableTools = new();

        ToolCollection[] automotiveTools;
        ToolCollection automotiveJacks = new();
        ToolCollection automotiveAirCompressors = new();
        ToolCollection automotiveBatteryChargers = new();
        ToolCollection automotiveSocketTools = new();
        ToolCollection automotiveBraking = new();
        ToolCollection automotiveDrivetrain = new();

        int categoryIndex;
        int typeIndex;

        public ToolLibrarySystem()
        {
            gardeningTools = new ToolCollection[]
            { gardeningLineTrimmers, gardeningLawnMowers, gardeningHandTools,
                gardeningWheelbarrows, gardeningGardenPowerTools };

            flooringTools = new ToolCollection[]
            { flooringScrapers, flooringFloorLasers, flooringFloorLevellingTools,
                flooringFloorLevellingMaterials, flooringFlooeHandTools, flooringTilingTools };

            fencingTools = new ToolCollection[]
            { fencingHandTools, fencingElectricFencing, fencingSteelFencingTools,
                fencingPowerTools, fencingFencingAccessories };

            measuringTools = new ToolCollection[]
            { measuringDistanceTools, measuringLaserMeasurer, measuringMeasuringJugs,
                measuringTemperatureAndHumidityTools, measuringLevellingTools, measuringMarkers };

            cleaningTools = new ToolCollection[]
            { cleaningDraining, cleaningCarCleaning, cleaningVacuum,
                cleaningPressureCleaners, cleaningPoolCleaning, cleaningFloorCleaning };

            paintingTools = new ToolCollection[]
            { paintingSandingTools, paintingBrushes, paintingRollers,
                paintingPaintRemovalTools, paintingPaintScrapers, paintingSprayers };

            electronicTools = new ToolCollection[]
            { electronicsVoltageTester, electronicsOscilloscopes, electronicsThermalImaging,
                electronicsDataTestTool, electronicsInsulationTesters };

            electricityTools = new ToolCollection[]
            { electricityTestEquipment, electricitySafetyEquipment, electricityBasicHandTools,
                electricityCircuitProtectin, electricityCableTools };

            automotiveTools = new ToolCollection[]
            { automotiveJacks, automotiveAirCompressors, automotiveBatteryChargers,
                automotiveSocketTools, automotiveBraking, automotiveDrivetrain };

            tools = new ToolCollection[][]
            { gardeningTools, flooringTools, fencingTools, measuringTools, cleaningTools, paintingTools,
                electronicTools, electricityTools, automotiveTools };
        }

        public ToolCollection[][] Tools
        {
            get { return tools; }
        }

        public int CategoryIndex
        {
            get { return categoryIndex; }
            set { categoryIndex = value; }
        }

        public int TypeIndex
        {
            get { return typeIndex; }
            set { typeIndex = value; }
        }

        public void add(Tool Tool)
        {
            tools[categoryIndex][typeIndex].add(Tool);
        }

        public void add(Tool Tool, int quantity)
        {
            Tool.Quantity += quantity;
            Tool.AvailableQuantity += quantity;
            tools[categoryIndex][typeIndex].add(Tool);
        }

        public void add(Member Member)
        {
            members.add(Member);
        }

        public void borrowTool(Member Member, Tool Tool)
        {
            Tool.NoBorrowings += 1;
            Tool.AvailableQuantity -= 1;

            tools[categoryIndex][typeIndex].add(Tool);

            Member.addTool(Tool);
        }

        public void delete(Tool Tool)
        {
            tools[categoryIndex][typeIndex].delete(Tool);
        }

        public void delete(Tool Tool, int quantity)
        {
            Tool.Quantity -= quantity;
            Tool.AvailableQuantity -= quantity;
            tools[categoryIndex][typeIndex].add(Tool);
        }

        public void delete(Member Member)
        {
            members.delete(Member);
        }

        public void displayBorrowingTools(Member Member)
        {
            string[] membersTools = listTools(Member);

            for (int i = 0; i < membersTools.Length; i++)
            {
                if (membersTools[i] != null)
                {
                    Console.WriteLine((i + 1).ToString() + ". " + membersTools[i]);
                }
                else
                    break;
            }
        }

        public void displayTools(string ToolType)
        {
            categoryIndex = Convert.ToInt32(char.GetNumericValue(ToolType[0]));
            typeIndex = Convert.ToInt32(char.GetNumericValue(ToolType[1]));

            Tool[] toolArray = tools[categoryIndex][typeIndex].toArray();

            for (int i = 0; i < 85; i++)
                Console.Write("=");

            Console.WriteLine();

            Console.Write("    ");

            Console.Write("Tool Name");

            for (int i = 0; i < 16; i++)
                Console.Write(" ");

            Console.Write("Quantity");

            for (int i = 0; i < 12; i++)
                Console.Write(" ");

            Console.Write("Available Quantity");

            for (int i = 0; i < 2; i++)
                Console.Write(" ");

            Console.Write("No. of Borrowings");

            for (int i = 0; i < 3; i++)
                Console.Write(" ");

            Console.WriteLine();

            for (int i = 0; i < 85; i++)
                Console.Write("=");

            Console.WriteLine();

            for (int i = 0; i < tools[categoryIndex][typeIndex].Number; i++)
            {
                if (toolArray[i] != null)
                {
                    if (i < 10)
                        Console.Write(" ");
                    Console.Write((i + 1).ToString() + ". " + toolArray[i].ToString());
                    Console.WriteLine();
                }
            }

            Console.WriteLine();

            for (int i = 0; i < 85; i++)
            {
                Console.Write("=");
            }

            Console.WriteLine();
        }

        public void displayTopTHree()
        {
            Tool[] calculateTopThree()
            {
                Tool most = new();
                Tool secondMost = new();
                Tool thirdMost = new();
                most.NoBorrowings = 0;
                secondMost.NoBorrowings = 0;
                thirdMost.NoBorrowings = 0;

                // Get the sorted tool array for each category and type or skip this tool type if it 
                // holds no tools
                for (int i = 0; i < tools.Length; i++)
                {
                    for (int j = 0; j < tools[i].Length; j++)
                    {
                        Tool[] sortedToolArray;
                        Tool[] toolArray = tools[i][j].toArray();
            
                        if (toolArray[0] == null)
                            continue;
                        else if (toolArray[1] == null)
                        {
                            sortedToolArray = toolArray;
                            sortedToolArray[sortedToolArray.Length - 1] = toolArray[0];
                            sortedToolArray[0] = toolArray[sortedToolArray.Length - 1];
                        }
                        else
                        {
                            sortedToolArray = mergeSort(toolArray);
                        }
            
                        int highestIndex = sortedToolArray.Length - 1;

                        // If the highest value in the sorted array is greater than the current highest  
                        // value, switch them and update the second and third highest
                        if (sortedToolArray[sortedToolArray.Length - 1] != null && sortedToolArray[highestIndex].NoBorrowings > most.NoBorrowings)
                        {
                            thirdMost = secondMost;
                            secondMost = most;
                            most = sortedToolArray[highestIndex];

                            // If the second highest value in the sorted array is greater than the current   
                            // second highest value, switch them and update the third highest
                            if (sortedToolArray[sortedToolArray.Length - 2] != null && sortedToolArray[highestIndex - 1].NoBorrowings > secondMost.NoBorrowings)
                            {
                                thirdMost = secondMost;
                                secondMost = sortedToolArray[highestIndex - 1];

                                // If the third highest value in the sorted array is greater than the current 
                                // third highest value, switch them
                                if (sortedToolArray[sortedToolArray.Length - 3] != null && sortedToolArray[highestIndex - 2].NoBorrowings > thirdMost.NoBorrowings)
                                {
                                    thirdMost = sortedToolArray[highestIndex - 2];
                                }
                            }
                            // If the second highest value in the sorted array is greater than the current 
                            // third highest value, switch them
                            else if (sortedToolArray[sortedToolArray.Length - 2] != null && sortedToolArray[highestIndex - 1].NoBorrowings > thirdMost.NoBorrowings)
                            {
                                thirdMost = sortedToolArray[highestIndex - 1];
                            }
                        }
                        // If the highest value in the sorted array is greater than the current second 
                        // highest value, switch them and update the third highest
                        else if (sortedToolArray[sortedToolArray.Length - 1] != null && sortedToolArray[highestIndex].NoBorrowings > secondMost.NoBorrowings)
                        {
                            thirdMost = secondMost;
                            secondMost = sortedToolArray[highestIndex];

                            // If the second highest value in the sorted array is greater than the current 
                            // third highest value, switch them
                            if (sortedToolArray[sortedToolArray.Length - 2] != null && sortedToolArray[highestIndex - 1].NoBorrowings > thirdMost.NoBorrowings)
                            {
                                thirdMost = sortedToolArray[highestIndex - 1];
                            }
                        }
                        // If the highest value in the sorted array is greater than the current third 
                        // highest value, switch them
                        else if (sortedToolArray[sortedToolArray.Length - 1] != null && sortedToolArray[highestIndex].NoBorrowings > thirdMost.NoBorrowings)
                        {
                            thirdMost = sortedToolArray[highestIndex];
                        }
                    }
                }

                return new Tool[3] { most, secondMost, thirdMost };
            }

            Tool[] mergeSort(Tool[] array)
            {
                Tool[] left;
                Tool[] right;

                // Base case to avoid infinite recursion
                if (array.Length <= 1)
                    return array;
 
                int midPoint = array.Length / 2;

                left = new Tool[midPoint];

                // If array has an even number of elements, the left and right array will have the same number of 
                // elements
                if (array.Length % 2 == 0)
                    right = new Tool[midPoint];
                // If array has an odd number of elements, the right array will have one more element than left
                else
                    right = new Tool[midPoint + 1];

                // Populate left array
                for (int i = 0; i < midPoint; i++)
                    left[i] = array[i];

                // Populate right array   
                int x = 0;
                for (int i = midPoint; i < array.Length; i++)
                {
                    right[x] = array[i];
                    x++;
                }

                // Recursively sort left array
                left = mergeSort(left);
                // Recursively sort right array
                right = mergeSort(right);

                // Merge and return our two sorted arrays
                return merge(left, right);
            }

            Tool[] merge(Tool[] left, Tool[] right)
            {
                int resultLength = right.Length + left.Length;
                Tool[] result = new Tool[resultLength];

                int indexLeft = 0, indexRight = 0, indexResult = 0;

                while (indexLeft < left.Length || indexRight < right.Length)
                {
                    // If both arrays have elements  
                    if (indexLeft < left.Length && indexRight < right.Length)
                    {
                        // If item on left array is a null object, add that item to the result array
                        if (left[indexLeft] == null)
                        {
                            result[indexResult] = left[indexLeft];
                            indexLeft++;
                            indexResult++;
                        }
                        // If item on right array only is a null object, add that item to the result array
                        else if (left[indexLeft] != null && right[indexRight] == null)
                        {
                            result[indexResult] = right[indexRight];
                            indexRight++;
                            indexResult++;
                        }
                        else
                        {
                            // If item on left array is less than item on right array, add that item to the result array
                            if (left[indexLeft].NoBorrowings <= right[indexRight].NoBorrowings)
                            {
                                result[indexResult] = left[indexLeft];
                                indexLeft++;
                                indexResult++;
                            }
                            // Else the item in the right array will be added to the results array
                            else
                            {
                                result[indexResult] = right[indexRight];
                                indexRight++;
                                indexResult++;
                            }
                        }
                    }
                    // If only the left array still has elements, add all its items to the results array
                    else if (indexLeft < left.Length)
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    // If only the right array still has elements, add all its items to the results array
                    else if (indexRight < right.Length)
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                return result;
            }

            Tool[] topThree = calculateTopThree();

            if (topThree[0].Name != "")
            {
                Console.WriteLine("Most frequently borrowed: " + topThree[0].Name);

                if (topThree[1].Name != "")
                {
                    Console.WriteLine("\nSecond most frequently borrowed: " + topThree[1].Name);

                    if (topThree[2].Name != "")
                    {
                        Console.WriteLine("\nThird most frequently borrowed: " + topThree[2].Name);
                    }
                }
            }
        }

        public string[] listTools(Member Member)
        {
            return Member.Tools;
        }

        public void returnTool(Member Member, Tool Tool)
        {
            Tool.AvailableQuantity += 1;

            tools[categoryIndex][typeIndex].add(Tool);

            Member.deleteTool(Tool);
        }
    }
}
