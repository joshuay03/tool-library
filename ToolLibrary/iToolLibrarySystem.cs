using System;
using System.Collections.Generic;
using System.Text;

namespace ToolLibrary
{
    interface iToolLibrarySystem
    {
        void add(Tool Tool); // add a new tool to the system

        void add(Tool Tool, int quantity); //add new pieces of an existing tool to the system

        void delete(Tool Tool); //delte a given tool from the system

        void delete(Tool Tool, int quantity); //remove some pieces of a tool from the system

        void add(Member Member); //add a new memeber to the system

        void delete(Member Member); //delete a member from the system

        void displayBorrowingTools(Member Member); //given a member, display all the tools that the member are currently renting


        void displayTools(string ToolType); // display all the tools of a tool type selected by a member

        void borrowTool(Member Member, Tool Tool); //a member borrows a tool from the tool library

        void returnTool(Member Member, Tool Tool); //a member return a tool to the tool library

        string[] listTools(Member Member); //get a list of tools that are currently held by a given member

        void displayTopTHree(); //Display top three most frequently borrowed tools by the members in the descending order by the number of times each tool has been borrowed.

    }
}
