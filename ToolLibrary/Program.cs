using System;

namespace ToolLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            ToolLibrarySystem toolLibrarySystem = new();

            int selection;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Tool Library");
                Console.WriteLine("===========Main Menu===========");
                Console.WriteLine("1. Staff Login");
                Console.WriteLine("2. Member Login");
                Console.WriteLine("0. Exit");
                Console.WriteLine("===============================\n");
                Console.WriteLine("Please make a selection (1-2, or 0 to exit):");

                selection = Convert.ToInt32(Console.ReadLine());

                if (selection == 0)
                {
                    Environment.Exit(0);

                }
                else if (selection == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to the Tool Library");
                    Console.WriteLine("===========Staff Login===========");
                    Console.WriteLine("=================================");

                    Console.WriteLine("\nEnter Username:");

                    string username = Console.ReadLine();

                    Console.WriteLine("\nEnter Password:");

                    string password = Console.ReadLine();

                    if (username == "admin" && password == "admin")
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Welcome to the Tool Library");
                            Console.WriteLine("===========Staff Menu===========");
                            Console.WriteLine("1. Add a new tool");
                            Console.WriteLine("2. Add new pieces of an exisiting tool");
                            Console.WriteLine("3. Remove some pieces of a tool");
                            Console.WriteLine("4. Register a new member");
                            Console.WriteLine("5. Remove a member");
                            Console.WriteLine("6. Find the contact number of a member");
                            Console.WriteLine("0. Return to main menu");
                            Console.WriteLine("================================\n");
                            Console.WriteLine("Please make a selection (1-6, or 0 to return to main menu):");

                            selection = Convert.ToInt32(Console.ReadLine());

                            if (selection == 0)
                            {
                                break;
                            }
                            else if (selection == 1 || selection == 2 || selection == 3)
                            {
                                Console.Clear();

                                if (selection == 1)
                                {
                                    Console.WriteLine("Welcome to the Tool Library");
                                    Console.WriteLine("===========Add New Tool===========");
                                }
                                else if (selection == 2)
                                {
                                    Console.WriteLine("Welcome to the Tool Library");
                                    Console.WriteLine("===========Add Pieces===========");
                                }
                                else if (selection == 3)
                                {
                                    Console.WriteLine("Welcome to the Tool Library");
                                    Console.WriteLine("===========Remove Pieces===========");
                                }

                                Console.WriteLine("1. Gardening Tool");
                                Console.WriteLine("2. Flooring tools");
                                Console.WriteLine("3. Fencing tools");
                                Console.WriteLine("4. Measuring tools");
                                Console.WriteLine("5. Cleaning tools");
                                Console.WriteLine("6. Painting tools");
                                Console.WriteLine("7. Electronic tools");
                                Console.WriteLine("8. Electricity tools");
                                Console.WriteLine("9. Automotive tools");
                                Console.WriteLine("0. Return to staff menu");
                                if (selection == 1)
                                    Console.WriteLine("==================================\n");
                                else if (selection == 2)
                                    Console.WriteLine("====================================\n");
                                else if (selection == 3)
                                    Console.WriteLine("===================================\n");
                                Console.WriteLine("Please make a selection (1-9, or 0 to return to staff menu):");

                                toolLibrarySystem.CategoryIndex = Convert.ToInt32(Console.ReadLine()) - 1;

                                if (toolLibrarySystem.CategoryIndex != -1)
                                {
                                    Console.Clear();

                                    if (selection == 1)
                                    {
                                        Console.WriteLine("Welcome to the Tool Library");
                                        Console.WriteLine("===========Add New Tool===========");
                                    }
                                    else if (selection == 2)
                                    {
                                        Console.WriteLine("Welcome to the Tool Library");
                                        Console.WriteLine("===========Add Pieces===========");
                                    }
                                    else if (selection == 3)
                                    {
                                        Console.WriteLine("Welcome to the Tool Library");
                                        Console.WriteLine("===========Remove Pieces===========");
                                    }

                                    if (toolLibrarySystem.CategoryIndex == 0)
                                    {
                                        Console.WriteLine("1. Line Trimmers");
                                        Console.WriteLine("2. Lawn Mowers");
                                        Console.WriteLine("3. Hand Tools");
                                        Console.WriteLine("4. Wheelbarrows");
                                        Console.WriteLine("5. Garden Power Tools");
                                        Console.WriteLine("0. Return to staff menu");
                                        if (selection == 1)
                                            Console.WriteLine("==================================\n");
                                        else if (selection == 2)
                                            Console.WriteLine("====================================\n");
                                        else if (selection == 3)
                                            Console.WriteLine("===================================\n");
                                        Console.WriteLine("Please make a selection (1-5, or 0 to return to staff menu):");

                                        toolLibrarySystem.TypeIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                                    }
                                    else if (toolLibrarySystem.CategoryIndex == 1)
                                    {
                                        Console.WriteLine("1. Scrapers");
                                        Console.WriteLine("2. Floor Lasers");
                                        Console.WriteLine("3. Floor Levelling Tools");
                                        Console.WriteLine("4. Floor Levelling Materials");
                                        Console.WriteLine("5. Floor Hand Tools");
                                        Console.WriteLine("6. Tiling Tools");
                                        Console.WriteLine("0. Return to staff menu");
                                        if (selection == 1)
                                            Console.WriteLine("==================================\n");
                                        else if (selection == 2)
                                            Console.WriteLine("====================================\n");
                                        else if (selection == 3)
                                            Console.WriteLine("===================================\n");
                                        Console.WriteLine("Please make a selection (1-6, or 0 to return to staff menu):");

                                        toolLibrarySystem.TypeIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                                    }
                                    else if (toolLibrarySystem.CategoryIndex == 2)
                                    {
                                        Console.WriteLine("1. Hand Tools");
                                        Console.WriteLine("2. Electric Fencing");
                                        Console.WriteLine("3. Steel Fencing Tools");
                                        Console.WriteLine("4. Power Tools");
                                        Console.WriteLine("5. Fencing Accessories");
                                        Console.WriteLine("0. Return to staff menu");
                                        if (selection == 1)
                                            Console.WriteLine("==================================\n");
                                        else if (selection == 2)
                                            Console.WriteLine("====================================\n");
                                        else if (selection == 3)
                                            Console.WriteLine("===================================\n");
                                        Console.WriteLine("Please make a selection (1-5, or 0 to return to staff menu):");

                                        toolLibrarySystem.TypeIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                                    }
                                    else if (toolLibrarySystem.CategoryIndex == 3)
                                    {
                                        Console.WriteLine("1. Distance Tools");
                                        Console.WriteLine("2. Laser Measurer");
                                        Console.WriteLine("3. Measuring Jugs");
                                        Console.WriteLine("4. Temperature & Humidity Tools");
                                        Console.WriteLine("5. Levelling Tools");
                                        Console.WriteLine("6. Markers");
                                        Console.WriteLine("0. Return to staff menu");
                                        if (selection == 1)
                                            Console.WriteLine("==================================\n");
                                        else if (selection == 2)
                                            Console.WriteLine("====================================\n");
                                        else if (selection == 3)
                                            Console.WriteLine("===================================\n");
                                        Console.WriteLine("Please make a selection (1-6, or 0 to return to staff menu):");

                                        toolLibrarySystem.TypeIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                                    }
                                    else if (toolLibrarySystem.CategoryIndex == 4)
                                    {
                                        Console.WriteLine("1. Draining");
                                        Console.WriteLine("2. Car Cleaning");
                                        Console.WriteLine("3. Vacuum");
                                        Console.WriteLine("4. Pressure Cleaners");
                                        Console.WriteLine("5. Pool Cleaning");
                                        Console.WriteLine("6. Floor Cleaning");
                                        Console.WriteLine("0. Return to staff menu");
                                        if (selection == 1)
                                            Console.WriteLine("==================================\n");
                                        else if (selection == 2)
                                            Console.WriteLine("====================================\n");
                                        else if (selection == 3)
                                            Console.WriteLine("===================================\n");
                                        Console.WriteLine("Please make a selection (1-6, or 0 to return to staff menu):");

                                        toolLibrarySystem.TypeIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                                    }
                                    else if (toolLibrarySystem.CategoryIndex == 5)
                                    {
                                        Console.WriteLine("1. Sanding Tools");
                                        Console.WriteLine("2. Brushes");
                                        Console.WriteLine("3. Rollers");
                                        Console.WriteLine("4. Paint Removal Tools");
                                        Console.WriteLine("5. Paint Scrapers");
                                        Console.WriteLine("6. Sprayers");
                                        Console.WriteLine("0. Return to staff menu");
                                        if (selection == 1)
                                            Console.WriteLine("==================================\n");
                                        else if (selection == 2)
                                            Console.WriteLine("====================================\n");
                                        else if (selection == 3)
                                            Console.WriteLine("===================================\n");
                                        Console.WriteLine("Please make a selection (1-6, or 0 to return to staff menu):");

                                        toolLibrarySystem.TypeIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                                    }
                                    else if (toolLibrarySystem.CategoryIndex == 6)
                                    {
                                        Console.WriteLine("1. Voltage Tester");
                                        Console.WriteLine("2. Oscilloscopes");
                                        Console.WriteLine("3. Thermal Imaging");
                                        Console.WriteLine("4. Data Test Tool");
                                        Console.WriteLine("5. Insulation Testers");
                                        Console.WriteLine("0. Return to staff menu");
                                        if (selection == 1)
                                            Console.WriteLine("==================================\n");
                                        else if (selection == 2)
                                            Console.WriteLine("====================================\n");
                                        else if (selection == 3)
                                            Console.WriteLine("===================================\n");
                                        Console.WriteLine("Please make a selection (1-5, or 0 to return to staff menu):");

                                        toolLibrarySystem.TypeIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                                    }
                                    else if (toolLibrarySystem.CategoryIndex == 7)
                                    {
                                        Console.WriteLine("1. Test Equipment");
                                        Console.WriteLine("2. Safety Equipment");
                                        Console.WriteLine("3. Basic Hand tools");
                                        Console.WriteLine("4. Circuit Protection");
                                        Console.WriteLine("5. Cable Tools");
                                        Console.WriteLine("0. Return to staff menu");
                                        if (selection == 1)
                                            Console.WriteLine("==================================\n");
                                        else if (selection == 2)
                                            Console.WriteLine("====================================\n");
                                        else if (selection == 3)
                                            Console.WriteLine("===================================\n");
                                        Console.WriteLine("Please make a selection (1-5, or 0 to return to staff menu):");

                                        toolLibrarySystem.TypeIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                                    }
                                    else if (toolLibrarySystem.CategoryIndex == 8)
                                    {
                                        Console.WriteLine("1. Jacks");
                                        Console.WriteLine("2. Air Compressors");
                                        Console.WriteLine("3. Battery Chargers");
                                        Console.WriteLine("4. Socket Tools");
                                        Console.WriteLine("5. Braking");
                                        Console.WriteLine("6. Drivetrain");
                                        Console.WriteLine("0. Return to staff menu");
                                        if (selection == 1)
                                            Console.WriteLine("==================================\n");
                                        else if (selection == 2)
                                            Console.WriteLine("====================================\n");
                                        else if (selection == 3)
                                            Console.WriteLine("===================================\n");
                                        Console.WriteLine("Please make a selection (1-6, or 0 to return to staff menu):");

                                        toolLibrarySystem.TypeIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                                    }

                                    if (toolLibrarySystem.TypeIndex == -1)
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        if (selection == 1)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Welcome to the Tool Library");
                                            Console.WriteLine("===========Add New Tool===========");
                                            toolLibrarySystem.displayTools(toolLibrarySystem.CategoryIndex.ToString() + toolLibrarySystem.TypeIndex.ToString());
                                            Console.WriteLine("==================================");

                                            Console.WriteLine("\nEnter tool name:");

                                            string toolName = Console.ReadLine();

                                            Tool tool = new(toolName, 1, 1, 0);
                                            toolLibrarySystem.add(tool);

                                            Console.Clear();
                                            Console.WriteLine("Welcome to the Tool Library");
                                            Console.WriteLine("===========Add New Tool===========");
                                            toolLibrarySystem.displayTools(toolLibrarySystem.CategoryIndex.ToString() + toolLibrarySystem.TypeIndex.ToString());
                                            Console.WriteLine("==================================");
                                            Console.WriteLine("\nEnter any key to exit:");

                                            Console.ReadLine();
                                        }
                                        else if (selection == 2)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Welcome to the Tool Library");
                                            Console.WriteLine("===========Add New Pieces===========");
                                            toolLibrarySystem.displayTools(toolLibrarySystem.CategoryIndex.ToString() + toolLibrarySystem.TypeIndex.ToString());
                                            Console.WriteLine("====================================");

                                            Console.WriteLine("\nPlease make a selection (or 0 to return to staff menu):");

                                            int toolIndex = Convert.ToInt32(Console.ReadLine()) - 1;

                                            if (toolIndex != -1)
                                            {
                                                Tool[] toolArray = toolLibrarySystem.Tools[toolLibrarySystem.CategoryIndex][toolLibrarySystem.TypeIndex].toArray();
                                                Tool tool = toolArray[toolIndex];

                                                if (tool.Name != null)
                                                {
                                                    Console.WriteLine("\nEnter the quantity:");

                                                    int quantity = Convert.ToInt32(Console.ReadLine());

                                                    if (quantity > 0)
                                                    {
                                                        toolLibrarySystem.add(tool, quantity);

                                                        Console.Clear();
                                                        Console.WriteLine("Welcome to the Tool Library");
                                                        Console.WriteLine("===========Add New Pieces===========");
                                                        toolLibrarySystem.displayTools(toolLibrarySystem.CategoryIndex.ToString() + toolLibrarySystem.TypeIndex.ToString());
                                                        Console.WriteLine("====================================");
                                                        Console.WriteLine("\nEnter any key to exit:");

                                                        Console.ReadLine();
                                                    }
                                                    else
                                                        Console.WriteLine("Invalid quantity!");
                                                }
                                                else
                                                    Console.WriteLine("Invalid selection!");
                                            }
                                            else
                                                continue;

                                        }
                                        else if (selection == 3)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Welcome to the Tool Library");
                                            Console.WriteLine("===========Remove Pieces===========");
                                            toolLibrarySystem.displayTools(toolLibrarySystem.CategoryIndex.ToString() + toolLibrarySystem.TypeIndex.ToString());
                                            Console.WriteLine("===================================");

                                            Console.WriteLine("\nPlease make a selection (or 0 to return to staff menu):");

                                            int toolIndex = Convert.ToInt32(Console.ReadLine()) - 1;

                                            if (toolIndex != -1)
                                            {
                                                Tool[] toolArray = toolLibrarySystem.Tools[toolLibrarySystem.CategoryIndex][toolLibrarySystem.TypeIndex].toArray();
                                                Tool tool = toolArray[toolIndex];

                                                if (tool.Name != null)
                                                {
                                                    Console.WriteLine("\nEnter the quantity:");

                                                    int quantity = Convert.ToInt32(Console.ReadLine());

                                                    if (quantity > 0 && quantity <= tool.Quantity)
                                                    {
                                                        if (quantity == tool.Quantity)
                                                            toolLibrarySystem.delete(tool);
                                                        else
                                                            toolLibrarySystem.delete(tool, quantity);

                                                        Console.Clear();
                                                        Console.WriteLine("Welcome to the Tool Library");
                                                        Console.WriteLine("===========Remove Pieces===========");
                                                        toolLibrarySystem.displayTools(toolLibrarySystem.CategoryIndex.ToString() + toolLibrarySystem.TypeIndex.ToString());
                                                        Console.WriteLine("===================================");

                                                        Console.WriteLine("\nEnter any key to exit:");

                                                        Console.ReadLine();
                                                    }
                                                    else
                                                        Console.WriteLine("Invalid quantity!");
                                                }
                                                else
                                                    Console.WriteLine("Invalid selection!");
                                            }
                                            else
                                                continue;
                                        }
                                    }
                                }
                                else
                                    continue;
                            }
                            else if (selection == 4)
                            {
                                Console.Clear();
                                Console.WriteLine("Welcome to the Tool Library");
                                Console.WriteLine("===========Register Member===========");
                                Console.WriteLine("=====================================");

                                Console.WriteLine("\nFirst Name:");

                                string firstName = Console.ReadLine();

                                Console.WriteLine("\nLast Name:");

                                string lastName = Console.ReadLine();

                                Console.WriteLine("\nContact Number:");

                                string contactNumber = Console.ReadLine();

                                Console.WriteLine("\nPIN:");

                                string pin = Console.ReadLine();

                                Member member = new(firstName, lastName, contactNumber, pin);

                                toolLibrarySystem.add(member);

                                Console.Clear();
                                Console.WriteLine("Welcome to the Tool Library");
                                Console.WriteLine("===========Register Member===========");
                                Console.WriteLine("=====================================");

                                Console.WriteLine("\nNew member " + firstName + " " + lastName + " has been added!");

                                Console.WriteLine("\nEnter any key to exit:");

                                Console.ReadLine();
                            }
                            else if (selection == 5)
                            {
                                Console.Clear();
                                Console.WriteLine("Welcome to the Tool Library");
                                Console.WriteLine("===========Remove Member===========");
                                Console.WriteLine("===================================");

                                Member[] members = toolLibrarySystem.members.toArray();

                                for (int i = 0; i < members.Length; i++)
                                {
                                    if (members[i] != null)
                                        Console.WriteLine((i + 1).ToString() + ". " + members[i].FirstName + " " + members[i].LastName);
                                }

                                Console.WriteLine("\nSelect a member to remove: (or 0 to return to member menu)");

                                int memberIndex = Convert.ToInt32(Console.ReadLine()) - 1;

                                if (memberIndex != -1)
                                {
                                    Member memberToRemove = members[memberIndex];

                                    toolLibrarySystem.delete(memberToRemove);

                                    Console.Clear();
                                    Console.WriteLine("Welcome to the Tool Library");
                                    Console.WriteLine("===========Remove Member===========");
                                    Console.WriteLine("===================================");

                                    Console.WriteLine("\nMember " + memberToRemove.FirstName + " " + memberToRemove.LastName + " has been removed!");

                                    Console.WriteLine("\nEnter any key to exit:");
                                    Console.ReadLine();
                                }
                                else
                                    continue;
                            }
                            else if (selection == 6)
                            {
                                Console.Clear();
                                Console.WriteLine("Welcome to the Tool Library");
                                Console.WriteLine("===========Find Member Contact===========");
                                Console.WriteLine("=========================================");

                                Member[] members = toolLibrarySystem.members.toArray();

                                for (int i = 0; i < members.Length; i++)
                                {
                                    if (members[i] != null)
                                        Console.WriteLine((i + 1).ToString() + ". " + members[i].FirstName + " " + members[i].LastName);
                                }

                                Console.WriteLine("\nSelect a member to find their contact number: (or 0 to return to member menu)");

                                int memberIndex = Convert.ToInt32(Console.ReadLine()) - 1;

                                if (memberIndex != -1)
                                {
                                    Member memberToFindContact = members[memberIndex];

                                    toolLibrarySystem.delete(memberToFindContact);

                                    Console.Clear();
                                    Console.WriteLine("Welcome to the Tool Library");
                                    Console.WriteLine("===========Find Member Contact===========");
                                    Console.WriteLine("=========================================");

                                    Console.WriteLine("\nMember " + memberToFindContact.FirstName + " " + memberToFindContact.LastName + "'s " + "contact number is: " + memberToFindContact.ContactNumber);

                                    Console.WriteLine("\nEnter any key to exit:");
                                    Console.ReadLine();
                                }
                                else
                                    continue;
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Welcome to the Tool Library");
                        Console.WriteLine("===========Staff Login===========");
                        Console.WriteLine("=================================");

                        Console.WriteLine("\nError! Invalid username and/or password!");

                        Console.WriteLine("\nEnter any key to exit:");
                        Console.ReadLine();
                    }
                }
                else if (selection == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to the Tool Library");
                    Console.WriteLine("===========Member Login===========");
                    Console.WriteLine("==================================");

                    Console.WriteLine("\nEnter Username:");

                    string username = Console.ReadLine();

                    Console.WriteLine("\nEnter PIN:");

                    string pin = Console.ReadLine();

                    bool authenticated = false;

                    Member[] members = toolLibrarySystem.members.toArray();

                    Member authenticatedMember = new("", "", "", "");

                    foreach (Member member in members)
                    {
                        if ((member.LastName + member.FirstName) == username && member.PIN == pin)
                        {
                            authenticated = true;
                            authenticatedMember = member;
                        }
                    }

                    if (authenticated)
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Welcome to the Tool Library");
                            Console.WriteLine("===========Member Menu===========");
                            Console.WriteLine("1. Display all the tools of a tool type");
                            Console.WriteLine("2. Borrow a tool");
                            Console.WriteLine("3. Return a tool");
                            Console.WriteLine("4. List all the tools that I am renting");
                            Console.WriteLine("5. Display top three (3) most frequently rented tools");
                            Console.WriteLine("0. Return to main menu");
                            Console.WriteLine("=================================\n");
                            Console.WriteLine("Please make a selection (1-5, or 0 to return to main menu):");

                            selection = Convert.ToInt32(Console.ReadLine());

                            if (selection == 0)
                            {
                                break;
                            }
                            else if (selection == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("Welcome to the Tool Library");
                                Console.WriteLine("===========Display All Tools===========");
                                Console.WriteLine("1. Gardening Tool");
                                Console.WriteLine("2. Flooring tools");
                                Console.WriteLine("3. Fencing tools");
                                Console.WriteLine("4. Measuring tools");
                                Console.WriteLine("5. Cleaning tools");
                                Console.WriteLine("6. Painting tools");
                                Console.WriteLine("7. Electronic tools");
                                Console.WriteLine("8. Electricity tools");
                                Console.WriteLine("9. Automotive tools");
                                Console.WriteLine("0. Return to staff menu");
                                Console.WriteLine("=======================================\n");
                                Console.WriteLine("Please make a selection (1-9, or 0 to return to member menu):");

                                toolLibrarySystem.CategoryIndex = Convert.ToInt32(Console.ReadLine()) - 1;

                                if (toolLibrarySystem.CategoryIndex != -1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Welcome to the Tool Library");
                                    Console.WriteLine("===========Display All Tools===========");

                                    if (toolLibrarySystem.CategoryIndex == 0)
                                    {
                                        Console.WriteLine("1. Line Trimmers");
                                        Console.WriteLine("2. Lawn Mowers");
                                        Console.WriteLine("3. Hand Tools");
                                        Console.WriteLine("4. Wheelbarrows");
                                        Console.WriteLine("5. Garden Power Tools");
                                        Console.WriteLine("0. Return to staff menu");
                                        Console.WriteLine("=======================================\n");
                                        Console.WriteLine("Please make a selection (1-5, or 0 to return to member menu):");

                                        toolLibrarySystem.TypeIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                                    }
                                    else if (toolLibrarySystem.CategoryIndex == 1)
                                    {
                                        Console.WriteLine("1. Scrapers");
                                        Console.WriteLine("2. Floor Lasers");
                                        Console.WriteLine("3. Floor Levelling Tools");
                                        Console.WriteLine("4. Floor Levelling Materials");
                                        Console.WriteLine("5. Floor Hand Tools");
                                        Console.WriteLine("6. Tiling Tools");
                                        Console.WriteLine("0. Return to staff menu");
                                        Console.WriteLine("=======================================\n");
                                        Console.WriteLine("Please make a selection (1-6, or 0 to return to member menu):");

                                        toolLibrarySystem.TypeIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                                    }
                                    else if (toolLibrarySystem.CategoryIndex == 2)
                                    {
                                        Console.WriteLine("1. Hand Tools");
                                        Console.WriteLine("2. Electric Fencing");
                                        Console.WriteLine("3. Steel Fencing Tools");
                                        Console.WriteLine("4. Power Tools");
                                        Console.WriteLine("5. Fencing Accessories");
                                        Console.WriteLine("0. Return to staff menu");
                                        Console.WriteLine("=======================================\n");
                                        Console.WriteLine("Please make a selection (1-5, or 0 to return to member menu):");

                                        toolLibrarySystem.TypeIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                                    }
                                    else if (toolLibrarySystem.CategoryIndex == 3)
                                    {
                                        Console.WriteLine("1. Distance Tools");
                                        Console.WriteLine("2. Laser Measurer");
                                        Console.WriteLine("3. Measuring Jugs");
                                        Console.WriteLine("4. Temperature & Humidity Tools");
                                        Console.WriteLine("5. Levelling Tools");
                                        Console.WriteLine("6. Markers");
                                        Console.WriteLine("0. Return to staff menu");
                                        Console.WriteLine("=======================================\n");
                                        Console.WriteLine("Please make a selection (1-6, or 0 to return to member menu):");

                                        toolLibrarySystem.TypeIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                                    }
                                    else if (toolLibrarySystem.CategoryIndex == 4)
                                    {
                                        Console.WriteLine("1. Draining");
                                        Console.WriteLine("2. Car Cleaning");
                                        Console.WriteLine("3. Vacuum");
                                        Console.WriteLine("4. Pressure Cleaners");
                                        Console.WriteLine("5. Pool Cleaning");
                                        Console.WriteLine("6. Floor Cleaning");
                                        Console.WriteLine("0. Return to staff menu");
                                        Console.WriteLine("=======================================\n");
                                        Console.WriteLine("Please make a selection (1-6, or 0 to return to member menu):");

                                        toolLibrarySystem.TypeIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                                    }
                                    else if (toolLibrarySystem.CategoryIndex == 5)
                                    {
                                        Console.WriteLine("1. Sanding Tools");
                                        Console.WriteLine("2. Brushes");
                                        Console.WriteLine("3. Rollers");
                                        Console.WriteLine("4. Paint Removal Tools");
                                        Console.WriteLine("5. Paint Scrapers");
                                        Console.WriteLine("6. Sprayers");
                                        Console.WriteLine("0. Return to staff menu");
                                        Console.WriteLine("=======================================\n");
                                        Console.WriteLine("Please make a selection (1-6, or 0 to return to member menu):");

                                        toolLibrarySystem.TypeIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                                    }
                                    else if (toolLibrarySystem.CategoryIndex == 6)
                                    {
                                        Console.WriteLine("1. Voltage Tester");
                                        Console.WriteLine("2. Oscilloscopes");
                                        Console.WriteLine("3. Thermal Imaging");
                                        Console.WriteLine("4. Data Test Tool");
                                        Console.WriteLine("5. Insulation Testers");
                                        Console.WriteLine("0. Return to staff menu");
                                        Console.WriteLine("=======================================\n");
                                        Console.WriteLine("Please make a selection (1-5, or 0 to return to member menu):");

                                        toolLibrarySystem.TypeIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                                    }
                                    else if (toolLibrarySystem.CategoryIndex == 7)
                                    {
                                        Console.WriteLine("1. Test Equipment");
                                        Console.WriteLine("2. Safety Equipment");
                                        Console.WriteLine("3. Basic Hand tools");
                                        Console.WriteLine("4. Circuit Protection");
                                        Console.WriteLine("5. Cable Tools");
                                        Console.WriteLine("0. Return to staff menu");
                                        Console.WriteLine("=======================================\n");
                                        Console.WriteLine("Please make a selection (1-5, or 0 to return to member menu):");

                                        toolLibrarySystem.TypeIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                                    }
                                    else if (toolLibrarySystem.CategoryIndex == 8)
                                    {
                                        Console.WriteLine("1. Jacks");
                                        Console.WriteLine("2. Air Compressors");
                                        Console.WriteLine("3. Battery Chargers");
                                        Console.WriteLine("4. Socket Tools");
                                        Console.WriteLine("5. Braking");
                                        Console.WriteLine("6. Drivetrain");
                                        Console.WriteLine("0. Return to staff menu");
                                        Console.WriteLine("=======================================\n");
                                        Console.WriteLine("Please make a selection (1-6, or 0 to return to member menu):");

                                        toolLibrarySystem.TypeIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                                    }

                                    if (toolLibrarySystem.TypeIndex != -1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Welcome to the Tool Library");
                                        Console.WriteLine("===========Display All Tools===========");
                                        toolLibrarySystem.displayTools(toolLibrarySystem.CategoryIndex.ToString() + toolLibrarySystem.TypeIndex.ToString());
                                        Console.WriteLine("=======================================\n");
                                        Console.WriteLine("\nEnter any key to exit:");

                                        Console.ReadLine();
                                    }
                                    else
                                        continue;
                                }
                            }
                            else if (selection == 2)
                            {
                                Console.Clear();
                                Console.WriteLine("Welcome to the Tool Library");
                                Console.WriteLine("===========Borrow Tool===========");
                                Console.WriteLine("=================================\n");
                                Console.WriteLine("\nEnter the name of the tool you wish to borrow:");

                                string toolName = Console.ReadLine();

                                bool found = false;

                                Tool borrowingTool = new("", 0, 0, 0);

                                for (int i = 0; i < toolLibrarySystem.Tools.Length; i++)
                                {
                                    for (int j = 0; j < toolLibrarySystem.Tools[i].Length; j++)
                                    {
                                        Tool[] toolArray = toolLibrarySystem.Tools[i][j].toArray();

                                        for (int k = 0; k < toolArray.Length; k++)
                                        {
                                            if (toolArray[k] != null)
                                            {
                                                if (toolArray[k].Name == toolName)
                                                {
                                                    found = true;
                                                    toolLibrarySystem.CategoryIndex = i;
                                                    toolLibrarySystem.TypeIndex = j;
                                                    borrowingTool = toolArray[k];
                                                    break;
                                                }
                                            }
                                            else
                                                break;
                                        }
                                    }
                                }

                                if (found)
                                {
                                    toolLibrarySystem.borrowTool(authenticatedMember, borrowingTool);

                                    Console.WriteLine("\nSuccess! You have now borrowed this tool!");
                                    Console.WriteLine("\nEnter any key to return to member menu:");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("\nError! No such tool exists!");
                                    Console.WriteLine("\nEnter any key to return to member menu:");
                                    Console.ReadLine();
                                }
                            }
                            else if (selection == 3)
                            {
                                Console.Clear();
                                Console.WriteLine("Welcome to the Tool Library");
                                Console.WriteLine("===========Return Tool===========");
                                toolLibrarySystem.displayBorrowingTools(authenticatedMember);
                                Console.WriteLine("=================================\n");
                                Console.WriteLine("\nSelect the tool you wish to return: (or 0 to return to member menu)");

                                int toolIndex = Convert.ToInt32(Console.ReadLine()) - 1;

                                bool found = false;

                                if (toolIndex != -1)
                                {
                                    string returningToolName = authenticatedMember.Tools[toolIndex];

                                    Tool returningTool = new("", 0, 0, 0);

                                    for (int i = 0; i < toolLibrarySystem.Tools.Length; i++)
                                    {
                                        for (int j = 0; j < toolLibrarySystem.Tools[i].Length; j++)
                                        {
                                            Tool[] toolArray = toolLibrarySystem.Tools[i][j].toArray();

                                            for (int k = 0; k < toolArray.Length; k++)
                                            {
                                                if (toolArray[k] != null)
                                                {
                                                    if (toolArray[k].Name == returningToolName)
                                                    {
                                                        found = true;
                                                        toolLibrarySystem.CategoryIndex = i;
                                                        toolLibrarySystem.TypeIndex = j;
                                                        returningTool = toolArray[k];
                                                        break;
                                                    }
                                                }
                                                else
                                                    break;
                                            }
                                        }
                                    }

                                    if (found)
                                    {
                                        toolLibrarySystem.returnTool(authenticatedMember, returningTool);

                                        Console.WriteLine("\nSuccess! You have now returned this tool!");
                                        Console.WriteLine("\nEnter any key to return to member menu:");
                                        Console.ReadLine();
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nError! No such tool exists!");
                                        Console.WriteLine("\nEnter any key to return to member menu:");
                                        Console.ReadLine();
                                    }


                                }
                                else
                                {
                                    Console.WriteLine("\nError! Invalid selection!");
                                    Console.WriteLine("\nEnter any key to return to member menu:");
                                    Console.ReadLine();
                                }
                            }
                            else if (selection == 4)
                            {
                                Console.Clear();
                                Console.WriteLine("Welcome to the Tool Library");
                                Console.WriteLine("===========Rented Tools===========");
                                toolLibrarySystem.displayBorrowingTools(authenticatedMember);
                                Console.WriteLine("==================================");
                                Console.WriteLine("\nEnter any key to return to member menu:");
                                Console.ReadLine();
                            }
                            else if (selection == 5)
                            {
                                Console.Clear();
                                Console.WriteLine("Welcome to the Tool Library");
                                Console.WriteLine("===========Top 3 Tools===========");
                                toolLibrarySystem.displayTopTHree();
                                Console.WriteLine("=================================");
                                Console.WriteLine("\nEnter any key to return to member menu:");
                                Console.ReadLine();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nERROR! Invalid username and/or password!");
                        Console.WriteLine("\nEnter any key to return to main menu:");

                        Console.ReadLine();

                        continue;
                    }
                }
            }
        }
    }
}